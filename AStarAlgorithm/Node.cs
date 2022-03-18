using System;
using AStarAlgorithm;

namespace AStarAlgorithm
{
	public class Nodes
	{
		private int GCost = 1;
		private int HCost;
		private int FCost;
		private string Name;
		private bool isStartNode;
		private Nodes Neighbour;


		public Nodes(string Name, Node Neighbour)
		{
			this.Name = Name;
			this.Neighbour = Neighbour;
			this.GCost = this.DistanceFromStart();
		}

		public int getDistance()
		{
			return this.GCost;
		}

		public void DistanceFromStart()
		{
			if (this.isStartNode)
			{
				this.GCost = 0;
			}
			else
			{
				this.GCost = Neighbour.getDistance() * 10;
			}

		}
	}

}


