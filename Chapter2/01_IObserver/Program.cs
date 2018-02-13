using System;

namespace _01_IObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates a new console input consumer         
            var consumer = new ConsoleTextConsumer();
            while (true)
            {
                Console.WriteLine("Write some text and press ENTER to send a  message\nPress ENTER to exit");
                //read console input             
                var input = Console.ReadLine();
                //check for empty messate to exit             
                if (string.IsNullOrEmpty(input))
                {
                    //job completed                 
                    consumer.OnCompleted();
                    Console.WriteLine("Task completed. Any further message will generate an error");
                }
                else
                {
                    //route the message to the consumer                 
                    consumer.OnNext(input);
                }
            }
        }
    }
}
