﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaWindowsUi
{
    public class BooksAuthor
    {
        public int ID_AUT { get; set; }
        public string NOM_AUT { get; set; }
        public string FullInfo
        {
            get
            {
                return ID_AUT + ":\t" + NOM_AUT;
            }
        }
    }
}
