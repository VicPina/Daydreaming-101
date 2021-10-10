using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaFantastica : MonoBehaviour
{
    public Mechanics universe;
    public BoxCollider2D Collider;
    public SpriteRenderer Sprite;
    public Rigidbody2D rbd;
    bool notRbd =false;


    // Start is called before the first frame update
    void Start()
    {
        if (rbd = null)
        {
            notRbd = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (universe._mundoActual == Mechanics.MundoActual.MundoFantastico)
        {
            Collider.enabled = true;
            Sprite.enabled = true;
            if(notRbd)
                rbd.simulated = true;
        }
        if (universe._mundoActual == Mechanics.MundoActual.MundoDeprimente)
        {
            Collider.enabled = false;
            Sprite.enabled = false;
            if (notRbd)
                rbd.simulated = false;
        }
    }
}
