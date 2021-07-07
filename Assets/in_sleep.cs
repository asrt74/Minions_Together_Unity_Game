using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class in_sleep : MonoBehaviour
{
    public Animator animato;
    private int count;
    //private GameObject child;
    //public BoxCollider box_coll;
    public CapsuleCollider cc;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        animato = gameObject.GetComponentInChildren<Animator>();
        //animato = GetComponent<Animator>();
        //animato = child.GetComponent<Animator>();
        if (gameObject.tag == "not_a_minion")
        {
            //animato.SetTrigger("to_start_min");
            GetComponent<char_conrol>().enabled = false;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
        count = GameObject.FindGameObjectsWithTag("minion").Length;
        //count = count / 2;
        if (Input.GetKeyDown(KeyCode.Space)) 
        { 
            Debug.Log(count); 
        }


        //animato.SetTrigger("to_standby");
        //if it is touched
        // animato.SetTrigger("alive");
        //movement script--> Active

        //touched by object--> destroy

        //if leader collider--> restart

        //count of minions

        //tasks

        //make sharp things
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag=="leader" || other.tag == "minion")
        {
            StartCoroutine(legs_out());
            animato.SetTrigger("touched");

            StartCoroutine(legs_out());
            gameObject.tag = "minion";
            GetComponent<char_conrol>().enabled = true;
            rb.useGravity = true;
            //box_coll.isTrigger = false;
            cc.isTrigger = false;
        }
    }
    IEnumerator legs_out()
    {
        yield return new WaitForSeconds(0.5f);
    }
}
