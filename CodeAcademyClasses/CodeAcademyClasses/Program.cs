using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademyClasses
{
    internal class Program
    {
        // To run your code you can open "Terminal" and write "dotnet run" and it will run your code but you can also press the play button

        // Comments are lines of code that are ignored by your computer; they’re intended to be read by developers. Comments are made with // or /* and */.
        static void Main(string[] args)
        {
            // *------------------------------------------------------------PROGRAM STARTS HERE------------------------------------------------------------*

            // Console.WriteLine() code outputs what's written inside to the tmernial or your output
            // Or in other words: Console.WriteLine() prints text to the console.
            Console.WriteLine("Hello, World!\n");
            Console.WriteLine("How old are you?");
            // This takes whatever string you type in the terminal and saves it as a variable i.e input 
            // Or in other words Console.ReadLine() captures user input in the console.
            string input = Console.ReadLine();
            Console.WriteLine($"you are {input} years old? Amazing!\n\n");

            // The Purpose of this is to make a creature
            Console.WriteLine(" .-.");
            Console.WriteLine("(o o)");
            Console.WriteLine("| O |");
            Console.WriteLine("|   |");
            Console.WriteLine("'~~~'");
            Console.WriteLine("This my creature his name is bob\n\n");
            // The backslash \ is an escape character in C#, so \" will show up as one quote in the output (") and \\ will show up as one backslash in the output (\). Spaces matter! " (" is not the same as "(".

            // *------------------------------------------------------------PROGRAM ENDS HERE------------------------------------------------------------*

            // Different Types of Variables in C#:

            /*
             * 
             * int - whole numbers, like: 1, -56, 948
             * double - decimal numbers, like: 239.43909, -660.01
             * char - single characters, like: “a”, “&”, “£”
             * string - string of characters, like: “dog”, “hello world”
             * bool - boolean values, like: true or false
             * 
             * */

            // Creating Variables in C#
            /* 1. To practice creating variables, we’re going to write a program that prints information about a dog to the console.We’ll be working with the types string, int, double, and bool.
            * First, create two string variables. The first one is called name and has the value "Shadow".
             The second one is called breed and has the value "Golden Retriever". */

            // ------------------------------------------------------------PROGRAM STARTS HERE------------------------------------------------------------*

            // Create Variables
            string name = "Shadow";
            string breed = "Golden Retriever";
            int age = 5;
            double weight = 65.22;
            bool spayed = true;

            // Print variables to the console
            Console.WriteLine(name);
            Console.WriteLine(breed);
            Console.WriteLine(age);
            Console.WriteLine(weight);
            Console.WriteLine(spayed);

            // Print variables in a single or two sentences
            Console.WriteLine("\nThe dog's name is " + name + " The breed is a " + breed + " Shadow is now " + age + " years old, and he weighs " + weight + ".");
            Console.WriteLine("True of false is he spayed?\n" + spayed + "\n\n\n");

            // *------------------------------------------------------------PROGRAM ENDS HERE------------------------------------------------------------*

            /*1. One example of when we have to use conversions is when we ask a user to input a numerical value. Even if that value is an integer or a decimal, Console.ReadLine() will always return a string.
               Let’s write a program that asks a learner for their favorite number and see if we can implicitly convert their response to an int.
               To start, below the Console.Write() statement, create an int variable named faveNumber and set it equal to Console.ReadLine().
               To run the program, press the Run button to save your work, then type dotnet run into the console. */

            // *------------------------------------------------------------PROGRAM STARTS HERE------------------------------------------------------------*

            // Ask user for fave number
            // Console.Write("Enter your favorite number!: ");
            // int faveNumber = Console.ReadLine(); // This will create an error because Console.ReadLine() is a string method

            // Turn that answer into an int

            // *------------------------------------------------------------PROGRAM ENDS HERE------------------------------------------------------------*

            /* 2. Hmm. That didn’t work. Instead, we got the error message:
             * error: cannot implicitly convert type 'string' to 'int'. The build failed. Please fix the build errors and run again.
             * Looks like we’re going to have to cast their response as an int some other way!
             * 
             * Try explicitly casting the value of faveNumber as an int and rerun the program. What happens this time?*/

            // HINT: To explicitly cast a value as an int: int variableName = (int)value;

            // *------------------------------------------------------------PROGRAM STARTS HERE------------------------------------------------------------*

            // Ask user for fave number
            // Console.Write("Enter your favorite number!: ");
            // int faveNumber = (int)Console.ReadLine();  // This still does not work

            // Turn that answer into an int

            // *------------------------------------------------------------PROGRAM ENDS HERE------------------------------------------------------------*

            /* 3. If you tried dotnet run again, you’ll see that (int) didn’t work either. That’s because it is not possible to explicitly convert a string into an int (or vice versa) in C#. This time, let’s try using a built-in method to do the conversion.
             * 
             * Look at this article on converting strings to int. It lists a few of the methods in the Convert class, including: Convert.ToInt32(). This method takes a string and outputs an integer. Let’s try it!
             * 
             * Delete the explicit casting (int) from the code editor. Add the Convert.ToInt32() method so that it takes the user input as a string.
             * 
             * Run the code again. Did you run into any errors? */

            // HINT: To use a method from the Convert class: int number = Convert.ToInt32("string value");

            // *------------------------------------------------------------PROGRAM STARTS HERE------------------------------------------------------------*

            // Ask user for fave number
            Console.Write("Enter your favorite number!: ");
            int faveNumber = Convert.ToInt32(Console.ReadLine());

            // Turn that answer into an int
            Console.WriteLine("Your favorite number is " + faveNumber);

            // *------------------------------------------------------------PROGRAM ENDS HERE------------------------------------------------------------*

            /* Galactic Travel Agency
            You are tasked with managing passenger profiles for a Galactic Travel Agency. 
            Each passenger has a name, age, ticket type, and preferred planet to visit. Using C#, you’ll start by creating these variables, manipulating them for different operations, 
            and applying data conversions where needed. */

            // *------------------------------------------------------------PROGRAM STARTS HERE------------------------------------------------------------*

            // Creating Passenger Profiles

            String passengerName = "Zara";
            int passengerAge = 28;
            string ticketType = "First Class";
            string preferredPlanet = "Mars";

            // Printing and Basic Operations

            Console.WriteLine("\n\n" + passengerName);
            Console.WriteLine(passengerAge);
            Console.WriteLine(ticketType);
            Console.WriteLine(preferredPlanet);

            passengerAge++;

            Console.WriteLine("Our Mistake, Passenger age is: ");
            Console.WriteLine(passengerAge);

            // Explicit and Implicit Conversions
            // Explicitly convert the passengerAge to a double and assign it to a variable called passengerAgeDouble. Print passengerAgeDouble to the console.

            double passengerAgeDouble = (double)passengerAge;
            Console.WriteLine(passengerAgeDouble);

            // Implicitly convert passengerAge to a double and assign it to passengerAgeDouble2. Print passengerAgeDouble2 to the console.

            double passengerAgeDouble2 = passengerAge;
            Console.WriteLine(passengerAgeDouble2);

            // Finally, convert the passengerAge to a string using Convert.ToString() and assign it to a variable called passengerAgeString. Print passengerAgeString to the console.

            string passengerAgeString = Convert.ToString(passengerAge);
            Console.WriteLine(passengerAgeString);


            // *------------------------------------------------------------PROGRAM ENDS HERE------------------------------------------------------------*

            // Numerical Data Types


            /* 1.
            Several large pizza chains employ C# developers. Let’s imagine that you work for the chain, Giant Brutus. Your boss gives you some data and wants you to enter it into a C# program.
            The first value they give you is the number of pizza shops they own, which is 4332. Save this number to a variable named pizzaShops. Which data type should you use for the variable? */

            // *------------------------------------------------------------PROGRAM STARTS HERE------------------------------------------------------------*

            // Number of pizza shops
            int pizzaShops = 4332;

            // Number of employees
            int totalEmployees = 86928;

            // Revenue
            decimal revenue = 390819.28m;

            // Log the values to the console:
            Console.WriteLine("\n\n" + pizzaShops);
            Console.WriteLine(totalEmployees);
            Console.WriteLine(revenue);

            // *------------------------------------------------------------PROGRAM ENDS HERE------------------------------------------------------------*

            // Arithmetic Operators

            /* 1. Did you know that your age would be different on another planet? Different planets orbit the sun at different rates, so 1 year on Earth can be much shorter or much longer on another planet, depending on their position in the solar system.
            Start by saving your age on Earth as a whole number in a variable named userAge.*/

            // *------------------------------------------------------------PROGRAM STARTS HERE------------------------------------------------------------*

            // Your Age
            int userAge = 21;

            // Length of years on Jupiter (in Earth years)
            double jupiterYears = 11.86;

            // Age on Jupiter
            double jupiterAge = userAge / jupiterYears;


            // Time to Jupiter
            double journeyToJupiter = 6.142466;


            // New Age on Earth
            double newEarthAge = userAge + journeyToJupiter;

            // New Age on Jupiter
            double newJupiterAge = newEarthAge / jupiterYears;


            // Log calculations to console
            Console.WriteLine("\n\nAge on Earth: " + userAge);
            Console.WriteLine("Lenght of years on Jupiter in Earth years: " + jupiterYears);
            Console.WriteLine("Age on Jupiter: " + jupiterAge);
            Console.WriteLine("Time to travel to Jupiter: " + journeyToJupiter + " years");
            Console.WriteLine("New age on Earth after travelling to Jupiter: " + newEarthAge);
            Console.WriteLine("New age on Jupiter: " + newJupiterAge);

            // *------------------------------------------------------------PROGRAM ENDS HERE------------------------------------------------------------*

            // Operator Shortcuts

            /* 1. Ever heard of the phrase, “two steps forward, one step back?” It means that you can make progress in some task, but also might suffer some setbacks in the process. It’s also a great way to illustrate the concept of incrementing and decrementing!
                  Start by creating a variable named steps and initialize it to 0.*/

            // *------------------------------------------------------------PROGRAM STARTS HERE------------------------------------------------------------*

            // Declare steps variable
            int steps = 0;

            // Two steps forward
            steps = steps + 2;
            // or steps += 2;


            // One step back 
            steps = steps - 1;
            // or steps -= 1;
            // or steps--;


            // Print result to the console
            Console.WriteLine(steps);


            // *------------------------------------------------------------PROGRAM ENDS HERE------------------------------------------------------------*

            // Modulo

            /* 1. You’re teaching computer science in a classroom and need to break up your students into teams.
                  Start by creating a variable named students that has the value 18.*/

            // *------------------------------------------------------------PROGRAM STARTS HERE------------------------------------------------------------*

            // Number of students
            int students = 18;

            // Number of students in a group
            int groupSizeOne = 3;
            int groupSizeTwo = 4;
            int groupSizeThree = 5;


            // Does groupSize go evenly into students?
            Console.WriteLine("Students left if group size is 3: ");
            Console.WriteLine(students % groupSizeOne + "\n");
            Console.WriteLine("Students left if group size is 4: ");
            Console.WriteLine(students % groupSizeTwo + "\n");
            Console.WriteLine("Students left if group size is 5: ");
            Console.WriteLine(students % groupSizeThree + "\n\n");


            // *------------------------------------------------------------PROGRAM ENDS HERE------------------------------------------------------------*

            // Built-In Methods

            /* 1. In this exercise, we’re going to use built-in methods to determine which number is smaller between the square roots of two different numbers.
                  First, find the square root of numberOne and round the answer down so it doesn’t have a decimal. Save this value to a new double variable numberOneSqrt.*/

            // *------------------------------------------------------------PROGRAM STARTS HERE------------------------------------------------------------*

            // Starting variables 
            int numberOne = 12932;
            int numberTwo = -2828472;

            // Use built-in methods and save to variable 
            double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));

            // Use built-in methods and save to variable 
            // double numberTwoSqrt = Math.Floor(Math.Sqrt(numberTwo)); This won't work because we can't take a negative number and sqrt it inb C#
            double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));


            // Print the lowest number
            // Console.WriteLine(Math.Min(numberOneSqrt, numberTwoSqrt)); Print's out Nan which stands for "Not a number" in C#
            Console.WriteLine("Smallest number between two square roots: " + Math.Min(numberOneSqrt, numberTwoSqrt) + "\n\n");

            // *------------------------------------------------------------PROGRAM ENDS HERE------------------------------------------------------------*

            // Building Strings

            /* 1. Create a string variable named firstSentence and save the following string to it: It is a truth universally acknowledged, that a single man in possession of a good fortune must be in want of a wife.*/

            // *------------------------------------------------------------PROGRAM STARTS HERE------------------------------------------------------------*


            // First string variable
            string firstSentence = "It is a truth universally acknowledged, that a single man in possession of a good fortune must be in want of a wife.\r\n";

            // Second string variable
            string firstSpeech = "\"My dear Mr. Bennet,\" said his lady to him one day, \"have you heard that Netherfield Park is let at last?\"\r\n";


            // Print variable and newline
            Console.WriteLine("Printing the first sentence and first speech\n" + firstSentence + "\n" + firstSpeech + "\n\n");


            // *------------------------------------------------------------PROGRAM ENDS HERE------------------------------------------------------------*

            // String Concatenation

            /* 1. Let’s use string concatenation to tell a story. Come up with a beginning, middle, and end to the story and save them to the corresponding variables beginning, middle, and end.*/

            // *------------------------------------------------------------PROGRAM STARTS HERE------------------------------------------------------------*

            // Declare the variables
            string beginning = "Once upon a time, \n";
            string middle = "There was once a soldier. He marched through techerous lands to find all the treassure in the world, which he did.\n";
            string end = "And he lived happily ever after.\n\n";


            // Concatenate the string and the variables
            string story = beginning + middle + end;


            // Print the story to the console 
            Console.WriteLine("Let me tell you a short story: \n" + story);


            // *------------------------------------------------------------PROGRAM ENDS HERE------------------------------------------------------------*

            // String Interpolation

            /* 1. Let’s revisit a story and use string interpolation. This time, we’ve provided you with the variables. Using the provided beginning, middle, and end variables, interpolate the story variable.*/


            // *------------------------------------------------------------PROGRAM STARTS HERE------------------------------------------------------------*

            // Declare the variables
            string beginning1 = "Once upon a time,";
            string middle1 = "The kid climbed a tree";
            string end1 = "Everyone lived happily ever after.";

            // Interpolate the string and the variables
            string story1 = $"Let me tell you a story, {beginning1} There was a kid named Bob {middle1} and somehow fell down and died. {end1}";


            // Print the story to the console 
            Console.WriteLine(story1 + "\n\n");



            // *------------------------------------------------------------PROGRAM ENDS HERE------------------------------------------------------------*


            // Get Info About Strings

            /* 1. You’ve been asked to build a program that verifies some information about a piece of data. First, check the length of password and save the result to the variable passwordLength.*/

            // *------------------------------------------------------------PROGRAM STARTS HERE------------------------------------------------------------*

            // Create password
            string password = "a92301j2add";

            // Get password length
            int passwordLength = password.Length;


            // Check if password uses symbol
            int passwordCheck = password.IndexOf("!");


            // Print results
            Console.WriteLine($"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check.\n\n");



            // *------------------------------------------------------------PROGRAM ENDS HERE------------------------------------------------------------*


            // Get Parts Of Strings

            /* 1. In program.cs, you are given a string defined as startStrand. Your goal is to find the ending condition for a DNA strand, "TGA", and then print out the substring of startStrand that starts from the first character and goes through "TGA".
             * This will output a valid DNA strand. First, use IndexOf() to find the location of "TGA" in startStrand. Save this as a variable called tga.*/

            // *------------------------------------------------------------PROGRAM STARTS HERE------------------------------------------------------------*

            // dna strand
            string startStrand = "ATGCGATGAGCTTAC";

            // find location of "tga"
            int tga = startStrand.IndexOf("TGA");


            // start point and stop point variables
            int startPoint = 0;
            int length = tga + 3;


            // define final strand
            string dna = startStrand.Substring(startPoint, length);
            Console.WriteLine(dna);


            // DNA mutation search
            Console.WriteLine("DNA Mutation Search.\nIf there isn't a mutation the output will be G.\nIf there is a mutation the output will be C or A");
            Console.WriteLine(dna[3] + "\n\n");

            // *------------------------------------------------------------PROGRAM ENDS HERE------------------------------------------------------------*


            // Manipulate Strings

            /*1. You’re writing a movie script but are having trouble following the style guide. To do so, transform this sentence so that the first two words (Close on) are in all caps and the rest are lowercase. 
             * 
             * "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it."
             * 
             * Your assistant already started on this program, separated out the necessary strings, and saved them in the variables cameraDirections and sceneDescription. You need to finish the program. 
             * First, make all of the letters in cameraDirections uppercase and re-save them to the variable cameraDirections.*/

            // *------------------------------------------------------------PROGRAM STARTS HERE------------------------------------------------------------*

            // Script line
            string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";

            // Get camera directions
            int charPosition = script.IndexOf("Close");
            int length1 = "Close on".Length;
            string cameraDirections = script.Substring(charPosition, length1);

            // Get scene description
            charPosition = script.IndexOf("a portrait");
            string sceneDescription = script.Substring(charPosition);

            // Make camera directions uppercase
            cameraDirections = cameraDirections.ToUpper();

            // Make scene description lowercase
            sceneDescription = sceneDescription.ToLower();

            // Print results
            Console.WriteLine($"{cameraDirections} {sceneDescription}\n\n");


            // *------------------------------------------------------------PROGRAM ENDS HERE------------------------------------------------------------*


            // Boolean Data Types


            /* 1. Time to practice writing variables that use a bool data type! 
             * Answer these True/False questions by saving your answer to the specified variables. 
             * 
             * True or False: The number 500 is greater than 24. Save your answer to a variable named answerOne.
             * 
             * True or False: “coffee” contains the letter “a”. Save your answer to a variable named answerTwo.
             */

            // *------------------------------------------------------------PROGRAM STARTS HERE------------------------------------------------------------*

            /*
            bool answerOne = true;
            bool answerTwo = false;
            */

            // *------------------------------------------------------------PROGRAM ENDS HERE------------------------------------------------------------*


            // Equality Operators

            /* Check Docs Document For the Instructions, I've given up now*/

            // *------------------------------------------------------------PROGRAM STARTS HERE------------------------------------------------------------*

            int cookiesSoldGuess = 250;
            Console.WriteLine("I'm guessing we sold: " + cookiesSoldGuess + " cookies\n");

            int storeOneCookies = 110;
            int storeTwoCookies = 135;

            int cookiesSoldActual = storeOneCookies + storeTwoCookies;

            bool guessedCorrect = cookiesSoldGuess == cookiesSoldActual;

            Console.WriteLine("Did i guess correct? " + guessedCorrect + "\n\n");



            // *------------------------------------------------------------PROGRAM ENDS HERE------------------------------------------------------------*


            // Comparison Operators

            /* Check Docs Document For the Instructions, I've given up now*/

            // *------------------------------------------------------------PROGRAM STARTS HERE------------------------------------------------------------*

            double timeToDinner = 4;
            double distance = 95;
            double rate = 30;
            Console.WriteLine("Time to dinner " + timeToDinner + " hours");
            Console.WriteLine("Distance to travel " + distance + " miles");
            Console.WriteLine("Average speed of " + rate + " mph\n");

            double tripDuration = distance / rate;

            bool answer = tripDuration <= timeToDinner;

            Console.WriteLine("Do we make it to our destination before dinner? True = yes, False = no.");
            Console.WriteLine(answer + "\n\n");


            // *------------------------------------------------------------PROGRAM ENDS HERE------------------------------------------------------------*


            // Logical Operators

            /* Check Docs Document For the Instructions, I've given up now*/

            // *------------------------------------------------------------PROGRAM STARTS HERE------------------------------------------------------------*

            bool beach = true;
            bool hiking = false;
            bool city = true;

            bool yourNeeds = beach && city;
            bool friendNeeds = beach || hiking;

            bool tripDecision = yourNeeds && friendNeeds;
            Console.WriteLine(tripDecision+"\n\n");


            // *------------------------------------------------------------PROGRAM ENDS HERE------------------------------------------------------------*


            // if Statements

            /* Check Docs Document For the Instructions, I've given up now*/

            // *------------------------------------------------------------PROGRAM STARTS HERE------------------------------------------------------------*

            int socks = 3;

            if (socks <= 3)
            {
                Console.WriteLine("Time to do laundry!\n\n");
            }


            // *------------------------------------------------------------PROGRAM ENDS HERE------------------------------------------------------------*


            // if-else Statements

            /* Check Docs Document For the Instructions, I've given up now*/

            // *------------------------------------------------------------PROGRAM STARTS HERE------------------------------------------------------------*

            int people = 10;
            string weather = "nice";

            if (people <= 10 && weather == "nice")
            {
                Console.WriteLine("SaladMart\n\n");
            }
            else
            {
                Console.WriteLine("Soup N Sandwich\n\n");
            }


            // *------------------------------------------------------------PROGRAM ENDS HERE------------------------------------------------------------*


            // else-if Statements

            /* Check Docs Document For the Instructions, I've given up now*/

            // *------------------------------------------------------------PROGRAM STARTS HERE------------------------------------------------------------*

            double ph = 3.0;

            if (ph < 7)
            {
                Console.WriteLine("Acidic\n\n");
            }
            else if (ph > 7)
            {
                Console.WriteLine("Basic\n\n");
            }
            else
            {
                Console.WriteLine("Neutral\n\n");
            }

            // *------------------------------------------------------------PROGRAM ENDS HERE------------------------------------------------------------*


            // Switch Statements

            /* Check Docs Document For the Instructions, I've given up now*/

            // *------------------------------------------------------------PROGRAM STARTS HERE------------------------------------------------------------*

            /*

            double ph1 = 4.5;

            switch (ph1)
            {
                case <= 3:
                    Console.WriteLine("Very Acidic\n\n");
                    break;
                case < 7:
                    Console.WriteLine("Acidic\n\n");
                    break;
                case >= 11:
                    Console.WriteLine("Very Basic\n\n");
                    break;
                case > 7:
                    Console.WriteLine("Basic\n\n");
                    break;
                default:
                    Console.WriteLine("Neutral\n\n");
                    break;
            }

            THIS SHOULD WORK BUT NOT IN THIS VERSION OF C#!!!!!!!

            */

            // *------------------------------------------------------------PROGRAM ENDS HERE------------------------------------------------------------*



            // Tenary Operators

            /* Check Docs Document For the Instructions, I've given up now*/

            // *------------------------------------------------------------PROGRAM STARTS HERE------------------------------------------------------------*

            int pepperLength = 4;
            string message = (pepperLength >= 3.5) ? "ready!" : "wait a little longer";

            Console.WriteLine(message+ "\n\n");

            // *------------------------------------------------------------PROGRAM ENDS HERE------------------------------------------------------------*



            // test

            /* Check Docs Document For the Instructions, I've given up now*/

            // *------------------------------------------------------------PROGRAM STARTS HERE------------------------------------------------------------*




        }
    }
}
