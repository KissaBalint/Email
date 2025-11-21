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
                    case "1" : Console.WriteLine("e-mailok listázása"); break;
                    case "2" : Console.WriteLine("új e-mail"); break;
                    case "3" : Console.WriteLine("e-mail törlése"); break;
                    case "4" : Console.WriteLine("érvényes e-mailok listázása"); break;
                    default : Console.WriteLine("rossz parancs");break;
                }
                Console.ReadKey();
            }
        }
    }
}
