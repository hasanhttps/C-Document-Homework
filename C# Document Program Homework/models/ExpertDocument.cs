using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document.models {
    class ExpertDocument : ProDocumentProgram { 

        // Methods

        public override sealed void SaveDocument() {
            Console.WriteLine("Document Saved in pdf format");
        }
    }
}
