

namespace ToDo
{
    public class ToDoList
    {
        private readonly List<string> tasks = new List<string>();

        public void Start()
        {
            MenuOption selectedOption;
            do
            {
                selectedOption = ShowMainMenu();
                switch (selectedOption)
                {
                    case MenuOption.Add:
                        AddTask();
                        break;
                    case MenuOption.Remove:
                        RemoveTask();
                        break;
                    case MenuOption.List:
                        ListTasks();
                        break;
                    case MenuOption.Exit:
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please select a valid option.");
                        break;
                }
            } while (selectedOption != MenuOption.Exit);
        }

        private MenuOption ShowMainMenu()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter your choice:");
            Console.WriteLine("1. Add new task");
            Console.WriteLine("2. Remove task");
            Console.WriteLine("3. List pending tasks");
            Console.WriteLine("4. Exit");

            int input = GetValidIntInput();
            return (MenuOption)input;
        }

        private void AddTask()
        {
            Console.WriteLine("Enter the new task name:");
            string taskName = Console.ReadLine().Trim();

            if (!string.IsNullOrEmpty(taskName))
            {
                tasks.Add(taskName);
                Console.WriteLine("Task added successfully.");
            }
            else
            {
                Console.WriteLine("Please enter a valid task name.");
            }
        }

        private void RemoveTask()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks to remove.");
                return;
            }

            Console.WriteLine("Enter the number of the task to remove:");
            ListTasks();

            int input = GetValidIntInput();
            int indexToRemove = input - 1;

            if (indexToRemove >= 0 && indexToRemove < tasks.Count)
            {
                string removedTask = tasks[indexToRemove];
                tasks.RemoveAt(indexToRemove);
                Console.WriteLine($"Task '{removedTask}' removed successfully.");
            }
            else
            {
                Console.WriteLine("Invalid task number. Please try again.");
            }
        }

        private void ListTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks to list.");
                return;
            }

            Console.WriteLine("----------------------------------------");
            int index = 1;
            foreach (string task in tasks)
            {
                Console.WriteLine($"{index++}. {task}");
            }
            Console.WriteLine("----------------------------------------");
        }

        private int GetValidIntInput()
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            return input;
        }

        public enum MenuOption
        {
            Add = 1,
            Remove = 2,
            List = 3,
            Exit = 4
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new ToDoList().Start();
        }
    }
}
