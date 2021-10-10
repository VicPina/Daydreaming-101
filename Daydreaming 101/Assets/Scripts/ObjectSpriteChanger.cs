using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpriteChanger : MonoBehaviour
{
    public bool Happy;
    public List<Sprite> HappyNSadImgs = new List<Sprite>();

    private SpriteRenderer renderer;
    private void Awake()
    {
        renderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void Update()
    {
        if (Happy) { renderer.sprite = HappyNSadImgs[0]; }
        if (!Happy) { renderer.sprite = HappyNSadImgs[1]; }
    }
}
