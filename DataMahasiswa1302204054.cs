using System.Text.Json;

namespace com.kpl.tp.modul6.nim1302204054
{
	public class DataMahasiswa1302204054
	{
		public string nama { get; set; }
		public string nim { get; set; }
		public string fakultas { get; set; }

		/// <summary>
		/// This program read the value(s) of tp6_1_1302204054.json and
		/// assign that value as attributes
		/// </summary>
		public void ReadJSON()
		{
			string fileName = "tp6_1_1302204054.json";

			string jsonString = File.ReadAllText(fileName);
			DataMahasiswa1302204054 jsonData = JsonSerializer.Deserialize<DataMahasiswa1302204054>(jsonString);
			
			this.nama = jsonData.nama;
			this.nim = jsonData.nim;
			this.fakultas = jsonData.fakultas;

			Console.WriteLine($"Nama {this.nama} dengan nim {this.nim} dari fakultas {this.fakultas}");
		}
	}
}