// Danh sách liên kết đơn với kiểu dữ liệu int 
package abstractDataType;

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
    //2. Thêm 1 nút giá trị x vào cuối danh sách 
    void addToTail(int x){
        if(head == null)
        {
            head = tail = new sllnode(x, null);
            head.next = tail;
            tail.next = null;
        }
        else
        {
            sllnode a = new sllnode(x, null);
            tail.next = a;
            tail = a; 
        }
    }
    //3. Thêm 1 nút với giá trị x vào sau nút p.
    void addAfter(sllnode p, int x){
        sllnode nodex = new sllnode(x, null);
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
            int x = head.data;
            head = tail = null;
            System.out.println("Linked link null.");
            return x;
        }else{
            int x = head.data;
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
            int x = tail.data;
            head = tail = null;
            System.out.println("Linked link null.");
            return x;
        }else{
            int x = tail.data;
            sllnode head1 = head;
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
    int deleteAter(sllnode p){
        if(p == tail){
            // Xoá nút sau tail 
            System.out.println("Không có nút sau tail / Linked link chỉ có 1 nút. Không xóa. ");
        }else{
            sllnode nextp = p.next;
            p.next = nextp.next;
            return nextp.data;            
        }
        return 0;
    }
    //8. xóa nút đầu tiên có giá trị bằng x.
    void dele(int x){
        sllnode head1 = head;
        while(head1.data != x){
            head1 = head1.next;
        }
        
    }
    //9. tìm kiếm và trả về tham chiếu đến nút đầu tiên có giá trị x 
    sllnode search(int x){
        sllnode head1 = head;
        while(head1.data != x){
            head1 = head1.next;
        }
        return head1;
    }
    //10. Dem và trả về số lượng nút trong danh sách.
    int count(){
        int count = 0 ;
        sllnode head1 = head;
        while(head1.next != null){
            head1 = head1.next;
            count++;
        }
        return count + 1;
    }
    //11. xóa một nút thứ i (1-n) trong danh sách. Đảm bảo rằng nút như vậy tồn tại.
    void delete(int index){
        int max = count();
        sllnode head1 = head;
        if(index > max || index <= 0)
        {
            System.out.println("Khong ton tai.");
        }
        else if (index == 1)
        {
            System.out.println("Xoa phan tu co index = 1 (xoa head) co gia tri " + head.data);
            head = head.next;
        }
        else if (index == max)
        {
            System.out.println("Xoa phan tu co index = " + max + " (xoa tail) co gia tri " + tail.data);
            while(head1.next != tail)
            {
                head1 = head1.next;
            }
            head1.next = null;
            tail = head1;
        }
        else
        {
            // Tim node co index = index - 1
            for(int i = 1; i <= index - 2; i++){
                head1 = head1.next;
            }
            System.out.print("Xoa phan tu co index = " + index + " co gia tri " + head1.next.data);
            head1.next = head1.next.next;
        }
    }
    //12. sắp xếp danh sách theo thứ tự tăng dần của giá trị.
    void sort(){
        sllnode head1 = head;
        sllnode head2 = head1.next;
        while(head1.next != null){
            while(head2 != null){
                if(head1.data > head2.data){
                    int x = head1.data;
                    head1.data = head2.data;
                    head2.data = x;
                }
                head2 = head2.next;
            }
            head1 = head1.next;
            head2 = head1.next;
        }
        System.out.println(" -> Singly linked link sau khi xap sep.");
    }
    //13. xóa nút p nếu nó tồn tại trong danh sách.
    void delete(sllnode p){
        if(p == head)
        {
            deleteFromHead();
        }
        else if(p == tail)
        {
            deleteFromTail();
        }
        else
        {
            // Tim nut ngay truoc nut p 
            sllnode head1 = head;
            while(head1.next != p)
            {
                head1 = head1.next;
            }
            head1.next = head1.next.next;
        }
        System.out.println("-> Singly linked link sau khi xoa nut p co gia tri " + p.data);
    }
    //14. Tạo và trả về một mảng chứa thông tin của tất cả các nút trong danh sách.
    // Khi dùng int x : arr thì arr full 0 ? 
    int[] toArray(){
        int n = count();
        int[] arr = new int[n];
        sllnode head1 = head;
        for(int i = 0; i < n ; i++){
            arr[i] = head1.data;
            head1 = head1.next;
        }
        return arr;
    }
    //15. Hợp nhất hai danh sách liên kết đơn đã sắp xếp thành một danh sách đã sắp xếp.
    mySinglyLinkedLink twoToOne(mySinglyLinkedLink sll1, mySinglyLinkedLink sll2){
        sllnode head1 = sll1.head;
        sllnode head2 = sll2.head;
        mySinglyLinkedLink sll = new mySinglyLinkedLink();
        while(true){
            if(head1 == null && head2 == null)
            {
                break;
            }
            else if(head2 == null)
            {
                sll.addToHead(head1.data);
                head1 = head1.next;                
            }
            else if(head1 == null)
            {
                sll.addToHead(head2.data);
                head2 = head2.next; 
            }
            else if(head1.data <= head2.data)
            {
                sll.addToHead(head1.data);
                head1 = head1.next;
            }
            else if(head1.data > head2.data)
            {
                sll.addToHead(head2.data);
                head2 = head2.next;                
            }
        }
        return sll;
    }
    //16. Thêm một nút với giá trị x vào trước nút p.
    void addBefore(sllnode p, int x){
        // Tìm node trước node p 
        sllnode head1 = head;
        if(head1 == p)
        {
            addToHead(x);
        }
        else
        {
            // Tìm node trước node p 
            while(head1.next != p )
            {
                head1 = head1.next;
            }
            head1.next = new sllnode(x, p);
        }
    }
    //17. Kết nối một danh sách liên kết đơn vào cuối của danh sách liên kết đơn khác.
    void twoToOneNoSort(mySinglyLinkedLink sll1){
        tail.next = sll1.head;
    }
    //18. tìm và trả về giá trị lớn nhất trong danh sách.
    int max(){
        sllnode head1 = head;
        sllnode max = head;
        while(head1 != null)
        {
            if(max.data < head1.data)
            {
                max = head1;
            }
            head1 = head1.next;
        }
        return max.data;
    }
    //19. tìm và trả về giá trị nhỏ nhất trong danh sách.
    int min(){
        sllnode head1 = head;
        int min = head.data;
        while(head1 != null)
        {
            if(min > head1.data)
            {
                min = head1.data;
            }
            head1 = head1.next;
        }
        return min;        
    }
    //20. trả về tổng của tất cả các giá trị trong danh sách.
    int sum(){
        sllnode head1 = head;
        int sum = 0;
        while(head1 != null)
        {
            sum += head1.data; 
            head1 = head1.next;
        }
        return sum;        
    }    
    //21. int avg() - trả về giá trị trung bình của tất cả các giá trị trong danh sách.
    int avg(){
        sllnode a=head;
        int x=0;
        int y=1;
        while(a.next!=null){
            x+=a.data;
            a=a.next;
            y++;
        }
        return x/y;      
    }
    //22.kiểm tra và trả về true nếu danh sách đã được sắp xếp, trả về false nếu danh sách chưa được sắp xếp.
    //22.a kiểm tra và trả về true nếu danh sách đã được sắp xếp tăng dần , trả về false nếu danh sách chưa được sắp xếp. 
    boolean sorted(){
        sllnode head1 = head;
        while(head1.next != null)
        {
            if(head1.data > head1.next.data)
            {
                return false;
            }
        }
        return true;
    }
    //23. chèn một nút có giá trị x vào danh sách đã sắp xếp để danh sách mới vẫn được sắp xếp.
    //23.a chèn một nút có giá trị x vào danh sách đã sắp xếp tăng dần để danh sách mới vẫn được sắp xếp tăng dần.
    void insert(int x){
        if(x <= head.data)
        {
            addToHead(x);
        }
        else if(x >= tail.data)
        {
            addToTail(x);
        }
        else
        {
            sllnode head1 = head;
            while(head1 != null)
            {
                if(head1.data <= x && x <= head1.next.data)
                {
                    sllnode y = new sllnode(x, head1.next);
                    head1.next = y;
                    break;
                }
                head1 = head1.next;
            }
        }
    }
    //24. Đảo ngược một danh sách liên kết đơn chỉ trong một lần duyệt qua danh sách.
    void daoNguoc(){
        mySinglyLinkedLink y = new mySinglyLinkedLink();
        sllnode head1 = head;
        sllnode head2 = head1.next;
        sllnode luuTru = null;
        while(head2 != null)
        {
            head1.next = luuTru; 
            head2.next = head1;
            
            luuTru = head1.next.next;
            head1 = head2;
            head2 = luuTru;
        }
    }
    //25. Kiểm tra xem hai danh sách liên kết đơn có cùng nội dung hay không.
    //25.a Kiểm tra xem hai danh sách liên kết đơn có cùng nội dung cùng thứ tự hay không.
    boolean checkContent(mySinglyLinkedLink sll1, mySinglyLinkedLink sll2){
        sllnode head1 = sll1.head;
        sllnode head2 = sll2.head;
        //Sắp xếp theo thứ tự tăng dần để check cho đỡ đau đầu 
        sll1.sort();
        sll2.sort();
        // Cùng độ dài 
        int length_sll1 = sll1.count();
        int length_sll2 = sll2.count();
        if(length_sll1 == length_sll2)
        {
            while(head1 != null)
            {
                if ( head1.data != head2.data)
                {
                    System.out.println( head1.data +" khác "+ head2.data);
                    return false;
                }
                head1 = head1.next;
                head2 = head2.next;
            }
        }
        //Khác độ dài 
        else
        {
            System.out.println("2 singly linked link khác length .");
        }
        return true;
    }
    //25.a Kiểm tra xem hai danh sách liên kết đơn có cùng nội dung hay không.
}

public class singlyLinkedLink {
    public static void main(String[] args) {
        mySinglyLinkedLink sll = new mySinglyLinkedLink();
        sll.addToHead(1);
        sll.addToHead(3);
        sll.addToHead(5);
        sll.addToHead(7);
        sll.addToTail(9);
        sll.addToHead(11);
        sll.addToHead(13);
        sll.show();
    }
}
