package sort;

class myHeapSort {
    public static int[] mhsInt(int[] arr){
        int N = arr.length;
        // Xây dựng heap (Max-Heap)
        for (int i = N / 2 - 1; i >= 0; i--) {
            heapify(arr, N, i);
        }
        // Trích xuất từng phần tử từ heap và sắp xếp
        for (int i = N - 1; i > 0; i--) {
            // Di chuyển gốc hiện tại đến cuối mảng
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;
            // Gọi heapify trên heap bị giảm đi
            heapify(arr, i, 0);
        }
        return arr;
    }
    private static void heapify(int arr[], int n, int i) {
        int papa = i; // Khởi tạo largest là gốc
        System.out.println("papa = "+papa);    
        int left = 2 * i + 1; // left = 2*i + 1
        System.out.println("left = "+left);       
        int right = 2 * i + 2; // right = 2*i + 2
        System.out.println("right = "+right);      
        // Nếu nút con bên trái lớn hơn gốc
        if (left < n && arr[left] > arr[papa]) {
            papa = left;
        }
        // Nếu nút con bên phải lớn hơn largest
        if (right < n && arr[right] > arr[papa]) {
            papa = right;
        }
        // Nếu largest không phải là gốc
        if (papa != i) {
            // Doi phan tu i cho phan tu duoc coi la lon hon no 
            int x = arr[i];
            arr[i] = arr[papa];
            arr[papa] = x;
            // Đệ quy heapify cây con bị ảnh hưởng
            heapify(arr, n, papa);
            System.out.println("de quy heapify");
        }
    }
}
