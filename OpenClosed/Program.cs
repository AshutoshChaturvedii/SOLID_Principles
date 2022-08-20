using System;

namespace OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice Finvoice = new FinalInvoice();
            Invoice Pinvoice = new PraposedInvoice();
            Invoice Rinvoice = new RecurringInvoice();
            double FInvoiceamnt = Finvoice.GetInvoicediscounting(1000);
            double PInvoiceamnt = Pinvoice.GetInvoicediscounting(1000);
            double RInvoiceamnt = Rinvoice.GetInvoicediscounting(1000);
            Console.WriteLine($"Final Invoice:{FInvoiceamnt}");
            Console.WriteLine($"Praposed Invoice:{PInvoiceamnt}");
            Console.WriteLine($"Recurring Invoice:{RInvoiceamnt}");
            Console.WriteLine("Hello World!");
            ///As you can see in the above code, 
            ///we have created three classes FinalInvoice, 
            ///ProposedInvoice, and RecurringInvoice.
            ///All these three classes are inherited from the base class Invoice and if they want then
            ///they can override the GetInvoiceDiscount() method. 
            ///Tomorrow if another Invoice Type needs to be added then we just need to create a new 
            ///class by inheriting it from the Invoice class. The point that you need to keep the focus 
            ///on is we are not changing the code of the Invoice class.
            ///Now, the Invoice class is closed for modification. But it is open for the extension a
            ///as it allows creating new classes deriving from the Invoice class which clearly follows the Open-Closed Principle in C#. 
        }
    }
    public class Invoice
    {

        public virtual double GetInvoicediscounting(double amount)
        {
            return amount - 10;
        }
    }

    public class FinalInvoice : Invoice
    {
        public override double GetInvoicediscounting(double amount)
        {
            return base.GetInvoicediscounting(amount)-50;
        }
    }

    public class PraposedInvoice:Invoice
    {
        public override double GetInvoicediscounting(double amount)
        {
            return base.GetInvoicediscounting(amount)-40;
        }
    }
    public class RecurringInvoice:Invoice
    {
        public override double GetInvoicediscounting(double amount)
        {
            return base.GetInvoicediscounting(amount)-30;  
        }
    }
}
