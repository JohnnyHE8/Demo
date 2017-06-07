using System;

namespace Bear
{
    class Program
    {
        static void Main(string[] args)
        {
            PandaBear pandaBear = new PandaBear();
            //GrizzyBear grizzyBear = new GrizzyBear();
            pandaBear.Display();
            BlackBear blackBear = new BlackBear();
            blackBear.Display();
            //grizzyBear._Bear();
            Console.ReadKey();
        }
    }

    class iDisplay
    {
        public void Display()
        {
            Console.WriteLine(this.GetType() + " is grrrrr!"); 
        }
    }


    class PandaBear : iDisplay
    {
        
    }

    class BlackBear : iDisplay
    { }
}