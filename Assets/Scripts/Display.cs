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

        Spin = gameObject.GetComponent<SpinTheWheel>();
        nameText.text = Spin.EventName;
        Cost.text = Spin.Cost.ToString();

    }

   
}
