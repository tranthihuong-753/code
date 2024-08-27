package PPQuyHoachDong;

import java.util.LinkedList;
import java.util.List;
import java.util.concurrent.CopyOnWriteArrayList;

public class chuong6 {
    public static void main(String[] args) {
        vd_khoangCach();
    }
    static int huong(int[] arr){
        int n = arr.length;
        int[] arr1 = new int[2]; // Xet phan tu i, Phan tu dau luu tru t 0 den i-2 , Phan tu 2 luu tru tu 0 den i - 1 
        // Xet phan tu index = 2 
        arr1[0] = arr[0];
        arr1[1] = arr[0] + arr[1];
        int min = 0;
        for(int i = 2 ; i < n ; i++){
            System.out.println("i = "+i+" arr(0) = "+arr1[0]+" arr(1) = "+arr1[1]);
            if((arr1[0] + arr[i]) <= (arr1[1] + arr[i])){
                int x = arr1[0];
                arr1[0] = arr1[1];
                arr1[1] = x + arr[i];
            }else{
                int x = arr1[0];
                arr1[0] = arr1[1];
                arr1[1] += arr[i];                
            }
        }
        return arr1[1];
    }
    static void vd1_huong(){
        int[] arr = {1, 1, 2, 1, 3, 1, 2};
        System.out.println("kq = "+huong(arr));        
    }
    
    // Tim min 1|5|7 
    static int huong2(int n){
        int arr[] = new int[n];
        for(int i = 1; i<5; i++){
            arr[i-1] = i;
        }
        arr[4] = 1; // 5 = 1.5
        arr[5] = 2; // 6 = 1.5 + 1.1 
        arr[6] = 1; // 7 = 1.7 
        for(int i = 7; i < n; i++){
            int value1 = arr[i-1]+1; 
            int value5 = arr[i-5]+1; 
            int value7 = arr[i-7]+1; 
            arr[i] = min(value5,value1,value7);
        }
        return arr[arr.length-1];
    }
    static int min(int a, int b, int c){
        int min = a;
        if(b <= a && b <= c){
            min = b;
        }
        if(c <= a && c <= b){
            min = c;
        }
        return min;
    }
    static void vd2_huong2(){
        System.out.println("money2 = "+huong2(26));
    }
    
    // Tim min 1/4/7 
    // Voi a, b, c la so nguyen . Tim a+b+C min sao cho n = ax1 + bx4 +cx7
    static int huong2b(int n){
        int[] arr = new int[n];
        arr[0] = arr[3] = arr[6] = 1;
        arr[1] = arr[4] = 2;
        arr[2] = arr[5] = 3;
        for(int i = 7 ; i < n ; i++){
            int a = arr[i-1] + 1;
            int b = arr[i-4] + 1;
            int c = arr[i-7] + 1;
            System.out.println("a="+a+" b="+b+" c="+c);
            arr[i] = min(a, b, c);
//            System.out.println(arr[i]+" i = "+i);
        }
        return arr[n-1];
    }
    static void vd2_huong2b(){
        System.out.println("money = "+huong2b(12));
    }
    
    static int huong3(int n){
        int[] arr1 = new int[n];
        arr1[0] = 1;
        arr1[1] = 2;
        arr1[2] = 3;
        arr1[3] = 6;
        for(int i = 4; i < arr1.length; i++){
            int a1 = arr1[i-1] + 1;
            int a3 = arr1[i-2] + 3;
            int a4 = arr1[i-4] + 6;
            arr1[i] = max(a1, a3, a4);
//            System.out.println("a1 = " + a1 +" a3 = "+a3+" max = "+arr1[i]);
        }
        return arr1[arr1.length-1];
    }
    static int max(int a, int b, int c){
        int max = a;
        if(b > a && b > c){
            max = b;
        }
        if(c > a && c > b){
            max = c;
        }
        return max;        
    }
    static void vd3_huong3(){
        System.out.println("max = "+ huong3(6));
    }
    
