package exp;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class h{
    public static void main(String[] args) {
         Scanner a = new Scanner(System.in);
         int n = a.nextInt();
         a.nextLine();
         int[] arr = new int[n];
         for(int i = 0; i < n; i++){
             arr[i] = a.nextInt();
//             a.nextLine();
             arr[i] = arr[i]*arr[i];
         }
         for(int i = 0; i < n; i++){
             System.out.print(arr[i] + " ");
         }         
    }
}

 