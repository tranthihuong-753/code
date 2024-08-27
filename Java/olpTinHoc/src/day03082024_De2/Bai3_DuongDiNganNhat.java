package day03082024_De2;

import java.util.Arrays;

public class Bai3_DuongDiNganNhat {
    public static void main(String[] args) {
        run_dijkstra();
    }
    // Hàm tìm đường đi ngắn nhất từ đỉnh head đến đỉnh tail trong đồ thị
    static int dijkstra(int[][] graph, int head, int tail) {
        int n = graph.length; // số cạnh 
        int[] dist = new int[n]; // trọng số 
        boolean[] check = new boolean[n]; 

        // Khởi tạo khoảng cách
        Arrays.fill(dist, Integer.MAX_VALUE); //dist[] = bằng vô cực
        dist[head] = 0; //khoảng cách từ đỉnh bắt đầu đến chính nó bằng 0
        for (int i = 0; i < n; i++) {
            // Tìm đỉnh có khoảng cách ngắn nhất chưa được xử lý
            int u = findMinDistance(dist, check, n);
            // Nếu đỉnh có khoảng cách ngắn nhất là đỉnh đích, trả về khoảng cách
            if (u == tail){
                return dist[u];
            }
            // Đánh dấu đỉnh đã được xử lý
            check[u] = true;
            // Cập nhật khoảng cách đến các đỉnh lân cận
            for (int v = 0; v < n; v++) {
                if (!check[v] && graph[u][v] != 0) {
                    int newDist = dist[u] + graph[u][v];
                    if (newDist < dist[v]) {
                        dist[v] = newDist;
                    }
                }
            }
        }
        return -1; 
    }

    // Hàm tìm đỉnh có khoảng cách ngắn nhất chưa được xử lý
    static int findMinDistance(int[] dist, boolean[] visited, int n) {
        int min = Integer.MAX_VALUE;
        int minIndex = -1;
        for (int i = 0; i < n; i++) {
            if (!visited[i] && dist[i] < min) {
                min = dist[i];
                minIndex = i;
            }
        }
        return minIndex;
    }
    static void run_dijkstra(){
        int[][] graph = {
            {0, 7, 9, 0, 0, 14},
            {7, 0, 10, 15, 0, 0},
            {9, 10, 0, 11, 0, 2},
            {0, 15, 11, 0, 6, 0},
            {0, 0, 0, 6, 0, 9},
            {14, 0, 2, 0, 9, 0}
        };

        int start = 0; // Đỉnh bắt đầu
        int end = 4;   // Đỉnh đích

        int shortestPath = dijkstra(graph, start, end);
        if (shortestPath == -1) {
            System.out.println("Không có đường đi từ đỉnh " + start + " đến đỉnh " + end);
        } else {
            System.out.println("Đường đi ngắn nhất từ đỉnh " + start + " đến đỉnh " + end + " là: " + shortestPath);
        }        
    }
}
