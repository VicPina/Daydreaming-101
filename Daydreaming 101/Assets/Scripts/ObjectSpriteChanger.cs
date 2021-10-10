using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjectSpriteChanger : MonoBehaviour
{
    public bool Happy;
    public List<Sprite> HappyNSadImgs = new List<Sprite>();
    public UnityEvent defaultProcess;

    private SpriteRenderer spriteRenderer;
    private Collider2D objCollider;

    public void ObjectAction() { defaultProcess.Invoke(); }
    private void Awake()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        objCollider = GetComponentInChildren<Collider2D>();
    }
    public void TurnColider()
    {
        if (Happy) { objCollider.enabled = true; }
        if (!Happy) { objCollider.enabled = false; }
    }
    public void ChangeSprite()
    {
        if (Happy) { spriteRenderer.sprite = HappyNSadImgs[0]; }
        if (!Happy) { spriteRenderer.sprite = HappyNSadImgs[1]; }
    }
}
