/*
https://luyencode.net/problem/vt03
 */
package exp;
import java.util.Scanner;
public class bai1ntn {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int n = scan.nextInt();
        scan.nextLine();
        
        String a = scan.nextLine();
        String[] arr1 = a.split(" ");
        int[] arr = new int[n];
        
        int i=0;
        for(int x : arr){
            x = Integer.parseInt(arr1[i]);
            i++;
        }
        //Tìm index của max 
        i=0;
        int max = arr[0];
        int index = 0; 
        for(int x : arr){
            if(max <= x){
                max = x;
                index = i;
            }
            i++;
        }
        System.out.println(index);
    }
}
