using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Products
{
    class Storage
    {
        public List<string> StorageRepresentation { get; set; }

        public Storage(List<string> transactions)
        {
            StorageRepresentation = transactions;
        }
        public void AddTransaction(string toBeAdded)
        {
            // check-up of transaction validity
            StorageRepresentation.Add(toBeAdded);
        }

    }
}
