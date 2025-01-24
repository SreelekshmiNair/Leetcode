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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
       //ListNode h1 = l1.Head,h2=l2.Head;
       ListNode res = new ListNode();
       ListNode res1 = res;
       int rem =0;
       while(l1!=null||l2!=null||rem!=0){
        
        int sum = rem;
        if(l1!=null) {sum += l1.val; l1=l1.next;}
        if(l2!=null) {sum += l2.val; l2=l2.next;}
        //Console.WriteLine(sum);
        rem = sum/10;
        res.val += sum%10;
       // Console.WriteLine(res.val);
         
         if(l1!=null||l2!=null||rem!=0){
            res.next = new ListNode();
            res= res.next;
         }
    }
       return res1;
    }
}