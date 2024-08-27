package abstractDataType;

class myDoubleLinkedLink{
    // lấy ở class singlyLinkedLink 
    sllnode head, tail;
    // Hàm hiển thị danh sách liên kết đôi double linked link 
    void show(){
        if(head != null)
        {
            System.out.println("Head: "+head.data);
        }
        if(tail != null)
        {
            System.out.println("Tail: "+tail.data);
        }
        sllnode head1 = head;
        if(head == null)
        {
            System.out.println("Double linked link null. ");
        }
        else
        {
            
        }
    }
}
public class doubleLinkedLink {
    public static void main(String[] args) {
        
    }
}
