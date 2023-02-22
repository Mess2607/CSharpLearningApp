namespace CsharpLearningApp
{
    public class MainMenu
    {
        public static void Run()
        {
            bool endApp = false;

            Console.WriteLine("--------------------");
            Console.WriteLine("Task storage");
            Console.WriteLine("--------------------");
            Console.WriteLine("This program stores insanely fun C# tasks and links to proposed answers");
            Console.WriteLine("--------------------");
            Console.WriteLine("");
            Console.WriteLine("List of available tasks:");
            Console.WriteLine("Task 1 - Task Storage application");
            Console.WriteLine("Task 2 - Calculator application");
            Console.WriteLine("Task 3 - blank");
            Console.WriteLine("Task 4 - blank");
            Console.WriteLine("Task 5 - blank");
            Console.WriteLine("");
            Console.WriteLine("--------------------");

            while (!endApp)
            {
                string numInput1 = "";

                Console.Write("Please input number of the task you want to display:");
                numInput1 = Console.ReadLine();

                int op = 0;
                while (!int.TryParse(numInput1, out op)) //checking for invalid input
                {
                    Console.Write("This is not a valid number. Please enter new value: ");
                    numInput1 = Console.ReadLine();
                }

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Task 1 - Task Storage application");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Write a console application that stores all tasks and their answers.");
                        Console.WriteLine("It has to ask for user input to display each task.");
                        Console.WriteLine("Display a description of possible inputs.");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Link to repository with proposed answer:");
                        Console.WriteLine("https://github.com/Mess2607/Csharp-tasks/tree/Task1");
                        Console.WriteLine("--------------------");

                        Menu.Calc();

                        break;
                    case 2:
                        Console.WriteLine("Task 2 - Calculator application");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Write a console calculator application that performs calculations on 2 numbers.");
                        Console.WriteLine("It should be able to perform addition, subtraction, multiplication, division.");
                        Console.WriteLine("It should also allow raising a number to power and calculation square root.");
                        Console.WriteLine("Additionally, it should display a remainder after divison");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Link to repository with proposed answer:");
                        Console.WriteLine("https://github.com/Mess2607/Csharp-tasks/tree/Task2");
                        Console.WriteLine("--------------------");
                        break;
                    case 3:
                        Console.WriteLine("Task 3 - blank");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("To be added in the future");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Link to repository with proposed answer:");
                        Console.WriteLine("");
                        Console.WriteLine("--------------------");
                        break;
                    case 4:
                        Console.WriteLine("Task 4 - blank");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("To be added in the future");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Link to repository with proposed answer:");
                        Console.WriteLine("");
                        Console.WriteLine("--------------------");
                        break;
                    case 5:
                        Console.WriteLine("Task 5 - blank");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("To be added in the future");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Link to repository with proposed answer:");
                        Console.WriteLine("");
                        Console.WriteLine("--------------------");
                        break;
                    default: //check for invalid input
                        break;
                }

                Console.WriteLine("Please choose a new task to display or press Q to exit."); //check whether the user wants to continue
                if (Console.ReadLine().ToUpper() == "Q") endApp = true;
            }

            Console.WriteLine("Okay then, bye!");
            return;
        }
    }
}
