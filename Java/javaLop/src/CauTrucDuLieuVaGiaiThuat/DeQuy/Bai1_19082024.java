/*
Bài 1 (19082024): Tính tổng S(n)=1+2+3+ ... +n 
https://www.youtube.com/watch?v=eQ3VpTtc9lE
 */
/*
Phân tích 
n = 1 -> S(n) = 1
S(n) = n + S(n-1)
*/
package CauTrucDuLieuVaGiaiThuat.DeQuy;

import java.util.Scanner;

public class Bai1_19082024 {
    public static void main(String[] args) {
        // Gọi hàm nhập vào n >= 1 
        int n = n();
        System.out.println("n = "+n);
        // Gọi hàm tính tổng 
        int S = S(n);
        System.out.println("Sum = "+S);
        int[] arr = new int[10];
    }
    // hàm nhập vào n >= 1. Có Exception 
    static int n (){ 
        int n = 0;
        Scanner scan = new Scanner(System.in);
        boolean check = true; // T -> while chay 
        while(check){
            System.out.print("Nhap vao n : ");
            try{
                n = scan.nextInt();
                if(n < 1){
                    System.out.println("Loi!!! Nhap vao so nguyen duong lon hon 0");
                    continue;                    
                }
                check = false;
            }catch(Exception ex){
                System.out.println("Loi!!!\n"+ex.toString());
                scan.next(); //Giúp con trỏ bỏ qua giá trị không hợp lệ(Nếu không có thì khi while lặp lại, con trỏ vẫn sẽ đọc giá tị lỗi đó -> Vòng lặp v hạn)  
            }
        }
        return n;
    }
    // hàm đêh quy tính tổng
    static int S(int n){
        if(n == 1)
            return 1;
        else
            return n + S(n - 1);
    }
}
