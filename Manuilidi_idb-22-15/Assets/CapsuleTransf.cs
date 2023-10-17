using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class transf : MonoBehaviour
{
    public float speed;
    public TextMeshProUGUI textCounter;

    private Rigidbody rb;
    private int counter;
    private void Start()
    {
        counter = 200;
        textCounter.text = "Count: 200";
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        rb.velocity = Vector3.forward * speed;
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Testobj"))
        {
            --counter;
            textCounter.text = "Count: " + counter.ToString();
            transform.position = new Vector3(0.29f, -0.261f, -1.135f); 
        }
    }
}
