package BaiTapTrenLop;

import java.util.LinkedList;
import java.util.List;
import java.util.Queue;
import java.util.Stack;

class Node{
    int info;
    Node next;
    Node() {}
    Node(int x, Node p){
        info=x;
        next=p;
    }
 }
class MyList{
    Node head,tail;
    MyList() {head=tail=null;}
    boolean isEmpty(){
        return(head==null);
    }
    void clear(){
        head=tail=null;
    }
// singlelinkedlink
    // int count() - đếm và trả về số lượng các nút trong danh sách.
    int count(){
        int x = 0;
        if(head != null){
            Node head1 = head;
            x = 1;
            while(head1 != null){
                head1 = head1.next;
                x++;
            }
        }
        return x;  
    }
    //int sum() - trả về tổng tất cả các giá trị trong danh sách.
    int sum(){
        int sum = 0;
        if(head != null){
            Node head1 = head;
            sum = head1.info;
            while(head1 != null){
                head1 = head1.next;
                sum += head1.info;
            }
        }
        return sum;        
    }
    // void insert(int x) - chèn nút với giá trị x vào danh sách đã được sắp xếp 
    // sao cho danh sách mới vẫn được sắp xếp, giả sử danh sách đã được xếp từ bé đến lớn.
    void insert(int x){
        Node a = new Node(x, null);
        // nho hon head
        if(x < head.info){
            a.next = head;
            head = a;
            return;
        }
        // lon hon tail 
        // tim tail 
        Node head1 = head;
        while(head1 != null){
            head1 = head1.next;
        }
        if(x > head1.info){
            head1.next = a;
            return;
        }
        // o giua 
        head1 = head;
        while(head1 != null){
            if(head1.next.info > x){
                break;
            }
            head1 = head1.next;
        }        
        Node b = head1.next;
        head1.next = a;
        a.next = b;
    }
    //int[] toArray() - tạo và trả về mảng chứa thông tin của tất cả các nút trong danh sách.
    int[] toArray(){
        int n =countsll();
        int[] arr = new int[n];
        Node head1 = head;
        arr[0] = head1.info;
        int index = 0;
        while(head1 != null){
            head1 = head1.next;
            arr[++index] = head1.info;
        }
        return arr;
    }
    // Ham tinh so luong node trong danh sach
    int countsll(){
        Node head1 = head;
        int count = 1;
        while(head1 != null){
            head1 = head1.next;
            count++;
        }
        return count;
    }
    // 5 
    int calculatePolynomial(Node p, double value){
        Queue<Integer> qu = new LinkedList<>();
        while(p != null){
            qu.add(p.info);
            p = p.next;
        }
        int sum = 0;
        for(int i = 0 ; i < qu.size() ; i++){
            sum += qu.poll()*Math.pow(value, i);
        }
        return sum;
    }
    void SumTwoList(MyList l1, MyList l2){
        int sum = 0;
        int x1 = calculatePolynomial(l1.head, 10);
        int x2 = calculatePolynomial(l2.head, 10);
        int kq = x1+x2; // 1234
        Stack<Integer> qu = new Stack<>();
        while(kq != 0){
            int x = kq % 10;
            qu.add(x); // 4 3 2 1 
            kq /= 10;
        }
        while(!qu.isEmpty()){
            addHead(qu.pop());
        }
    }
    // Ham them phan tu vao dau list 
    void addHead(int x){
        if(head == null){
            head = new Node(x, null);
        }else{
            Node a = new Node(x, null);
            a.next = head;
            head = a;
        }
    }
}

public class Bai1_07082024 {
    
}
