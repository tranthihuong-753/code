package CauTrucDuLieuVaGiaiThuat.HangDoi_Queue;

import java.util.LinkedList;
import java.util.PriorityQueue;
import java.util.Queue;

public class queue {
    public static void main(String[] args) {
        run();
    }
    // hàng đợi được sắp xếp theo a-z
    static void run_az(){
        // PriorityQueue -> se xap sep lai cac phan tu 
        Queue<String> danhSachSV = new PriorityQueue<String>();
        // Them pha tu 
        danhSachSV.offer("tran a");
        danhSachSV.offer("tran e");
        danhSachSV.offer("tran c");
        danhSachSV.offer("tran d"); // outpput a -> c -> d -> e 
        danhSachSV.remove();//Xoa phan tu dau quere c -> d -> e
        danhSachSV.poll(); //Xoa phan tu dau khoi quere d -> e 
        while(true){
            String name = danhSachSV.poll(); // Lay ra va xoa, peek() Lay ra va khong xoa
            if(name == null){
                break;
            }
            System.out.println(name);
        }   
    }
    // hàng đợi không sắp xếp 
    static void run(){
        // PriorityQueue -> se xap sep lai cac phan tu 
        Queue<String> danhSachSV = new LinkedList<>();
        // Them pha tu 
        danhSachSV.offer("tran a");
        danhSachSV.offer("tran e");
        danhSachSV.offer("tran c");
        danhSachSV.offer("tran d"); // outpput a -> e -> c -> d 
        danhSachSV.remove();//Xoa phan tu dau quere e -> c -> d 
        danhSachSV.poll(); //Xoa phan tu dau khoi quere c -> d 
        while(true){
            String name = danhSachSV.poll(); // Lay ra va xoa, peek() Lay ra va khong xoa
            if(name == null){
                break;
            }
            System.out.println(name);
        }        
    }
}
