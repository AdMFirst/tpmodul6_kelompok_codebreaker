using System.Text.Json;

namespace tp06_1302201138
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_1302201138 data = new DataMahasiswa_1302201138();
            data.ReadJSON();

            Console.WriteLine("");

            KuliahMahasiswa_1302201138 kuliah = new KuliahMahasiswa_1302201138();
            kuliah.ReadJSON();
        }
    }
}
