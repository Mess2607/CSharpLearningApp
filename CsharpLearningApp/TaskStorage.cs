namespace CsharpLearningApp
{
    public class MainMenu
    {
        public static void Run()
        {
            bool endApp = false;

            string TaskStorageInfo = String.Join(Environment.NewLine,
                "--------------------",
                "Task storage",
                "--------------------",
                "This program stores insanely fun C# tasks and links to proposed answers",
                "--------------------",
                "List of available tasks:",
                "Task 1 - Task Storage application",
                "Task 2 - Calculator application",
                "Task 3 - blank",
                "Task 4 - blank",
                "Task 5 - blank",
                "--------------------");

            Console.Clear();

            Console.WriteLine(TaskStorageInfo);

            while (!endApp)
            {
                string numInput1 = "";

                Console.Write("Please input number of the task you want to display:");
                numInput1 = Console.ReadLine();

                int selection = 0;
                if (!int.TryParse(numInput1, out selection))
                {
                    Console.WriteLine("This is not a valid number. Please enter new value: ");
                    continue;
                }

                string taskInfo = String.Join(Environment.NewLine,
                            @"Task {0} - {1}",
                            "--------------------",
                            @"{2}",
                            "--------------------");

                string continueString = "Input Y followed by Enter to start the program, or press Enter to return to the main menu";

                switch (selection)
                {
                    case 1:
                        Console.Clear();
                        string taskInfo1 = string.Format(taskInfo, 1, "Task Storage application",
                            "Write a console application that stores all tasks and their answers.\n" +
                            "It has to ask for user input to display each task.\n" +
                            "Display a description of possible inputs.");
                        Console.WriteLine(taskInfo1);
                        break;
                    case 2:
                        Console.Clear();
                        string taskInfo2 = string.Format(taskInfo, 2, "Calculator application", 
                            "Write a console calculator application that performs calculations on 2 numbers.\n" +
                            "It should be able to perform addition, subtraction, multiplication, division.\n" +
                            "It should also allow raising a number to power and calculation square root.\n" +
                            "Additionally, it should display a remainder after divison.");
                        Console.WriteLine(taskInfo2);
                        Console.WriteLine(continueString);
                        if (Console.ReadLine().ToUpper() == "Y")
                            Menu.Calc();
                        break;
                    case 3:
                        Console.Clear();
                        string taskInfo3 = string.Format(taskInfo, 3, "blank",
                            "To be added in the future");
                        Console.WriteLine(taskInfo3);
                        break;
                    case 4:
                        Console.Clear();
                        string taskInfo4 = string.Format(taskInfo, 4, "blank",
                            "To be added in the future");
                        Console.WriteLine(taskInfo4);
                        break;
                    case 5:
                        Console.Clear();
                        string taskInfo5 = string.Format(taskInfo, 5, "blank",
                            "To be added in the future");
                        Console.WriteLine(taskInfo5);
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Press Enter to continue or input Q followed by Enter to exit."); //check whether the user wants to continue
                if (Console.ReadLine().ToUpper() == "Q")
                    endApp = true;                                
            }

            Console.Clear();
            Console.WriteLine("Okay then, bye!");
            return;
        }
    }
}
