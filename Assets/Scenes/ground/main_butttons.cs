using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_butttons : MonoBehaviour
{
    public void l1()
    {
        SceneManager.LoadScene("lev1");
    }
    public void l2()
    {
        SceneManager.LoadScene("lev2");
    }
    public void l3()
    {
        SceneManager.LoadScene("lev3");
    }
    public void l4()
    {
        SceneManager.LoadScene("lev4");
    }
    public void l5()
    {
        SceneManager.LoadScene("lev5");
    }
    public void quit_game()
    {
        Application.Quit();
    }
    public void back_to_main_menu()
    {
        SceneManager.LoadScene("main_menu0");
    }
    public void play_to_levels()
    {
        SceneManager.LoadScene("levels_list");
    }
}
