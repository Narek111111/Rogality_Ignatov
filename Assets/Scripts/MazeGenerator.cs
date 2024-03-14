using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MazeGenerator : MonoBehaviour
{
    public int mazeWidth;
    public int mazeHeight;
    public GameObject wallPrefab;
    private Vector2Int[,] maze;
    private List<Vector2Int> freePositions;

    // Start is called before the first frame update
    void Start()
    {
        maze = new Vector2Int[mazeWidth, mazeHeight];
        freePositions = new List<Vector2Int>();

        for (int x = 0; x < mazeWidth; x++)
        {
            for (int y = 0; y < mazeHeight; y++)
            {
                maze[x, y] = new Vector2Int(x, y);
                freePositions.Add(new Vector2Int(x, y));
            }
        }
        GenerateMaze();
    }

    void GenerateMaze()
    {
        while (freePositions.Count > 1)
        {
            Vector2Int position1 = freePositions[Random.Range(0, freePositions.Count)];
            Vector2Int position2 = freePositions[Random.Range(0, freePositions.Count)];

            FreePosition(position1);
            FreePosition(position2);

            AddWall(position1, position2);
        }
    }

    void FreePosition(Vector2Int position)
    {
        int x = position.x;
        int y = position.y;

        if (x < 0 || y < 0 || x >= mazeWidth || y >= mazeHeight)
        {
            return;
        }

        freePositions.Remove(position);
    }

    void AddWall(Vector2Int start, Vector2Int end)
    {
        GameObject wall = Instantiate(wallPrefab, transform);
        wall.transform.position = new Vector3(start.x, /*0,*/ start.y);
        //Destroy(wall.gameObject, 5f);
    }
}