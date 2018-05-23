using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour {

    public playerMovement pm;


     void OnTriggerEnter()
    {
        pm.CompleteLevel();
    }
}
