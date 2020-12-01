using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KondisiMenang : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject groupMusuh;
    public GameObject CanvasMenang;
    float timer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;

        if (timer>=10)
        {
            if (groupMusuh.transform.childCount<=0)
            {
                CanvasMenang.SetActive(true);
                Time.timeScale = 0;
            }
        }
        
    }
}
