using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPull : MonoBehaviour
{

    public bool empujado;
    float posicionX;

    void Start()
    {
        posicionX = transform.position.x;
    }

    
    void Update()
    {
        if (empujado == false)
        {
            transform.position = new Vector3(posicionX, transform.position.y);
        }
        else
        {
            posicionX = transform.position.x;
        }
    }
}
