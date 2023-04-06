using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Generic_Sigorta
{
    public class DataOperations<T>
    {

        private static List<T> DataList { get; set; } = new List<T>(); // Genel Liste
        private static string GetObjectFullName()
        {
            return typeof(T).FullName; // bize dönen tipe göre fullname i alır 
        }

        private static string GetObjectFileName()
        {
            string path = "C:/Data2/";
            path = path + GetObjectFullName(); // bize gelen objeye göre File oluşturur.
            path = path + ".Sigorta";
            return path;
        }

        public static void IfNotExistsCreateFile()
        {
            string fileName = GetObjectFileName();

            if (!File.Exists(fileName))
            {
                File.Create(fileName).Close();
            }
        }

        //File a yazdırma.
        private static void SaveData()
        {
            JavaScriptSerializer s = new JavaScriptSerializer();
            string data = s.Serialize(DataList);
            File.WriteAllText(GetObjectFileName(), data);
        }


        //File den çekme
        public static List<T> GetData()
        {
            IfNotExistsCreateFile();

            string data = File.ReadAllText(GetObjectFileName());
            JavaScriptSerializer s = new JavaScriptSerializer();
            var objectData = s.Deserialize<List<T>>(data);

            if (objectData == null)
                DataList = new List<T>();
            else
                DataList = objectData;

            return DataList.ToList();
        }




        //Veriyi alıp file a yazdırdığımız zaman listeye de ekleyip save çağırıyoruz.
        public static void AddData(T data)
        {
            DataList.Add(data);
            SaveData();
        }

        //Silme
        public static void DeleteData(int index)
        {
            DataList.RemoveAt(index);
            SaveData();
        }

        public static void EditData(int index, T data)
        {
            DataList[index] = data;
            SaveData();
        }

        public static T GetDataWithIndex(int index)
        {
            return DataList[index];
        } // burda ki T ne iş yapıyor data indexi alıyoruz düzenlemek için tamam
        // ama buradaki fonksiyondaki T ne işe yarıyor.

    }
}

