package day10082024;

public class BaiToanThapHaNi {
    public static void main(String[] args) {
        ChuyenDia(4, '1', '2', '3');
    }
    static int buoc = 0;
    // buoc (2^n) - 1 
    static void ChuyenDia(int n , char A, char B, char C){
        // n chan chuyen tu A sang B 
        // n le chuyen tu A sang C 
        if(n == 1){
            System.out.println("B"+(++buoc)+" Chuyen dia tu "+ A +" sang "+C);
        }else{
            ChuyenDia(n-1, A, C, B);
            ChuyenDia(1, A, B, C);
            ChuyenDia(n-1, B, A, C);
        }
    }
}
