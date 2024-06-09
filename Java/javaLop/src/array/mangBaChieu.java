package array;

class Node{
    int info;
    Node next;
    Node(){}
    Node(int x, Node p){
        info=x;
        next=p;
    }
}

class MyList{
    //head đầu tail cuối 
    Node head,tail;
    Node head(){
        return head;
    }
    Node tail(){
        return tail;
    }
    MyList(){
        head=tail=null;
    }
    boolean isEmpty(){
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
        if(isEmpty()){
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
        Node a
    }
//    //xóa nút đầu và trả về giá trị của nó.
//    int deleteFromHead(){
//        
//    }
//    // xóa nút cuối và trả về giá trị của nó
//    int deleteFromTail(){
//        
//    }
//    //xóa nút sau nút p và trả về giá trị của nó
//    int deleteAter(Node p){
//        
//    }
//    //xóa nút đầu tiên có giá trị bằng x
//    void dele(int x){
//        
//    }
//    //tìm kiếm và trả về tham chiếu đến nút đầu tiên có giá trị x
//    Node search(int x){
//        
//    }
//    //đếm và trả về số lượng nút trong danh sách
//    int count(){
//        
//    }
//    //xóa một nút thứ i trong danh sách. Đảm bảo rằng nút như vậy tồn tại.
//    void delete(int i){
//        
//    }
//    // sắp xếp danh sách theo thứ tự tăng dần của giá trị.
//    void sort(){
//        
//    }
//    //xóa nút p nếu nó tồn tại trong danh sách
//    void dele(Node p){
//        
//    }
//    //tạo và trả về một mảng chứa thông tin của tất cả các nút trong danh sách
//    int [] toArray(){
//        
//    }
//    //Hợp nhất hai danh sách liên kết đơn đã sắp xếp thành một danh sách đã sắp xếp
//    void hopNhat(){
//        
//    }   
    //Giữ lại phàn từ đầu tiên 
    void removeFirst(){
        if(isEmpty()){
            head=tail=null;
        }else{
            head.next=null; 
        }        
    }
    void removeFirst1(){
        if(isEmpty()){
            head=tail=null;
        }else{
            //Vị trí của Ptu đầu = Gía trị phần tử sau 
            head=head.next; 
        } 
        if(head==null){
            tail=null;
        }
    }
    void removeLast(){
        if(head.next==tail){
            head=tail=null;
        }else{
            
        }
    }
    //Kết nối 2 list với nhau 
    MyList connet_lost(MyList l1, MyList l2){
          if(l1==null){
              return l2;
          }else if(l2==null){
              return l1;
          }else{
              l1.tail().next=l2.head();
              return l1;
          }  
    }
    void remove_all_value(int x){
        
    }
}
public class mangBaChieu {
    public static void main(String[] args) {
        MyList l=new MyList();
        l.addToTail(1);
        l.addToTail(2);
        l.addToTail(3);
        l.addToTail(4);
        l.addToTail(5);
        l.addToTail(6);
        l.addToTail(7);
        l.addToTail(8);
        l.addToTail(-23);
        l.addToTail(-24);
        l.addToTail(-25);
        l.addToTail(-26);
        //Lấy phần tử có giá trị 2 
        Node a=l.head;
        while(a.next!=null){
            if(a.info==2){
                break;
            }
            a=a.next;
        }
        //Thêm phần tử có giá trị 0 vào sau phần tử có giá trị 2 
        l.addAfter(a, 0);
        //Thêm phần tử có giá trị -1 vào sau phần tử thứ 3 
        l.addAfter(l.head.next.next, -1);
        //Thêm phần tử có giá trị -10 vào sau phần tử thứ 10 
        Node b=l.head;
        for(int i=0;i<10-1;i++){
            b=b.next;
        }
        l.addAfter(b,-10);
        
        l.show();
    }
}

