﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class ReferenceBook
    {
        public string LibraryId { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public int Pages { get; set; }

        public int CheckOutDurationInDays { get; set; }

        public string Borrower { get; set; }

        public DateTime BorrowDate { get; set; }

        public void CheckOut (string borrower)
        {
            throw new NotImplementedException ();
        }

        public void CheckIn()
        {

        }
    }
}
