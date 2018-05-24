using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concordance
{
    public class Reader
    {
      
       
        public string[] Read ( String path)
        {
            string[] lines = {};// массив строк
            try
            {
                lines = File.ReadAllLines(path: path);//открывает файл считывает все строки и закрывает его
                
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);//если что-то не так брось это
            }
            return lines;// что считали
        }

        

       
    }
}
