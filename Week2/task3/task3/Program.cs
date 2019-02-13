using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task3
{
    class Program
    {
        public static void probel(int num)//создаем функцию, которая осталяет пробелы между уровнями папок 
        {
            for(int i=0; i<num; i++)
            {
                Console.Write("   ");
            }
        }
        public static void Ex(DirectoryInfo dir, int a)//создаем функцию, которая выводит названия и все содержимое в папке 
        {
            foreach(FileInfo f in dir.GetFiles())//для файлов
            {
                probel(a);
                Console.WriteLine(f.Name);
            }
            foreach(DirectoryInfo d in dir.GetDirectories())//для папок
            {
                probel(a);
                Console.WriteLine(d.Name);
                Ex(d, a + 1);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Лох№1\Desktop\PP2");
            Ex(dir, 0);//вызываем функцию
            
        }
    }
}
