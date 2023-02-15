using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Fruit : MonoBehaviour
{
    public TMP_Text fc;
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
       
    }
}
