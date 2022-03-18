using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AStarAlgorithm
{
    	public class Node
	{
		public int GCost = 1;
		private int HCost;
		private int FCost;
		private string Name;
		private bool isStartNode;
		private Node Neighbour;


		public Node(string Name, bool isStartNode)
		{
			this.Name = Name;
			this.isStartNode = isStartNode;
		}

		public int getDistance()
		{
			return this.GCost;
		}

		public int DistanceFromStart()
		{

			this.GCost = this.Neighbour.getDistance() * 10;

		}

		public void SetNeighbour(Node n)
        {
			this.Neighbour = n;
        }
	}
    class Program
    {
        static void Main(string[] args)
        {
            Node A = new Node("A", true);
			Node B = new Node("B", false);
			Node C = new Node("B", false);
			B.SetNeighbour(A);
			C.SetNeighbour(B);

			Console.WriteLine(C.getDistance());
            
            Console.ReadKey();
        }
    }
}
