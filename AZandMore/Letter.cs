using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AZandMore
{
    public class Letter
    {
        public string UpperCaseLetter;
        public string LowerCaseLetter;
        public string Name;
        public string Pronunciation;
        public string ExampleWord;
        public string ExampleWordPronunciation;
        public string ExampleWordImage;
        public string PhoneticCharacter;

        public Letter(string upperCaseLetter, string lowerCaseLetter, string name,
                        string pronunciation, string exampleWord, string exampleWordPronunciation,
                        string exampleWordImage, string phoneticCharacter)
        {
            this.UpperCaseLetter = upperCaseLetter;
            this.LowerCaseLetter = lowerCaseLetter;
            this.Name = name;
            this.Pronunciation = pronunciation;
            this.ExampleWord= exampleWord;
            this.ExampleWordPronunciation = exampleWordPronunciation;
            this.ExampleWordImage = exampleWordImage;
            this.PhoneticCharacter = phoneticCharacter;
        }
    }
}
