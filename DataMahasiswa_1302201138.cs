using System.Text.Json;

namespace tp06_1302201138
{
    public class DataMahasiswa_1302201138
    {
        public class DataMahasiswa
        {
            public string nama { get; set; }
            public string nim { get; set; }
            public string fakultas { get; set; }
        }

        public void ReadJSON()
        {
            string file = "tp6_1_1302201138.json";
            string dataStr = File.ReadAllText(file);
            DataMahasiswa dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa>(dataStr);
            
            
            Console.WriteLine($"Nama {dataMahasiswa.nama} dengan NIM {dataMahasiswa.nim} dari fakultas {dataMahasiswa.fakultas}");
        }
    }
}