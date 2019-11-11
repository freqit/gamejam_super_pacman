using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PacManGame
{
    public class Grid : MonoBehaviour
    {
        int gridSizeX, gridSizeY;
        float nodeSpacing;

        public Node[,] grid;

        Vector2Int[] directions = new Vector2Int[] 
        {
            new Vector2Int(0,1),
            new Vector2Int(1,0),
            new Vector2Int(0,-1),
            new Vector2Int(-1,0)
        };

        private void Awake()
        {
            
        }

        public void CreateGrid(int sizeX, int sizeY, float spacing)
        {
            grid = new Node[sizeX, sizeY];
            gridSizeX = sizeX;
            gridSizeY = sizeY;
            nodeSpacing = spacing;

            for(int x = 0; x < gridSizeX; x++)
            {
                for(int y = 0; y < gridSizeY; y++)
                {
                    grid[x, y] = new Node(new Vector2Int(x, y), new Vector2(x * nodeSpacing, y * nodeSpacing), false);
                    print(grid[x, y].arrayIndex);
                }
            }
        }

        public List<Node> GetNeighborNodes(Node thisNode)
        {
            List<Node> neighbors = new List<Node>();

            foreach(var DIR in directions)
            {
                int X = thisNode.arrayIndex.x + DIR.x;
                int Y = thisNode.arrayIndex.y + DIR.y;

                if(X >= 0 && X < gridSizeX && Y >= 0 && Y < gridSizeY)
                {
                    neighbors.Add(grid[X, Y]);
                }
            }

            return neighbors;
        }

        public int Heuristic(Node pos1, Node pos2)
        {
            int X = Mathf.RoundToInt(Mathf.Abs(pos1.worldPosition.x - pos2.worldPosition.x));
            int Y = Mathf.RoundToInt(Mathf.Abs(pos1.worldPosition.y - pos2.worldPosition.y));

            if (X > Y)
                return 14 * Y + 10 * (X - Y);
            return 14 * X + 10 * (Y - X);
        }
    }
}