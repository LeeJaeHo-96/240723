namespace levelTest4
{
    internal class Program
    {
        static void Main(string[] args)
        {















            Graph graph = new ListGraph(8);


            graph.Connect(0, 2);
            graph.Connect(0, 4);

            graph.Connect(1, 2);
            graph.Connect(1, 3);
            graph.Connect(1, 5);

            graph.Connect(2, 0);
            graph.Connect(2, 1);
            graph.Connect(2, 4);
            graph.Connect(2, 5);
            graph.Connect(2, 6);

            graph.Connect(3, 1);
            graph.Connect(3, 5);
            graph.Connect(3, 7);

            graph.Connect(4, 0);
            graph.Connect(4, 2);
            graph.Connect(4, 6);
            graph.Connect(4, 7);

            graph.Connect(5, 1);
            graph.Connect(5, 2);
            graph.Connect(5, 3);
            graph.Connect(5, 6);

            graph.Connect(6, 2);
            graph.Connect(6, 4);
            graph.Connect(6, 5);
            graph.Connect(6, 7);

            graph.Connect(7, 3);
            graph.Connect(7, 4);
            graph.Connect(7, 6);

            for (int from = 0; from < 8; from++)
            {
                Console.WriteLine($"현재 위치: {from}");
                for (int to = 0; to < 8; to++)
                {
                    if (graph.IsConnect(from, to))
                    {
                        Console.WriteLine($" 이동 가능한 장소 : {to}");
                    }

                }


            }
        }
        public abstract class Graph
        {
            public int VertexCount { get; protected set; }

            public Graph(int vertex)
            {
                VertexCount = vertex;
            }

            public abstract void Connect(int from, int to);
            public abstract void DisConnect(int from, int to);
            public abstract bool IsConnect(int from, int to);
        }


        public class ListGraph : Graph
        {
            private List<int>[] graph;

            public ListGraph(int vertex) : base(vertex)
            {
                graph = new List<int>[vertex];
                for (int i = 0; i < vertex; i++)
                {
                    graph[i] = new List<int>();
                }
            }

            public override void Connect(int from, int to)
            {
                graph[from].Add(to);
            }

            public override void DisConnect(int from, int to)
            {
                graph[from].Remove(to);
            }

            public override bool IsConnect(int from, int to)
            {
                return graph[from].Contains(to);
            }
        }
    }
}
