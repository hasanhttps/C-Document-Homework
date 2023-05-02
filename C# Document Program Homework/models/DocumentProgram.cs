using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document.models { 
    public class DocumentProgram {

        // Private Fields

        private string _name;
        private string _description;
        private static int _id;
        private readonly int _size;

        // Properties

        public int Id { get { return _id; } }
        public string Name { get { return _name; } 
            set {
                try {
                    if (value != ".") _name = value;
                    else throw new Exception("Name couldn't be .!");
                }catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
            } 
        }
        public string Description { get { return _description; } set { _description = value; } } 

        // Constructors

        static DocumentProgram() { _id = 0; }
        public DocumentProgram() { }
        public DocumentProgram(string name, string description, int size) { 
            _id = GetCurrentId();
            _size = setSize(size);
            Name = name;
            Description = description;
        }

        // Methods

        private int GetCurrentId() { return ++_id; }
        private int setSize(int value) {
            try {
                if (value >= 0) return value;
                else throw new Exception("Size couldn't be less than 0!");
            }catch(Exception e) {
                Console.WriteLine(e.Message);
                throw new Exception("Size couldn't be less than 0!");
            }
        }

        public void OpenDocument() {
            Console.WriteLine("Document Opened");
        }

        public virtual void EditDocument() {
            Console.WriteLine("Can Edit in Pro and Expert versions");
        }

        public virtual void SaveDocument() {
            Console.WriteLine("Can Edit in Pro and Expert versions");
        }
    }
}
