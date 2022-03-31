using System.Text.Json;

namespace com.kpl.tp.modul6.nim1302204054
{
	public class KuliahMahasiswa1302204054
	{
		public string kode_mk { get; set; }
		public string nama_mk { get; set; }

		/// <summary>
		/// this function read jsoon file and crate an array of KuliahMahasiswa1302204054
		/// after that the values on this array are printed
		/// </summary>
		public void ReadJson()
        {
			string fileName = "tp6_2_1302204054.json";

			string jsonString = File.ReadAllText(fileName);
			KuliahMahasiswa1302204054[] jsonData = JsonSerializer.Deserialize<KuliahMahasiswa1302204054[]>(jsonString);

			int i = 1;
			Console.WriteLine("Daftar mata kuliah yang diambil");
			foreach (KuliahMahasiswa1302204054 K in jsonData)
            {
				Console.WriteLine($"MK {i} {K.kode_mk} - {K.nama_mk}"); i++;
            }
			
		}
	}
}
