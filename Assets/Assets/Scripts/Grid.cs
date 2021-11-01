using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Grid : MonoBehaviour
{
    public enum CANDY_TYPE
    {
        NORMAL,
        COUNT
    }

    [SerializeField] private int xSize;
    [SerializeField] private int ySize;

    [System.Serializable]
    public struct candyPrefab
    {
        public CANDY_TYPE type;
        public GameObject prefab;
    }

    public candyPrefab[] candyPrefabs;
    public GameObject backgroundPrefab;

    private Dictionary<CANDY_TYPE, GameObject> candyPrefabDict;

    private Candy[,] candies;

    // Start is called before the first frame update
    void Start()
    {
        candyPrefabDict = new Dictionary<CANDY_TYPE, GameObject>();
        for(int i = 0; i < candyPrefabs.Length; i++)
        {
            if (!candyPrefabDict.ContainsKey(candyPrefabs[i].type))
            {
                candyPrefabDict.Add(candyPrefabs[i].type, candyPrefabs[i].prefab);
            }
        }

        for(int x = 0; x < xSize; x++) 
        {
            for(int y = 0; y < ySize; y++)
            {
                GameObject background = (GameObject)Instantiate(backgroundPrefab, GetWorldPosition(x,y,0), Quaternion.identity);
                background.transform.parent = transform;
            }
        }

        candies = new Candy[xSize, ySize];

        for (int x = 0; x < xSize; x++)
        {
            for (int y = 0; y < ySize; y++)
            {
                GameObject newCandy = (GameObject)Instantiate(candyPrefabDict[CANDY_TYPE.NORMAL], Vector3.zero, Quaternion.identity);
                newCandy.name = "Candy(" + x + ", " + y + ")";
                newCandy.transform.parent = transform;

                candies[x, y] = newCandy.GetComponent<Candy>();
                candies[x, y].Init(x, y, this, CANDY_TYPE.NORMAL);

                if (candies[x, y].IsMovable())
                {
                    candies[x, y].MovableComponent.Move(x, y);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3 GetWorldPosition(int x, int y, int z)
    {
        return new Vector3(transform.position.x - xSize / 2.0f + x+ 0.5f, transform.position.y + ySize / 2.0f - y-0.5f,z);
    }
}
