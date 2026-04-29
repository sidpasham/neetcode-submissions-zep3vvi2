/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public void ReorderList(ListNode head) {
        ListNode t = head;
        ListNode h = head;

        while(h != null && h.next != null) {
            t = t.next;
            h = h.next.next;
        }

        ListNode r = Reverse(t.next);
        t.next = null;

        head = Merge(head, r);
    }

    public ListNode Reverse(ListNode node) {
        ListNode curr = node;
        ListNode prev = null;

        while(curr != null) {
            ListNode temp = curr.next;
            curr.next = prev;

            prev = curr;
            curr = temp;
        }

        return prev;
    }

    public ListNode Merge(ListNode n1, ListNode n2) {
        ListNode dummy = new ListNode(0);
        ListNode curr = dummy;
        bool isOn = true;

        while(n1 != null && n2 != null) {

            if(isOn) {
                curr.next = n1;
                isOn = false;
                n1 = n1.next;
            } else {
                curr.next = n2;
                isOn = true;
                n2 = n2.next;
            }
            curr = curr.next;
        }

        if(n1 != null) {
            curr.next = n1;
        } else if (n2 != null) {
            curr.next = n2;
        }
        
        return dummy.next;
    }
}
