using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class katana : MonoBehaviour
{
    int FruitCount;
    [SerializeField] private ParticleSystem ps;
    public TextMeshProUGUI fc;

    private void Update()
    {
        fc.text = FruitCount.ToString();
    }
    void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.CompareTag("Fruit"))
        {
            addPoints();
        }
    }
    void addPoints()
    {
        FruitCount += 1;
    }
}
