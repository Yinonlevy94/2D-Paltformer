using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false); // Disable the GameObject at the start
    }

    // Update is called once per frame
    void Update()
    {
        // Your Update logic here
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            gameObject.SetActive(true); // Enable the GameObject when colliding with "Finish"
        }
    }
}
