using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : MonoBehaviour
{

    [SerializeField] GameObject leftWing;
    [SerializeField] GameObject rightWing;


    private void Awake()
    {
        BeAnt();
    }

    private void FixedUpdate()
    {
        BeAnt();
    }

    private void BeAnt()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector3.forward, Mathf.Infinity);

        if (hit.collider != null)
        {
            Debug.Log("Lesss go!");
            GameObject cellUnder = hit.collider.gameObject;
            SpriteRenderer cellRender = cellUnder.GetComponent<SpriteRenderer>();
            if (cellRender.color == Color.white) //cell is "alive"
            {
                cellRender.color = Color.black;
                transform.position = rightWing.transform.position;
                transform.eulerAngles = Vector3.forward * -90;
                float tmp = 0;


                
            }
            if (cellRender.color == Color.black) //cell is "dead"
            {
                cellRender.color = Color.white;
                transform.position = leftWing.transform.position;
                transform.eulerAngles = Vector3.forward * 90;
                float tmp = 0;


            }
        }
        else
        {
            Debug.Log("Panie, nic tam nie ma!");
        }
        
    }

}
