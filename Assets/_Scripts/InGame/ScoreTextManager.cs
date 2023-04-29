using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreTextManager : MonoBehaviour
{
    TextMeshProUGUI textMeshProUGUI;
    // Start is called before the first frame update
    void Start()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    public void OnScoreChanged(int score)
    {
        textMeshProUGUI.text = "Score = " + score;
    }
}
