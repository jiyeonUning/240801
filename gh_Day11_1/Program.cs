namespace gh_Day11_1
{
    /* 과제. 그래프 구현하기
       다음의 아래의 과정을 수행하여 그래프를 구현하시오.

       제공되는 URL 페이지를 통해서 그래프를 확인하고 스크린샷으로 저장하시오.
       기본학습 내용을 참고하여 그래프를 구현하고, 스크린샷 상황의 그래프를 구현한 코드에 추가하시오.
     */


    public class Program
    {
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


        public class MatrixGraph : Graph
        {
            private bool[,] graph;

            public MatrixGraph(int vertex) : base(vertex)
            {
                graph = new bool[vertex, vertex];
            }

            public override void Connect(int from, int to)
            {
                graph[from, to] = true;
            }

            public override void DisConnect(int from, int to)
            {
                graph[from, to] = false;
            }

            public override bool IsConnect(int from, int to)
            {
                return graph[from, to];
            }
        }


        static void Main()
        {
            Graph graph = new MatrixGraph(8);

            graph.Connect(0, 1);
            graph.Connect(0, 2);
            graph.Connect(1, 3);
            graph.Connect(1, 5);
            graph.Connect(2, 0);
            graph.Connect(2, 7);
            graph.Connect(3, 7);
            graph.Connect(4, 6);
            graph.Connect(5, 7);
            graph.Connect(6, 4);

            graph.DisConnect(0, 3);
            graph.DisConnect(0, 4);
            graph.DisConnect(0, 5);
            graph.DisConnect(0, 6);
            graph.DisConnect(0, 7);
            graph.DisConnect(1, 0);
            graph.DisConnect(1, 2);
            graph.DisConnect(1, 4);
            graph.DisConnect(1, 6);
            graph.DisConnect(1, 7);
            graph.DisConnect(2, 1);
            graph.DisConnect(2, 3);
            graph.DisConnect(2, 4);
            graph.DisConnect(2, 5);
            graph.DisConnect(2, 6);
            graph.DisConnect(2, 7);
            graph.DisConnect(3, 0);
            graph.DisConnect(3, 1);
            graph.DisConnect(3, 2);
            graph.DisConnect(3, 4);
            graph.DisConnect(3, 5);
            graph.DisConnect(3, 6);
            graph.DisConnect(4, 0);
            graph.DisConnect(4, 1);
            graph.DisConnect(4, 2);
            graph.DisConnect(4, 3);
            graph.DisConnect(4, 5);
            graph.DisConnect(4, 7);
            graph.DisConnect(5, 0);
            graph.DisConnect(5, 1);
            graph.DisConnect(5, 2);
            graph.DisConnect(5, 3);
            graph.DisConnect(5, 4);
            graph.DisConnect(5, 6);
            graph.DisConnect(6, 0);
            graph.DisConnect(6, 1);
            graph.DisConnect(6, 2);
            graph.DisConnect(6, 3);
            graph.DisConnect(6, 5);
            graph.DisConnect(6, 7);
            graph.DisConnect(7, 0);
            graph.DisConnect(7, 1);
            graph.DisConnect(7, 2);
            graph.DisConnect(7, 3);
            graph.DisConnect(7, 4);
            graph.DisConnect(7, 5);
            graph.DisConnect(7, 6);

            for (int from = 0; from < 8; from++)
            {
                Console.WriteLine($"{from} 정점 : ");

                for (int to = 0; to < 8; to++)
                {
                    if (graph.IsConnect(from, to))
                    {
                        Console.WriteLine($" {to} 정점");
                    }
                }
                Console.WriteLine();
            }

        }
    }

}

