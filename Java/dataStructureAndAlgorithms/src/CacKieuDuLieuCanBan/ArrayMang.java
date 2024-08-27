package CacKieuDuLieuCanBan;

import java.util.Scanner;

class myArray{
    // Ham tao va tra ve mang co kieu du lieu bat ki 
    // Input : so luong phan tu mang 
    public static Object[] arr(int count){
        Scanner scan = new Scanner(System.in);
        Object[] arrOut = new Object[count];
        for(int i = 0 ; i < count ; i++){
            arrOut[i] = scan.nextLine();
        }
        return arrOut;
    }
}

public class ArrayMang {
    public static void main(String[] args) {
        myArray a = new myArray();
        Object[] arr1 = a.arr(5);
        for(Object x : arr1){
            System.out.println(x);
        }
    }
}