    //1. Viết bài toán tìm phần tử lớn nhất của mảng sử dụng quy hoạch động dynamic programming - DP
    static int maxArr(int[] arr){
        int n = arr.length;
        int[] arrDB = new int[n];
        arrDB[0] = arr[0]; 
        for(int i = 1 ; i < n ; i++){
            arrDB[i] = max(arr[i], arrDB[i-1]);
        }
        return arrDB[n-1];
    }
    // Ham tim max cua 2 int 
    static int max(int a, int b){
        int max = b;
        if(a>b){
            max = a;
        }
        return max;
    }
    static void vd6_maxArr(){
        int[] arr = {1, 4, -2, 0 , 4, 4, 4, -3};
        System.out.println("Max arr = " + maxArr(arr));
    }
    //2. Cho hai xâu ký tự. Tìm độ dài xâu con chung nhỏ nhất giữa chúng. 
    // Ví dụ: "quetzalcoatl" và "tezcatlipoca" thì xâu con chung dài nhất sẽ là "ezaloa" với độ dài 6.
    static int xauConDaiNhat(String txt1, String txt2){
        return txt2.length();
    }
    static void vd_xauConDaiNhat(){
        String txt1 = "conchomauxanh"; // 13
        String txt2 = "conmeonoitienganh"; //17
        System.out.println("Length = "+ xauConDaiNhat(txt1, txt2));
    }
    //Cho một tập hợp các số nguyên không âm và một giá trị tổng, 
    //nhiệm vụ là kiểm tra xem có tồn tại một tập con của tập hợp đã cho 
    // mà tổng của nó bằng với tổng đã cho hay không.
    // Input : int[] arr, int sum 
    // VD: set[] = {3, 34, 4, 12, 5, 2}, sum = 9 -> TRUE 
    // ! Bat ky phan tu nao cua mang != sum 
    static boolean checkSum(int[] arr, int sum){
        int n = arr.length;
        for(int i = 0 ; i < n ; i++){
            int[] arr1 = new int[n];
            if(arr[i] < sum){
                arr1[0] = arr[i];
                arr1[1] = sum - arr1[0];
                int index = 2;
                for(int j = i+1 ; j < n ; j++){
                    if(arr[j] < arr1[1]){
                        for(int k = 2 ; k <= index ; k++){
                            if((arr[j] + arr1[k])== sum){
                                return true;
                            }else if((arr[j] + arr1[k])< sum){
                                arr1[k] += arr[j];
                            }else{
                                arr1[index] = arr[j];
                                index++;
                            }
                        }
                    }
                }
            }
        }
        return false;
    }
    public static Boolean bai1TrangDi(int input[], int sum){
        List<Integer> sumAvai = new LinkedList<Integer>();
        sumAvai.add(0);
        for(int i = 0; i< input.length; i++){
            if( input[i]<=sum){
                List<Integer> originalSumAvai = new CopyOnWriteArrayList<>(sumAvai);
                originalSumAvai.add(input[i]);
                for (int x : sumAvai) {
                    if(x + input[i] == sum ) return true;
                    originalSumAvai.add(x + input[i]);
                }
                sumAvai = new CopyOnWriteArrayList<>(originalSumAvai);
            }
        }
        return sumAvai.contains(sum);
    }
    static void vd_checkSum(){
        int[] arr = {3, 35, 487, 8362429, 50, 2, 76, 88, 99, 378296492};
        int sum = 100000;
        System.out.println("Huong "+checkSum(arr, sum));
        System.out.println("Trang "+bai1TrangDi(arr, sum));
    }
    //Cho một mảng arr[]
    //nhiệm vụ là tìm độ dài của Chuỗi Con Tăng Dần Dài Nhất (LIS)
    //tức là chuỗi con dài nhất mà các phần tử của chuỗi con đó được sắp xếp theo thứ tự tăng dần.
    // VD Input: arr[] = {3, 10, 2, 1, 20} Output: 3 / is 3, 10, 20
    static String stringLTS;
    static String stringLTS1;
    static int LTS(int[] arr){
        int n = arr.length;
        int[] arr1 = new int[2]; 
        for(int i = 0 ; i < n ; i++){
            arr1[0] = 1;
            int check = arr[i];
            stringLTS1 = Integer.toString(arr[i]) + ", "; // Chuyển int thành String
            System.out.println("string "+stringLTS1);
            for(int j = i + 1 ; j < n ; j++){
                if(check < arr[j]){
                    arr1[0]++;
                    check = arr[j];
                    stringLTS1 += Integer.toString(arr[j]) + ", ";
                }
            }
            if(arr1[0] > arr1[1]){
                arr1[1] = arr1[0];
                stringLTS = stringLTS1;
            }
        }
        return arr1[1];
    }
    static void vd_LTS(){
        int[] arr = {1,2,3,4,3,2,1};
        System.out.println("LTS có length max = " + LTS(arr));
        System.out.println(stringLTS);
    }
    //Viết hàm input mảng 2 chiều, index i, j 
    // Output số nguyên 
    static int ConDuongDaiNhat(int[][] arr){ // ma tran kich thuoc nxn 
        int n = arr.length;
        int max = 1;
        for(int i = 0 ; i < n ; i++){
            for(int j = 0 ; j < n ; j++){
                int a = i;
                int b = j;
                System.out.println("h");
                int count = 1;
                boolean check = true;
                while(check){
                    System.out.println(a+""+b);
                    int ch = 0;
                    if((a-1)<n &&(a-1)>=0 && (arr[a-1][b] - arr[a][b]) == 1){
                        a = a-1;
                        ch = 1;
                    }
                    if((b-1)<n && (b-1)>=0 && (arr[a][b-1] - arr[a][b]) == 1){
                        b = b - 1;
                        ch = 1;
                    }
                    if((b+1)<n && (arr[a][b+1] - arr[a][b]) == 1){
                        b = b + 1;
                        ch = 1;
                    }
                    if((a+1)<n && (arr[a+1][b] - arr[a][b]) == 1){
                        a = a + 1;
                        ch = 1;
                    }  
                    if(ch == 0){
                        check = false;
                    }else{
                        count++;
                    }
                }
                if(count > max){
                    max = count;
                }
            }
        }
        return max;
    }
    static void vd_ConDuongDaiNhat(){
        int[][] arr = {
            {1, 3, 5},
            {2, 7, 9},
            {4, 32, 22}
        };
        System.out.println("Con duong dai nhat : " + ConDuongDaiNhat(arr));
    }
    
