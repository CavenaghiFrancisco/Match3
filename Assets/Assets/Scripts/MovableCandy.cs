using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableCandy : MonoBehaviour
{
    private Candy candy;

    void Awake()
    {
        candy = GetComponent<Candy>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(int newX, int newY)
    {
        candy.X = newX;
        candy.Y = newY;

        candy.transform.localPosition = candy.GridRef.GetWorldPosition(newX, newY, -1);
    }
}
