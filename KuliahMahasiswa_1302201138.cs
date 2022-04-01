using System.Text.Json;

namespace tp06_1302201138
{
    public class KuliahMahasiswa_1302201138
    {
        public class AllMatkul
        {
            public Matkul[] listMatkul { get; set; }
        }

        public class Matkul
        {
            public string kode_mk { get; set; }
            public string nama_mk { get; set; }
        }

        public void ReadJSON()
        {
            string file = "tp6_2_1302201138.json";
            string dataStr = File.ReadAllText(file);
            Matkul[] list = JsonSerializer.Deserialize<Matkul[]>(dataStr);

            int i = 1;
            Console.WriteLine("Daftar mata kuliah yang diambil:");
            foreach (var item in list)
            {
                Console.WriteLine("MK "+ i+ $" {item.kode_mk} - {item.nama_mk}");
                i++;
            }
        }
    }
}
