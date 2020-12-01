using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CanvasSetting : MonoBehaviour
{
    public TextMeshProUGUI Koin_txt;
    public TextMeshProUGUI health_txt;
    public GameObject CanvasGameOver;

    public int koin;
    public int health;

    
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        Koin_txt.text = "Coin : " + koin;
        health_txt.text = "Health : " + health;
        //misi_txt.text = "Golem:"+(musuh-misi)+"/10";
    }

    public void tambah_koin()
    {
        koin+=10;
    }

    public void kurangi_nyawa()
    {
        health -= 1;
        if (health<=0)
        {
            Time.timeScale = 0;
            CanvasGameOver.SetActive(true);
        }
    }

   
}
