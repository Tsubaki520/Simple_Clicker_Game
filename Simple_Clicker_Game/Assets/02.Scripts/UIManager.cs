using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject character;
    public GameObject summons;
    public Text Gold;
    public Text DPC;
    public Text GPS;

    public static UIManager Instance = null;

    private void Awake ()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy (gameObject);
            return;
        }
    }

    void Start ()
    {
        Init ();
    }

    public void Init ()
    {

    }

    void Update ()
    {

    }

    private void OnDestroy ()
    {
        Instance = null;
    }
}
