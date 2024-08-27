/*

 */
package CauTrucDuLieuVaGiaiThuat.NganXep_Stack;

import java.util.Stack;

public class stack {
    public static void main(String[] args) {
        Stack<Integer> s = new Stack<>();
        s.push(3);
        s.push(2);
        s.push(1); // stack 3->2->1 (đáy -> đỉnh)
        s.peek(); // stack 3->2->1 (đáy -> đỉnh)
        s.pop(); // stack 3->2 (đáy -> đỉnh)
        for(int x : s){
            System.out.print("->" + x);
        }
    }
}
