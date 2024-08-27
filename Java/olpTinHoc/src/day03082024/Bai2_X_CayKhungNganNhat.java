package day03082024;

import java.util.Arrays;

public class Bai2_X_CayKhungNganNhat {
    public static void main(String[] args) {
//        char[][] arr = CreateGraph();
////        char[][] arr1 = QuickSort(arr, 0, arr.length - 1);
//        char[][] arr1 = Kruskal(arr);
//        for(int i = 0 ; i < arr1.length ; i++){
//            for(int j = 0 ; j < arr1[0].length - 1 ; j++){
//                System.out.print(arr1[i][j]);
//            }
//            System.out.print(" "+(int)arr1[i][2]);
//            System.out.println("");
//        }
    }
    // Tao do thi thu mang 2 chieu 
    static char[][] CreateGraph(){
        char[][] arr = {
            {'A', 'G', 1},
            {'C', 'D', 9},
            {'A', 'H', 1},
            {'A', 'F', 2},
            {'G', 'F', 3},
            
            {'B', 'F', 5},
            {'G', 'B', 4},
            {'B', 'E', 6},
            {'F', 'D', 8},
            {'E', 'F', 7},
            
            {'H', 'C', 10}
        };
        return arr;
    }
 }
