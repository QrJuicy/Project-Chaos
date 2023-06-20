using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    private bool play = false;
    public UI ui;
    public AudioClip pirates;
    public AudioSource audioSource;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(ui.start == true && play == false)
        {
            play = true;
            audioSource.clip = pirates;
            audioSource.Play();
        }
    }
}
