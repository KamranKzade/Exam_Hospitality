using Exam_Hospitality.DataBase;
using Newtonsoft.Json;
using System.IO;



namespace Exam_Hospitality.Json
{
    public class JsonSerialization
    {
        public static void SerializeDatabase(Database db)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter("database.json"))
            {
                using (JsonTextWriter jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    serializer.Serialize(jw, db);
                }
            }
        }

        public static Database DeserializeDatabase()
        {
            Database db;
            var serializer = new JsonSerializer();
            using (var sr = new StreamReader("database.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    db = serializer.Deserialize<Database>(jr)!;
                }
            }
            return db;
        }
    }
}