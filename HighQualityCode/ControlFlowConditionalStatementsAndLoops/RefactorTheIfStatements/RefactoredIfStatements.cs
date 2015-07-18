/* Refactor the following if statements:
    Potato potato;
    //... 
    if (potato != null)
       if(!potato.HasNotBeenPeeled && !potato.IsRotten)
        Cook(potato);
    and

    if (x >= MIN_X && (x =< MAX_X && ((MAX_Y >= y && MIN_Y <= y) && !shouldNotVisitCell)))
    {
       VisitCell();
    }
*/

namespace RefactorTheIfStatements
{
    using System;

    public class RefactoredIfStatements
    {
        public static void Main()
        {
            Potato potato = new Potato();
            
            if (potato == null)
            {
                throw new NullReferenceException();
            }

            if (potato.HasNotBeenPeeled && potato.IsRotten)
            {
                throw new NotImplementedException();
            }
            else
            {
                Cook(potato);
            }

            // Another if statement
            const int MIN_X = 0;
            const int MAX_X = 0;
            const int MIN_Y = 100;
            const int MAX_Y = 100;
            int x = 5, y = 10;

            bool shouldNotVisitCell = false;
            bool isValidX = x >= MIN_X && x <= MAX_X;
            bool isValidY = MAX_Y >= y && MIN_Y <= y;

            if (isValidX && isValidY && (shouldNotVisitCell == false))
            {
               VisitCell();
            }
        }

        private static void VisitCell()
        {
            throw new NotImplementedException();
        }

        private static void Cook(Potato potato)
        {
            throw new System.NotImplementedException();
        }
    }
}
