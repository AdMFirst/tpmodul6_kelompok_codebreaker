using System.Text.Json;

namespace com.kpl.tp.modul6.nim1302204047
{
	public class DataMahasiswa1302204047
	{
		public string nama { get; set; }
		public string nim { get; set; }
		public string fakultas { get; set; }

		
		public void ReadJSON()
		{
			string fileName = "tp6_1_1302204047.json";

			string jsonString = File.ReadAllText(fileName);
			DataMahasiswa1302204047 jsonData = JsonSerializer.Deserialize<DataMahasiswa1302204047>(jsonString);

			this.nama = jsonData.nama;
			this.nim = jsonData.nim;
			this.fakultas = jsonData.fakultas;

			Console.WriteLine($"Nama {this.nama} dengan nim {this.nim} dari fakultas {this.fakultas}");
		}
	}
}