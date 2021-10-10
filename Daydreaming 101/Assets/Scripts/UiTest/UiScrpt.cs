using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiScrpt : MonoBehaviour
{
    private TestMov thePlayer;
    public SpriteRenderer Invisible;
    void Start()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Invisible.enabled = true;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        Invisible.enabled = false;
    }
}
