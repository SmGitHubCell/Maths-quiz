using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_task_2
{
    class Program
    {
        static string name; //This is a global variable and will store an end users name so that it can be used in other parts of the program 
        static char choice; //another global variable used in the menu option and the first main procedure of the program

        static void Main(string[] args)
        {

            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();// input here must be text based and will be assigned to the name variable
            Console.WriteLine("Please choose one of the following options. \n 'T' if you wish to take the multiplication test \n 'E' if you want to exit the progam ");// the '\n' creates a newline in the block of text making it easier for an end user to read
            choice = char.Parse(Console.ReadLine());//the data type Char must be parsed for it to be read by the program
            choice = char.ToUpper(choice);// Part of my potential error avoidance, this forces the input to a capital essentialy illiminating case sensitivity in this selection.

            if (choice == 'T')//the first option that is checked for and will open up the 'test' sub procedure
            {
                Console.Clear();
                test();//the console calling the sub procedure 'test'
            }

            else if (choice == 'E')//This is the second option the selection statement will check for
            {
                Console.Clear();//this will clear the console screen of any previouse text displayed whihc will tidy up the UI
                exit();
            }

            else// if neither of the previous two options this option will then run in the program
            {
                Console.Clear();
                Console.WriteLine("Please make sure have entered either 'T' or 'E'. \n Press enter to try again");// a simple message to show the neduser that they have inputted an invaled value
                Console.ReadLine();
                selection();//this will run the selection sub procedure 
            }

        }

            static void selection()// this is the selection sub procedure much the same as the previous main bit of code, only used encase of an invalid input during the original menu option.
        {
            Console.WriteLine("Please choose one of the following options. \n 'T' if you wish to take the multiplication test \n 'E' if you want to exit the progam ");
            choice = char.Parse(Console.ReadLine());
            choice = char.ToUpper(choice);

            if (choice == 'T')
            {
                Console.Clear();
                test();
            }

            else if (choice == 'E')
            {
                Console.Clear();
                exit();
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Please make sure have entered either 'T' or 'E'. \n Press enter to try again");
                Console.ReadLine();
                selection();
            }
        }






            static void test()
            {
            int question = 10;//needs a pre-set value as in the loop this value will have 1 added to it each time the loop runs through
            int score = 0;//needs a preset value as in the loop this value will have 1 added to it each time the enduser answers a question correctly
            int answer;
            int firstnum;
            int secondnum;
            int result;
            Random randomnumber = new Random();//imports the random class into the program, needs this if the program wants to use random numbers.



            Console.WriteLine("Welcome to a maths multiplication test.\n You must answer ten questions to the best of your ability in whole numbers\n press the enter key to continue");
            Console.ReadLine();

                 do
                 {
                firstnum = randomnumber.Next(1, 10);//using the random number class to get the first number for the multiplication sum
                secondnum = randomnumber.Next(1, 10);//using the random number class to get the second number for the multiplication sum
                result = firstnum * secondnum;//getting the reulst value by multiplying the previous two numbers

                Console.WriteLine("Please enter the answer to {0} × {1}", firstnum, secondnum);//presentes the question to the enduser in a text format
                answer = int.Parse(Console.ReadLine());//needs to parse the input so it can be held by an integer variable

                    if (result == answer)//if the user inputted answer matches the value of the program calculated result then the enduser has got the sum correct and it increases their score by 1 
                    {
                    Console.BackgroundColor = ConsoleColor.Green;// used the colour green for clear visual feed back
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Welldone, that is the correct answer");
                    Console.ReadLine();
                    score++;//the socre variable having it's value increased by 1 to keep count of how many questions the enduser has got right
                    }

                    else if (answer >= 101 && answer <= -1)//if the number is greater than or equal to 101, or equal or less than -1 this message will appear
                    {
                    Console.WriteLine("Please make a serious attempt");
                    Console.ReadLine();
                    }


                    else//any other answer that doesn't fit into the two previous categories will result in this output
                    {
                    Console.BackgroundColor = ConsoleColor.Yellow;// used the colour yellow for clear visual feed back
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("That was not the correct answer");
                    Console.ReadLine();
                    }
                question--;//this minuses 1 form the question variable each time the loop is run, making it act as a countdown
                Console.Clear();



                 } while (question != 0);//as soon as 10 questions have been completed 



            Console.WriteLine("Welldone {1} you have completed the test, your score is {0}/10.\n Press enter to exit the test.", score, name);//this uses the score and name varaibles to give a slightly personalised message to the user and tell them what they scored out of 10
            Console.ReadLine();//after thsi readline the program will now end
             
            }

            static void exit()//this sub procedure is simply usaed to exit the program fromthe options menu at the start.
        {
            Console.WriteLine("Have a nice day, good bye. \n Press enter to exit");
            Console.ReadLine();
        }

        
    }
}
