using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PacManGame
{
    public class A_Star : MonoBehaviour
    {
        public Grid grid = new Grid();

        public void CalculatePath(Node startNode, Node endNode)
        {
            List<Node> openList = new List<Node>();
            List<Node> closedList = new List<Node();

            openList.Add(startNode);
        }
    }
}
