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
<<<<<<< Updated upstream
    void Start()
    {
        
    }

    
=======
    void Start()
    {
        CreateEvent();
    }
    public void CreateEvent()
    {
        Debug.Log("Starting");
        int num = Random.Range(1, 3);
         //int num = 3;
         switch (num)

         {
             case 1:
                title.text = "Mine Collapse!";
                description.text = "A mineshaft has collapsed. Save your orphan mineshaft \"workers\" or save the ore?";
                btn1Title.text = "Save the orphans!";
                btn2Title.text = "Save the ore!";
                 break;
             case 2:
                title.text = "Tax the Twoots!";
                description.text = "Lobby to add a tax for every Twoot?";
                btn1Title.text = "Yes!";
                btn2Title.text = "No!";
                 break;
             case 3: 
                 title.text = "test3";
                description.text = "Ran out of ideas. Test 3";
                btn1Title.text = "Test 3 button";
                btn2Title.text = "Test button 2";
                 break;
             default:
                 title.text = "error!";
                 break;
         }
  
    }
>>>>>>> Stashed changes
}
