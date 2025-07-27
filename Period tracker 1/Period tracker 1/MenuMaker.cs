using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Period_tracker_1
{
    internal abstract class MenuMaker
    {
        private string title { get; set; }
        private List<string> options { get; set; }

        public MenuMaker(string title, List<string> options)
        {
            this.title = title;
            this.options = options;
        }
        public void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine(title);
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {options[i]}");
            }
            Console.WriteLine($"{options.Count + 1}. Exit");
        }

        public abstract void ChoiceAction(int choice);
    }
}
