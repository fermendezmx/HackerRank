using System.Collections;

namespace HackerRank.Training.DataStructures
{
    #region Problem

    // Detect a cycle in a linked list.
    // Note that the head pointer may be 'null' if the list is empty.

    #endregion

    public static class DetectCycle
    {
        public static bool Solution(Node head)
        {
            if (head == null)
                return false;

            Node fast = head.Next;
            Node slow = head;

            // While 'fast' and 'slow' do not reach the end of the list then:
            while (fast != null && fast.Next != null && slow != null)
            {
                // If 'fast' and 'slow' find each other
                if (fast == slow)
                {
                    // Then we are in a cycle
                    return true;
                }

                // Move two position ahead
                fast = fast.Next.Next;
                // Move one position ahead
                slow = slow.Next;
            }

            // We are not in a cycle
            return false;
        }
    }

    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
    }
}
