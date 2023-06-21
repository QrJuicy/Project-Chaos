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
    
    void deathUI()
    {
        resUI.SetActive(true);
    }
    public void respawnTimer()
    {
        Invoke("deathUI", 4f);
    }
    public void QuitToTitle()
    {
        Application.Quit();
    }
}
