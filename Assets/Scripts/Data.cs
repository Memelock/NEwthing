using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data : MonoBehaviour
{
    public int profit = 0;
    public int goodWill = 50;
    public int mcDooglesRep = 50;
    public int wreckingRep = 50;
    public int politicsRep = 50;
    public int realEstateRep = 50;
    public int minesRep = 50;
    public int deaths = 50;
    public int weeks = 0;
    public int actions = 0;

    public void newGame()
    {
        profit = 0;
        goodWill = 50;
        mcDooglesRep = 50;
        wreckingRep = 50;
        politicsRep = 50;
        realEstateRep = 50;
        minesRep = 50;
        deaths = 0;
        weeks = 0;
    }
}
