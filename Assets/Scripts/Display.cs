using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Display : MonoBehaviour
{
    public GameObject ArchGood;
    private SpinTheWheel Spin;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI Cost;

    void Start()
    {

        Cost.text = Spin.Cost.ToString();
        nameText.text = Spin.EventName;
        Spin = gameObject.GetComponent<SpinTheWheel>();

    }

   
}
