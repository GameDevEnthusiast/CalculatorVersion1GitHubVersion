using System;



namespace GettingInput

{

    class Program

    {

        static void Main()

        {




            /*



       Task for wednesday in c#





      a program





      "Hello Shazia!



      Lets play a game. Give me three numbers.



      give me a number1: <input from console>



      give me a number2: <input from console>



      give me a number 3: <input from console>





      Following is The result from your input: < show the result by adding the values>



      Do you want to play again? J/N



      Thank you for the game < 3 



      */

            Console.WriteLine("Hello! What is your name?");



            string name = Console.ReadLine();

            Console.WriteLine(name);

            Console.WriteLine($"\nHello {name}!\n  ");

            /*
             * This version of WriteLine has spaces hard coded in the line so that the space between "Hello" and {name} makes it so for example output in console looks like "Hello Name" 
             * rather than "HelloName"
             */



            bool done = false;

            /* 
             * pretty retarded way to this since:
             * basically one variable start as false then
             * while loop wants true 
             * so you reverse false with "!" in order to get while true - continue the loop
             * when you couldve just done done = true
             * then simply output an if based on readline for y for true and n for false simple to read not this jumbled shit
             * but i guess thats what happens when you barely learn about while loops and still some random stack overflow guy`s code lmao 
            */

            while (!done)

            {

                if (!done)

                {

                    //do something here

                    /* Console.WriteLine("\nHello! What is your name?");



                      string name = Console.ReadLine();

                    Console.WriteLine(name);

                      Console.WriteLine($"\nHello {name} !  \n  ");

                      */

                    Console.WriteLine("\nLets play a game. Give me three numbers.");




                    Console.WriteLine("Give me the first number:");

                    string FirstNumber = Console.ReadLine();

                    Console.WriteLine(FirstNumber);



                    int FirstNumberInt;

                    FirstNumberInt = Convert.ToInt32(FirstNumber);



                    Console.WriteLine(FirstNumberInt);





                    Console.WriteLine("Give me the second number:");

                    string SecondNumber = Console.ReadLine();

                    Console.WriteLine(SecondNumber);



                    int SecondNumberInt;

                    SecondNumberInt = Convert.ToInt32(SecondNumber);



                    Console.WriteLine(SecondNumberInt);





                    Console.WriteLine("Give me the third number:");

                    string ThirdNumber = Console.ReadLine();

                    Console.WriteLine(ThirdNumber);



                    int ThirdNumberInt;

                    ThirdNumberInt = Convert.ToInt32(ThirdNumber);



                    Console.WriteLine(ThirdNumberInt);



                    //***Hmmm i put in "2839233" but it WriteLine's "283923"



                    /* 



                    Unhandled Exception: System.OverflowException: Value was either too large or too small for an Int32.

                       at System.Number.ParseInt32(ReadOnlySpan`1 s, NumberStyles style, NumberFormatInfo info)

                       at System.Convert.ToInt32(String value)

                       at GettingInput.Program.Main() in /home/ccuser/workspace/c-sharp-hello-world-getting-input/Program.cs:line 58



                       meaning that once the max int count of 2,147,483,647 is maxed out it gives this error



                       while 64-bit integer with a maximum value of 9,223,372,036,854,775,807 allows more keyboard number spam



                       */




                    Console.WriteLine("Following is the result from the sum of your 3 inputs:  ");

                    //string Result = "FirstNumber" + "SecondNumber" + "ThirdNumber"; 

                    //prints out "FirstNumberSecondNumberThirdNumber" lmao



                    // string Result = "FirstNumber" + 2;

                    //print out "FirstNumber2" lmao




                    int Result = FirstNumberInt + SecondNumberInt + ThirdNumberInt;

                    Console.WriteLine(Result);

                    //< show the result by adding the values >





                    Console.WriteLine("Do YOU want to play again? Type \"Y\" or \"N\"");



                    string YesOrNoInput = Console.ReadLine();



                    Console.WriteLine(YesOrNoInput);






                    if (YesOrNoInput == "Y")

                    {

                        done = false;

                    }



                    else if (YesOrNoInput == "y")

                    {

                        Console.WriteLine("False/Else If");

                        done = false;

                    }



                    else if (YesOrNoInput == "N")

                    {

                        Console.WriteLine("False/Else If");

                        done = true;

                    }



                    else if (YesOrNoInput == "n")

                    {

                        Console.WriteLine("False/Else If");

                        done = true;

                    }









                    else

                    {

                        Console.WriteLine("False/Else");

                        done = true;

                    }

                    //Else Console.WriteLine("Thank you for participating in this game <3 ");

                }

                else

                {

                    done = true;

                }

            }




        }

    }

}