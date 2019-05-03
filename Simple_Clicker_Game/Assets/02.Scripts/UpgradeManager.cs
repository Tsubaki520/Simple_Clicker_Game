using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{
    public ClickController click;
    public Text itemInfo;
    public float cost;
    public int count = 0;
    public float upgrade = 1.15f;
    public int clickPower;
    public string itemName;
    private float baseCost;

    private Button btn;
    private Color standard = Color.white;
    private Color affordable = Color.gray;

    void Start ()
    {
        baseCost = cost;
        btn = GetComponent<Button> ();
        //btn.onClick.AddListener (PurchasedUpgrade);
    }

    void Update ()
    {
        itemInfo.text = itemName + "\nCost:" + cost + "\nPower:+ " + clickPower;
    }

    public void PurchasedUpgrade ()
    {
        if (click.gold >= cost)
        {
            click.gold -= cost;
            count += 1;
            click.dmagePerClick += clickPower;
            cost = Mathf.Round (baseCost * Mathf.Pow (upgrade, count));
        }
    }
}
