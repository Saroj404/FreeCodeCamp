using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freecodecamp
{
    class BookConstr
    {
        public string title;
        public string author;
        public int pages;

        public BookConstr(string aTitle,string aAuthor,int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}
