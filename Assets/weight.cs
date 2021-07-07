using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weight : MonoBehaviour
{
    private int count;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        count = GameObject.FindGameObjectsWithTag("minion").Length;

        //count = count + 1;
        if (count > 1 && gameObject.tag == "1")
        {
            // Debug.Log("0.1");
            // gameObject.GetComponent<Rigidbody>().mass = 0.1f;
            rb.mass = 0.1f;
        }
        

        else if (count > 3 && gameObject.tag == "3")
        {
            rb.mass = 0.1f;
        }
        
        else if (count > 2 && gameObject.tag == "2")
        {
            rb.mass = 0.1f;
        }
        
        else if (gameObject.tag == "wt")
        {
            rb.mass = 200f;
        }
        else
        {
            // Debug.Log("100");
            //gameObject.GetComponent<Rigidbody>().mass = 100f;
            rb.mass = 100f;
        }

    }
}
