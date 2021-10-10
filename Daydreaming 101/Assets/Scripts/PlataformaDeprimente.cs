using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaDeprimente : MonoBehaviour
{

    public Mechanics universe;
    public BoxCollider2D Collider;
    public SpriteRenderer Sprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (universe._mundoActual == Mechanics.MundoActual.MundoFantastico)
        {
            Collider.enabled = false;
            Sprite.enabled = false;
        }
        if (universe._mundoActual == Mechanics.MundoActual.MundoDeprimente)
        {
            Collider.enabled = true;
            Sprite.enabled = true;
        }
    }
}
