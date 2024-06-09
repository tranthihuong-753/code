package thuatToan;

class circularLinkedLink{
    Node head, tail;
    circularLinkedLink(){
        head=tail=null;
    }
    boolean check(){
        return(head==null);
    }
    void show() {
        Node current = head.next;
        System.out.print(current.info + "->");
        if(head.next!=tail){
            while (current!= tail.next) {
                System.out.print(current.info + "->");
                current = current.next;
            }            
        }
        System.out.println();
    }
    void addFirst(int x){
        if(check()){
            head=new Node(x,tail);
            tail=new Node(x,head);
        }else{
            head=new Node(x,head);
            tail.next=head;
        }
    }
}
public class danhSachLienKetVong {
    public static void main(String[] args) {
        circularLinkedLink l=new circularLinkedLink();
        l.addFirst(3);
//        l.addFirst(4);
//        l.addFirst(5);
        l.show();
    }
}
