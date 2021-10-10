using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mechanics : MonoBehaviour
{

    public enum MundoActual
    {
        MundoDeprimente,
        MundoFantastico
    }

    public MundoActual _mundoActual = MundoActual.MundoDeprimente;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_mundoActual == MundoActual.MundoDeprimente)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                _mundoActual = MundoActual.MundoFantastico;
            }
        }
        if (_mundoActual == MundoActual.MundoFantastico)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                _mundoActual = MundoActual.MundoDeprimente;
            }
        }
    }
}
