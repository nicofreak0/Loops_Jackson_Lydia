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
            Console.WriteLine($"The sentence, \"{response}\" has {CountNumOfSpaces(response)} spaces in it.");

            Console.WriteLine("Enter a whole number.");
            string response2 = Console.ReadLine();
            Console.WriteLine($"The sum of the individual digits of {response2} is {SumOfDigits(response2)}.");
        }

        //counts the number of spaces in the response
        static int CountNumOfSpaces(string sentence)
        {
            int numberOfSpaces = 0;
            foreach(char character in sentence)
            {
                if(character == ' ')
                    numberOfSpaces++;
            }
            return numberOfSpaces;
        }
        
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