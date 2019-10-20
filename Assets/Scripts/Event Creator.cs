using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Event", menuName ="Scenario")]
public class EventMaker : ScriptableObject
{
    public string eventName;
    public string eventDescription;


    public Sprite artwork;

    // Hidden values for change of industry rates
    //So we (James) dont forget what the last parts stand for here we go: 
    public string btn1Name;
    public int btn1DeltaMD;  //Mcdoogles
    public int btn1DeltaPol; //politics
    public int btn1DeltaWC;  //Wreakage company
    public int btn1DeltaMC;  //Mining company
    public int btn1DeltaRE;  //Real estate
    public int btn1DeltaGW; // Goodwill modifier
    public int btn1DeltaProfit; //Profit modifier
    public int btn1DeltaDeaths; //Deaths modifier

    public string btn2Name;
    public int btn2DeltaMD;  //Mcdoogles
    public int btn2DeltaPol; //politics
    public int btn2DeltaWC;  //Wreakage company
    public int btn2DeltaMC;  //Mining company
    public int btn2DeltaRE;  //Real estate
    public int btn2DeltaGW; // Goodwill modifier
    public int btn2DeltaProfit; //Profit modifier   
    public int btn2DeltaDeaths; //Deaths modifier
}