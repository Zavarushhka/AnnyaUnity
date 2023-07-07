using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int health=100;
        int level=2;
        health = health + level;
        print("health"+health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
