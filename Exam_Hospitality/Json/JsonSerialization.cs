﻿using Exam_Hospitality.DataBase;
using Newtonsoft.Json;



namespace Exam_Hospitality.Json;

public class JsonSerialization
{
   public static void SerializeDatabaseAdmin(DatabaseForAdmin db)
   {
       var serializer = new JsonSerializer();
  
       using (var sw = new StreamWriter("../../../Services/admin.json"))
       {
           using (JsonTextWriter jw = new JsonTextWriter(sw))
           {
               jw.Formatting = Formatting.Indented;
               serializer.Serialize(jw, db);
           }
       }
   }

   public static DatabaseForAdmin DeserializeDatabaseAdmin()
   {
       DatabaseForAdmin db;
       var serializer = new JsonSerializer();
       using (var sr = new StreamReader("../../../Services/admin.json"))
       {
           using (var jr = new JsonTextReader(sr))
           {
               db = serializer.Deserialize<DatabaseForAdmin>(jr)!;
           }
       }
       return db;
   }

    public static void SerializeDatabaseDoctor(DataBaseForDoctors db)
    {
        var serializer = new JsonSerializer();

        using (var sw = new StreamWriter("../../../Services/doctor.json"))
        {
            using (JsonTextWriter jw = new JsonTextWriter(sw))
            {
                jw.Formatting = Formatting.Indented;
                serializer.Serialize(jw, db);
            }
        }
    }

    public static DataBaseForDoctors DeserializeDatabaseDoctor()
    {
        DataBaseForDoctors db;
        var serializer = new JsonSerializer();
        using (var sr = new StreamReader("../../../Services/doctor.json"))
        {
            using (var jr = new JsonTextReader(sr))
            {
                db = serializer.Deserialize<DataBaseForDoctors>(jr)!;
            }
        }
        return db;
    }
}