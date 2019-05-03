using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickController : MonoBehaviour
{
    [Header ("ClickSetting")]
    [SerializeField]
    private Text goldDisplay = null;
    [SerializeField]
    private Text gpc = null;

    private Button btn;
    [Space (15)]
    public float gold = 0.00f;
    public int dmagePerClick = 1;

    void Start ()
    {
        btn = GetComponent<Button> ();
        btn.onClick.AddListener (Clicked);
    }

    void Update ()
    {
        goldDisplay.text = "Gold：" + Currencyconverter.Instance.GetCurrencyIntoString (gold);
        gpc.text = Currencyconverter.Instance.GetCurrencyIntoString (dmagePerClick) + ":dps";
    }

    public void Clicked ()
    {
        gold += dmagePerClick;
    }
}
