// Danh sachd liên kết đơn với kiểu dữ liệu int 
package dataStructuresandAlgorithms;

// Tạo nút 
class llnode{
    int value;
    llnode next;
    llnode(int a, llnode b){
        value = a;
        next = b;
    }
}
// Lớp chứa các phương thức cơ bản của danh sách liên kết đơn 
class myLinkedLink{
    // Tạo  nút đầu head và cuối tail 
    llnode head, tail;
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
                System.out.println("Head: " + head.value);
            }
            if(tail != null)
            {
                System.out.println("Tail: " + tail.value);
            }            
            //Duyệt và in ra giá trị của tất cả các nút trong linked link 
            llnode head1 = head;
            do
            {
                System.out.print("-> "+head1.value);
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
            head = tail = new llnode(x, null);
            head.next = tail;
            tail.next = null; 
        }
        else
        {
            llnode a = new llnode(x, head);
            head = a;
        }
    }    
    //2. Thêm 1 nút giá trị x vào cuối danh sách 
    void addToTail(int x){
        if(head == null)
        {
            head = tail = new llnode(x, null);
            head.next = tail;
            tail.next = null;
        }
        else
        {
            llnode a = new llnode(x, null);
            tail.next = a;
            tail = a; 
        }
    }
    //3. Thêm 1 nút với giá trị x vào sau nút p.
    void addAfter(llnode p, int x){
        llnode nodex = new llnode(x, null);
        nodex.next = p.next;
        p.next = nodex;
    }
    //4. Duyệt từ đầu đến cuối danh sách và hiển thị thông tin của tất cả các nút -> giống show 
    void traverse(){
        
    }
    //5. Xóa nút đầu và trả về giá trị của nó.
    int deleteFromHead(){
        if(head == null){
            System.out.println("Linked link null. Không thể xóa. ");
        }else if(head.next == null){
            int x = head.value;
            head = tail = null;
            System.out.println("Linked link null.");
            return x;
        }else{
            int x = head.value;
            head = head.next;
            return x;
        }
        return 0;
    }
    //6. Xóa nút cuối và trả về giá trị của nó.
    int deleteFromTail(){
        if(head == null){
            System.out.println("Linked link null. Không thể xóa. ");
        }else if(head.next == null){
            int x = tail.value;
            head = tail = null;
            System.out.println("Linked link null.");
            return x;
        }else{
            int x = tail.value;
            llnode head1 = head;
            while(head1.next != tail){
                head1 = head1.next;
            }
            tail = head1;
            head1.next = null; // Không có dòng này thì vẫn chưa xóa dược vì head1.next(tail mới) = tail(cũ)
            return x;
        }
        return 0;        
    }
    //7. xóa nút sau nút p và trả về giá trị của nó.
    int deleteAter(llnode p){
        if(p == tail){
            // Xoá nút sau tail 
            System.out.println("Không có nút sau tail / Linked link chỉ có 1 nút. Không xóa. ");
        }else{
            llnode nextp = p.next;
            p.next = nextp.next;
            return nextp.value;            
        }
        return 0;
    }
    //8. xóa nút đầu tiên có giá trị bằng x.
    void dele(int x){
        llnode head1 = head;
        while(head1.value != x){
            head1 = head1.next;
        }
        
    }
//    //9. 
//    Node search(int x){
//        
//    }
    //10. 
    //11. 
    //12. 
    //13. 
    //14. 
    //15. 
    //16. 
    //17. 
    //18. 
    //19. 
    //20. 
    //21. 
    //22. 
    //23. 
    //24. 
    //25. 
}

public class linkedLink {
    public static void main(String[] args) {
        myLinkedLink mll = new myLinkedLink();
        mll.addToHead(5);
//        mll.addToHead(4);
//        mll.addToHead(3);
//        mll.addToHead(2);
//        mll.addToHead(1);
        System.out.println("GT vừa xóa : "+mll.deleteAter(mll.head));
        mll.show();
    }
}