    //Cho hai chuỗi S1 và S2
    // nhiệm vụ là tìm độ dài của chuỗi con chung dài nhất
    //tức là chuỗi con dài nhất xuất hiện trong cả hai chuỗi.
    // S1 = “ABC” ; S2 = “ACD” Output:2 is “AC”.
    static int ChuoiConChungDaiNhat(String str1, String str2){
        char[] ch1 = str1.toCharArray();
        int n1 = ch1.length;
        char[] ch2 = str2.toCharArray();
        int n2 = ch2.length;
        int lengthmax = 0;
        int i1 = 0 ;
        boolean check = true;
        while(check){
            int length = 0;
            int m = 0;
            for(int i = i1 ; i < n1 ; i++){
                for(int j = m ;  j < n2 ; j++){
                    if(ch1[i] == ch2[j]){
                        length++;
                        m = i + 1 ; 
                        break;
                    }
                }
            }
            if(length > lengthmax){
                lengthmax = length;
            }
            if(i1 == (n1-1)){
                check = false;
            }else{
                i1++;
            }
        }
        return lengthmax;
    }
    static void vd_ChuoiConChungDaiNhat(){
//        String str1 = "ABC"; String str2 = "ACD"; // 2; AC 
//        String str1 = "XYZW"; String str2 = "XYWZ"; // 3 ; AYZ 
        String str1 = "TRANTHIHUONG"; String str2 = "NGUYENTRANG"; // 3 ; AYZ 
        System.out.println("Chuoi con chung dai nhat la: " + ChuoiConChungDaiNhat(str1, str2));
    }
    
