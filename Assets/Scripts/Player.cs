using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int moveSpeed;
    public float horizontal, vertical;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.Translate(new Vector3(horizontal,0,0));
        vertical = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(new Vector3(0, 0, vertical));
    }

    
}
