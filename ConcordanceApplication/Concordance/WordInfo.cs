using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concordance
{
    public class WordInfo
    {
        public WordInfo(string word, int firstLineNumber)
        {
            this.Word = word;
            this.WordCount = 1;
            this.LineNumbers = new List<int>() { firstLineNumber };// лист номеров строк встреч
        }

        public string Word { get; set; }
        public int WordCount { get; set; }
        public List<int> LineNumbers { get; set; }
    }
}
