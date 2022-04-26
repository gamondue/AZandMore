using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AZandMore
{
    public class Number
    {      
        public string name;
       
        public string exampleWord;
        public string exampleWordPronunciation;

        public Number(string name,string exampleWord, string exampleWordPronunciation)
        {            
            this.name = name;
            this.exampleWord = exampleWord;
            this.exampleWordPronunciation = exampleWordPronunciation;                        
        }
    }
}
