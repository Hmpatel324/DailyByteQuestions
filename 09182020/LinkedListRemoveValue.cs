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
    public ListNode RemoveElements(ListNode head, int val) {
        if (head == null) return null; // Null Check
        while(head!=null && head.val == val){ // Move Forward Head bc Val at front of LL
            head = head.next;
        }
        if(head==null || head.next == null) return head; // New Head Null or single link check
        ListNode slow = head, fast = head.next;
        while (fast != null) // Use fast and slow pointer to traverse. Fast hits Val then set next to fast next
        {
            if (fast.val == val)
            {
                slow.next = fast.next;
                fast = fast.next;
            }
            else{
                fast = fast.next;
                slow = slow.next;
            }
        }
        return head;
    }
}