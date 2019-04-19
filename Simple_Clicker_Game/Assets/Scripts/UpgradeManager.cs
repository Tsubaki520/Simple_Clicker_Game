using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public ClickController click;
    public UnityEngine.UI.Text itemInfo;
    public float cost;
    public int count = 0;
    public int clickPower;
    public string itemName;
    private float m_newCost;

    void Start ()
    {

    }

    void Update ()
    {
        itemInfo.text = itemName + "\nCost：" + cost + "\nPower：+" + clickPower;
    }

    public void PurchasedUpgrade ()
    {
        if (click.gold >= cost)
        {
            click.gold -= cost;
            count += 1;
            click.goldperclick += clickPower;
            cost = Mathf.Round (cost * 1.15f);
            m_newCost = Mathf.Pow (cost, m_newCost = cost);
        }
    }
}
