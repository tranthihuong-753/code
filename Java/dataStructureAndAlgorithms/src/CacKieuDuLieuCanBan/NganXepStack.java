package CacKieuDuLieuCanBan;

// Stack sử dung mảng 
class myStack_array {
    int maxSize;    // Kích thước tối đa của ngăn xếp
    int[] stackArray; // Mảng dùng để lưu trữ các phần tử của ngăn xếp
    int top;        // Chỉ số của phần tử ở đỉnh ngăn xếp 
    // Hàm in ra stack 
    public void show(){
        System.out.print("Stack : ");
        if(stackArray == null){
            System.out.println("Stack null.");
        }
        for(int i = 0 ; i <= top ; i++){
            System.out.println("  " + stackArray[i]);
        }
    }
    // Ham khởi tạo ngăn xếp với kích thước xác định
    public myStack_array(int size) {
        this.maxSize = size;
        this.stackArray = new int[maxSize];
        this.top = -1; // Khởi tạo ngăn xếp rỗng
    }
    // Phương thức đẩy (push) một phần tử vào ngăn xếp
    public void push(int value) {
        if(isFull()) {
            System.out.println("Ngăn xếp đã đầy, không thể thêm phần tử mới");
            return;
        }
        stackArray[++top] = value;
    }
    // Phương thức lấy (pop) một phần tử khỏi ngăn xếp
    public int pop() {
        if(isEmpty()) {
            System.out.println("Ngăn xếp rỗng, không có phần tử nào để lấy ra");
            return -1; // Trả về -1 nếu ngăn xếp rỗng
        }
        return stackArray[top--];
    }
    // Phương thức kiểm tra ngăn xếp có đầy không
    public boolean isFull() {
        return (top == maxSize - 1);
    }
    // Phương thức kiểm tra ngăn xếp có rỗng không
    public boolean isEmpty() {
        return (top == -1);
    }
    // Phương thức lấy phần tử ở đỉnh ngăn xếp mà không lấy ra khỏi ngăn xếp
    public int peek() {
        if(isEmpty()) {
            System.out.println("Ngăn xếp rỗng, không có phần tử nào ở đỉnh");
            return -1; // Trả về -1 nếu ngăn xếp rỗng
        }
        return stackArray[top];
    }
}

//Stack sử dụng danh sách liên kết 
class myStack{
    node head;
    // Hàm in ra stack 
    public void show(){
        System.out.print("Stack : ");
        if(head == null){
            System.out.print("null");
        }else{
            node head1 = head;
            while(head1 != null){
                System.out.print("  " + head1.data);
                head1 = head1.next;
            }
        }
    }
    // Phương thức đẩy (push) một phần tử vào ngăn xếp
    public void push(int value){
        if(head == null){
            head = new node(value, null);
        }else{
            node x = new node(value, head);
            head = x;
        }
    }  
    // Phương thức lấy (pop) một phần tử khỏi ngăn xếp
    public Object pop(){
        if(head == null){
            System.out.println("Stack null.");
            return null;
        }else{
            Object x = head.data;
            head = head.next;
            return x;
        }
    }
    // Phương thức lấy phần tử ở đỉnh ngăn xếp mà không lấy ra khỏi ngăn xếp
    public Object peek(){
        if(head == null){
            System.out.println("Stack null.");
            return null;
        }else{
            return head.data;
        }        
    }
}

public class NganXepStack {
    static void runmyStack_array(){
        myStack_array stack = new myStack_array(5); // Khởi tạo ngăn xếp với kích thước 5
        
        stack.push(10);
        stack.push(20);
        stack.push(30);
        stack.show();
        System.out.println("Phần tử ở đỉnh ngăn xếp: " + stack.peek()); // In ra phần tử ở đỉnh ngăn xếp

        System.out.println("Lấy ra phần tử: " + stack.pop()); // Lấy ra phần tử ở đỉnh ngăn xếp
        System.out.println("Lấy ra phần tử: " + stack.pop());
        System.out.println("Lấy ra phần tử: " + stack.pop());
        System.out.println("Lấy ra phần tử: " + stack.pop()); // Thử lấy ra phần tử khi ngăn xếp rỗng

        stack.push(40);
        stack.push(50);
        stack.push(60);
        stack.push(70);
        stack.push(80);
        stack.push(90); // Thử thêm phần tử khi ngăn xếp đã đầy          
    }
    static void runmyStack(){
        myStack s = new myStack();
        s.show();
        s.push(0);
        s.push(2);
        s.push(5);
        System.out.println("");
        s.show();
        s.pop();
        System.out.println("");
        s.show();        
    }
    public static void main(String[] args) {
      runmyStack();
    }
}
