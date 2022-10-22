﻿using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.GradeBooks;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        private new bool isWeighted;

        public bool GetisWeighted()
        {
            return isWeighted;
        }

        public void SetisWeighted(bool value)
        {
            isWeighted = value;
        }

        public StandardGradeBook(string name, bool weighted) : base(name)
        {
            Type = Enums.GradeBookType.Standard;
        }
    }
}
