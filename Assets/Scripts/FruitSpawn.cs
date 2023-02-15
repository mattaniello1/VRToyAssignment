using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FruitSpawn : MonoBehaviour
{
    public GameObject fruit1;
    public Transform spawnPoint;
    public float Timer;
    public float TimerDuration;
    public float Force;

    private void Update()
    {
        Timer -= Time.deltaTime;
        
        if (Timer < 0)
        {
            Spawn();
            TimerDuration = Random.Range(2, 8);
            Timer = TimerDuration;
        }
    }

    void Spawn()
    {
        Force = Random.Range(10, 13);
        GameObject fruit = Instantiate(fruit1, spawnPoint.position, Quaternion.identity);
        Rigidbody rb = fruit.GetComponent<Rigidbody>();
        rb.velocity = Force * spawnPoint.forward;
    }
}
