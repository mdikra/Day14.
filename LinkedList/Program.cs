using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LInkedlist operations \n");
            Console.WriteLine("please select following options \n");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    LinkedListUC<int> LinkedListAdd = new LinkedListUC<int>();
                    LinkedListAdd.add(56);
                    LinkedListAdd.add(30);
                    LinkedListAdd.add(70);
                    LinkedListAdd.display();
                    break;

                case 2:
                    LinkedListUC<int> LinkedListsequence = new LinkedListUC<int>();
                    LinkedListsequence.add(70);
                    LinkedListsequence.display();
                    LinkedListsequence.InsertAtFirst(56);
                    LinkedListsequence.display();
                    break;

                case 3:
                    LinkedListUC<int> LinkedListseq = new LinkedListUC<int>();
                    LinkedListseq.add(56);
                    LinkedListseq.add(30);
                    LinkedListseq.add(70);
                    LinkedListseq.display();
                    break;

                case 4:
                    LinkedListUC<int> LinkedListInsert = new LinkedListUC<int>();
                    LinkedListInsert.add(56);
                    LinkedListInsert.add(70);
                    LinkedListInsert.display();
                    LinkedListInsert.InsertAfter(56, 30);
                    LinkedListInsert.display();
                    break;

            }
        }
    }
}
