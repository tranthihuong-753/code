package abstractDataType;

import java.util.LinkedList;
import java.util.PriorityQueue;
import java.util.Queue;

public class hangDoi1DauQueue {
    public static void main(String[] args) {
        // PriorityQueue -> se xap sep lai cac phan tu 
        Queue<String> danhSachSV = new PriorityQueue<String>();
        // Them pha tu 
        danhSachSV.offer("nguyen a");
        danhSachSV.offer("tran e");
        danhSachSV.offer("tran c");
        danhSachSV.offer("tran d");
        danhSachSV.remove();//Xoa phan tu dau quere 
        String a = danhSachSV.poll(); // Gan gia tri dau cho a va xoa phan tu dau khoi quere 
        // outpput a -> c -> d -> e 
        while(true){
            String name = danhSachSV.poll(); // Lay ra va xoa, peek() Lay ra va khong xoa
            if(name == null){
                break;
            }
            System.out.println(name);
        }
    }
}
