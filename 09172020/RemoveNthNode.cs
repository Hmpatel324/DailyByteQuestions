// Definition for singly-linked list.
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
	public ListNode RemoveNthFromEnd(ListNode head, int n)
	{
		ListNode fast = head, slow = null; // Seed Data
		if (head == null) return null; // Null Check
		while (n > 0) // Advance Fast pointer n places
		{
			n -= 1;
			fast = fast.next;
		}
		if (fast == null) return head.next; // advance past linked list check
		slow = head;
		while (fast.next != null) //Advance Slow
		{
			fast = fast.next;
			slow = slow.next;
		}
		slow.next = slow.next.next; // Delete node
		return head;
	}
}