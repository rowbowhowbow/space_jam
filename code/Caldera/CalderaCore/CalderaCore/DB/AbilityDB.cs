using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using JsonExSerializer;

namespace CalderaCore.DB
{
    public class AbilityDB
    {
        public static List<Keyword> GetLatestKeywords()
        {
            String query = "SELECT id, name, text, hasxvalue, guid, version FROM keywordabilities AS allkeywords WHERE version in (SELECT MAX(version) FROM keywordabilities WHERE guid = allkeywords.guid);";
            DBCore dbconnection = new DBCore();
            DataTable dtResults = dbconnection.ExecuteQuery(query);
            return ConvertTableToKeywordList(dtResults);
        }

        public static Keyword GetLatestVersionofKeywordbyID(string keywordID)
        {
            String query = "SELECT id, name, text, hasxvalue, guid, version FROM keywordabilities AS allkeywords WHERE id = '{0}' AND version in (SELECT MAX(version) FROM keywordabilities WHERE guid = allkeywords.guid);";
            DBCore dbconnection = new DBCore();
            DataTable dtResults = dbconnection.ExecuteQuery(query);
            List<Keyword> results = ConvertTableToKeywordList(dtResults);
            if (results == null || results.Count == 0)
            {
                return null;
            }
            else
            {
                return results[0];
            }
        }

        public static List<Keyword> GetAllVersionsofKeyword(string keywordID)
        {
            String query = String.Format("SELECT id, name, text, hasxvalue, guid, version FROM keywordabilities WHERE guid = '{0}';", keywordID);
            DBCore dbconnection = new DBCore();
            DataTable dtResults = dbconnection.ExecuteQuery(query);

            return ConvertTableToKeywordList(dtResults);
        }

        public static List<KeywordInstance> GetAbilitiesForCard(int cardID)
        {

            String query = "SELECT id, name, text, hasxvalue, guid, version, xvalue FROM keywordabilites INNER JOIN cardabilities WHERE id IN (SELECT keywordid FROM cardabilities WHERE cardid = {0});";
            DBCore dbconnection = new DBCore();
            DataTable dtResults = dbconnection.ExecuteQuery(query);

            return ConvertTableToInstanceList(dtResults);
        }

        public static bool SaveAbilitiesOnCard(Card cardToSave)
        {
            List<bool> success = new List<bool>();
            foreach (KeywordInstance keywordAbility in cardToSave.KeywordAbilities)
            {
                success.Add(SaveKeywordInstance(cardToSave.ID, keywordAbility));
            }
            return !success.Contains(false);
        }

        public static int SaveKeyword(Keyword keywordToSave)
        {
            int version = 0;
            DBCore dbConnection = new DBCore();
            if (keywordToSave.Guid != String.Empty)
            {
                String versionQuery = String.Format("SELECT MAX(version) from keywordabilities WHERE guid = '{0}';", keywordToSave.Guid);
                version = dbConnection.ExecuteScalar(versionQuery) + 1;
            }
            if (version == 0)
            {
                String guid = "KW-" + Guid.NewGuid().ToString().Replace("-", "").Substring(0, 12);
                keywordToSave.Guid = guid;
            }
            keywordToSave.Version = version;
            String abilityMarkup = new Serializer(typeof(Keyword)).Serialize(keywordToSave);
            String insertQuery = String.Format(@"INSERT INTO keywordabilities 
                            (guid, name, text, hasxvalue, version) 
                            VALUES ('{0}', '{1}', '{2}', {3}, {4});",
                            keywordToSave.Guid, keywordToSave.Name, abilityMarkup, keywordToSave.HasXValue, keywordToSave.Version);
            int keywordID = dbConnection.ExecuteInsertQuery(insertQuery);
            return keywordID;
        }

        public static bool SaveKeywordInstance(int cardID, KeywordInstance instanceToSave)
        {
            String insertQuery = String.Format(@"INSERT INTO cardabilities
                                               (cardid, keywordid, xvalue)
                                                VALUES ({0}, {1}, {2});",
                                                cardID, instanceToSave.ID, instanceToSave.XValue);
            DBCore dbConnection = new DBCore();
            int success = dbConnection.ExecuteInsertQuery(insertQuery);
            return success > -1;
        }

        private static List<Keyword> ConvertTableToKeywordList(DataTable table)
        {
            List<Keyword> keywordList = new List<Keyword>();
            foreach (DataRow row in table.Rows)
            {
                keywordList.Add(ConvertRowToKeyword(row));
            }
            return keywordList;
        }

        private static Keyword ConvertRowToKeyword(DataRow rowToConvert)
        {
            Serializer abilitySerializer = new Serializer(typeof(Keyword));
            Keyword keyword = (Keyword)abilitySerializer.Deserialize((String)rowToConvert["text"]);
            if (keyword == null)
            {
                keyword = new Keyword();
            }
            keyword.Name = (String)rowToConvert["name"];
            keyword.Guid = (String)rowToConvert["guid"];
            keyword.ID = (int)rowToConvert["id"];
            object hasX = rowToConvert["hasxvalue"];
            keyword.HasXValue = (bool)hasX;
            keyword.Version = (int)rowToConvert["version"];
            return keyword;
        }

        private static List<KeywordInstance> ConvertTableToInstanceList(DataTable tableToConvert)
        {
            List<KeywordInstance> instanceList = new List<KeywordInstance>();
            foreach (DataRow row in tableToConvert.Rows)
            {
                instanceList.Add(ConvertRowToKeywordInstance(row));
            }

            return instanceList;
        }
        
        private static KeywordInstance ConvertRowToKeywordInstance(DataRow rowToConvert)
        {
            Serializer abilitySerializer = new Serializer(typeof(KeywordInstance));
            KeywordInstance keywordInstance = (KeywordInstance)abilitySerializer.Deserialize((String)rowToConvert["markup"]);
            keywordInstance.Guid = (String)rowToConvert["guid"];
            keywordInstance.ID = (int)rowToConvert["id"];
            keywordInstance.HasXValue = (bool)rowToConvert["hasxvalue"];
            keywordInstance.Version = (int)rowToConvert["version"];
            if (keywordInstance.HasXValue)
            {
                keywordInstance.XValue = (int)rowToConvert["xvalue"];
            }
            return keywordInstance;
        }
    }
}

