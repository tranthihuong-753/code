package DoThi;

import java.util.LinkedList;
import java.util.Queue;
import java.util.Stack;

public class graph {
    public static void main(String[] args) {
        run_BFS();
    }
    static int N; // so dinh 
    static char[] arrDinh;
    static int[][] arrMaTranKe;
    // Khoi tao do thi voi V dinh va ma tran ke arrMaTranKe
    public graph(int n, char[] arrdinh){
        this.N = n;
        this.arrDinh = arrdinh;
        arrMaTranKe = new int[N][N];
    }
    // Ham hien thi ma tran ke
    static void showMaTranKe(){
        System.out.print(" ");
        for(int i = 0 ; i < N ; i++){
            System.out.print(" "+arrDinh[i]);
        }
        for(int i = 0 ; i < N ; i++){
            System.out.println("");
            System.out.print(arrDinh[i]);
            for(int j = 0 ; j < N ; j++){
                System.out.print(" "+arrMaTranKe[i][j]);
            }
        }
        System.out.println("");
    }
    //Them mot canh vao do thi
    static void addEdge(char head, char tail){
        int i = index(head);
        int j = index(tail);
        arrMaTranKe[i][j] = 1;
        arrMaTranKe[j][i] = 1;
    }
    //Ham tra ve vi tri cua nut trong hang/ cot 
    static int index(char x){
        for(int i = 0 ; i < N ; i++){
            if(arrDinh[i] == x){
                return i;
            }
        }
        return -1;
    }
    //Ham duyet do thi theo chieu rong
    static char[] BFS(char head) {
        char[] arrout = new char[N];
        Queue<Character> qu = new LinkedList<>();
        boolean[] boolcheck = new boolean[N];
        
        qu.add(head);
        int index_boolcheck = index(head);
        boolcheck[index_boolcheck] = true;
        
        int index_arrout = 0; // index cho arrout 
        
        while (index_arrout != N) {
            if(qu != null){
                char x = qu.poll();
                arrout[index_arrout++] = x;
                int index_x = index(x);
                // Them phan tu lien quan toi x vao qu 
                // trong MaTranKe = 1 && booleancheck != true (khong ton tai trong arrout[] va khong ton tai trong qu)
                for(int i = 0 ; i < N ; i++){
                    if(arrMaTranKe[index_x][i] == 1 && boolcheck[i] != true){
                        qu.add(arrDinh[i]);
                        boolcheck[i] = true;
                    }
                }
                continue;
            }
            // Duyet lay cac dinh -> booleancheck != true (khong ton tai trong arrout[] va khong ton tai trong qu)
            for(int i = 0 ; i < N ; i++){
                if(boolcheck[i] != true){
                    qu.add(arrDinh[i]);
                    boolcheck[i] = true;
                    break;
                }
            }    
        }
        return arrout;
    }
    // Hàm kiểm tra xem 2 dinh dau vao co la canh hay khong 
    static boolean check(char a, char b) {
        int i = index(a);
        int j = index(b);
        if(arrMaTranKe[i][j] == 1){
            return true;
        }
        return false;
    }
    static void run_BFS(){
        char[] Dinh = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H'};
        int soDinh = Dinh.length;
        graph g = new graph(soDinh, Dinh);
        g.addEdge('A', 'G');
        g.addEdge('A', 'H');
        g.addEdge('A', 'F');
        g.addEdge('F', 'G');
        g.addEdge('B', 'G');
        g.addEdge('F', 'B');
        g.addEdge('B', 'E');
        g.addEdge('E', 'F');
        g.addEdge('F', 'D');
        g.addEdge('D', 'C');
        g.addEdge('H', 'C');
        g.showMaTranKe();
        char[] arr = BFS('A'); // A F G H B D E C  
        System.out.print("Duyet theo chieu rong do thi la : ");
        for(char x : arr){
            System.out.print(" "+x);
        }
    }
//    //Ham duyet do thi theo chieu sau 
//    static char[] DFS(char head) {
//        char[] arrout = new char[N];
//        Stack<Character> st = new Stack<>();
//        
//        st.push(head);
//        int index = 0;
//
//        while (!st.isEmpty()) {
//            char x = st.pop();
//            if(!check(arrout, x)){
//                arrout[index++] = x;
//                System.out.println("i = "+index+" arr = "+x);
//                for (int i = N-1; i >= 0 ; i--) {
//                    char y = arrDinh[i];
//                    if (!check(arrout, y)) {
//                        st.add(y);
//                    }
//                }
//            }
//        }
//        return arrout;
//    }
//
//    static void run_DFS(){
////        char[] Dinh = {'A', 'B', 'C', 'D'};
//        char[] Dinh = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'S'};
//        int soDinh = Dinh.length;
//        graph g = new graph(soDinh, Dinh);
//        g.addEdge('A', 'B');
//        g.addEdge('A', 'S');
//        g.addEdge('S', 'C');
//        g.addEdge('S', 'G');
//        g.addEdge('C', 'D');
//        g.addEdge('E', 'C');
//        g.addEdge('F', 'C');
//        g.addEdge('G', 'F');
//        g.addEdge('H', 'G');
//        g.addEdge('H', 'E');
//        g.showMaTranKe();
//        char[] arr = DFS('A'); // A B S C D E H G F
//        System.out.print("Duyet theo chieu sau do thi la : ");
//        for(char x : arr){
//            System.out.print(" "+x);
//        }        
//    }
}
