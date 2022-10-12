using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count() < 5)
            {
                InvalidOperationException invalidOperationException = new InvalidOperationException();
                throw invalidOperationException;
            }
            else
            {
                if (averageGrade >= 0.8 && averageGrade <= 1)
                {
                    return 'A';
                }
                else if (averageGrade >= 0.6 && averageGrade < 0.8)
                {
                    return 'B';
                }
                else if (averageGrade >= 0.4 && averageGrade < 0.6)
                {
                    return 'C';
                }
                else if (averageGrade >= 0.2 && averageGrade < 0.4)
                {
                    return 'D';
                }
                return 'F';
            }
            
        }
    }
}

