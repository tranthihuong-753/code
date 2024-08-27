package ThuatToanCoBan;

public class SapXep {
    public static void main(String[] args) {
//        run_BubbleSort();
        run_QuickSort();
    }
    // Sap xep noi bot bubble sort 
    static int[] BubbleSort(int[] arr){
        int n = arr.length; // n la so luong phan tu cua mang arr
        for(int i = n - 1 ; i >= 0 ; i--){
            for(int j = 0 ; j < i ; j++){
                if(arr[j] > arr[j+1]){
                    int x = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = x;
                }
            }
        }
        return arr;
    }
    static int[] BubbleSort_DQ(int[] arr, int n){
        for(int j = 0 ; j < n - 1 ; j++){
            if(arr[j] > arr[j+1]){
                int x = arr[j];
                arr[j] = arr[j+1];
                arr[j+1] = x;
            }
        }
        if(n >= 0){ // Dieu kien dung de quy 
            BubbleSort_DQ(arr, n - 1);
        }
        return arr;        
    }
    static void run_BubbleSort(){
        int[] arr = {1, -3, 4, 0, 3, 5, -3, 7634, 8, 376, 333, 76,-9, -3, 8398 };
        int[] arrnew = BubbleSort_DQ(arr, arr.length);
        for(int i = 0 ; i < arr.length ; i++){
            System.out.print(arrnew[i] + " ");
        }
    }
    // Sap xep nhanh Quick Sort
    static int[] QuickSort(int[] arr, int head, int tail){
        int pivot = tail;
        for(int i = head; i < pivot ; i++){
            if(arr[i] > arr[pivot]){
                // doi cho i va (pivot - 1)
                int x = arr[i];
                arr[i] = arr[pivot - 1];
                arr[pivot - 1] = x;
                // doi cho (pivot - 1) va pivot
                int x1 = arr[pivot - 1];
                arr[pivot - 1] = arr[pivot];
                arr[pivot] = x1;
                //cap nhat pivot 
                --pivot;
                --i; // hay quen nay :))) 
            }
        }
        // De quy 
        if(tail > head){
            QuickSort(arr, head, pivot - 1);
            QuickSort(arr, pivot + 1, tail);            
        }
        return arr;
    }
    static void run_QuickSort(){
        int[] arr = {2, 4, 2, 6, 3, 0 , 389, -3};
        int[] arrnew = QuickSort(arr, 0, arr.length - 1);
        for(int i = 0 ; i < arr.length ; i++){
            System.out.print(arrnew[i] + " ");
        }        
    }
}
