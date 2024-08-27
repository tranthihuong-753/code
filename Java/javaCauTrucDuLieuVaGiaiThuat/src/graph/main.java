package graph;

public class main {
    public static void main(String[] args) {
        char[] vertices = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'S'};
        myGraph g = new myGraph(vertices.length, vertices);
        g.addEdge('A', 'B');
        g.addEdge('A', 'S');
        g.addEdge('S', 'C');
        g.addEdge('S', 'G');
        g.addEdge('C', 'D');
        g.addEdge('E', 'C');
        g.addEdge('F', 'C');
        g.addEdge('G', 'F');
        g.addEdge('H', 'G');
        g.addEdge('H', 'E');
        System.out.println(g.DFS('A'));
//        g.display();
    }
}
