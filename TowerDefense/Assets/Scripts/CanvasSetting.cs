using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CanvasSetting : MonoBehaviour
{
    public TextMeshProUGUI Koin_txt;
    public TextMeshProUGUI health_txt;
    public GameObject CanvasGameOver;
    public GameObject CanvasMenang;

    public int koin;
    public int health;
    public bool gameover;

    
    // Start is called before the first frame update
    void Start()
    {
        gameover = false;
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

    public void kurangi_nyawa(int damage)
    {
        health -= damage;
        if (health<=0)
        {
            gameover = true;
            Time.timeScale = 0;
            CanvasGameOver.SetActive(true);

        }
    }

   
}
