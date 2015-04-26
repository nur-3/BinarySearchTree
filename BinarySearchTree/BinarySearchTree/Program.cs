using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5] { 6,7,8,5,3 };
            Console.WriteLine("aranılan sayı:");
            int x = Convert.ToInt32(Console.ReadLine());

            int kucuk = 0; int orta; int buyuk=sayilar.Length-1;
            while(kucuk<=buyuk){
            
                orta=(kucuk+buyuk)/2;

                if (x == sayilar[orta]) {
                    Console.WriteLine("aranılan sayı dizinin {0}. elemanı",orta);
                    break;
                 

                }
                else if (x < sayilar[orta])
                
                    buyuk = orta - 1;
                
                else 
                    kucuk = orta + 1;
                
                
            }

            Console.ReadKey();

           
        }
    }
}
