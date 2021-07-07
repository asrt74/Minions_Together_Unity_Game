using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score_place : MonoBehaviour
{
    public TextMeshProUGUI scoretext;
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        scoretext = GameObject.Find("minion_count").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        count = GameObject.FindGameObjectsWithTag("minion").Length;
        count_inc(count);
    }
    void count_inc(int count)
    {
        scoretext.text = count.ToString("0");
    }
}
