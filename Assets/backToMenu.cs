using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backToMenu : MonoBehaviour
{
    public GameObject uiOpt;
    public GameObject uiMain;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            uiOpt.SetActive(false);
            uiMain.SetActive(true);
        }
    }
}
