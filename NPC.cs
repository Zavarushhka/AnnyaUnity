using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //�������� NPC
    public int health;

    //������� NPC
    public int level;

    //�������� NPC
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        health = 4;
        level = 2;
        health+= level;
        print("�������� ������-" + health);
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 newposition = transform.position;
        newposition.z -= speed*Time.deltaTime;
        transform.position = newposition;
}
       
    }
