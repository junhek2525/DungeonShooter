using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effecf : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void speed(int a)
    {
        PlayerController.speed = PlayerController.speed + 1.0f;

    }

}
