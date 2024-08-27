package CacKieuDuLieuCanBan;

import java.util.ArrayDeque;
import java.util.Deque;
import java.util.PriorityQueue;
import java.util.Queue;

// Hàng đợi sử dụng linked link 
class myQueue{
    node head, tail;
    // Ham them mot phan tu vao queue
    public void add(Object a){
        if(head == null){
            head = tail = new node(a, null, null);
        }else{
            node x = new node(a, null, tail);
            tail.next = x;
            tail = x;
        }
    }
    // Ham hien thi queue 
    public void show(){
        System.out.print("Queue: ");
        if(head == null){
            System.out.print("null");
        }else{
            node head1 = head;
            while(head1 != null){
                System.out.print(" " + head1.data);
                head1 = head1.next;
            }
        }
    }  
}

public class HangDoiQueue {
    public static void main(String[] args) {
//        queue();
//        deque();
        myQueue qe = new myQueue();
//        qe.add(1);
        qe.add(2);
        qe.show();
    }
    // Hàng đợi su dung goi cua java chỉ thao tác được trên 1 đầu 
    static void queue(){
        // PriorityQueue -> se xap sep lai cac phan tu 
        Queue<String> danhSachSV = new PriorityQueue<String>();
        // Them pha tu 
        danhSachSV.offer("nguyen a");
        danhSachSV.offer("tran e");
        danhSachSV.offer("tran c");
        danhSachSV.offer("tran d");
        danhSachSV.remove();//Xoa phan tu dau quere 
        String a = danhSachSV.poll(); // Gan gia tri dau cho a va xoa phan tu dau khoi quere 
        // outpput a -> c -> d -> e 
        while(true){
            String name = danhSachSV.poll(); // Lay ra va xoa, peek() Lay ra va khong xoa
            if(name == null){
                break;
            }
            System.out.println(name);
        } 
    }
    // Hàng đợi su dung goi cua java thao tác được trên 2 đầu 
    static void deque(){
        Deque<String> danhSachSV = new ArrayDeque<String>();
        // Them pha tu 
        danhSachSV.offer("nguyen a");
        danhSachSV.offer("tran b");
        danhSachSV.offer("tran c");
        danhSachSV.offer("tran d");
        danhSachSV.offerFirst("one");
        danhSachSV.offerLast("two");
        // outpput one -> a -> b -> c -> d -> two    
        while(true){
            String name = danhSachSV.poll();
            if(name == null){
                break;
            }
            System.out.println(name);
        }        
    }
}
