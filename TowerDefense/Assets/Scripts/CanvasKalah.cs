using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasKalah : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    GameObject camera;
    public int level;
    void Start()
    {
        if (level == 1)
        {
            camera = GameObject.Find("Camera");
            camera.GetComponent<SoundEffect>().playSound(4, false, 0.5f);
        }
        else if (level == 2)
        {
            camera = GameObject.Find("Camera");
            camera.GetComponent<SoundEffect>().playSound(3, false, 0.5f);
        }
        else if (level == 3)
        {
            camera = GameObject.Find("Camera");
            camera.GetComponent<SoundEffect>().playSound(3, false, 0.5f);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
