using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VirtualPetSimulator
{
    class Class1
    {

        static String name = " ";
        static int hunger = 0;
        static int happiness = 0;
        static int health = 0;

        static bool isTimeOneHour = true;
        static void petOptions()
        {

            Console.WriteLine("\n Main Menu:");
            Console.WriteLine("1. Feed " + name);
            Console.WriteLine("2. Play with " + name);
            Console.WriteLine("3. Let " + name + " Rest");
            Console.WriteLine("4. Check " + name + "'s Status");
            Console.WriteLine("5. Exit \n");
        }

        static void chooseName(int input)
        {

            switch (input)
            {

                case 1:
                    Console.Write("You've chosen a Cat. What would you like to name your pet?\n");
                    break;

                case 2:
                    Console.Write("You've chosen a Dog. What would you like to name your pet? \n ");
                    break;

                case 3:
                    Console.Write("You've chosen a Rabbit. What would you like to name your pet between the? \n");
                    break;
            }

            name = Console.ReadLine();

            Console.WriteLine("\n User Input :" + name + "\n");

            Console.WriteLine("welcome" + " " + name + "! Let's take good care of him.");
        }

         void petStatus()
        {
            // Console.WriteLine("\n"+name + "'s Status: Hunger: " + hunger+ " Happiness: " + happiness+ " Health: " + health+"\n");
            Console.WriteLine("\n -----------------------------------------------------------------------\n");
            Console.WriteLine(name + "'s Status:");
            Console.WriteLine("- Hunger: " + hunger);
            Console.WriteLine("- Happiness: " + happiness);
            Console.WriteLine("- Health: " + health);
            Console.WriteLine("\n -----------------------------------------------------------------------\n");

        }
         


         void eventStatus()
        {
            
            if (hunger >= 7)
            {
                Console.WriteLine("\n-------------------------------------------------------------------------");
                Console.WriteLine("\n"+name+" is very hungry. You need to feed them!");
            }

            if (happiness <= 3)
            {
                Console.WriteLine("\n-------------------------------------------------------------------------");
                Console.WriteLine("\n"+name+" is very unhappy. Play with them to improve their mood!");
            }

            if (health <= 2)
            {
                Console.WriteLine("\n-------------------------------------------------------------------------");
                Console.WriteLine("\n"+name +" 's health is dangerously low. Take better care of them!");
            }
        }

        void passageOfTime()
        {
            bool timePass = true;

            if (timePass == isTimeOneHour)
            {
                Console.WriteLine("\n Since the Time has passed to an hour, pet status will also change");
                ++hunger;
                --happiness;
                
            }
        }
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            Console.WriteLine("Welcome to the Virtual Pet Simulator \n");
            Console.WriteLine("----------------------------------------------------------------------------\n");
            Console.WriteLine("Please enter the hunger of your pet between the scale of 1 to 10");

            String valueOfHunger = Console.ReadLine();
            hunger = Convert.ToInt32(valueOfHunger);

            Console.WriteLine("Please enter the health  of your pet between the scale of 1 to 10 ");
            String valueOfHealth = Console.ReadLine();
            health = Convert.ToInt32(valueOfHealth);

            Console.WriteLine("Please enter the  happiness of your  pet between the scale of 1 to 10");
            String valueOfHappiness = Console.ReadLine();
            happiness = Convert.ToInt32(valueOfHappiness);

            Console.WriteLine("Has the passage of Time passed to an Hour , this may effect the Pet's Status ? Please enter 'Yes' or 'No' ");
            String answerOfTime = Console.ReadLine();

            if (answerOfTime == "Yes")
                isTimeOneHour = true;
            else
                isTimeOneHour = false;




            Console.WriteLine("Please choose a type of pet: ");
            Console.WriteLine("1. Cat");
            Console.WriteLine("2. Dog");
            Console.WriteLine("3. Rabbit \n");

            String input1 = Console.ReadLine();
            Console.WriteLine("\n User Input :" + input1 + "\n");
            if (input1 == "Cat" || input1 == "Dog" || input1 == "Rabbit")
            {
                if (input1 == "Cat")
                    input1 = "1";
                if (input1 == "Dog")
                    input1 = "2";
                if(input1 == "Rabbit")
                    input1 = "3";
            }
            int input2 = Convert.ToInt32(input1);
            chooseName(input2);

            while (true)
            {
                obj.petStatus();
                petOptions();
               

                string userInput = Console.ReadLine();
                Console.WriteLine("\n User Input :" + userInput + "\n");

                switch (userInput)
                {
                    case "1":
                        Console.Write("You fed " + name + ". His hunger decreases, and health improves slightly");
                        health++;
                        hunger = hunger - 4;

                        break;

                    case "2":
                        Console.Write("You played with " + name + ". His happiness increases, and hunger increases slightly");
                        happiness = happiness + 5;
                        hunger++;
                        break;

                    case "3":
                        Console.Write("Let " + name + " rest. His health improves, and happiness decreases slightly \n");
                        health = health + 5;
                        happiness--;
                        break;

                    case "4":
                        obj.petStatus();
                        return;

                    case "5":
                        Console.Write("Ending the game , Thankyou for playing game.\n");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                obj.eventStatus();
                obj.passageOfTime();
            }

            


        }
    }


}




