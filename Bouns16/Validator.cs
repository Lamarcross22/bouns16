using System;
using System.Text.RegularExpressions;

namespace Bouns16
{
    class Validator
    {
        public static int Validator()
        {
            int x = 0;
            while (true)
            {
                Console.WriteLine("How a many cars are you entering?");
                
                try
                {
                    x= int.Parse(Console.ReadLine());
                    if (x > 0)
                    {
                        return x;
                    }

                    Console.WriteLine("Value must be greater than zero!");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    //throw;
                }

                string ContinueValidator(string askUser, string errorMessage)

                {

                    Console.WriteLine(askUser);

                    while (true)

                    {

                        string userInput = Console.ReadLine();

                        if (userInput == "")

                        {

                            Console.WriteLine(errorMessage);

                        }

                        else if (!Regex.IsMatch(userInput ?? throw new InvalidOperationException(), @"^[yY]$|^[yY][eE][sS]$|^[nN]$|^[nN][oO]$"))

                        {

                            Console.WriteLine(errorMessage);

                        }

                        else

                        {

                            return userInput;

                        }

                    }

                }

            }
        }


        public static string ContinueChoiceValidator(string wouldYouLikeToBuyAnotherOne)
        {
            throw new NotImplementedException();
        }
    }
}
