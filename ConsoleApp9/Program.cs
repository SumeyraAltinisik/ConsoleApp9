namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = " Hello, World!";
            Console.WriteLine(String.IsNullOrEmpty(s)); //bu class a ait olduğu için "String." yazarak çağırdık. (Class member)
            Console.WriteLine(s.Length); //bu instance properties i olduğu için "s." yazarak çağırdık. (instance member)
            Console.WriteLine(s.Trim().ToUpper()); //Trim: başındaki ve sonundaki boşluk karakterlerini atar. Görünmeyen karakterleri temizler.
                                                   //"s.Trim('H')" Başında ve sonunda olan H yi atar. Tek tırnak kullandık çünkü karakter.
                                                   // "s.Trim().ToUpper()" Tüm karakterleri büyük harf yapar.
            Console.WriteLine(s.Substring(2, 3)); //Kullanıldığı string tipli değişkende içeriğin belli bir kısmının alınmasını geri kalan kısmın atılmasını sağlar.
            Console.WriteLine(s.StartsWith("Hello")); // Bununla mı başlıyor. "s.EndsWith("")" bunula mı bitiyor.
            Console.WriteLine("11".PadLeft(5, '*')); // Verilen karakter sayısı kadar istenilen karakteri başına ekliyor.
            Console.WriteLine(s.Replace("Hello", "Naber")); // Hello gördüğün yerde Naber koy.
            Console.WriteLine(s.Contains('H')); //İçinde H geçiyor mu?
            Console.WriteLine(s.IndexOf('H')); // H string içinde kaçıncı karakterde ilk kez karşılaşılıyor.
            Console.WriteLine(s.Insert(3, "H")); //Belli bir yere belli bir karakter koyar.
            Console.WriteLine(s.Reverse());
            Console.WriteLine(ContainsX("Araba", 'b')); //Araba kelimesinde b geçiyor mu?
                                                        //s.ToList().Sort(); 

            Console.WriteLine(PadLeftX("Araba", 7, '*'));
        }
        public static bool ContainsX(string s, char c)
        {
            List<Char> chars = s.ToList();
            foreach (var item in chars)
            {
                if (item == c)
                {
                    return true;
                }
            }
            return false;
        }
        public static int IndexOfX(string s, char c)
        {
            List<Char> chars = s.ToList();
            for (int i = 0; i < chars.Count; i++)
            {
                if (chars[i] == c)
                {
                    return i;
                }
                
            }
            return 1;
        }
        public static string SubstringX(string s, int start)
        {
            string sonuc = "";
            for (int i = start; i < s.Length; i++)
            {
                sonuc = sonuc + s[i];
            }
            return sonuc;
        }
        public static string SubstringX(string s, int start, int count)
        {  
            //return SubstringX(s, start).Take(count).ToString();
            string sonuc = "";
            for (int i = start; i < count; i++)
            {
                sonuc = sonuc + s[i];
            }
            return sonuc;

        }
        public static string PadLeftX(string s, int count, char c)
        {
            if (s.Length >= count)
            {
                return s;
            }
            int fark = count - s.Length;
            string pad = "";
            for (int i = 0; i < fark; i++)
            {
                pad = pad + c;
            }
            return pad + s;
        }
    }
       
}
