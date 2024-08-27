package baiTap;

// singly linked link node
class sllnode{
    int data;
    sllnode next;
    sllnode(int a, sllnode b){
        data = a;
        next = b;
    }
}

class mySinglyLinkedLink{
    // Chi co head thi sao ? 
    sllnode head, tail;
    // Hàm hiển thị danh sách liên kết đơn linked link 
    void show(){
        if(head == null)
        {
            System.out.println("Linked link null.");
        }
        else
        {
            if(head != null)
            {
                System.out.println("Head: " + head.data);
            }
            if(tail != null)
            {
                System.out.println("Tail: " + tail.data);
            }            
            //Duyệt và in ra giá trị của tất cả các nút trong linked link 
            sllnode head1 = head;
            do
            {
                System.out.print("-> "+head1.data);
                head1 = head1.next;
            }
            while(head1 != null);      
        }
        System.out.println(""); // Xuống dòng 
    }
    
    //1. Thêm 1 nút giá trị x vào đầu danh sách 
    void addToHead(int x){
        if(head == null)
        {
            head = tail = new sllnode(x, null);
            head.next = tail;
            tail.next = null; 
        }
        else
        {
            sllnode a = new sllnode(x, head);
            head = a;
        }
    }    
    // Them phan tu dau va cuoi cua linked link vao danh sach ban dau 
    void add(mySinglyLinkedLink msll){
        addToHead(msll.head.next.data);
        addToHead(msll.head.data);
    }
    // Tong binh phuong cua cac phan tu torng ds
    int square_sum(){
        int y = 0;
        if(head == null){
            System.out.println("Danh sach lien ket null.");
        }else{
            sllnode head1 = head;
            while(head1 != null){
                y += (head1.data)*(head1.data);
                head1 = head1.next;
            }
            return y;
        }
        return 0;
    }
}

public class baiTap3 {
    public static void main(String[] args) {
        mySinglyLinkedLink msll = new mySinglyLinkedLink();
        msll.addToHead(1);
        msll.addToHead(2);
        msll.addToHead(3);
        msll.show();
        System.out.println("Tong binh phuong = "+msll.square_sum());
//        mySinglyLinkedLink msll1 = new mySinglyLinkedLink();
//        msll1.addToHead(-3);
//        msll1.addToHead(-6);
//        msll1.addToHead(-9);  
//        msll1.show();
//        msll.add(msll1);
//        msll.show();
    }
}
