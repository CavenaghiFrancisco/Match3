using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Grid : MonoBehaviour
{
    public enum PIECE_TYPE
    {
        NORMAL,
        COUNT
    }

    [SerializeField] private int xSize;
    [SerializeField] private int ySize;

    [System.Serializable]
    public struct PiecePrefab
    {
        public PIECE_TYPE type;
        public GameObject prefab;
    }

    public PiecePrefab[] piecePrefabs;
    public GameObject backgroundPrefab;

    private Dictionary<PIECE_TYPE, GameObject> piecePrefabDict;

    // Start is called before the first frame update
    void Start()
    {
        piecePrefabDict = new Dictionary<PIECE_TYPE, GameObject>();
        for(int i = 0; i < piecePrefabs.Length; i++)
        {
            if (!piecePrefabDict.ContainsKey(piecePrefabs[i].type))
            {
                piecePrefabDict.Add(piecePrefabs[i].type, piecePrefabs[i].prefab);
            }
        }

        for(int x = 0; x < xSize; x++) 
        {
            for(int y = 0; y < ySize; y++)
            {
                GameObject background = (GameObject)Instantiate(backgroundPrefab, new Vector3(x, y, 0), Quaternion.identity);
                background.transform.parent = transform;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
