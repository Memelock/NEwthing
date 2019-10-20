using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
[CreateAssetMenu(fileName ="New Card", menuName ="Card")]
public class Card : ScriptableObject
{
    public new string name;
    public int Cost;
    public int RefNo;



    // Hidden values for change of industry rates
    //So we (James) dont forget what the last parts stand for here we go: 
    public int deltaMD;  //Mcdoogles
    public int deltaPol; //politics
    public int deltaWC;  //Wreakage company
    public int deltaMC;  //Mining company
    public int deltaRE;  //Real estate
    public int deltaPI;  //Personal image


}
