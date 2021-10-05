using System;

namespace GettoKnowyourClassmates
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] studNameArray =
            {
                "Justin", //0
                "Matt", //1
                "Logan", //2
                "Raston", //3
                "Yousif", //4
                "Yash", //5
                "Raston", //6
                "Chris", //7
                "Radeen", //8
                "Josh", //9
                "Aron", //10
                "Kasean", //11
                "Scott", //12
                "Delmar", //13
                "Brandon" //14
            };

            string[] homeTownArray =
            {
                "Wyoming, MI",
                "Flint, MI",
                "Plymouth, MI",
                "Zeeland, MI",
                "Oak Park, MI",
                "Detroit, MI",
                "Novi, MI",
                "Warren, MI",
                "Northville, MI",
                "Berea, KY",
                "Detroit, MI",
                "Lansing, MI",
                "Detroit, MI",
                "Novi, MI"
            };

            string[] favFoodArray =
            {
                "Baja Blast",
                "Hot Wings",
                "Fuyuns",
                "Vanilla Instant Pudding",
                "Deep Dish Pizza",
                "Hot Cheeto Puffs",
                "Tacos",
                "Mexican Food",
                "Naleśniki",
                "Sushi",
                "Steak",
                "Nashville Chicken",
                "Vietnamese Food",
                "Sushi"
            };

            string endingInput = "y";

            do
            {
                Console.WriteLine("Welcome to our C# class. Which Student would you like to learn more about? (1-15)");
                int userInput = int.Parse(Console.ReadLine());


                if (userInput <= 15 && userInput >= 1)
                {
                    bool runprogram2 = true;
                    string studentName = studNameArray[userInput - 1];

                    while (runprogram2 == true)
                    {
                        Console.WriteLine($"Student {userInput} is {studentName}. What would like you like to know about them? (hometown/favorite food)");
                        string optionInput = Console.ReadLine();

                        if (optionInput.ToLower().Equals("hometown"))
                        {
                            Console.WriteLine($"{studentName} is from {homeTownArray[userInput - 1]}. Would you like to know more? (y/n)");
                            string yesOrNo = "";
                            yesOrNo = Console.ReadLine();
                            if (yesOrNo.Equals("n"))
                            {
                                runprogram2 = false;
                            }
                            else if (yesOrNo.Equals("y"))
                            {
                                runprogram2 = true;
                            }
                        }
                        else if (optionInput.ToLower().Equals("favorite food"))
                        {
                            Console.WriteLine($"{studentName} likes {favFoodArray[userInput - 1]}. Would you like to know more? (y/n)");
                            string yesOrNo = "";
                            yesOrNo = Console.ReadLine();
                            if (yesOrNo.Equals("n"))
                            {
                                runprogram2 = false;
                            }
                            else if (yesOrNo.Equals("y"))
                            {
                                runprogram2 = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("That student does not exist. Please try again.");
                            runprogram2 = true;
                        }
                    }

                }

                Console.WriteLine("Would you like to learn about a different Student? (y/n)");
                endingInput = Console.ReadLine();
            }
            while (endingInput.Equals("y"));
        }
    }
}
