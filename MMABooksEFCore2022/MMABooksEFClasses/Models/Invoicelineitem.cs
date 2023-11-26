﻿/* Author:  Lindy Stewart
 * Editor:  Eric Robinson L00709820
 * Date:    11/25/23
 * Course:  Lane Community College CS234 Advanced Programming: C# (.NET)
 * Lab:     6 
 * Purpose: 
 */

using System;
using System.Collections.Generic;

namespace MMABooksEFClasses.Models
{
    // Constructor
    public partial class Invoicelineitem
    {
        // Properties
        public int InvoiceId { get; set; }
        public string ProductCode { get; set; } = null!;
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal ItemTotal { get; set; }

        public virtual Invoice Invoice { get; set; } = null!;
        public virtual Product ProductCodeNavigation { get; set; } = null!;

        public override string ToString()
        {
            return InvoiceId + ", " + ProductCode + ", " + UnitPrice + ", " + Quantity + ", " + ItemTotal;
        }

    } // end class Invoicelineitem
} // namespace MMABooksEFClasses.Models
