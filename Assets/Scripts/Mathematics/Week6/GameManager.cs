using System;
using UnityEngine;
using Mathematics.Week6;
public class GameManager : MonoBehaviour
{
    [SerializeField] private int life;
    [SerializeField] private GameObject UI;
    public static event Action<int> EventText;
    public static event Action<int> EventLife;
    private void Start()
    {
        TimeGame(1);
        ActiveEventLife();
    }
    private void ActiveEventText()
    {
        EventText?.Invoke(10);
    }
    private void Life(int life)
    {
        this.life -= life;
        if (this.life <= 0)
        {
            UI.SetActive(true);
            TimeGame(0);
        }
        ActiveEventLife();
    }
    private void ActiveEventLife()
    {
        EventLife?.Invoke(life);
    }
    public void TimeGame(int time)
    {
        Time.timeScale = time;
    }
    private void OnEnable()
    {
        BasuraController.eventBullet += ActiveEventText;
        PlaneController.EventLife += Life;
    }
    private void OnDisable()
    {
        BasuraController.eventBullet -= ActiveEventText;
        PlaneController.EventLife -= Life;

    }
}
