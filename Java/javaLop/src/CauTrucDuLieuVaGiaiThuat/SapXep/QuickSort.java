package CauTrucDuLieuVaGiaiThuat.SapXep;

public class QuickSort {
    public static void main(String[] args) {
        run_QS();
    }
    // Sắp xép tăng dần theo sx nhanh 
    static int[] QS(int[] arr, int head, int tail){
        int pivot = tail; // trục 
        for(int i = head ; i < pivot ; i++){
            if(arr[i] > arr[pivot]){
                // Đổi chỗ i và pivot -1 
                int x = arr[i];
                arr[i] = arr[pivot - 1];
                arr[pivot - 1] = x;
                
                // Đổi chỗ pivot - 1 với pivot 
                int x1 = arr[pivot - 1];
                arr[pivot - 1] = arr[pivot];
                arr[pivot] = x1;
                // Cập nhật pivot và i 
                pivot = pivot - 1;
                i = i - 1;
            }
        }
        if(tail > head){
            QS(arr, head, pivot - 1);
            QS(arr, pivot + 1, tail);
        }
        return arr;
    }
    static void run_QS(){
        int[] arr = {2, 3, 0 ,4, -2, -5, 3};
        int[] arrBS = QS(arr, 0, arr.length - 1); // n , 0 -> (n-1)
        for(int i = 0 ; i < arrBS.length ; i++){
            System.out.print(" " + arrBS[i]);
        }        
    }
}
