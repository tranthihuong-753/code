package day03082024_De2;

import java.util.ArrayList;

public class Bai2_DayConLienTiep {
    public static void main(String[] args) {
        run_thunghiem();
    }
    static int[][] DayConLienTiep(int m, int[] arr) {
        ArrayList<int[]> list = new ArrayList<>();
        int n = arr.length;

        for (int i = 0; i < n; i++) {
            int sum = 0;
            ArrayList<Integer> l = new ArrayList<>();
            for (int j = i; j < n; j++) {
                int x = arr[j];
                l.add(x);
                sum += x;

                if (sum == m) {
                    list.add(l.stream().mapToInt(Integer::intValue).toArray()); // chuyen odi arraylist thanh int[] 
                    // Neu them break thi se thieu truong hop 
                }
            }
        }

        // Chuyển ArrayList<int[]> thành int[][]
        int[][] arrout = new int[list.size()][];
        for (int i = 0; i < list.size(); i++) {
            arrout[i] = list.get(i);
        }
        return arrout;
    }
    static void run_thunghiem(){
        int M = 10;
        int[] arr = {1, 3, -2 ,7, -2, -6, 3, 4, 4, -2, 1}; // 11 
//        int M = 3;
//        int[] arr = {1, 4, -2, 2, 1}; // 5
//        int[][] arrout = DayConLienTiep(M, arr);
//        int m = arrout.length;
//        int n = arrout[0].length;
//        System.out.println("Cac day con la: ");
//        for(int i = 0 ; i < m ; i++){
//            System.out.print("  ");
//            for(int j = 0 ; j < n ; j++){
//                System.out.print(arrout[i][j]);
//            }
//            System.out.println("");
//        }
//        int M = 5;
//        int[] arr = {1, 2, 4, -2, 1, -1, 1, 3};
        int[][] result = DayConLienTiep(M, arr);

        // In kết quả
        for (int[] subArray : result) {
            if (subArray != null) {
                for (int value : subArray) {
                    System.out.print(value + " ");
                }
                System.out.println();
            }
        }
    }
}
