using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpinTheWheel : MonoBehaviour
{
    public string EventName;
    public int Cost;
    // Hidden values for change of industry rates
    //So we (James) dont forget what the last parts stand for here we go: 
    public int deltaMD;  //Mcdoogles
    public int deltaPol; //politics
    public int deltaWC;  //Wreakage company
    public int deltaMC;  //Mining company
    public int deltaRE;  //Real estate
    public int deltaPI;  //Personal image
    public void WheelSpin()
    {
    int Wheel = Random.Range(0, 3) + 1;
        switch (Wheel)
        {

            case 1:
                EventName = "Real Neighbor Hours";
                Cost = 100;
                deltaMD = 1;
                deltaPol = -5;
                deltaMC = 2;
                deltaWC = 4;
                deltaRE = 5;
                deltaPI = -2;
                Debug.Log("RNH");
                break;
            case 2:
                EventName = "Pokemon Go To the Poles";
                Cost = 6900;
                deltaMD = 1;
                deltaPol = 3;
                deltaMC = 2;
                deltaWC = 4;
                deltaRE = 5;
                deltaPI = -2;
                Debug.Log("Pok");
                break;
            case 3:
                EventName = "Recycling Initiative";
                Cost = 1690;
                deltaMD = 1;
                deltaPol = 3;
                deltaMC = 2;
                deltaWC = 4;
                deltaRE = 5;
                deltaPI = -2;
                Debug.Log("Rec");
                break;



        }
            


}


}
    

