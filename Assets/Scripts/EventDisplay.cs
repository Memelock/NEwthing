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

    public List<EventMaker> EventList;
    // Start is called before the first frame update
    void Start()
    {
        Call();
    }

    void Call()
    {
        for (int i = 0; i < EventList.Count;)
        {
            scenario = EventList[i];
            title.text = scenario.text;
            
            if(Input.GetKeyDown(KeyCode.Space))
            {
                i++;
            }
        }
    }
}
