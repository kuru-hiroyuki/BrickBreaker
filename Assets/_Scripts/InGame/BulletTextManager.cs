using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BulletTextManager : MonoBehaviour
{
    TextMeshProUGUI textMeshProUGUI;
    private void Awake()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateText(int count)
    {
        textMeshProUGUI.text = "Bullets =" + count;
    }
}
