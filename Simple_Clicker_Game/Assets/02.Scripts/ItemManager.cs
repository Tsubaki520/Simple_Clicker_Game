using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public UnityEngine.UI.Text itemInfo;
    public ClickController click;
    public float cost;
    public int tickValue;
    public int count;
    public string itemName;
    private float baseCost;

    void Start ()
    {
        baseCost = cost;
    }

    void Update ()
    {
        itemInfo.text = itemName + "\nCost：" + cost + "\nGold：" + tickValue + "/s";
    }

    public void PurchasedUpgrade ()
    {
        if (click.gold >= cost)
        {
            click.gold -= cost;
            count += 1;
            click.dmagePerClick += tickValue;
            cost = Mathf.Round (baseCost * Mathf.Pow (1.15f, count));
        }
    }
}
