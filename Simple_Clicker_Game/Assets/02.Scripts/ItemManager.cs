using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    public Text itemInfo;
    public ClickController click;
    public float cost;
    public int tickValue;
    public int count;
    public string itemName;
    private float baseCost;
    private Button btn;

    void Start ()
    {
        baseCost = cost;
        btn = GetComponent<Button> ();
        btn.onClick.AddListener (PurchasedUpgrade);
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
