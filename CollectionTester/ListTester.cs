using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CollectionTester
{
    class ListTester
    {
        private List<int> numberList; // A list of integers

        public ListTester()
        {
            //When we create a List object, we do not need to specify any size:
            numberList = new List<int>();
            for (int number = 0; number < 10; number++)
            {
                numberList.Add(number * number);
            }
            printList();
            Console.WriteLine("Removes the element 0");
            numberList.Remove(0);// removes the element with value 0
            printList();
            Console.WriteLine("Removes the element at position 4");
            numberList.RemoveAt(4); // removes the element at possition 4
            printList();
            // iterating using a for loop
            Console.WriteLine("Print out the elements using a for loop");
            for (int i = 0; i < numberList.Count; i++)
            {
                int number = numberList[i];
                Console.WriteLine(number);
            }

        }

        public void printList()
        {
            foreach (int value in numberList)
            {
                Console.WriteLine(value);
            }
        }
    }
}
