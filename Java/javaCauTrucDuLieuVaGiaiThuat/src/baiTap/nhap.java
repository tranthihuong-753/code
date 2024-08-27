package baiTap;

public class nhap {
    public static void swap(int[] arr, int x, int y){
        int m = arr[x];
        arr[x] = arr[y];
        arr[y] = m;
    }
    private static int partition(int[] arr, int low, int high) {
            int pivot = arr[high];  // pivot
            int i = low - 1;
            for (int j = low; j < high; j++) {
                    if (arr[j] < pivot) {
                    i++;
                    swap(arr, i, j); }
            }
            swap(arr, i + 1, high);
            return i + 1;
    }
    public static void main(String[] args) {
        
    }
}
