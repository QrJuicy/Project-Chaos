using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Stopeatch : MonoBehaviour
{
    public SearchAndDestroy SearchAndDestroy;
    public UI UI; 
    public TextMeshProUGUI scoreText;
    public float scoreAmount;
    public float scoreIncreasedPerSecond;
    void Start()
    {
       scoreAmount = 0f;
       scoreIncreasedPerSecond = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        if (UI.start == true && SearchAndDestroy.dead == false)
        {
        scoreText.SetText((int)scoreAmount +"");
        scoreAmount += scoreIncreasedPerSecond * Time.deltaTime;
        }
    }
}
