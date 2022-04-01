using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace tp06_1302204050
{
    public class DataMahasiswa_1302204050
    {
        public class DataMahasiswa
        {
            public string nama { get; set; }
            public string nim { get; set; }
            public string fakultas { get; set; }
        }

        public void ReadJSON()
        {
            string file = "tp6_1_1302204050.json";
            string dataStr = File.ReadAllText(file);
            DataMahasiswa dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa>(dataStr);


            Console.WriteLine($"Nama {dataMahasiswa.nama} dengan NIM {dataMahasiswa.nim} dari fakultas {dataMahasiswa.fakultas}");
        }
    }
}
