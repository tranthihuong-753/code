package ham;
import java.util.Scanner;

public class inOutArray {
    //Ham nhap vao va tra ve mot mang
    //Input: so luong phan tu mang 
    static Object[] arr(int n){
        Scanner scan = new Scanner(System.in);
        Object[] arr = new Object[n];
        for(int i = 0 ; i < arr.length ; i++){
            arr[i] = scan.nextLine();
        }
        return arr;
    }
    public static void main(String[] args) {
        Object[] a = arr(3);
        for(Object x : a){
            System.out.println(x);
        }
    }
}
