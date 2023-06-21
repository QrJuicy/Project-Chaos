using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnBox: MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
       Invoke("DestroyOnImpact",10f);
    }

    private void DestroyOnImpact()
    {
        Destroy(this.gameObject);
    }
}