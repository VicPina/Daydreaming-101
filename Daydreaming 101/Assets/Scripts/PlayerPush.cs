using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPush : MonoBehaviour
{
    public float distancia = 1f;
    public LayerMask boxMask;
    public GameObject playerCheck;
    GameObject box;

    void Start()
    {
        
    }

    void Update()
    {
        Physics2D.queriesStartInColliders = false;
        RaycastHit2D hit = Physics2D.Raycast(playerCheck.transform.position, Vector2.right * transform.localScale.x, distancia, boxMask);
        Debug.DrawRay(playerCheck.transform.position, Vector2.right * transform.localScale.x * distancia, Color.red);

        if (hit.collider != null && hit.collider.gameObject.tag == "Pusheable" && Input.GetButtonDown("Interactuable"))
        {
            box = hit.collider.gameObject;
            box.GetComponent<FixedJoint2D>().enabled = true;
            box.GetComponent<BoxPull>().empujado = true;
            box.GetComponent<FixedJoint2D>().connectedBody = this.GetComponent<Rigidbody2D>();
        }
        else if (Input.GetButtonUp("Interactuable"))
        {
            box.GetComponent<FixedJoint2D>().enabled = false;
            box.GetComponent<BoxPull>().empujado = false;
        }
    }

   
}
