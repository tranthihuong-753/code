package graph;

import java.util.ArrayDeque;
import java.util.Deque;
import java.util.HashSet;
import java.util.LinkedList;
import java.util.Queue;
import java.util.Set;
import java.util.Stack;

class myGraph{
    int V; //So luong dinh 
    char[] vertices; // Mang luu tru dinh 
    int[][] adjMatrix; // ma tran ke 
    
    // Khoi tao do thi voi V dinh va ma tran ke adjMatric
    public myGraph(int V, char[] vertices){
        this.V = V;
        this.vertices = vertices;
        adjMatrix = new int[V][V];
    }
    //Them mot canh vao do thi . Input : Nut bat dau, Nut ket thuc 
    void addEdge(char src, char dest){
        int srcIndex = getIndex(src);
        int desIndex = getIndex(dest);
        adjMatrix[srcIndex][desIndex] = 1;
    }
    //Ham tra ve vi tri cua nut trong hang/ cot 
    int getIndex(char x){
        for(int i = 0; i < vertices.length ; i++){
            if(x == (vertices[i])){
                return i;
            }
        }
        return -1;
    }
    // Hien thi ma tran ke cua do thi 
    void display(){
        System.out.print("   ");
        for(char vertex : vertices){
            System.out.print(vertex +"  ");
        }
        System.out.println();
        for(int i = 0; i < V ; i++){
            System.out.print(vertices[i] + "  ");
            for(int j = 0; j < V ; j++){
                System.out.print(adjMatrix[i][j] + "  ");
            }
            System.out.println();
        }
    }
//    // Duyet theo chieu rong. Input: nut bat dau 
//    String BFS(char src) {
//        
//    }
    // Duyệt theo chiều sâu chỉ trong một phương thức
    String DFS(char src) {
        // Tao mang visited 
        char[] visited = new char[V];
        // Tao queue
        Queue<Character> qu = new LinkedList<Character>();
        qu.add(src);
        for(int i = 0 ; i < V ; i++){
            char x = qu.poll();
            visited[i] = x;
            int index = getIndex(x);
            for(int j = 0 ; j < V ; j++){
                if(adjMatrix[index][j] == 1){
                    qu.add(vertices[j]);
                }
            }
        }
        String str = new String(visited);
        return str;
    }  
}
class minLength{
    int V; //So luong dinh 
    char[] vertices; // Mang luu tru dinh 
    int[][] adjMatrix; // ma tran ke 
    // Khoi tao do thi voi V dinh va ma tran ke adjMatric
    public minLength(int V, char[] vertices){
        this.V = V;
        this.vertices = vertices;
        adjMatrix = new int[V][V];
    }
    //Them mot canh vao do thi . Input : Nut bat dau, Nut ket thuc 
    void addEdge(char src, char dest){
        int srcIndex = getIndex(src);
        int desIndex = getIndex(dest);
        adjMatrix[srcIndex][desIndex] = 1;
    }
    //Ham tra ve vi tri cua nut trong hang/ cot 
    int getIndex(char x){
        for(int i = 0; i < vertices.length ; i++){
            if(x == (vertices[i])){
                return i;
            }
        }
        return -1;
    }
    // Hien thi ma tran ke cua do thi 
    void display(){
        System.out.print("   ");
        for(char vertex : vertices){
            System.out.print(vertex +"  ");
        }
        System.out.println();
        for(int i = 0; i < V ; i++){
            System.out.print(vertices[i] + "  ");
            for(int j = 0; j < V ; j++){
                System.out.print(adjMatrix[i][j] + "  ");
            }
            System.out.println();
        }
    }    

}