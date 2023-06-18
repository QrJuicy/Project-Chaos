 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchAndDestroy : MonoBehaviour
{
    public bool dead = false;

    private void OnTriggerEnter(Collider other)
    {
        string ObjectTag = other.gameObject.tag;
        if (ObjectTag == "enemy")
        {
            if (dead == false)
            {
                Debug.Log("got hit");
                Destroy(this.gameObject);
                dead = true;
            }
        }

    }

}
