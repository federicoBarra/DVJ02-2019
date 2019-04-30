using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace DVJ02.Clase06
{
[Serializable]
public class PlayerStats
{
    public int Strenght = 10;
    public int Dexterity = 10;
    public int Magic = 10;
    public int Luck = 10;

    public void AddToAllStats()
    {
        Strenght++;
        Dexterity++;
        Magic++;
        Luck++;
    }
}
}