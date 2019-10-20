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
    public string EventName;
        public int Price;
 
    public void Yeet(string EventName,int Price)
    {
       // Spin = gameObject.GetComponent<SpinTheWheel>();
        Debug.Log("Why");
        nameText.text = EventName;
        Cost.text = Price.ToString();
    }
  
}
