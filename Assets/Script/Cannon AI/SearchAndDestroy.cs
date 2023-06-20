 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchAndDestroy : MonoBehaviour
{
    public UI ui;
    public bool dead = false;
    public GameObject deathsprt;
    public Transform transSprite;

    private void OnTriggerEnter(Collider other)
    {
        string ObjectTag = other.gameObject.tag;
        if (ObjectTag == "enemy")
        {
            if (dead == false)
            {
                Debug.Log("got hit");
                Destroy(this.gameObject);
                Instantiate(deathsprt, transSprite.position, Quaternion.identity);
                dead = true;
                ui.respawnTimer();
            }
        }

    }

}
