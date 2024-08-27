package ThuatToanCoBan;

import java.util.Arrays;

public class Dijkstra_TimDuongDiNganNhatTrongDoThi {
    public static void main(String[] args) {
        run_();
    }
    public static int dijkstra(int[][] arr, int startVertex, int endVertex) {
        int vertices = arr.length;
        int[] distances = new int[vertices];
        boolean[] shortestPathTreeSet = new boolean[vertices];
        int[] predecessors = new int[vertices];

        Arrays.fill(distances, Integer.MAX_VALUE);
        Arrays.fill(predecessors, -1);
        distances[startVertex] = 0;

        for (int count = 0; count < vertices - 1; count++) {
            int u = minDistance(distances, shortestPathTreeSet);
            shortestPathTreeSet[u] = true;

            for (int i = 0; i < arr.length; i++) {
                int vertex1 = arr[i][0];
                int vertex2 = arr[i][1];
                int weight = arr[i][2];

                if (vertex1 == u && !shortestPathTreeSet[vertex2] && distances[u] != Integer.MAX_VALUE &&
                    distances[u] + weight < distances[vertex2]) {
                    distances[vertex2] = distances[u] + weight;
                    predecessors[vertex2] = u;
                }
            }
        }

//        printPath(predecessors, startVertex, endVertex);
//        System.out.println("Khoảng cách từ đỉnh " + startVertex + " đến đỉnh " + endVertex + " là " + distances[endVertex]);
        return distances[endVertex];
    }

    private static int minDistance(int[] distances, boolean[] shortestPathTreeSet) {
        int min = Integer.MAX_VALUE;
        int minIndex = -1;

        for (int v = 0; v < distances.length; v++) {
            if (!shortestPathTreeSet[v] && distances[v] <= min) {
                min = distances[v];
                minIndex = v;
            }
        }
        return minIndex;
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

        int x =dijkstra(arr, 0, 3); // Bắt đầu từ đỉnh 0
        
        System.out.println("KC = " + x);
    }
}