using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using JsonExSerializer;

namespace CalderaCore.DB
{
    public class CardDB
    {
        public static List<Card> GetAllCards()
        {
            String query = "SELECT * FROM cards;";
            DBCore dbconnection = new DBCore();
            DataTable dtCards = dbconnection.ExecuteQuery(query);
            return ConvertTableToList(dtCards);
        }

        public static List<Card> GetAllLatestCards()
        {
            String query = @"SELECT * FROM cards AS allcards 
                           WHERE version = (SELECT MAX(version) FROM cards WHERE guid = allcards.guid);";
            DBCore dbconnection = new DBCore();
            DataTable dtCards = dbconnection.ExecuteQuery(query);
            return ConvertTableToList(dtCards);
        }

        public static Card GetLatestVersionFromGUID(String id)
        {
            String query = String.Format("SELECT * FROM cards WHERE guid='{0}' AND version in (SELECT MAX(version) FROM cards WHERE guid='{0}');", id);
            DBCore dbConnection = new DBCore();
            DataTable dtResult = dbConnection.ExecuteQuery(query);
            if (dtResult == null || dtResult.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return ConvertRowToCard(dtResult.Rows[0]);
            }

        }

        public static List<Card> GetAllVersionsFromGUID(String guid)
        {
            String query = "SELECT * FROM cards WHERE guid={0} ORDER BY version ASC;";
            DBCore dbConnection = new DBCore();
            DataTable dtResult = dbConnection.ExecuteQuery(query);
            List<Card> allVersions = new List<Card>();
            foreach (DataRow cardRow in dtResult.Rows)
            {
                allVersions.Add(ConvertRowToCard(cardRow));
            }
            return allVersions;
        }

        static List<Card> GetCardsLikeName(String partialName)
        {
            throw new NotImplementedException();
        }

        static List<Card> GetCardsWithAbilityText(String text)
        {
            throw new NotImplementedException();
        }

        static List<Card> GetCardsWithAttributeValue(String attribute, String value)
        {
            throw new NotImplementedException();
        }

        static List<Card> GetCardsWithAttributeValue(String attribute, int value)
        {
            throw new NotImplementedException();
        }

        public static bool SaveCardToDBVersioned(Card card)
        {
            String versionQuery = String.Format("SELECT MAX(version) FROM cards WHERE cards.guid = '{0}';", card.Guid);
            DBCore dbConnection = new DBCore();
            int version = dbConnection.ExecuteScalar(versionQuery) + 1;
            int success = SaveCardToDBAsIs(card);

            return success > 0;
        }

        private static int SaveCardToDBAsIs(Card card)
        {
            if (card.Version == 0)
            {
                String guid = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 12);
                card.Guid = "C" + guid;
            }
            card.Flavor = card.Flavor.Replace("\"", "\\\"");
            Serializer cardSerializer = new Serializer(typeof(Card));
            String queryMarkup = cardSerializer.Serialize(card);
            card.Flavor.Replace("\\\"", "\"");

            // int deleteStart = queryMarkup.IndexOf("/*");
            // int deleteEnd = queryMarkup.IndexOf("*/", deleteStart + 2);
            // queryMarkup = queryMarkup.Remove(deleteStart, deleteEnd - deleteStart + 1);

            DBCore dbConnection = new DBCore();
            String query = String.Format("INSERT INTO cards (version, guid, editor, markup) VALUES ({0}, '{1}', '{2}', '{3}');", card.Version, card.ID, card.Creds.Designer, queryMarkup);
            int success = dbConnection.ExecuteInsertQuery(query);

            query = String.Format("SELECT LATEST_INSERT_ID()");
            int newID = dbConnection.ExecuteScalar(query);
            card.ID = newID;

            AbilityDB.SaveAbilitiesOnCard(card);
            return newID;
        }

        public static int SaveCardToDBAsNew(Card card)
        {
            card.Version = 0;
            return SaveCardToDBAsIs(card);
        }

        static Card ConvertRowToCard(DataRow rowToConvert)
        {
            String markup = (String)rowToConvert["markup"];
            Serializer cardSerializer = new Serializer(typeof(Card));
            Card card = (Card)cardSerializer.Deserialize(markup);
            card.ID = (Int32)rowToConvert["id"];
            card.Guid = (String)rowToConvert["guid"];
            card.Version = (Int32)rowToConvert["version"];
            if (card.Creds == null)
            {
                card.Creds = new Credits();
            }
            card.Creds.Designer = (String)rowToConvert["editor"];
            return card;
        }

        static List<Card> ConvertTableToList(DataTable table)
        {
            List<Card> cards = new List<Card>();
            foreach (DataRow row in table.Rows)
            {
                Card cardToAdd = ConvertRowToCard(row);
                cards.Add(cardToAdd);
            }
            return cards;
        }
    }
}
