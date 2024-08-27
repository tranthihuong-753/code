package PPQuyHoachDong;

import static PPQuyHoachDong.chuong6.min;

public class DynamicProgramming {
    public static void main(String[] args) {

    }
    // Dãy số Fibonaci . Input : index 
    // VD (index, Fibo) = (0, 0) , (1, 1), (2, 1), (3, 2), (4, 3), (5, 5), ... 
    // Day Fibonacci de check : 0, 1, 1, 2, 3, 5, 8, 13, 21, ... 
    static int Fibonaci(int n){
        int[] arr = new int[n + 1];
        arr[0] = 0;
        arr[1] = 1;
        for(int i = 2 ; i <= n ; i++){
            arr[i] = arr[i-1] + arr[i-2];
        }
        return arr[n];
    }
    static void vd1_Fibonaci(){
        int index = 8;
        System.out.println("indexFibonaci = " + index + " , Fibonaci = " + Fibonaci(index));
    }
    
    // Inbut : bang nhi phan c
    // Output : Dien tich hinh vuong lon nhat chua full 1 
    static int hinhVuongNhiPhan(int[][] arr){
        int n = arr.length; // so hang
        int m = arr[0].length; // so cot
        int[][] arrnew = new int[n][m]; 
        int canh = 0;
        for(int i = 0 ; i < n ; i++){
            for(int j = 0 ; j < n ; j++){
                if(arr[i][j] == 1){
                    if(i == 0 || j == 0){
                        arrnew[i][j] = 1;
                    }else{
                        arrnew[i][j] = min(arrnew[i-1][j], arrnew[i][j-1], arrnew[i-1][j-1])+1;
                    }
                    if(arrnew[i][j] > canh){
                        canh = arrnew[i][j];
                    }
                    System.out.println("canh = "+canh);
                }
            }
        }
        return canh*canh;
    }
    static void vd2_hinhVuongNhiPhan(){
        int[][] arr = {
            {1, 1, 1, 0, 1},
            {1, 0, 1, 1, 0},
            {1, 1, 1, 1, 1},
            {0, 0, 1, 0, 1},
            {0, 1, 1, 1, 1}
        };
        int x = hinhVuongNhiPhan(arr);
        System.out.println("Smax = " + x); // Time: 0.0600 secs , Memory: 35.248 Mb
    }
    
    // Tìm cách tính tích các ma trận sao cho ít phép tính nhất . Luôn bắt đầu bằng ma trận đầu tiên 
    static int tichMaTranC(int[][] arr){
        int n = arr.length;
        int[] p = new int[n + 1];
        // Tạo mảng p từ kích thước ma trận
        for (int i = 0; i < n; i++) {
            p[i] = arr[i][0];
        }
        p[n] = arr[n - 1][1];
        int[][] dp = new int[n][n];
        int[][] s = new int[n][n];
        // Khởi tạo bảng dp với chi phí 0 cho ma trận đơn
        for (int i = 0; i < n; i++) {
            dp[i][i] = 0;
        }
        // Tính chi phí tối ưu cho tất cả các đoạn từ 2 ma trận trở lên
        for (int l = 2; l <= n; l++) {
            for (int i = 0; i <= n - l; i++) {
                int j = i + l - 1;
                dp[i][j] = Integer.MAX_VALUE;
                for (int k = i; k < j; k++) {
                    int q = dp[i][k] + dp[k + 1][j] + p[i] * p[k + 1] * p[j + 1];
                    if (q < dp[i][j]) {
                        dp[i][j] = q;
                        s[i][j] = k;
                    }
                }
            }
        }

        return dp[0][n - 1];
    }
    // Trả về số phép tính min của tích ma trận cho sẵn thứ tự rồi 
    static int tichMaTran(int[][] arr){
        int n = arr.length;//so ma tran
        int[][] arrnew = new int[n][n];
        // i = j thi la 0 
        for(int i = 0 ; i < n ; i++){
            arrnew[i][i] = 0;
        }
        int KhoangCach = 1; 
        while(KhoangCach < n){
            int i = 0;
            int j = i + KhoangCach;
            // Chu y la j < n chu khong phai i < n
            while(j < n){
                int[] arrk = new int[j - i];
                int min = 10000;
                for(int k = 0; k < j - i ; k++){
                    arrk[k] = arrnew[i][i+k] + arrnew[i+k+1][j] + arr[i][0]*arr[i+k][1]*arr[j][1];
                    if(arrk[k] < min){
                        min = arrk[k];
                    }
                }
                arrnew[i][j] = min;
                //Thay doi gia tri i va j 
                i++; j++;
            }
            KhoangCach++;
        }
        return arrnew[0][n-1];
    }
    static void vd3_tichMaTran(){
        int[][] arr = {{1, 2}, {2, 3}, {3, 6}, {6, 4}};
        System.out.println("Min: "+tichMaTran(arr));
    }    
    
    // Bài toán ăn trộm 
    // Input : số cân, mảng 2 chiều [cân nặng, giá trị, tên vật] 
    // Output : mảng 1 chiều chứa tên các vật nên lấy thỏa mãn (<= số cân, mỗi vật chỉ được sử dụng 1 lần)
//    static Object[] baiTOANanTROM(int weight, int[][] thing){
//        int n = thing.length;// so vat 
//        Object[][] arr = new Object[weight][2]; // [giá trị, tên vật] 
//        int indexmax = -1;
//        // Gan gia tri cho cac phan tu dau tien 
//        
//    }
    // Input : int n, mang 2 chieu chua day so () 
    // Tim day chua cac so sao cho bang n 
    
}
