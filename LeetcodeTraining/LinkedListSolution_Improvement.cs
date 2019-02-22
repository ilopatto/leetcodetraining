using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeTraining
{
    // NOT IMPROVED
    // APPROVED THE OLD VERSION

    public class MyLinkedList
    {
        private int Count = 0;
        private Node HEAD;
        private Node TAIL;
        private int lastIndex;
        private Node lastNode;

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

            if (lastIndex == index) return lastNode.Val;

            if(index == 0)
            {
                return HEAD.Val;
            }
            else if (index == Count - 1)
            {
                return TAIL.Val;
            }
            else
            {
                Node current = lastNode;

                if (lastIndex < index)
                {
                    for (int i = lastIndex; i < index; i++)
                    {
                        current = current.Next;
                    }
                    lastNode = current;
                    lastIndex = index;
                }
                else if (lastIndex > index)
                {
                    for (int i = lastIndex; i > index; i--)
                    {
                        current = current.Previous;
                    }
                    lastNode = current;
                    lastIndex = index;
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

                lastNode = HEAD;
            }
            //It because our collection is up one element
            lastIndex++;
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
                Node current = lastNode;
                if (lastIndex < index)
                {
                    for (int i = lastIndex; i < index; ++i)
                    {
                        current = current.Next;
                    }
                }
                else
                {
                    for (int i = lastIndex; i > index; --i)
                    {
                        current = current.Previous;
                    }
                }
                newNode.Next = current;
                newNode.Previous = current.Previous;
                current.Previous.Next = newNode;
                current.Previous = newNode;

                lastIndex = index;
                lastNode = newNode;

                Count++;
            }

            
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index >= Count || index < 0) return;

            if (index == Count - 1)
            {
                TAIL = TAIL.Previous;
                TAIL.Next = null;

                if (index == lastIndex)
                {
                    lastNode = TAIL;
                    //lastIndex = index;
                    //return;
                }

                lastIndex--;
            }
            else if (index == 0)
            {
                if (HEAD.Next != null)
                {
                    HEAD = HEAD.Next;
                    HEAD.Previous = null;
                }
                else
                {
                    HEAD = null;
                }

                if (index == lastIndex)
                {
                    lastNode = HEAD;
                    //lastIndex = index;
                    Count--;
                    return;
                }

                lastIndex--;

            }
            else
            {
                Node current = lastNode;

                if (index > lastIndex)
                {
                    for (int i = lastIndex; i < index; ++i)
                    {
                        current = current.Next;
                    }
                } else
                {
                    for (int i = lastIndex; i > index; --i)
                    {
                        current = current.Previous;
                    }
                }

                //if (current.previous != null)
                    current.Previous.Next = current.Next;

                //if (current.next != null)
                    current.Next.Previous = current.Previous;

                lastIndex = index;
                lastNode = current.Next;
            }

            Count--;
        }
    }
}
