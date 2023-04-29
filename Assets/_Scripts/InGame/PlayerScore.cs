using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScore : MonoBehaviour
{
    public int _score = 0;
    public ScoreTextManager scoreTextManager;
    public TextMeshProUGUI textMeshProUGUI;

    public void OnFinished()
    {
        textMeshProUGUI.text = "Score : " + _score;
    }
}
