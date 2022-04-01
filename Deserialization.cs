using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace tp06_1302204050
{
	public class Kuliah1302204050 {
		public string kode_mk { get; set; }
		public string nama_mk { get; set; }

		public void ReadJson() {
			string fileName = "tp6_2_1302204050.json";

			string jsonString = File.ReadAllText(fileName);
			KuliahMahasiswa1302204047[] jsonData = JsonSerializer.Deserialize<KuliahMahasiswa1302204050[]>(jsonString);

			int i = 1;
			Console.WriteLine("Daftar mata kuliah yang diambil");
			foreach (KuliahMahasiswa1302204050 K in jsonData)
			{
				Console.WriteLine($"MK {i} {K.kode_mk} - {K.nama_mk}"); i++;
			}

		}
	}
}