    // THUẬT TOÁN CHIA ĐỂ TRỊ - Ảo hơn merge sort 
    // Chua xong 
    static int[] ChiaDeTri(int[] arr){
        int soPhanTu = 1;
        int n = arr.length;
        int[] arrnew = new int[n];
        while(soPhanTu <= n){
            int indexarrnew = 0;
            int a = 0;
            int b = soPhanTu;
            int sptgia = soPhanTu;
            while(sptgia < n){
                // Thay doi gia tri cua mang cho toi khi can moc tuong thu nhat 
                while(a < sptgia && b < sptgia*2){
                    if(arr[a] <= arr[b]){
                        arrnew[indexarrnew] = arr[a];
                        a++; indexarrnew++;
                    }else{
                        arrnew[indexarrnew] = arr[b];
                        b++; indexarrnew++;
                    }
                }
                // Thay doi gia tri cua mang cho toi khi can moc dich 
                while(a < sptgia){
                    arrnew[indexarrnew] = arr[a];
                    a++; indexarrnew++;                
                }
                while(b < sptgia){
                    arrnew[indexarrnew] = arr[b];
                    b++; indexarrnew++;                
                }
                a = sptgia*2;
                sptgia = sptgia*2;
                b += sptgia;                
            }
            soPhanTu = soPhanTu * 2;
        }
        return arrnew;
    }
    static void vd_chiaDeTri(){
        int[] arr = {4, 1, 6, 8, 3, 9, 2};
        int[] arrnew = ChiaDeTri(arr);
        System.out.print("Sxep tăng dần : ");
        for(int x : arrnew){
            System.out.print(x);
        }
    }
    
    // 
    int pow(int x, int n){ 
        if(n ==0) return 1;
        if(n % 2 ==0){
            int ans = pow(x, n/2);
            return ans*ans;
        }else{
            int ans = pow(x, (n-1)/2);
            return ans*ans*x;
        }
    }
    // Thuat toan dem so phan tu x trong 1 day so huu han (1 mang) theo chien thuat chia de tri 
//    static int demx;
    static int dem(int[] arr, int head, int tail , int x){
        if(tail > head){
            int n = (tail + head)/2;
            return dem(arr, head, n, x) + dem(arr, n+1, tail, x);
        }
        if(arr[head] == x){
            return 1;
        }
        return 0;
    }
    static void vd_dem(){
        int[] arr = {3, 6, 3, 5, 4, 8, -2};
        int head = 0 ;
        int tail = arr.length - 1;
        int x = 3;
        System.out.println("So luong "+x+" co trong mang la " + dem(arr, head, tail, x));
    }
    static int minCount(int k){
        if(k == 1){
            return 1;
        }
        if(k == 2){
            return 2;
        }
        int count = 2;
        int n = 2;
        while(n < k){
            System.out.println(" n = "+n);
            if(n*2 >= k){
                count++;
                n = n*2;
            }else{
                count++;
                n += 1;
            }
        }
        return count;
    }
    static void vd_minCount(){
        int k = 10;
        System.out.println("So luong phep tinh nho nhat la " + minCount(k));
    }
    static int khoangCach(int k){
        int[] arr = new int[k];
        arr[0] = 1; // 1
        arr[1] = 2; //2
        arr[2] = 4; //3
        for(int i = 3; i < k ; i++){
            arr[i] = arr[i-1] + arr[i-2] + arr[i-3];
        }
        return arr[k-1];
    }
    static void vd_khoangCach(){
        int k = 5;
        System.out.println("Khoang cach = " + khoangCach(k));
    }
}