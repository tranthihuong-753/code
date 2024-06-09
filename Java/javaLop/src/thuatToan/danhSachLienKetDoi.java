package thuatToan;
class Nodee{
    int info;
    Nodee next;
    Nodee prev;
    Nodee(int a, Nodee b, Nodee c){
        info=a;
        next=b;
        prev=c;
    }
}
class doubleLinkedLink{
    Nodee head, tail;
    boolean check(){
        return(head==null);
    }
    void show() {
        Nodee a = head;
        while (a != null) {
            System.out.print(a.info + "->");
            a = a.next;
        }
        System.out.println();
    }   
    void addFirst(int x){
        Nodee a=new Nodee(x, null, null);
        if(check()){
            head=tail=a;
        }else{
            head=new Nodee(x, head, tail);
        }
    }
    void addLast(int x){
        Nodee a=new Nodee(x, null, null);
        if(check()){
            head=tail=a;
        }else{
            tail.next=a;
            a.next=null;
            tail=a;
        }        
    }
    void daoNguoc(){
//        Nodee truoc=null;
        Nodee bayGio=head;
        Nodee sau=bayGio.next; 
        int i=1;
        while(sau.next!=null){
            Nodee a=bayGio;
            bayGio.next=sau.next;
            bayGio.prev=bayGio;
            sau.next=sau;
            sau.prev=a.prev;
            
            bayGio=bayGio.next;
            sau=bayGio.next;
            System.out.println(i++);
        }
//            Nodee b=head;
//            head=tail;
//            tail=b;
//            head.next=tail.next;
//            head.prev=head;
//            tail.next=tail;
//            tail.prev=b.prev;        
    }
}
public class danhSachLienKetDoi {
    public static void main(String[] args) {
        doubleLinkedLink l=new doubleLinkedLink();
        l.addFirst(2);
        l.addFirst(3);
        l.addLast(1);
        l.addLast(0);
        l.show();
        System.out.println("Đảo ngược.");
        l.daoNguoc();
        l.show();
    }
}
