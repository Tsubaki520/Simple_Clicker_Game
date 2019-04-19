using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickController : MonoBehaviour
{
    [Header ("ClickSetting")]
    [SerializeField]
    private UnityEngine.UI.Text goldDisplay = null;
    [SerializeField]
    private UnityEngine.UI.Text dps = null;
    public float gold = 0.00f;
    public int goldperclick = 1;

    void Start ()
    {

    }

    void Update ()
    {
        goldDisplay.text = "Gold：" + gold;
        dps.text = "DPS：" + goldperclick;
    }

    public void Clicked ()
    {
        gold += goldperclick;
    }
}
