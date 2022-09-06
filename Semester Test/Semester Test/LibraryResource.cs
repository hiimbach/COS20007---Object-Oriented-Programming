using System;
using System.Collections.Generic;
using System.Text;

namespace Semester_Test
{
    internal abstract class LibraryResource
    {
        string _name, _developer;
        bool _onLoan;

        public LibraryResource(string name, string developer)
        {
            _name = name;
            _developer = developer;
            _onLoan = false;
        }

        public string Name { get { return _name; } }
        public string Developer { get { return _developer; } }
        public bool OnLoan { get { return _onLoan; } set { _onLoan = value; } }
    }
}
