using System;
using Generics.Models;

namespace Generics
{
  class Program
    {
        static void Main(string[] args)
        {
            var book = new Book { Isbn= 1111, Title= "C# Advanced"};

            // var Books = new BookList();
            // Books.Add(book);

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(new Book());
            
            var dictionary = new GenericDictonary<string, Book>();
            dictionary.Add("123", new Book());

        }
    }
}
