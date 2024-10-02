using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextLIfeController : MonoBehaviour
{
    TMP_Text text;
    private void Awake()
    {
        text = GetComponent<TMP_Text>();
    }
    private void PrinLife(int life)
    {
        text.text = "Vidas: " + life;
    }
    private void OnEnable()
    {
        GameManager.EventLife += PrinLife;
    }
    private void OnDisable()
    {
        GameManager.EventLife -= PrinLife;
    }
}
