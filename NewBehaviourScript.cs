using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int health = 5;
    public int level = 1;
    public float speed = 1.2f;
    public Vector3 newPosition;

    private void Start()
    {
        health += level;
        print("Количество жизней: " + health);
    }

    private void Update()
    {
        newPosition = transform.position;
        newPosition.z = newPosition.z + speed * Time.deltaTime;
        transform.position = newPosition;
    }

}
