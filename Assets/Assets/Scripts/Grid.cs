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

    private Dictionary<PIECE_TYPE, GameObject> piecePrefabDict;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
