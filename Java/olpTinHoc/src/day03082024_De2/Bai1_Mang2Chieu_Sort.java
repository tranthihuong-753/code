package day03082024_De2;

import java.util.Scanner;

public class Bai1_Mang2Chieu_Sort {
    public static void main(String[] args) {
        run_thunghiem(); // khong nhap mang tu console -> Lau e 
    }
    //Tao va trả về mang 2 chiều gồm m dòng và n cột 
    static int[][] arr(int n, int m){
        
        int[][] arr = new int[m][n];
        Scanner scan = new Scanner(System.in);
        for(int i = 0 ; i < m ; i++){
            for(int j = 0 ; j < n ; j++){
                try{
                    arr[i][j] = scan.nextInt();
                }catch(Exception ex){
                    System.out.println(ex.toString());
                }
                scan.nextLine();
            }
        }
        return arr;
    }
    // Sap xep moi dong voi gia tri phan tu tang dan 
    static int[][] arrSort(int[][] arr){
        int m = arr.length; // so hang
        int n = arr[0].length; // so cot
        for(int i = 0 ; i < m ; i++){
            QuickSort(arr[i], 0, n - 1);
        }
        return arr;
    }
    // Sap xep nhanh Quick Sort cho mang 1 chieu 
    static int[] QuickSort(int[] arr, int head, int tail){
        int n = arr.length;
        int indexpivot = tail;
        for(int i = head ; i < indexpivot ; i++){
            if(arr[i] > arr[indexpivot]){
                int x1 = arr[i];
                arr[i] = arr[indexpivot - 1];
                arr[indexpivot - 1] = x1;
                
                int x2 = arr[indexpivot - 1];
                arr[indexpivot - 1] = arr[indexpivot];
                arr[indexpivot] = x2;
                
                indexpivot--;
                i--;
            }
        }
        if(tail > head){
            QuickSort(arr, head, indexpivot - 1);
            QuickSort(arr, indexpivot + 1, tail);
        }
        return arr;
    }
    static void run_thunghiem(){
        int[][] arr = { // 5x6
            {2, 4, -3, 0, 2, -5},
            {1, 3, -1, 4, -2, 6},
            {7, -8, 2, -3, 5, 0},
            {-1, -2, 3, 4, -6, 7},
            {8, 0, -9, 2, 1, -4}
        };
        arr = arrSort(arr);
        int m = arr.length;
        int n = arr[0].length;
        for(int i = 0 ; i < m ; i++){
            for(int j =  0; j < n ; j++){
                System.out.print(arr[i][j]+" ");
            }
            System.out.println("");
        }
    }
}
