using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //adatszerkezet
            List<string> e_mailok = new List<string>();
            e_mailok.Add("alma1@kört.hu");
            e_mailok.Add("alma2@dfdfdf.hu");
            e_mailok.Add("alma3@sdssds.hu");
            e_mailok.Add("kissb1@kkszki.hu");
            e_mailok.Add("alma.korte@alma.hu");



            //menü vezérlés
            while (true)
            {
                
                Console.Clear();
                Console.WriteLine("0 - Kilépés");
                Console.WriteLine("1 - e-mailok listázása");
                Console.WriteLine("2 - új e-mail");
                Console.WriteLine("3 - e-mail törlése");
                Console.WriteLine("4 - érvényes e-mailok listázása");

                string valasztas = Console.ReadLine();

                switch (valasztas) 
                {
                    case "0" : return;

                    case "1" :
                        Console.Clear();
                        Console.WriteLine("e-mail címek: ");
                        int sorszam = 0;
                        foreach (string e_mail in e_mailok)
                        {
                        Console.WriteLine($"{sorszam++}.{e_mail}");
                        }; 
                        break;

                    case "2" :
                        Console.Clear(); 
                        Console.WriteLine("Adja meg az új e-mailcímet: ");
                        string uj = Console.ReadLine();
                        e_mailok.Add(uj);
                        break;

                    case "3" :
                        Console.Clear();
                        Console.Write("Adja meg a törlendő e-mail azonosítóját: ");
                        int index = Convert.ToInt32(Console.ReadLine());
                        e_mailok.RemoveAt(index);
                        break;

                    case "4" : Console.WriteLine("érvényes e-mailok listázása"); break;
                    default : Console.WriteLine("rossz parancs");break;
                }
                Console.ReadKey();
            }
        }
    }
}
