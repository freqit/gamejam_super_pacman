using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PacManGame
{
    //Nodes and their respective position in the A* Grid

    public class Node
    {
        public Vector2Int arrayIndex;
        public Vector2 worldPosition;
        public bool canWalk;
        public int gCost;
        public int hCost;

        public Node(Vector2Int idx, Vector2 pos, bool isBlocked)
        {
            arrayIndex = idx;
            worldPosition = pos;
            canWalk = isBlocked;
        }

        public int GetFCost { get { return gCost + hCost; } }
    }
}
