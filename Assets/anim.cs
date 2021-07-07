using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour
{
    public Animator anima;

    // Start is called before the first frame update
    void Start()
    {
        anima = GetComponent<Animator>();
        if (gameObject.tag == "leader")
        {
            //Debug.Log("anim");
            anima.SetTrigger("to_start_min");
            //GameObject.Find("leader").GetComponent<movemnet>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S))
        {
            int k = Random.Range(1, 10);
            //Debug.Log(k);
            //Debug.Log("RUN");
            if (k == 1 || k == 3 || k == 5 || k == 7 || k == 9 )
            {
                anima.SetBool("run", true);
                anima.SetBool("sit", false);
            }
            if (k == 2 || k == 4 || k == 6 || k == 8 || k == 10)
            {
                anima.SetBool("run2", true);
                anima.SetBool("sit2", false);
            }
        }


        else
        {
            anima.SetBool("run", false);
            anima.SetBool("sit", true);

            anima.SetBool("run2", false);
            anima.SetBool("sit2", true);
        }
    }
}
