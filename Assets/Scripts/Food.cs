using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name != "Plane") { 
            Destroy(gameObject);
            EventBus.PickedUpFood();
        }
        
    }
}
