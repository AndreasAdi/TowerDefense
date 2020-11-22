using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CanvasSetting : MonoBehaviour
{
    public TextMeshProUGUI Koin_txt;

    public int koin;
    // Start is called before the first frame update
    void Start()
    {
        koin = 20;
        Koin_txt.text = "Koin : " + koin;
    }

    // Update is called once per frame
    void Update()
    {
        Koin_txt.text = "Koin : " + koin;
    }

    public void tambah_koin()
    {
        koin+=10;
        Koin_txt.text = "Koin : " + koin;
    }
}
