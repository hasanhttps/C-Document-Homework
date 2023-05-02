using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document.models {
    public static class Functions {

        public static int Menu(List<string> choose) {
            Console.Clear();
            bool entered = false;
            int index = 0;
            while (true) {
                int y = 14 - choose.Count;
                for (int i = 0; i < choose.Count; i++) {
                    Console.SetCursorPosition(55, y + i);
                    if (index == i) Console.BackgroundColor = ConsoleColor.DarkGray;
                    else Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(choose[i]);
                }
                dynamic ascii = Console.ReadKey();
                if (ascii.Key == ConsoleKey.Escape) break;
                else if (ascii.Key == ConsoleKey.UpArrow) {
                    if (index > 0) index--;
                    else index = choose.Count - 1;
                }
                else if (ascii.Key == ConsoleKey.DownArrow) {
                    if (index < choose.Count - 1) index++;
                    else index = 0;
                }
                else if (ascii.Key == ConsoleKey.Enter) { 
                    entered = true;
                    break;
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            if (entered) return index;
            return -1;
        }

        public static void Enter() {
            Console.Write("Press any key to continue . . .");
            dynamic key = Console.ReadKey();
        }

        public static void setDocument(ref DocumentProgram? document) {
            bool validKey = true;

            while (validKey) {
                Console.SetCursorPosition(45, 13);
                Console.Write("Please enter the product key : ");
                string? productKey = Console.ReadLine();
                validKey = false;

                if (productKey == "basic") { document = new DocumentProgram(); }
                else if (productKey == "pro") { document = new ProDocumentProgram(); }
                else if (productKey == "expert") { document = new ExpertDocument(); }
                else {
                    validKey = true;
                    Console.WriteLine("Please enter the valid key!");
                    Enter();
                }
            }
        }
    }
}
