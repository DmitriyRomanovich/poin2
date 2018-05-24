using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Concordance
{
    class Program
    {
        static void Main(string[] args)
        {
            Reader reader = new Reader();
            String[] text = reader.Read(@"Text.txt");//считывает в text содержимое файла

            Concordance  concordance = new Concordance();// создает коллекцию 
            concordance.AddWordsToDictionary(text);// добавляет слова к колекции
            concordance.ShowResult();// вывод результата в консоль
            


           

        
        }
    }
}
