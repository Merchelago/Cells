using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metabolism : MonoBehaviour
{
    public float energy = 100f;

    public void UseEnergy()
    {
        energy--;
        
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

    private void Start()
    {
        StartCoroutine(StartMetabolism());
    }

}
