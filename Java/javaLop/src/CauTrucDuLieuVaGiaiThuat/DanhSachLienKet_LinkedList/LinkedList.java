/*
Không sử dụng được thư viện java cho linked list 
 */
package CauTrucDuLieuVaGiaiThuat.DanhSachLienKet_LinkedList;
class node{
    int data;
    node next, pre;
    node(int a){
        data = a;
    }
}
// Danh sách liên kết đơn 1 node = data + link tới node tiếp theo 
class singlell{
    node head;
    // Thêm int x vào đầu danh sách liên kết đơn 
    void addhead(int x){
        if(head == null){
            head = new node(x);
        }else{
            node exp = new node(x);
            exp.next = head;
            head = exp;
        }
    }
    // Thêm int x vào cuối danh sách liên kết đơn 
    void addtail(int x){
        if(head == null){
            head = new node(x);
        }else{
            node head1 = head;
            while(head1.next != null){
                head1 = head1.next;
            }
            head1.next = new node(x);
        }
    }
    // Hiển thị danh sách liên kết đơn 
    void show(){
        if(head == null){
            System.out.println("Không có gì đâu bé ơi.");
        }else{
            node headexp = head;
            while(headexp != null){
                System.out.print("-> " + headexp.data);
                headexp = headexp.next;
            }
        }
    }
    // Hàm trả về 1 danh sách liên kết đơn sao cho phần tử thứ i bằng tổng các phần tử từ 0 đến i - 1 
    singlell SLLnew(node p){
        singlell sll = new singlell();
        sll.addhead(p.data);
        int n = 0; 
        while(true){
            node head1 = head;
            n++;
            int sum = 0;
            for(int i = 0 ; i <= n ; i++){
                sum += head1.data;
                head1 = head1.next;
            }
            sll.addtail(sum);
            if(head1 == null){
                break;
            }
        }
        return sll;
    }
}
// Danh sách liên kết đôi 1 node = data + link tới node tiếp theo + link tới node sau đó 
class doublell{
    node head;
    // Thêm int x vào đầu danh sách liên kết đôi 
    void addhead(int x){
        if(head == null){
            head = new node(x);
        }else{
            node exp =  new node(x);
            head.pre = exp;
            exp.next = head;
            head = exp;
        }
    }
    // Hiển thị danh sách liên kết đôi 
    void show(){
        if(head == null){
            System.out.println("Khong co gi dau be oiii.");
        }else{
            node headexp = head;
            while(headexp != null){
                System.out.print("-> " + headexp.data);
                headexp = headexp.next;
            }
        }
    }
}
// Danh sách liên kết vòng 1 node = data + link tới node tiếp theo (node tail.next = head)
class circularll{
    node head, tail;
    // Thêm int x vào đầu danh sách liên kết vòng  
    void addhead(int x){
        if(head == null){
            head = tail = new node(x);
        }else{
            node exp = new node(x);
            tail.next = exp;
            exp.next = head;
            head = exp;
        }
    }
    // Hiển thị danh sách liên kết vòng 
    void show(){
        if(head == null){
            System.out.println("Rong");
        }else{
            node headexp = head;
            do{
                System.out.print("-> " + headexp.data);
                headexp = headexp.next;
            }while(headexp != tail.next);
        }
    }
    // 
}
public class LinkedList {
    public static void main(String[] args) {
        run_singlell();
//        run_doublell();
//        run_circularll();
    }
    static void run_singlell(){
        singlell sll = new singlell();
////        System.out.println("Luc khong co phan tu nao.");
////        sll.show();
//        System.out.println("Them phan tu.");
        sll.addhead(1);
        sll.addhead(2);
        sll.addhead(3);
        System.out.println("ham cu.");
        sll.show();
        singlell sll1 = sll.SLLnew(sll.head);
        System.out.println("");
        System.out.println("ham moi.");
        sll1.show();
    }
    static void run_doublell(){
        doublell dll = new doublell();
        dll.addhead(1);
        dll.addhead(3);
        dll.show();
    }
    static void run_circularll(){
        circularll cll = new circularll();
        cll.addhead(2);
        cll.addhead(3);
        cll.addhead(4);
        cll.show();
    }
}
