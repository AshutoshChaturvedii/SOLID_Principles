using System;

namespace Interface_Segrigation_Principle
{
    class Program
    {

       public interface IPrinterTasks
        {
            void Print(string printContent);
            void Scan(string scancontent);

        }

        interface IFax
        {
            void Fax(string faxContent);
            void printDuplex(string printduplexContent);
        }

        public class HpLaserJetPrinter : IPrinterTasks,IFax
        {
            public void Fax(string faxContent)
            {
                throw new NotImplementedException();
            }

            public void Print(string printContent)
            {
                throw new NotImplementedException();
            }

            public void printDuplex(string printduplexContent)
            {
                throw new NotImplementedException();
            }

            public void Scan(string scancontent)
            {
                throw new NotImplementedException();
            }
        }

        class LiquidinkJetPrinter : IFax
        {
           
            public void printDuplex(string printduplexContent)
            {
                throw new NotImplementedException();
            }
            public void Fax(string faxContent)
            {
                throw new NotImplementedException();
            }

        }

        /// <summary>
        /// In above code we have segregated interface in two categories Ifax and Print which is as per "Interface segregation Principle"
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

           
            
            Console.WriteLine("Hello World!");
        }
    }
}
