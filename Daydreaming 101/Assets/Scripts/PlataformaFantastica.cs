using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaFantastica : MonoBehaviour
{
    public Mechanics universe;
    public BoxCollider2D Collider;
    public SpriteRenderer Sprite;
    public Rigidbody2D rbd;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (universe._mundoActual == Mechanics.MundoActual.MundoFantastico)
        {
            Collider.enabled = true;
            Sprite.enabled = true;
            rbd.simulated = true;
        }
        if (universe._mundoActual == Mechanics.MundoActual.MundoDeprimente)
        {
            Collider.enabled = false;
            Sprite.enabled = false;
            rbd.simulated = false;
        }
    }
}
