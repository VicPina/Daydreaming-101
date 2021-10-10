using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public GameObject scenery;

    public List<ObjectSpriteChanger> sceneObjs = new List<ObjectSpriteChanger>();

    public bool happy;

    public void Awake()
    {
        foreach(Transform newObj in )
    }

    public void ChangeScenery()
    {
        foreach(ObjectSpriteChanger affectedObj in sceneObjs)
        {
            affectedObj.Happy = happy;
        }
    }
}
