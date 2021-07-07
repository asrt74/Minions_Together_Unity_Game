using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class way_out : MonoBehaviour
{
    private Scene scene;
    private int count;
    public Animator an;
    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        count = GameObject.FindGameObjectsWithTag("minion").Length;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "leader" || other.tag == "minion")
        {
            if (scene.name == "lev1")
            {
                StartCoroutine(change_scene());
               
            }
            if (scene.name == "lev2" && count > 2)
            {
                StartCoroutine(change_scene());
            }
            if (scene.name == "lev3" && count > 3)
            {
                StartCoroutine(change_scene());
            }
            if (scene.name == "lev4" && count > 2)
            {
                StartCoroutine(change_scene());
            }
            if (scene.name == "lev5" && count > 2)
            {
                StartCoroutine(change_scene());
            }

        } 
    }
    IEnumerator change_scene()
    {
        an.SetTrigger("tra_out");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("levels_list");
    }
}
