using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObserverCenter : Singleton<ObserverCenter>
{
    public UnityEvent<int> CoinsUpdatedEvent = new UnityEvent<int>();
}