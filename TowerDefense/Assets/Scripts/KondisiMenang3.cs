using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KondisiMenang3 : MonoBehaviour
{
    public GameObject Boss;
    public GameObject CanvasMenang;
    GameObject camera;
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
            CanvasMenang.SetActive(true);
            Time.timeScale = 0;

        /*    camera = GameObject.Find("Camera");
            camera.GetComponent<SoundEffect>().playSound(2, true, 0.5f);*/
        }
    }
}
