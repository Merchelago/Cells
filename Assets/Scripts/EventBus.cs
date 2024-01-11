
using UnityEngine;
using UnityEngine.Events;

public static class EventBus
{
    public static UnityEvent OnChangeEnergy = new UnityEvent();


    public static void ChangedEnergy()
    {
        OnChangeEnergy.Invoke();
    }
}
