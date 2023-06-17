using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnCanonBall : MonoBehaviour
{
    private void Awake()
    {
     Destroy(this.gameObject,10f);   
    }
   
}


//in progress (Don't mess unless you know what are you going to do)
