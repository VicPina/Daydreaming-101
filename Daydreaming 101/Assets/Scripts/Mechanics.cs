using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mechanics : MonoBehaviour
{
    public GameObject scenery;

    public ObjectSpriteChanger[] sceneObjs;

    public enum MundoActual
    {
        MundoDeprimente,
        MundoFantastico
    }

    public MundoActual _mundoActual = MundoActual.MundoDeprimente;
    private void Awake()
    {
        sceneObjs = scenery.GetComponentsInChildren<ObjectSpriteChanger>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_mundoActual == MundoActual.MundoDeprimente)
        {
            if (Input.GetButtonDown("Fantastico"))
            {
                _mundoActual = MundoActual.MundoFantastico;
                var setTrue = true;
                StartCoroutine(SetSprites(setTrue));
            }
        }
        if (_mundoActual == MundoActual.MundoFantastico)
        {
            if (Input.GetButtonDown("Depresivo"))
            {
                _mundoActual = MundoActual.MundoDeprimente;
                var setFalse = false;
                StartCoroutine(SetSprites(setFalse));
            }
        }
    }

    IEnumerator SetSprites(bool changeTo)
    {
        foreach(ObjectSpriteChanger affected in sceneObjs)
        {
            affected.ObjectAction();
            affected.Happy = changeTo;
        }

        yield return null;
    }
}
