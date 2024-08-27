package CauTrucDuLieuVaGiaiThuat.DeQuy;

import java.util.ArrayDeque;
import java.util.Deque;

public class deque {
    public static void main(String[] args) {
        Deque<String> danhSachSV = new ArrayDeque<String>();
        // Them pha tu 
        danhSachSV.offer("nguyen a");
        danhSachSV.offer("tran b");
        danhSachSV.offer("tran c");
        danhSachSV.offer("tran d");
        danhSachSV.offerFirst("one");
        danhSachSV.offerLast("two");
        // outpput one -> a -> b -> c -> d -> two    
        while(true){
            String name = danhSachSV.poll();
            if(name == null){
                break;
            }
            System.out.println(name);
        }
    }
}
