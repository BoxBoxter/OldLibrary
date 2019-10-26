using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaWindowsUi
{
    public class Book
    {
        public int ID_LLIB { get; set; }
        public string TITOL { get; set; }
        public string FullInfo
        {
            get
            {
                return ID_LLIB + ":\t" + TITOL;
            }
        }
    }
}
