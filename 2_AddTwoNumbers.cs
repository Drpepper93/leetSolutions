public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var keep = true;
        ListNode l3 = new ListNode((l1.val + l2.val) % 10);
        var p = l1.val + l2.val > 9 ? 1 : 0;
        ListNode l33 = l3;

        while(true){
            l1 = l1 != null ? l1.next : null;
            l2 = l2 != null ? l2.next : null;
            if(l1 == null && l2 == null){
                if(p == 1){
                    l33.next = new ListNode(1);
                }
                break;
            }

            l33.next = new ListNode(((l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + p) % 10);
            l33 = l33.next;
            p = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + p > 9 ? 1 : 0;
        }
        return l3;
    }
}
