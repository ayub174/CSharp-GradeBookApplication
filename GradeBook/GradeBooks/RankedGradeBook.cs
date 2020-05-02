using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {

        public RankedGradeBook(string name) : base(name)
        {
                
            this.Type = Enums.GradeBookType.Ranked;
            
        }


        //Create an override for the get grade method
        public override char GetLetterGrade(double averageGrade)
        {
            
            if(Students.Capacity < 5)
            {
                throw new InvalidOperationException();
            }
            return 'F';
        }

    }
}