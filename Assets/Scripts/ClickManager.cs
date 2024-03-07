using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickManager : MonoBehaviour
{
    public List<float> autoCLickersLastTime = new List<float>();
    public int autoClickerPrice;
    public TextMeshProUGUI quantityText;

    void Update()
    {
        for (int i = 0; i < autoCLickersLastTime.Count; i++)
        {
            if (Time.time - autoCLickersLastTime[i] > 1.0f)
            {
                autoCLickersLastTime[i] = Time.time;
                EnemyManager.instance.curEnemy.Damage();
            }
        }
    }

    public void OnBuyAutoClicker()
    {
        if (GameManager.instance.gold >= autoClickerPrice)
        {
            GameManager.instance.TakeGold(autoClickerPrice);
            autoCLickersLastTime.Add(Time.time);

            quantityText.text = "x " + autoCLickersLastTime.Count.ToString();
        }
    }
}
