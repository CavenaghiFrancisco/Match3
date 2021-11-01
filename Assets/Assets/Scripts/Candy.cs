using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour
{

    private int x;
    private int y;

    public int X
    {
        get 
        { 
            return x; 
        }
        set 
        { 
            if (IsMovable())
            {
                x = value;
            }
        }
    }

    public int Y
    {
        get
        {
            return y;
        }
        set
        {
            if (IsMovable())
            {
                y = value;
            }
        }
    }

    private Grid.CANDY_TYPE type;

    public Grid.CANDY_TYPE Type
    {
        get 
        { 
            return type; 
        }
    }

    private Grid grid;

    public Grid GridRef
    {
        get 
        { 
            return grid; 
        }
    }

    private MovableCandy movableComponent;

    public MovableCandy MovableComponent
    {
        get 
        { 
            return movableComponent; 
        }
    }

    void Awake()
    {
        movableComponent = GetComponent<MovableCandy>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Init(int _x, int _y, Grid _grid, Grid.CANDY_TYPE _type)
    {
        x = _x;
        y = _y;
        grid = _grid;
        type = _type;
    }

    public bool IsMovable()
    {
        return movableComponent != null;
    }
}
