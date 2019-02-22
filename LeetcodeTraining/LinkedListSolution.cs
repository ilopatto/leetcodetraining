public static class LinkedListSolution
{
    public class MyLinkedList
    {
        private int Count = 0;
        private Node HEAD;
        private Node TAIL;

        private class Node
        {
            public Node Next;
            public Node Previous;
            public int Val;
        }

        /** Initialize your data structure here. */
        public MyLinkedList()
        {
            Count = 0;
            HEAD = null;
            TAIL = null;
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (index >= Count) return -1;

            if (index == 0)
            {
                return HEAD.Val;
            }
            else if (index == Count - 1)
            {
                return TAIL.Val;
            }
            else
            {
                Node current = HEAD;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }
                return current.Val;
            }
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            Node newNode = new Node { Val = val };

            if (HEAD != null)
            {
                newNode.Next = HEAD;
                HEAD.Previous = newNode;
                HEAD = newNode;
            }
            else
            {
                HEAD = newNode;
                TAIL = newNode;
            }
            Count++;
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            Node newNode = new Node { Val = val };

            if (TAIL != null)
            {
                TAIL.Next = newNode;
                newNode.Previous = TAIL;
                TAIL = newNode;
            }
            else
            {
                HEAD = newNode;
                TAIL = newNode;
            }
            Count++;
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index > Count || index < 0) return;

            Node newNode;

            if (index == Count)
            {
                this.AddAtTail(val);
            }
            else if (index == 0)
            {
                this.AddAtHead(val);
            }
            else
            {
                newNode = new Node { Val = val };

                Node current = HEAD;
                for (int i = 0; i < index; ++i)
                {
                    current = current.Next;
                }
                newNode.Next = current;
                newNode.Previous = current.Previous;
                current.Previous.Next = newNode;
                current.Previous = newNode;
                Count++;
            }
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index >= Count || index < 0) return;

            if (index == Count - 1)
            {
                TAIL.Previous.Next = null;
                TAIL = TAIL.Previous;
            }
            else if (index == 0)
            {
                if (HEAD.Next != null)
                {
                    HEAD.Next.Previous = null;
                    HEAD = HEAD.Next;
                }
                else
                {
                    HEAD = null;
                }
            }
            else
            {
                Node current = HEAD;
                for (int i = 0; i < index; ++i)
                {
                    current = current.Next;
                }

                //if (current.previous != null)
                current.Previous.Next = current.Next;

                //if (current.next != null)
                current.Next.Previous = current.Previous;
            }

            Count--;
        }
    }
}

/*TEST CASES
["MyLinkedList","addAtHead","addAtTail","addAtIndex","get","deleteAtIndex","get"]
[[],[1],[3],[1,2],[1],[1],[1]]
["MyLinkedList","addAtHead","addAtHead","deleteAtIndex","addAtIndex","addAtTail","addAtIndex","addAtTail","addAtHead","addAtHead","addAtHead","addAtTail","addAtTail","addAtHead","addAtTail","addAtTail","addAtHead","addAtTail","deleteAtIndex","addAtTail","addAtTail","get","addAtIndex","addAtHead","get","get","addAtHead","get","addAtIndex","addAtTail","addAtIndex","addAtHead","addAtHead","addAtHead","get","addAtHead","addAtIndex","addAtTail","addAtHead","addAtIndex","get","addAtTail","addAtTail","addAtIndex","addAtIndex","addAtHead","addAtHead","get","addAtTail","addAtIndex","addAtIndex","addAtHead","deleteAtIndex","addAtIndex","addAtHead","deleteAtIndex","addAtTail","deleteAtIndex","addAtTail","addAtHead","addAtTail","addAtTail","addAtHead","addAtTail","addAtIndex","deleteAtIndex","addAtHead","addAtHead","addAtHead","addAtTail","get","addAtIndex","addAtTail","addAtTail","addAtTail","deleteAtIndex","get","addAtHead","get","get","addAtTail","deleteAtIndex","addAtTail","addAtIndex","addAtHead","addAtIndex","addAtTail","get","addAtIndex","addAtIndex","addAtHead","addAtHead","get","get","get","addAtIndex","addAtHead","addAtIndex","addAtHead","addAtTail","addAtIndex","get"]
[[],[38],[45],[2],[1,24],[36],[3,72],[76],[7],[36],[34],[91],[69],[37],[38],[4],[66],[38],[14],[12],[32],[5],[7,5],[74],[7],[13],[11],[8],[10,9],[19],[3,76],[7],[37],[99],[10],[12],[1,20],[29],[42],[21,52],[11],[44],[47],[6,27],[31,85],[59],[57],[4],[99],[13,83],[10,34],[48],[9],[22,64],[69],[33],[5],[18],[87],[42],[1],[35],[31],[67],[36,46],[23],[64],[81],[29],[50],[23],[36,63],[8],[19],[98],[22],[28],[42],[24],[34],[32],[25],[53],[55,76],[38],[23,98],[27],[18],[44,27],[16,8],[70],[15],[9],[27],[59],[40,50],[15],[11,57],[80],[50],[23,37],[12]]
["MyLinkedList","get","addAtIndex","get","get","addAtIndex","get","get"]
[[],[0],[1,2],[0],[1],[0,1],[0],[1]]
["MyLinkedList","addAtHead","addAtHead","deleteAtIndex","addAtIndex","addAtHead","addAtHead","addAtHead","get","addAtTail","addAtIndex","addAtHead"]
[[],[5],[2],[1],[1,9],[4],[9],[8],[3],[1],[3,6],[3]]
*/
