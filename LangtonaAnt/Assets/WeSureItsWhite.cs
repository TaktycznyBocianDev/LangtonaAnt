using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeSureItsWhite : MonoBehaviour
{
    private void Awake()
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.white;
    }
}
