package thuatToan;

class Node{
    int info;
    Node next;
    Node(int x, Node p){
        info=x;
        next=p;
    }
}

class linkedLink{
    //head đầu tail cuối 
    Node head,tail;
    Node head(){
        return head;
    }
    Node tail(){
        return tail;
    }
    
    linkedLink(){
        head=tail=null;
    }
    boolean check(){
        return(head==null);
    }
    void clear(){
        head=tail=null;
    }
    void show() {
        Node current = head;
        while (current != null) {
            System.out.print(current.info + "->");
            current = current.next;
        }
        System.out.println();
    }
    //thêm một nút với giá trị x vào đầu danh sách liên kết đơn     
    void addToHead(int x){
        if(head==null){
            head=new Node(x, tail);  
            tail=new Node(x,null);
        }else{
            head=new Node(x, head);
        }
    }
    //thêm một nút với giá trị x vào cuói danh sách
    void addToTail(int x) {
        Node new_node=new Node(x,null);
        if(check()){
            head=new_node;
            tail=new_node;
        }else{
            tail.next=new_node;
            //Gtri cuối 
            tail=new_node;             
        }
    }
    //thêm một nút với giá trị x vào sau nút p
    void addAfter(Node p, int x){
        p.next=new Node(x,p.next);
    }
    //duyệt từ đầu đến cuối danh sách và hiển thị thông tin của tất cả các nút
    void traverse(linkedLink l){
        Node a=l.head;
        int i=1;
        if(check()){
            System.out.println("Danh sách liên kết null.");
            System.out.println("in1");
        }else{
            while(a.next!=null){
                System.out.println("Nút thứ "+i+" có info = "+a.info);
                i++;
                a=a.next;
            }            
        }
    }
    //xóa nút đầu và trả về giá trị của nó.
    int deleteFromHead(){
        if(check()){
            System.out.println("Danh sách liên kết là null.");
            return 0;
        }else{
            Node a=head;
            Node b=head.next;
            head=b;
            return a.info;            
        }
    }
    // xóa nút cuối và trả về giá trị của nó
    int deleteFromTail(){
        if(check()){
            System.out.println("Danh sách liên kết là null.");
            return 0;
        }else{
            Node a=tail;
            Node b=head;
            while(b.next!=tail){
                b=b.next;
            }
            tail=b;
            b.next=null;  
            return a.info;
        }        
    }
    //xóa nút sau nút p và trả về giá trị của nó
    int deleteAter(Node p){
        if(check() || head==tail){
            System.out.println("Danh sách liên kết gần đạt null. ");            
        }else{
            Node a=p.next;
            p.next=a.next;
            return a.info;            
        }
        return 0;
    }
    //xóa nút đầu tiên có giá trị bằng x
    void dele(int x){
        if(x==head.info){
            deleteFromHead();
        }else{
            Node a=head;
            while(a.info!=x){
                a=a.next;
            }
            //Tìm phần tử trước của x (a)
            Node b=head;
            while(b.next!=a){
                b=b.next;
            }
            b.next=a.next;            
        }
    }
    //tìm kiếm và trả về tham chiếu đến nút đầu tiên có giá trị x
    Node search(int x){
        if(x==head.info){
            System.out.println("Nút đầu tiên giá trị = "+x+" có thứ tự trong danh sách là : 0");
            return head;
        }else{
            Node a=head;
            int i=0;
            while(a.info!=x){
                a=a.next;
                i++;
            }
            System.out.println("Nút đầu tiên giá trị = "+x+" có thứ tự trong danh sách là : "+i);
            return a;           
        }        
    }
    //đếm và trả về số lượng nút trong danh sách
    int count(){
        int i=1;
        Node a=head;
        while(a.next!=null){
            a=a.next;
            i++;
        }
        return i;
    }
    //xóa một nút thứ i (VT i-1) trong danh sách. Đảm bảo rằng nút như vậy tồn tại.
    void delete(int i){
        if(i==1){
            deleteFromHead();
        }else{
            Node a=head;
            //Tìm nút thứ i-1
            for(int m=1;m<i-1;m++){
                a=a.next;
            }
            a.next=a.next.next;            
        }
    }
    // sắp xếp danh sách theo thứ tự tăng dần của giá trị.
    void sort(){
         if (head == null || head.next == null) {
            return; // Danh sách trống hoặc chỉ có một phần tử, không cần sắp xếp
        }

        boolean swapped;
        do {
            Node current = head;
            Node prev = null;
            Node next = head.next;
            swapped = false;

            while (next != null) {
                if (current.info > next.info) {
                    // Hoán đổi giá trị của hai nút
                    int temp = current.info;
                    current.info = next.info;
                    next.info = temp;
                    swapped = true;
                }
                prev = current;
                current = next;
                next = next.next;
            }
        } while (swapped);
        
    }
    //xóa nút p nếu nó tồn tại trong danh sách
    void delete(Node p){
        Node a=head;
        int x=0;
        while(a.next!=null){
            if(p==a.next){
                a.next=p.next;
                x=1;
            }
            a=a.next;
        }
        if(x==0){
            System.out.println("Không tồn tại nút "+p+" trong danh sách.");
        }
    }
    //tạo và trả về một mảng chứa thông tin của tất cả các nút trong danh sách
    int [] toArray(linkedLink l){
        //Tính số lượng phần tử của mảng 
        Node a=head;
        int n=1;
        while(a.next!=null){
            a=a.next;
            n++;
        }
        a=head;
        int[] array = new int[n];
        for(int i=0;i<n;i++){
            array[i]=a.info;
            a=a.next;
        }
        return array;
    }
    //15. Hợp nhất hai danh sách liên kết đơn đã sắp xếp thành một danh sách đã sắp xếp
    void hopNhat(linkedLink l1, linkedLink l2){
        if(l1.tail.info<l2.head.info){
            l1.tail.next=l2.head;
        }else if(l2.tail.info<l1.head.info){
            l2.tail.next=l1.head;
        }else{
            int[] arr1=toArray(l1);
            int[] arr2=toArray(l2);
            int[] arr3= new int[arr1.length+arr2.length];
            for(int i=0;i<arr1.length;i++){
                if(i<arr1.length){
                    arr3[i]=arr1[i];
                }else{
                    arr3[i]=arr2[i-arr1.length];
                }
            }
            
        }
    }   
    //16. void addBefore(Node p, int x) - thêm một nút với giá trị x vào trước nút p.
    void addBefore(Node p, int x){
        Node a=head;
        while(a.next!=p){
            a=a.next;
        }
        a.next=new Node(x, p);       
    }
    //17. Kết nối một danh sách liên kết đơn vào cuối của danh sách liên kết đơn khác. giống 15? 
    
