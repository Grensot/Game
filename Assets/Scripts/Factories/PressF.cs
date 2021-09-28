using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressF : MonoBehaviour
{
    [SerializeField] private TrapFactory _trapFactory;

    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            TrapKey();
            return;
        }

    }
    public void TrapKey()
    {
     var prefab = _trapFactory.GetNewInstance();
    }
}
