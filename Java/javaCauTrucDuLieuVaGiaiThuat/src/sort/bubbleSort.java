package sort;
// Sap xep noi bot 
class myBubbleSort{
    // Ham sap xep day so nguyen theo thu tu tang dan gia tri 
    // Input : mang . Output : mang sap xep tang dan 
    public static int[] mbsInt_comment(int[] arr){
        int n = arr.length ;
        // kiem tra xem co su sap xep voi 1 lan "Xet k phan tu" hay khong (2<=k<=n). True la co . False la khong  
        boolean check = false; 
        // VD 3_ 5 2 4_ 1 thi xet tu 3 den 4 vi neu chay den 1 thi so sanh voi ma a 
        for(int i = 1 ; i <= n - 1 ; i++){
            // VD n = 5 
            // Xet 5 phan tu [0, 4] , thi chay tu 0 den 3 
            // Xet 4 phan tu [0, 3] , thi chay tu 0 den 2 
            // Xet k phan tu [0, k - 1] , thi chay tu 0 den k - 2
            
            // Xet lan dau [0, n - 1], thi chay tu 0 den n - 2 = n - 1 - i (voi i = 1)
            // Xet lan 2 [0, n - 2], thi chay tu 0 den n - 3 = n - 1 - i (voi i = 2)
            // Xet lan 3 [0, n - 3], thi chay tu 0 den n - 4 = n - 1 - i (voi i = 3)
            for(int  j = 0 ; j < n - i ; j++){
                if(arr[j] > arr[j + 1]){
                    int x = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = x;
                    check = true;
                }
            }   
            if(check == false){
                return arr;
            }
        }
        return arr;
    }
    public static int[] mbsInt(int[] arr){
        int n = arr.length;
        boolean check = false;
        for(int i = 1 ; i <= n - 1 ; i++){
            for(int j = 0 ; j < n - i ; j++){
                if(arr[j] > arr[j+1]){
                    int x = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = x;
                    check = true;
                }
            }
            if(check == false){
                return arr;
            }
        }
        return arr;
    }
}