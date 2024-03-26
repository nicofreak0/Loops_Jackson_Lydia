namespace Loops_Jackson_Lydia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //asks user why they like video games
            Console.WriteLine("Why do you like video games?");
            //takes the sentence the user inputs and puts it to response
            string response = Console.ReadLine();
            //prints to console the users response and states how many spaces are in it
            Console.WriteLine($"The sentence, \"{response}\" has {CountNumberOfSpaces(response)} spaces in it.");

            //asks user to enter a whole number
            Console.WriteLine("Enter a whole number.");
            //takes the user's response and puts it to response2
            string response2 = Console.ReadLine();
            //prints the sum of the individual digits in the number the user inputted
            Console.WriteLine($"The sum of the individual digits of {response2} is {SumOfDigits(response2)}.");
        }

        /// <summary>
        /// counts the number of spaces in the response
        /// </summary>
        /// <param name="sentence">the sentence to count number of spaces in</param>
        /// <returns> number of spaces in the sentence</returns>
        static int CountNumberOfSpaces(string sentence)
        {
            int numberOfSpaces = 0;
            foreach(char character in sentence)
            {
                if(character == ' ')
                    numberOfSpaces++;
            }
            return numberOfSpaces;
        }

        /// <summary>
        /// counts the sum of the individual digits in the whole number response2
        /// </summary>
        /// <param name="number">to find the sum of the individual digits in</param>
        /// <returns>the sum of the individual digits</returns>
        static int SumOfDigits(string number)
        {
            int sum = 0;
            foreach(char digit in number) 
            {
                sum += (int)Char.GetNumericValue(digit);
            }
            return sum;
        }

    }
}