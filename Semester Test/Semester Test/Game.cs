using System;
using System.Collections.Generic;
using System.Text;

namespace Semester_Test
{
    internal class Game:LibraryResource
    {
        string _contentRating;
        public Game(string name, string developer, string contentRating):base(name, developer)
        {
            _contentRating = contentRating;
        }

        public string ContentRating
        {
            get { return _contentRating; }
        }

    }
}
