using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvasPause;
    public GameObject canvasConfirm;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           
            if (!canvasPause.activeSelf)
            {
                Debug.Log("pause");
                Time.timeScale = 0;
                canvasPause.SetActive(true);
            }
            else if (canvasPause.activeSelf)
            {
                Debug.Log("Resume");
                Time.timeScale = 1;
                canvasPause.SetActive(false);
            }
          
        }
    }

    public void resume()
    {
        Time.timeScale = 1;
        canvasPause.SetActive(false);
    }

    public void exit()
    {
        canvasConfirm.SetActive(true);
    }
}
