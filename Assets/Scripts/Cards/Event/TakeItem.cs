using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TakeItem : EventCard
{
    [SerializeField]
    int itemAmount = 0;

    public override void Effect()
    {
        base.Effect();
    }

    public TakeItem(int itemAmount)
    {
        this.itemAmount = itemAmount;
    }

}