    //18. int max() - tìm và trả về giá trị lớn nhất trong danh sách.
    int max(){
        sort();
        return tail.info;
    }
    //19. int min() - tìm và trả về giá trị nhỏ nhất trong danh sách.
    int min(){
        sort();
        return head.info;
    }
    //20. int sum() - trả về tổng của tất cả các giá trị trong danh sách.
    int sum(){
        Node a=head;
        int x=0;
        while(a.next!=null){
            x+=a.info;
            a=a.next;
        }
        return x;
    }
    //21. int avg() - trả về giá trị trung bình của tất cả các giá trị trong danh sách.
    int avg(){
        Node a=head;
        int x=0;
        int y=1;
        while(a.next!=null){
            x+=a.info;
            a=a.next;
            y++;
        }
        return x/y;      
    }
    //22. boolean sorted() - kiểm tra và trả về true nếu danh sách đã được sắp xếp, trả về false nếu danh sách chưa được sắp xếp.
    boolean sorted(){  
        Node a=head;
        Node b=a.next;
        while(a.next!=null){
            if(a.info>b.info){
                return false;
            }
            a=a.next;
        }
        return true;
    }
    //23. void insert(int x) - chèn một nút có giá trị x vào danh sách đã sắp xếp để danh sách mới vẫn được sắp xếp.
     void insert(int x){
         if(x<=head.info){
             addToHead(x);
         }else if(x>=head.info){
             addToTail(x);
         }else{
            Node a=head;
            Node b=a.next;
            while(a.next!=null){
                if(a.info<=x && b.info>=x){
                    a.next=new Node(x,b);
                    break;
                }
                a=a.next;
                b=a.next;
            }             
         }
     }
    //24. Đảo ngược một danh sách liên kết đơn chỉ trong một lần duyệt qua danh sách.
    void daoNguoc(){
        Node truoc = null;
        Node bayGio = head;
        Node sau = null;
        while (bayGio != null) {
            sau = bayGio.next;
            bayGio.next = truoc;
            truoc = bayGio;
            bayGio = sau;
        }
        head = truoc;
    }
    //25. Kiểm tra xem hai danh sách liên kết đơn có cùng nội dung hay không.
    boolean checkND(linkedLink l1, linkedLink l2){
        Node a=l1.head;
        Node b=l2.head;
        int na=1, nb=1;
        while(a.next!=null){
            a=a.next;
            na++;
        }
        while(b.next!=null){
            b=b.next;
            nb++;
        }        
        if(na!=nb){
            return false;
        }else{
            while(b.next!=null){
                if(a.info!=b.info){
                    return false;
                }
                a=a.next;
                b=b.next;
            }
        }  
        return true;
    }
    //Tìm kiếm phần tử x 
}
public class danhSachLienKet {
    public static void main(String[] args) {
        linkedLink l=new linkedLink();
        l.addToTail(1);
        l.addToTail(2);
        l.addToTail(3);
//        l.addToTail(5);
//        l.addToTail(6);
//        l.addToTail(7);
//        l.addToTail(8);
//        l.addToTail(-23);
//        l.addToTail(-24);
//        l.addToTail(-25);
//        l.addToTail(-26);
//        //Lấy phần tử có giá trị 2 
//        Node a=l.head;
//        while(a.next!=null){
//            if(a.info==2){
//                break;
//            }
//            a=a.next;
//        }
//        //Thêm phần tử có giá trị 0 vào sau phần tử có giá trị 2 
//        l.addAfter(a, 0);
//        //Thêm phần tử có giá trị -1 vào sau phần tử thứ 3 
//        l.addAfter(l.head.next.next, -1);
//        //Thêm phần tử có giá trị -10 vào sau phần tử thứ 10 
//        Node b=l.head;
//        for(int i=0;i<10-1;i++){
//            b=b.next;
//        }
//        l.addAfter(b,-10);
//        l.delete(l.head.next.next);
//        //in ra mảng 
//        int[] a=l.toArray(l);
//        for(int i=0;i<a.length;i++){
//            System.out.println(a[i]);
//        }
        linkedLink l1=new linkedLink();
        l1.addToTail(4);
        l1.addToTail(5);
        l.hopNhat(l, l1);
//        l.hopNhat(l, l1);
//        l.addBefore(l.head.next.next, 5);
        l.show();
//        if(l.checkND(l , l1)==true){
//            System.out.println("true");
//        }else{
//            System.out.println("false");
//        }
//        l.daoNguoc();
//        l.show();
    }
}
