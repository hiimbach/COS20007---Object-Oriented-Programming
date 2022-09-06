using System;
using System.Collections.Generic;
using System.Text;

namespace Semester_Test
{
    internal class Book:LibraryResource
    {
        string _isbn;
        public Book(string name, string author, string isbn):base(name, author)
        {
            _isbn = isbn;
        }

        public string ISBN { get { return _isbn; } }
    }
}
