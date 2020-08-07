using System;

namespace Dequeue
{
    class DequeueA
    {
        static void Main(string[] args)
        {
            int choice, x;
            DequeueA1 dq = new DequeueA1(8);
            while(true)
            {
                Console.WriteLine("1.Insert at the front end");
                Console.WriteLine("2.Insert at the rear end");
                Console.WriteLine("3.Delete from front end");
                Console.WriteLine("4.Delete from rear end");
                Console.WriteLine("5.Display all elements of dequeue");
                Console.WriteLine("6.Quit");
                Console.WriteLine("Enter your choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 6)
                    break;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the element to be inserted at front");
                        x = Convert.ToInt32(Console.ReadLine());
                        dq.InsertFront(x);
                        break;
                    case 2:
                        Console.WriteLine("Enter the element to be inserted at end");
                        x = Convert.ToInt32(Console.ReadLine());
                        dq.InsertRear(x);
                        break;
                    case 3:
                        Console.WriteLine("Element deleted from front end:" + dq.DeleteFront());
                        break;
                    case 4:
                        Console.WriteLine("Element deleted from rear end:" + dq.DeleteRear());
                        break;
                    case 5:
                        dq.Display();
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
            }
        }
    }
}
