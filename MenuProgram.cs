
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoShape
{
    public abstract class MenuProgram
    {
        protected const int QUIT = 0;
        public void Run()
        {  
            bool running = true;
            while(running)
            {
                PrintMenu();
                int choice = GetChoice();
                DoTask(choice);
                if(choice == QUIT) running = false;
            }
        }
        protected abstract void PrintMenu();
        protected abstract void DoTask(int choice);

        protected virtual int GetChoice()
        {
            Console.WriteLine("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
        protected virtual void ShowError()
        {
            Console.WriteLine("Invalid choice! Choose again");
        }

    }
}