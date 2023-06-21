using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreResult : MonoBehaviour
{
    public TextMeshProUGUI inGameScore;
    public TextMeshProUGUI resultScore;

    void Awake() 
    {
        resultScore.SetText(inGameScore.text);
    }
}
