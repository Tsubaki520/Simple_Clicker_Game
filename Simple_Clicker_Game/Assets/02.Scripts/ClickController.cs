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

    public float gold = 0.00f;
    public int dmagePerClick = 1;

    void Start ()
    {

    }

    void Update ()
    {
        goldDisplay.text = "Gold：" + gold.ToString ("F0");
        gpc.text = dmagePerClick + "dmage/click";
    }

    public void Clicked ()
    {
        gold += dmagePerClick;
    }
}
