package sort;

class myQuickSort{
    // Ham sap xep day so nguyen theo thu tu tang dan gia tri 
    // Input : mang, phan tu bat dau cua mang, phan tu ket thuc cua mang (why ? de quy) . Output : mang sap xep tang dan 
    // (head = 0 , tail = arr.length - 1)
    public static int[] mqsInt(int[] arr, int head, int tail){
        // De quy den khi mang chi con 1 phan tu -> head = tail, ma ban chat head >= tail 
        if(head < tail){
            // Chon chot la phan tu cuoi cung 
            int pivot = arr[tail];
            for(int i = head ; i <= tail ; i++){
                // Gap phan tu lon hon pivot thi chuyen sang phai pivot 
                if(arr[i] > pivot){
                    // Doi vi tri cua phan tu dang xet voi phan tu ngay sau pivot 
                    int x1 = arr[i];
                    arr[i] = arr[tail - 1];
                    arr[tail - 1] = x1;
                    // Doi vi tri cua pivot voi phan tu ngay sau no 
                    int x2 = arr[tail - 1];
                    arr[tail - 1] = arr[tail];
                    arr[tail] = x2;
                    
                    tail-=1;
                    i--;
                }
//                // Neu i = tail thi dung sap xep 
//                if(i == tail){break;}
            }
            // Cho tail co dinh o day nen la khong de quy tail 
            mqsInt(arr, head, tail - 1);
            mqsInt(arr, tail+1, arr.length - 1);
        }
        return arr;
    }
}