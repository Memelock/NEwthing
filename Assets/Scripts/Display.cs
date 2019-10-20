using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Display : MonoBehaviour
{
    public Card card;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI Cost;

    void Start()
    {

        nameText.text = card.name;
        Cost.text = card.Cost.ToString();

    }

   
}
