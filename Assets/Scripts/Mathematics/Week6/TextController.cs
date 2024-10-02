using UnityEngine;
using TMPro;
public class TextController : MonoBehaviour
{
    TMP_Text text;
    float point;
    private void Awake()
    {
        text = GetComponent<TMP_Text>();
    }
    private void Start()
    {
        PrintPointEvent(0);
        Invoke("PrintPoint", 0.5f);
    }
    private void PrintPointEvent(int point)
    {
        this.point +=  point;
        text.text = "Puntos: " + this.point;
    }
    private void PrintPoint()
    {
        this.point += 1;
        text.text = "Puntos: " + this.point;
        Invoke("PrintPoint", 1f);
    }
    private void OnEnable()
    {
        GameManager.EventText += PrintPointEvent;
    }
    private void OnDisable()
    {
        GameManager.EventText -= PrintPointEvent;
    }
}
