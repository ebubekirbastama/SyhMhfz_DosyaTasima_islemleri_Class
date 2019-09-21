using System.IO;

namespace SyhMhfzDosyaTasimaClass
{
    public class ebubekirbastama
    {
        public static string klasor_tasi(string KaynakDosya, string HedefDosya)
       {
            try
            {
                Directory.Move(KaynakDosya, HedefDosya);
            }
            catch (IOException exp)
            {
                return exp.Message;
            }
            return "Taşıma İşlemi Tamamlandı.";
       }
        public static string Copy(string KaynakDosya, string HedefDosya)
        {
            var diSource = new DirectoryInfo(KaynakDosya);
            var diTarget = new DirectoryInfo(HedefDosya);
            return CopyAll(diSource, diTarget);
        }
        public static string CopyAll(DirectoryInfo KaynakDosya, DirectoryInfo HedefDosya)
        {
            try
            {
                Directory.CreateDirectory(HedefDosya.FullName);

                foreach (FileInfo fi in KaynakDosya.GetFiles())
                {
                    fi.CopyTo(Path.Combine(HedefDosya.FullName, fi.Name), true);
                }

                foreach (DirectoryInfo diSourceSubDir in KaynakDosya.GetDirectories())
                {
                    DirectoryInfo nextTargetSubDir =
                        HedefDosya.CreateSubdirectory(diSourceSubDir.Name);
                    CopyAll(diSourceSubDir, nextTargetSubDir);
                }
            }
            catch (System.Exception ex)
            {
                return ex.Message;
            }
            return "Kopyalama İşlemi Tamam";
        }
    }
}
