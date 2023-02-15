using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MeasureDist : MonoBehaviour
{
    // Attach this to the floor

    public TMP_Text textfield;
    private void OnCollisionEnter(Collision collision)
    {
        float dist = Vector3.Distance(Vector3.zero, collision.GetContact(0).point);
        textfield.text = dist.ToString();
    }
}
