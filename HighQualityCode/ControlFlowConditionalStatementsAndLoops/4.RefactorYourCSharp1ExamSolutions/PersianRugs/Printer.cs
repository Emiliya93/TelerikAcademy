/* Telerik Academy Exam 1 @ 3 February 2015 Morning
    Original code (sent in BGCoder) for Task 4. Persian rugs:

    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 1;
            int height = 2 * n + 1;
            int d = int.Parse(Console.ReadLine());
            int slashesEndCount = 2;
             //5 2 
             // 01234567891011
             //   \  \.../  / 0
             //                   smallw = w - 2*d - 2*(r + 1)
             //   #\  \./  /# 1   smw    = w - 2*d - 2*(row - 2 * (row - n) + 1)
             //   ##\     /## 2            11 - 2*2 - 2*(9 - 2 * (9 - 5) + 1)
             //   ###\   /### 3
             //   ####\ /#### 4 

             //   #####X##### 5 = n
 
             //   ####/ \#### 6   row - 2 * (row - n)        n - 1 = 4  1space
             //   ###/   \### 7   row - 2 * (row - n)        n - 2 = 3  3
             //   ##/     \## 8   row - 2 * (row - n)        n - 3 = 2  4
             //   #/  /.\  \# 9   row - 2 * (row - n)        n - 4 = 1 
             //   /  /...\  \ 10 = height - 1
            
            for (int row = 0; row < height; row++)
            {
                //if (row == 0)
                //{
                //    
                // //   \  \.../  / 
                //    
                //    Console.Write('\\');
                //    if ((width - 2 * d - 2) == 5)
                //    {
                //        Console.Write(new string(' ', d));
                //        Console.Write('\\');
                //        Console.Write(new string('.', 3));
                //        Console.Write('/');
                //        Console.Write(new string(' ', d));
                //        Console.Write('/');
                //    }
                //    else
                //    {
                //        Console.Write(new string(' ', width - 2));
                //        Console.Write('/');
                //    }
                //}

                //int smallWidth = (width - 2 * d - 2 * (row + 1));
                //int dotsCount = smallWidth - slashesEndCount;
                //if (dotsCount >= 1)
                //{
                //    Console.Write('\\');
                //    Console.Write(new string('.', dotsCount));
                //    Console.Write('/');
                //}
                //Console.WriteLine();

                //else if (row == height - 1)
                //{
                //    
                // //       /  /...\  \
                //        
                //    Console.Write('/');
                //    if ((width - 2 * d - 2) == 5)
                //    {
                //        Console.Write(new string(' ', d));
                //        Console.Write('/');
                //        Console.Write(new string('.', 3));
                //        Console.Write('\\');
                //        Console.Write(new string(' ', d));
                //        Console.Write('\\');
                //    }
                //    else
                //    {
                //        Console.Write(new string(' ', width - 2));
                //        Console.Write('\\');
                //    }
                //}

                if (row >= 0 && row < n)
                {
                    
                    //  #\  \./  /#
                    //  ##\     /##
                    //  ###\   /###
                    //  ####\ /####
                    

                    int smallWidth = (width - 2 * d - 2 * (row + 1));
                    int dotsCount = smallWidth - slashesEndCount;
                    int spacesCount = width - (row + 1) * 2;
                    Console.Write(new string('#', row));
                    Console.Write('\\');
                
                    //if (dotsCount >= 1)
                    //{
                    //    Console.Write('\\');
                    //    Console.Write(new string('.', dotsCount));
                    //    Console.Write('/');
                    //}
                    if ((width - 2 * d) >= 3 && dotsCount >= 1)
                    {
                        Console.Write(new string(' ', d));
                        Console.Write('\\');
                        Console.Write(new string('.', dotsCount));
                        Console.Write('/');
                        Console.Write(new string(' ', d));
                    }
                    else
                    {
                        Console.Write(new string(' ', spacesCount));
                    }

                    Console.Write('/');
                    Console.Write(new string('#', row));
                }
                
                // #####X#####
                
                else if (row == n)
                {
                    Console.Write(new string('#', n));
                    Console.Write('X');
                    Console.Write(new string('#', n));
                }

                else if (row >= n + 1 && row < height)
                {
                    // smw    = w - 2*d - 2*(row - 2 * (row - n) + 1)
                    int smallWidth = (width - 2 * d - 2 * (row - 2 * (row - n) + 1));
                    int dotsCount = smallWidth - slashesEndCount;
                    int spacesCount = width - 2 * (row - 2 * (row - n)) - slashesEndCount;
                

                    Console.Write(new string('#', row - 2 * (row - n)));
                    Console.Write('/');
                
                    if (smallWidth >= 3 && dotsCount >= 1)
                    {
                        Console.Write(new string(' ', d));
                        Console.Write('/');
                        Console.Write(new string('.', dotsCount));
                        Console.Write('\\');
                        Console.Write(new string(' ', d));
                    }
                    else
                    {
                        Console.Write(new string(' ', spacesCount));
                    }

                    Console.Write('\\');
                    Console.Write(new string('#', row - 2 * (row - n)));
                }
                Console.WriteLine();
            }
        }
    }
*/

