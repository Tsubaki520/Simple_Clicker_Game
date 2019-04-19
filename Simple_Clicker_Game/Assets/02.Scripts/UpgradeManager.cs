using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{
    public ClickController click;
    public Text itemInfo;
    public float cost;
    public int count = 0;
    public int clickPower;
    public string itemName;
    private float baseCost;

    private Color standard = Color.white;
    private Color affordable = Color.gray;
    private Slider slider;

    void Start ()
    {
        baseCost = cost;
        slider = GetComponentInChildren<Slider> ();
    }

    void Update ()
    {
        itemInfo.text = itemName + "\nCost:" + cost + "\nPower:+ " + clickPower;

        slider.value = click.gold * 100;
        if (slider.value >= 100)
        {
            GetComponent<Image> ().color = affordable;
        }
        else
        {
            GetComponent<Image> ().color = standard;
        }
    }

    public void PurchasedUpgrade ()
    {
        if (click.gold >= cost)
        {
            click.gold -= cost;
            count += 1;
            click.dmagePerClick += clickPower;
            cost = Mathf.Round (baseCost * Mathf.Pow (1.15f, count));
        }
    }
}
