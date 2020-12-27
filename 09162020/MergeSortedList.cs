// Definition for singly-linked list.
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        // Null Check
        if(l1 == null && l2 == null) return null;
        else if(l1 == null) return l2;
        else if(l2 == null) return l1;

        // Seed data - Linked List head to return and placeholder for head of new
        var res = (l1.val < l2.val) ? l1 : l2;
        ListNode curr = new ListNode(-1);
        while (l1 != null && l2 != null)
        {
            if (l1.val < l2.val) // Add L1 and move to next
            {
                curr.next = l1;
                l1 = l1.next;
            }
            else  // Add L2 and move to next
            {
                curr.next = l2;
                l2 = l2.next;
            }
            curr = curr.next;

        }
        curr.next = l1 ?? l2; // Attach remainder tail
        return res;
    }
}