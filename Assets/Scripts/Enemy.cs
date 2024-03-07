using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int curHp;
    public int maxHp;
    public int goldToGive;
    public Image healthBarFill;

    public void Damage()
    {
        curHp--;
        healthBarFill.fillAmount = (float)curHp / (float)maxHp;

        if (curHp <= 0)
        {
            Defeated();
        }
    }

    public void Defeated()
    {
        Debug.Log("Defeated");
    }
}
