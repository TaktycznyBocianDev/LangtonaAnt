using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceMaker : MonoBehaviour
{
    [Header("How wide and hight should be our space?")]
    [SerializeField] int cellNumber;
    
    [Header("Cell prefab")]
    [SerializeField] GameObject cell;

    [Header("Ant for testing")]
    [SerializeField] GameObject ant;

    private static Vector3 middlePoint;
    public static Vector3 GetMiddlePoint()
    {
        return middlePoint;
    }
    

    private void Start()
    {
        MakeSpace();
    }

    public void MakeSpace()
    {
        for (int x = 0; x < cellNumber; x++)
        {
            for (int y = 0; y < cellNumber; y++)
            {
                GameObject gridCell = Instantiate(cell);
                gridCell.transform.position = new Vector3(x, y, 0f);

                if (x == cellNumber/2 && y == cellNumber/2)
                {
                    middlePoint = gridCell.transform.position;
                }
            }
        }

        ant.transform.position = new Vector3(middlePoint.x, middlePoint.y, 0);
        ant.SetActive(true);
    }

}
