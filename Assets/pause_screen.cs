using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause_screen : MonoBehaviour
{
    public GameObject pm;
    // Start is called before the first frame update
    void Start()
    {
        pm.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            pm.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void pause_it()
    {

        pm.SetActive(true);
        Time.timeScale = 0f;
    }
    public void for_continue()
    {
        Time.timeScale = 1f;
        pm.SetActive(false);
    }
    public void for_restart()
    {
        Time.timeScale = 1f;
        pm.SetActive(false);

        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
    public void for_levels()
    {
        Time.timeScale = 1f;
        pm.SetActive(false);
        SceneManager.LoadScene("levels_list");
    }
}
