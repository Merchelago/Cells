using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public GameObject foodPrefab;
    public int quantityFood = 50;
    public List<GameObject> foodList = new();
    void Start()
    {
        for (int i = 0; i < quantityFood; i++)
        {
            GameObject temp = Instantiate(foodPrefab, new Vector3(Random.Range(-10, 10), 0.2f, Random.Range(-10, 10)), Quaternion.identity);
            foodList.Add(temp);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
