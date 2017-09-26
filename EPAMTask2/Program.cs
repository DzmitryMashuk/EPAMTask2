using System;
using System.Linq;

namespace EPAMTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            var activator = new ListActivator();
            var linkedList = (LinkedList)activator.Run();

            ListItem item1 = new ListItem(1);
            ListItem item2 = new ListItem(2);
            ListItem item3 = new ListItem(3);
            ListItem item4 = new ListItem(4);
            ListItem item5 = new ListItem(5);

            // Метода AddFirst в действии
            linkedList.AddFirst(item1);
            linkedList.AddFirst(item2);

            // Метода AddLast в действии
            linkedList.AddLast(item3);
            linkedList.AddLast(item4);

            // Метода Insert в действии
            linkedList.Insert(item5, 6);

            // Метода Reverse в действии
            var firstElement = linkedList.GetFirst();
            Console.WriteLine(firstElement.Value);

            // Метода Reverse в действии
            linkedList.Reverse();

            // Метода IsEmpty в действии
            Console.WriteLine(linkedList.IsEmpty());

            // Метода GetAll в действии
            var allItems = linkedList.GetAll().ToList();

            // Метода Clear в действии
            linkedList.Clear();
            Console.WriteLine(linkedList.IsEmpty());

            Console.ReadKey();
        }
    }

    class ListActivator : IRunnable
    {
        public object Run()
        {
            return new LinkedList();
        }
    }
}
