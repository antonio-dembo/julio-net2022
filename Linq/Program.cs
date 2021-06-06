using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "the quick brown fox jumps over the lazy dog";

            string[] words = sentence.Split(' ');

            // using query expression syntax
            var query = from word in words      
                        group word.ToUpper() by word.Length into gr
                        orderby gr.Key
                        select new {Length = gr.Key, Words = gr};

            // Using method-based query syntax
            var query2 = words.GroupBy(w => w.Length , w => w.ToUpper())
                .Select(g => new {Length = g.Key , Words = g})
                .OrderBy(o => o.Length) ;

            foreach (var obj in query2)
            {
                Console.WriteLine("Words of Length {0}", obj.Length);
                foreach(string word in obj.Words){
                    Console.WriteLine(word);
                }
            }

        }
    }
}
