/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ThuatToanCoBan;

import java.util.Arrays;
import java.util.Comparator;

/**
 *
 * @author dhhuo
 */
public class Kruskal_TimCayKhungCucTieu {
    public static void main(String[] args) {
        run_();
    }
    // Hàm kiểm tra xem việc thêm cạnh có tạo thành chu trình hay không
    static boolean isCycle(int[][] adjMatrix, int[] parent, int u, int v) {
        for (int i = 0; i < adjMatrix.length; i++) {
            if (adjMatrix[u][i] != 0 && adjMatrix[v][i] != 0) {
                if (parent[i] != -1 && (parent[i] == u || parent[i] == v)) {
                    return true;
                }
            }
        }
        return false;
    }

    // Hàm thực hiện thuật toán Kruskal và trả về mảng trọng số của các cạnh trong MST
    public static int[] kruskal(int[][] arr) {
        int V = 0;
        for (int[] edge : arr) {
            V = Math.max(V, Math.max(edge[0], edge[1]) + 1); // Tính số lượng đỉnh
        }

        // Chuyển mảng 2 chiều thành mảng cạnh với trọng số
        int[][] edges = new int[arr.length][3];
        for (int i = 0; i < arr.length; i++) {
            edges[i] = arr[i];
        }

        // Sắp xếp tất cả các cạnh theo trọng số tăng dần
        Arrays.sort(edges, Comparator.comparingInt(edge -> edge[2]));

        // Tạo ma trận kề để kiểm tra chu trình
        int[][] adjMatrix = new int[V][V];
        for (int[] edge : edges) {
            adjMatrix[edge[0]][edge[1]] = edge[2];
            adjMatrix[edge[1]][edge[0]] = edge[2];
        }

        // Tạo mảng để lưu trữ các cạnh của MST
        int[] mstWeights = new int[V - 1];
        int e = 0; // Chỉ số cho MST
        int[] parent = new int[V];
        Arrays.fill(parent, -1); // Khởi tạo mảng parent

        for (int i = 0; i < edges.length && e < V - 1; i++) {
            int[] edge = edges[i];
            int u = edge[0];
            int v = edge[1];

            // Kiểm tra xem việc thêm cạnh có tạo thành chu trình hay không
            if (!isCycle(adjMatrix, parent, u, v)) {
                mstWeights[e++] = edge[2];
                parent[u] = v; // Đánh dấu đỉnh u là cha của đỉnh v
            }
        }

        // Cắt mảng MST theo kích thước thực tế
        return Arrays.copyOf(mstWeights, e);
    }
    static void run_(){
        // Mảng 2 chiều với định dạng [đỉnh 1, đỉnh 2, trọng số]
        int[][] arr = {
            {0, 1, 4},
            {0, 2, 1},
            {1, 2, 2},
            {1, 3, 5},
            {2, 3, 8},
            {2, 4, 10},
            {3, 4, 2}
        };

        int[] mstWeights = kruskal(arr);
        System.out.println("Trọng số của các cạnh trong cây khung nhỏ nhất (MST) là:");
        for (int weight : mstWeights) {
            System.out.println(weight);
        }
    }
}
