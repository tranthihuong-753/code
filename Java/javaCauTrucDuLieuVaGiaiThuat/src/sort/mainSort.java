package sort;

import java.util.Scanner;
import static sort.myBubbleSort.mbsInt;
import static sort.myInsertionSort.misInt;
import static sort.mySelectionSort.mslInt;
import static sort.myQuickSort.mqsInt;
import static sort.myMergeSort.mmsInt;
import static sort.myHeapSort.mhsInt;

public class mainSort {
    public static void main(String[] args) {
        int n = oneInt();
        int[] arrInt = arrInt(n);
        System.out.println("n-1="+(n-1));
        showArr(n, mhsInt(arrInt));
    }
    //Ham nhap vao mot so nguyen 
    public static int oneInt(){
        Scanner scan = new Scanner(System.in);
        int n = scan.nextInt();
        scan.nextLine();
        return n; 
    }
    //Ham hien thi mang so nguyen 
    //Input: so luong phan tu cua mang, mang . Output: hien thi mang 
    public static void showArr(int n, int[] arr){
        System.out.println("Gia tri cua mang la: ");
        for(int x : arr){
            System.out.println("    " + x);
        }
    }
    //Ham nhap vao mot day so nguyen, cac phan tu ngan cach boi dau cach space. 
    //Input: so luong phan tu cua mang . Output: mang 
    public static int[] arrInt(int n){
        Scanner scan = new Scanner(System.in);
        //Khai bao mang
        int[] arr = new int[n];
        //Nhap vao gia tri cua cac phan tu trong mang 
        for(int i = 0; i < n ; i++){
            // Ham nhap vao duoc nhieu hon n so nguyen , n so nguyen dau se tro thanh con cua mang, con lai go to the trash  
            arr[i] = scan.nextInt();
        }
        return arr;
    }
}
