using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Concordance
{
    public class Concordance
    {
       
        public Dictionary<string, WordInfo> concordanceDictionary = new Dictionary<string, WordInfo>();//коллекция классов с ключем

        public void AddWordsToDictionary(string[] lines)//метод добавляет отдельные слова к словарю
        {
            int i = 0;

            foreach (var line in lines)// проходим по всей коллекции
            {
                foreach (string word in SplitWords(line.ToLower()))//переводит строку в нижний
                {
                    if (!concordanceDictionary.ContainsKey(word))//содержится ли указаныый ключ в словаре
                    {
                        concordanceDictionary.Add(word, new WordInfo(word, i/12 + 1));// одна страница 12 строк
                        if (concordanceDictionary.ContainsKey(""))//пустые удалять
                        {
                            concordanceDictionary.Remove("");//удаляем пустоту
                        }
                    }
                    else
                    {
                        concordanceDictionary[word].WordCount++;
                        if (!concordanceDictionary[word].LineNumbers.Contains(i/12+1))// есть ли такой элемент
                        {
                           
                            concordanceDictionary[word].LineNumbers.Add(i/12+1);// добавить элемент
                        }
                    }
                } i++;// наращиваем
            } 
            
        }

        public void ShowResult()
        {
           
            List<WordInfo> sortedWordInfos = concordanceDictionary.Values.OrderBy(a => a.Word).ToList();// лист с результатом

            string temp2 = "";
            foreach (var pair in sortedWordInfos) //
            {
                Console.WriteLine("\n");
               
                
                    string temp = pair.Word.Substring(0, 1).ToUpper();//преобразуем к верхнему регистру
                    if (temp != temp2)
                        Console.WriteLine("{0}", pair.Word.Substring(0, 1).ToUpper());
                    
                    temp2 = pair.Word.Substring(0, 1).ToUpper();
                
                Console.Write(pair.Word + "........." + pair.WordCount + ":");
                foreach (int lineNumber in pair.LineNumbers)
                {
                    Console.Write("{0} ", lineNumber);
                }
            }
            Console.ReadKey();
        }


    public  string[] SplitWords(string s)
        {
            return Regex.Split(s, @"\W+");
        }
    }
}
