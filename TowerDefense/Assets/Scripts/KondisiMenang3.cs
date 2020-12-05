using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KondisiMenang3 : MonoBehaviour
{
    public GameObject Boss;
    public GameObject CanvasMenang;

    bool gameover;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       gameover = GameObject.Find("Canvas").GetComponent<CanvasSetting>().gameover;
        if (Boss.transform.childCount<=0 && !gameover)
        {
           // CanvasMenang.SetActive(true);
           // Time.timeScale = 0;
        }
    }
}