namespace PersianRugs
{
    using System;

    public class Printer
    {
        public static void Main()
        {
            // rug’s width = height = 2 * numberForRugsWidthAndHeightFormula + 1.
            int numberForRugsWidthAndHeightFormula = int.Parse(Console.ReadLine());
            int width = (2 * numberForRugsWidthAndHeightFormula) + 1;
            int height = (2 * numberForRugsWidthAndHeightFormula) + 1;
            int distanceBetweenTheSmallerAndTheLargerTriangle = int.Parse(Console.ReadLine());
            int slashesEndCount = 2;

            /*5 2 
             * 01234567891011
                \  \.../  / 0
                                smallw = w - 2*d - 2*(r + 1)
                #\  \./  /# 1   smw    = w - 2*d - 2*(row - 2 * (row - n) + 1)
                ##\     /## 2            11 - 2*2 - 2*(9 - 2 * (9 - 5) + 1)
                ###\   /### 3
                ####\ /#### 4 

                #####X##### 5 = n
 
                ####/ \#### 6   row - 2 * (row - n)        n - 1 = 4  1space
                ###/   \### 7   row - 2 * (row - n)        n - 2 = 3  3
                ##/     \## 8   row - 2 * (row - n)        n - 3 = 2  4
                #/  /.\  \# 9   row - 2 * (row - n)        n - 4 = 1 
                /  /...\  \ 10 = height - 1
            */

            for (int currentRow = 0; currentRow < height; currentRow++)
            {
                if (currentRow >= 0 && currentRow < numberForRugsWidthAndHeightFormula)
                {
                    /*
                    #\  \./  /#
                    ##\     /##
                    ###\   /###
                    ####\ /####
                    */

                    int smallWidth = width - (2 * distanceBetweenTheSmallerAndTheLargerTriangle) - (2 * (currentRow + 1));
                    int dotsCount = smallWidth - slashesEndCount;
                    int spacesCount = width - ((currentRow + 1) * 2);
                    Console.Write(new string('#', currentRow));
                    Console.Write('\\');

                    if ((width - (2 * distanceBetweenTheSmallerAndTheLargerTriangle)) >= 3 && dotsCount >= 1)
                    {
                        Console.Write(new string(' ', distanceBetweenTheSmallerAndTheLargerTriangle));
                        Console.Write('\\');
                        Console.Write(new string('.', dotsCount));
                        Console.Write('/');
                        Console.Write(new string(' ', distanceBetweenTheSmallerAndTheLargerTriangle));
                    }
                    else
                    {
                        Console.Write(new string(' ', spacesCount));
                    }

                    Console.Write('/');
                    Console.Write(new string('#', currentRow));
                }
                else if (currentRow == numberForRugsWidthAndHeightFormula)
                {
                    Console.Write(new string('#', numberForRugsWidthAndHeightFormula));
                    Console.Write('X');
                    Console.Write(new string('#', numberForRugsWidthAndHeightFormula));
                }
                else if (currentRow >= numberForRugsWidthAndHeightFormula + 1 && currentRow < height)
                {
                    // smw    = w - 2*d - 2*(row - 2 * (row - n) + 1)
                    int smallWidth = width - (2 * distanceBetweenTheSmallerAndTheLargerTriangle) - (2 * (currentRow - (2 * (currentRow - numberForRugsWidthAndHeightFormula)) + 1));
                    int dotsCount = smallWidth - slashesEndCount;
                    int spacesCount = width - (2 * (currentRow - (2 * (currentRow - numberForRugsWidthAndHeightFormula)))) - slashesEndCount;

                    Console.Write(new string('#', currentRow - (2 * (currentRow - numberForRugsWidthAndHeightFormula))));
                    Console.Write('/');

                    if (smallWidth >= 3 && dotsCount >= 1)
                    {
                        Console.Write(new string(' ', distanceBetweenTheSmallerAndTheLargerTriangle));
                        Console.Write('/');
                        Console.Write(new string('.', dotsCount));
                        Console.Write('\\');
                        Console.Write(new string(' ', distanceBetweenTheSmallerAndTheLargerTriangle));
                    }
                    else
                    {
                        Console.Write(new string(' ', spacesCount));
                    }

                    Console.Write('\\');
                    Console.Write(new string('#', currentRow - (2 * (currentRow - numberForRugsWidthAndHeightFormula))));
                }

                Console.WriteLine();
            }
        }
    }
}