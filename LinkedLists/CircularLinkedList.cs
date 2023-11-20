namespace LinkedLists
{
    public class CircularLinkedList
    {
        public Node? Start = null;

        public void Insert()
        {
            Console.Write("Enter value of data for new node:");
            int data;
            if (int.TryParse(Console.ReadLine(), out data) == false)
            {
                Console.WriteLine("Please enter a valid integer no.");
            }

            Node? tmp = Start;
            //Node? prev = null;
            Node? newNode = new Node(data);

            //TODO - pending implementation
            int refData = -1; bool? before = null;
            do
            {
                //Insert 1st node - at start 
                if (Start == null)
                {
                    Start = newNode;
                    newNode.next = Start;
                    break;
                }
                //else if (tmp?.next == null)
                //{
                //    tmp.next = newNode;
                //    break;
                //}
                //else if (tmp.data == refData) //TODO
                //{
                //    if (before == true)
                //    {
                //        newNode.next = tmp;
                //        prev.next = newNode;
                //    }
                //    else if (before == false)
                //    {
                //        newNode.next = tmp?.next;
                //        tmp.next = newNode;
                //    }
                //    break;
                //}
                else //insert at end
                {
                    //prev = tmp;
                    tmp = tmp?.next;
                }
            } while (tmp != null);
        }
    }
}
