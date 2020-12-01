using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KondisiMenang2 : MonoBehaviour
{
    // Start is called before the first frame update
    float waktu;
    public TextMeshProUGUI waktu_txt;
    public GameObject canvasMenang;
    void Start()
    {
        waktu  = 3 * 60;
        DisplayTime(waktu);
    }

    // Update is called once per frame
    void Update()
    {
        waktu -= Time.deltaTime;
        DisplayTime(waktu);
        if (waktu<=0)
        {
            Time.timeScale = 0;
            canvasMenang.SetActive(true);
            
        }

    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        waktu_txt.text = "Countdown : " + string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
