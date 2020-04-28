using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace GradeBook.GradeBooks
{
    class StandardGradeBook : BaseGradeBook
    {
        //Call to the base constructor
        public StandardGradeBook(string name) : base(name)
        {
            this.Type = GradeBookType.Standard;
        }
    }
}
