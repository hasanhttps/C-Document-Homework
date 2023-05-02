using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document.models {
    class ProDocumentProgram : DocumentProgram {

        // Methods

        public override sealed void EditDocument() {
            Console.WriteLine("Document Edited");
        }

        public override void SaveDocument() {
            Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
        }
    }
}
