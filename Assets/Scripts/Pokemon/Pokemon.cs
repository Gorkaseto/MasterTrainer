using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pokemon : MonoBehaviour
{
    [SerializeField]
    public int number = 4;
    [SerializeField]
    public string pokeName = "Charmander";
    [SerializeField]
    public int powerPoint = 5;
    [SerializeField]
    public AttackInfo attackInfo = new AttackInfo { attackName = "Ember", attackStrength = 4 };

    [ContextMenu("Puntos de Poder")]
    public int GetPowerPoint()
    {
        return powerPoint;
    }

    [ContextMenu("Nombre")]
    public string GetName()
    {
        return pokeName;
    }

    public int Attack(int diceRoll)
    {
        return diceRoll + attackInfo.attackStrength;
    }
}

[Serializable]
public struct AttackInfo
{
    public string attackName;
    public int attackStrength;
}
