using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    
    public GameObject resUI;
    public bool start = false;
    void Start()
    {
        
    }

    public void pressStart()
    {
        start = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void deathUI()
    {
        resUI.SetActive(true);
    }
    public void respawnTimer()
    {
        Invoke("deathUI", 4f);
    }
}
