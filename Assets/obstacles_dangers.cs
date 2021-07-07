using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class obstacles_dangers : MonoBehaviour
{
    public AudioSource aud;
    //private Animator animat;
    // Start is called before the first frame update
    void Start()
    {
        aud = GameObject.Find("leader").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "leader" || other.tag == "minion")
        {
            aud.Play();
            other.GetComponent<char_conrol>().death();
            
            //Instantiate(death_effect, other.transform.position, Quaternion.identity);
            //animat = other.GetComponentInChildren<Animator>();
            //animat.SetTrigger("destroy");
        }
    }
}