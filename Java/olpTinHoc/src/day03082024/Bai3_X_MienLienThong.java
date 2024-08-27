package day03082024;

import java.util.Stack;

public class Bai3_X_MienLienThong {
    public static void main(String[] args) {
        run2_MienLienThong_DFS();
    }
    static int MienLienThong_DFS(char[][] arredge, char[] arrDinh, char head) {
        int n = arrDinh.length;
        Stack<Character> st = new Stack<>();
        boolean[] check = new boolean[n]; // KT xem các đỉnh đã được duyệt qua chưa 
        int count = 0; // đếm số miền 
        
        // chuẩn bị cho while 
        st.add(head);
        int indexdinh = index(arrDinh, head);
        check[indexdinh] = true;

        while (!st.isEmpty()) { // stack không rỗng 
            char x = st.pop();
            indexdinh = index(arrDinh, x);
            
            // Duyệt tất cả các đỉnh liên thông với đỉnh hiện tại
            for (int i = 0; i < n; i++) {
                if (arredge[indexdinh][i] == '1' && !check[i]) {
                    st.add(arrDinh[i]);
                    check[i] = true;
                }
            }

            // Kiểm tra và thêm các đỉnh chưa được thăm vào stack
            if (st.isEmpty()) { // stack rỗng 
                ++count;
                for (int i = 0; i < n; i++) {
                    if (!check[i]) {
                        st.add(arrDinh[i]);
                        check[i] = true;
                        break;
                    }
                }
            }
        }

        return count;
    }
    // Ham kiem tra boolean[] check full true  
    static boolean ch (boolean[] arr){
        for(int i = 0 ; i < arr.length ; i++){
            if(arr[i] != true){
                return false;
            }
        }
        return true;
    }
    // Ham kiem tra xem canh co thuoc do thi khong
    // Input : dinh dau, Output : dinh sau
    static boolean ch(char d1, char d2, char[][] arredge){
        int n = arredge.length;
        for(int i = 0 ; i < n ; i++){
            if(arredge[i][0] == d1 && arredge[i][1] == d2){
                return true;
            }
            if(arredge[i][1] == d1 && arredge[i][0] == d2){
                return true;
            }            
        }
        return false;
    }
    // Ham lay index cua mot dinh
    static int index(char[] arrDinh, char dinh){
        for(int i= 0 ; i < arrDinh.length ; i++){
            if(arrDinh[i] == dinh){
                return i;
            }
        }
        return -1;
    }
    static void run1_MienLienThong_DFS(){
        char[] arrDinh = {'A', 'B', 'C', 'D'};
        char[][] arredge = {
            {'0', '1', '0', '0'}, // A
            {'1', '0', '1', '0'}, // B
            {'0', '1', '0', '1'}, // C
            {'0', '0', '1', '0'}  // D
        };
        int out = MienLienThong_DFS(arredge, arrDinh, 'A'); // 1 
        System.out.println("MienLienThong = " + out);
    }
    static void run2_MienLienThong_DFS(){
        char[] arrDinh = {'A', 'B', 'C', 'D'};
        char[][] arredge = {
            {'0', '1', '0', '0'}, // A
            {'1', '0', '0', '0'}, // B
            {'0', '0', '0', '1'}, // C
            {'0', '0', '1', '0'}  // D
        };

        int out = MienLienThong_DFS(arredge, arrDinh, 'A'); // 1 
        System.out.println("MienLienThong = " + out);
    }
}
