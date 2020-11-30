using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CanvasSetting : MonoBehaviour
{
    public TextMeshProUGUI Koin_txt;
    public TextMeshProUGUI misi_txt;


    public int koin;
    int misi;
    int musuh;
    // Start is called before the first frame update
    void Start()
    {
        koin = 20;
        Koin_txt.text = "Koin : " + koin;

       
        //misi =  GameObject.Find("Canvas").GetComponent<SpawnMusuh>().jumlahMusuh;
        musuh = 10;
        //misi_txt.text = "Golem: 0/10";
    }

    // Update is called once per frame
    void Update()
    {
        Koin_txt.text = "Koin : " + koin;
        //misi_txt.text = "Golem:"+(musuh-misi)+"/10";
    }

    public void tambah_koin()
    {
        koin+=10;
        Koin_txt.text = "Koin : " + koin;
    }
}
