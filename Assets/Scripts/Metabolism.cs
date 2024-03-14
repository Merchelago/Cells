using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metabolism : MonoBehaviour
{
    public float Energy { get; private set; } = 100f;
    public int Fe { get; private set; } = 0;
    public int Mg { get; private set; } = 0;
    public int N { get; private set; } = 0;
    public int Si { get; private set; } = 0;

    public void UseEnergy()
    {
        Energy--;
        
    }
    IEnumerator StartMetabolism()
    {
        while (true)
        {
            UseEnergy();
            EventBus.ChangedEnergy();
            yield return new WaitForSeconds(1);
        }
        
    }

    void TakeEnergy()
    {
        Energy++;
        EventBus.ChangedEnergy();
    }
    private void Awake()
    {
        EventBus.OnPickUpFood.AddListener(TakeEnergy);
    }
    private void Start()
    {
        StartCoroutine(StartMetabolism());
    }

}
