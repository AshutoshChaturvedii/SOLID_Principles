using System;

namespace Single_Responsibility_Principle
{
    //Here we have segregated all the classes to  ensure every class is having single responsibility
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public interface ILogger
    {
        void Debug(string info);
    }
    public class Logger :
        ILogger
    {

        public Logger()
        {

        }
        public void Debug(string info)
        {
            throw new NotImplementedException();
        }
    }
    public class MailSender
    {

        public MailSender()
        {

        }
        public string EmailSender { get; set; }
        public void SendEmail()
        {
        }


    }
    public class Invoice
    {
        public long InvAmount { get; set; }
        private ILogger FileLogger;
        private MailSender Emailsender;
        public Invoice()
        {
            FileLogger = new Logger();
            Emailsender = new MailSender();
        }
    }
}
