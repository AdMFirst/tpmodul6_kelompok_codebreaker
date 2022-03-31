using com.kpl.tp.modul6.nim1302204054;

namespace com.kpl.tp.modul6
{
    public class main
    {
        public static void Main()
        {
            DataMahasiswa1302204054 mhs1 = new DataMahasiswa1302204054();
            mhs1.ReadJSON();

            KuliahMahasiswa1302204054 mhs2 = new KuliahMahasiswa1302204054();
            mhs2.ReadJson();
        }
    }
}