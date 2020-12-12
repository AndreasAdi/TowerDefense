using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToCredit : MonoBehaviour
{
   public GameObject canvasMenang;
   public GameObject canvasCredit;
   public void loadCredit()
    {
        canvasMenang.SetActive(false);
        canvasCredit.SetActive(true);
    }
}
