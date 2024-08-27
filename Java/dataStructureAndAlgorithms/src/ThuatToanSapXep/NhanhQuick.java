package ThuatToanSapXep;

public class NhanhQuick {
    public static void main(String[] args) {
//        int[] arr = {2, -1, 3, 4, -6, 0, 2, 5};
//        printArr(QuickSort(arr, 0, arr.length - 1));
        String[] arrs = {"AB", "AAC", "F", "H", "U", "O", "o", "N", "n"};
        printArr(QuickSort(arrs, 0, arrs.length - 1));        
    }
    // Input: mang, index bat dau, index ket thuc mang 
    static int[] QuickSort(int[] arr, int head, int tail){
        int n = tail - head + 1;
        int indexP = head;
        for(int i = 0 ; i < indexP ; i++){
            if(arr[i] > arr[indexP]){
                // Doi cho i cho indexP - 1 
                int a = arr[i];
                arr[i] = arr[indexP - 1];
                arr[indexP - 1] = a;
                // Doi cho indexP - 1 cho indexP
                int b = arr[indexP - 1];
                arr[indexP - 1] = arr[indexP];
                arr[indexP] = b;
                // Cap nhat indexP
                indexP --;
            }
        }
        if(head < tail){
            QuickSort(arr, 0, indexP - 1);
            QuickSort(arr, indexP + 1, tail);            
        }
        return arr;
    }
    static String[] QuickSort(String[] arr, int head, int tail){
            int n = tail - head + 1;
            int indexP = head;
            for(int i = 0 ; i < indexP ; i++){
                if(arr[i].compareTo(arr[indexP]) > 0){
                    // Doi cho i cho indexP - 1 
                    String a = arr[i];
                    arr[i] = arr[indexP - 1];
                    arr[indexP - 1] = a;
                    // Doi cho indexP - 1 cho indexP
                    String b = arr[indexP - 1];
                    arr[indexP - 1] = arr[indexP];
                    arr[indexP] = b;
                    // Cap nhat indexP
                    indexP --;
                }
            }
            if(head < tail){
                QuickSort(arr, 0, indexP - 1);
                QuickSort(arr, indexP + 1, tail);            
            }
            return arr;
        }    
    static void printArr(String[] arr){
        System.out.print("Array: ");
        for(int i = 0; i < arr.length ; i++){
            System.out.print(" " + arr[i]);
        }
    }   
}
