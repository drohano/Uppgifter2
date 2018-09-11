using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Uppgifter10SEP
{
    class Program
    {
        static void Main(string[] args)
        {

            int start = 1;

            do

            {
                int n;

                Console.WriteLine("\n Pick a programm \n 1 , 2 , 3 , 4 , 5 , 6 , 7, 8 \n Press 0 then enter to exit");
                n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.WriteLine("\n Write a sentence ");
                        String sentenceOne = Console.ReadLine();

                        Regex regexA = new Regex(@"[^\W\d](\w|[-']{1,2}(?=\w))*");
                        MatchCollection matchesOne = regexA.Matches(sentenceOne);

                        Console.WriteLine("\n The sentence contains {0} words." , matchesOne.Count);

                        String[] words = sentenceOne.Split(' ');
                        foreach (Match word in matchesOne)
                        {
                            Console.WriteLine(" {0} contains {1} characters." , word, word.Length);
                        }



                        start = 1;
                        break;


                    case 2:
                        Console.WriteLine("\n Write a sentence.\n The words will be placed in order based on their size.\n ");
                        String sentenceTwo = Console.ReadLine();

                        Regex regexB = new Regex(@"[^\W\d](\w|[-']{1,2}(?=\w))*");
                        MatchCollection matchesTwo = regexB.Matches(sentenceTwo);
                        
                        //put stings in the array
                        String[] arrayTwo = new string [matchesTwo.Count];
                        int indexTwo = 0;
                        foreach(Match match in matchesTwo)
                        {
                            arrayTwo[indexTwo++] = match.ToString();
                        }

                        // compares the words 
                        Array.Sort(arrayTwo, (x, y) => x.Length.CompareTo(y.Length));
                        foreach(string wordTwo in arrayTwo)
                        {
                            Console.WriteLine(wordTwo);                            
                        }

                        Console.WriteLine("\n"); 

                        Array.Sort(arrayTwo, (x, y) => y.Length.CompareTo(x.Length));
                        foreach (string wordTwo in arrayTwo)
                        {
                            Console.WriteLine(wordTwo);
                        }

                        start = 1;
                        break;


                    case 3:


                        start = 1;
                        break;



                    case 4:


                        start = 1;
                        break;



                    case 5:


                        start = 1;
                        break;


                    case 6:


                        start = 1;
                        break;


                    case 7:


                        start = 1;
                        break;


                    case 8:


                        start = 1;
                        break;


                    case 0:
                        start = 0;
                        break;


                    default:
                        Console.WriteLine("Whoops something went wrong try again. \n");
                            start = 1;
                        break;
                }
  
            }

            while (start != 0);
        }
    }
}
