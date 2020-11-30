using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasConfirm : MonoBehaviour
{
   public void exit()
    {
        Application.Quit();
    }
    
    public void back()
    {
        gameObject.SetActive(false);
    }
}
