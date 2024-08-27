package exp;

class node{
    int mahanghoa;
    String tenhanghoa;
    int soluongnhap;
    String xuatxu;
    node next;
    node(){}
    node(int a, String b, int c, String d){
        mahanghoa = a;
        tenhanghoa = b;
        soluongnhap = c;
        xuatxu = d;
    }
}

public class huong20082024 {
    public static void main(String[] args) {
        node root1 = new node(1, "bút bi xanh", 100, "HN");
        root1.next = new node(2, "bút bi đỏ", 1000, "HD");
        root1.next.next = new node(3, "tẩy", 3, "VP");
        show(root1);
        System.out.println("Tong so luong nhap = " + TongSoLuongNhap(root1));
    }
    static void show(node p){
        node head1 = p;
        while(head1 != null){
            System.out.println("MHH: " + head1.mahanghoa);
            System.out.println("THH: " + head1.tenhanghoa);
            System.out.println("SoLuongNhap: " + head1.soluongnhap);
            System.out.println("XuatXu: " + head1.xuatxu);
            head1 = head1.next;
        }
    }
    static int TongSoLuongNhap(node p){
        node head1 = p;
        int out = 0;
        while(head1 != null){
            out += head1.soluongnhap;
            head1 = head1.next;
        }
        return out;
    }
}
