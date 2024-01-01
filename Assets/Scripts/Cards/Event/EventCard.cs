using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class EventCard : MonoBehaviour
{

    Player sufferingPlayer;

    UnityEvent eventoCarta;

    public virtual void Effect()
    {
        eventoCarta.Invoke();
    }

}
