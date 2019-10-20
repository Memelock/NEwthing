using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EventDisplay : MonoBehaviour
{
    public EventMaker scenario;

    public TextMeshProUGUI title;
    public TextMeshProUGUI description;
    public TextMeshProUGUI btn1Title;
    public TextMeshProUGUI btn2Title;
    // Start is called before the first frame update
    void Start()
    {
        title.text = scenario.eventName;
    }

    // Update is called once per frame
}
