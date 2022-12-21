using System;

namespace Open_Lab_05._02
{
    public class StringTools
    {
        public string NoYelling(string sentence)
        {
            string result = sentence;
            while (sentence[sentence.Length-1] == sentence[sentence.Length -2]&&sentence.Length>0 )
            {
                result =sentence.Remove(sentence.Length -1 ); 
            }
            return result;
        
        }
    }
}
