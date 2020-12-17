using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilihTower : MonoBehaviour
{
    public int jenisTower;

    public GameObject[] tower;

    public GameObject temp;

    private Vector2 mousePos;
    // Update is called once per frame

    private void Start()
    {

    }
    void Update()
    {
        if (temp!=null)
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(Mathf.Round(mousePos.x), Mathf.Round(mousePos.y));
        }

    }

    public void Pilih()
    {

        jenisTower = 0;
        if (temp!=null)
        {
            Destroy(temp);
        }

        if (GameObject.Find("Canvas").GetComponent<CanvasSetting>().koin>=10)
        {
            temp = Instantiate(tower[jenisTower], transform.position, Quaternion.identity);
            GameObject.Find("Canvas").GetComponent<CanvasSetting>().koin -= 10;
        } 
        
    }

    public void Pilih2()
    {
        jenisTower = 1;
        if (temp != null)
        {
            Destroy(temp);
        }

        if (GameObject.Find("Canvas").GetComponent<CanvasSetting>().koin >= 30)
        {
            temp = Instantiate(tower[jenisTower], transform.position, Quaternion.identity);
            GameObject.Find("Canvas").GetComponent<CanvasSetting>().koin -= 30;
        }
    }

    public void Pilih3()
    {
        jenisTower = 2;
        if (temp != null)
        {
            Destroy(temp);
        }

        if (GameObject.Find("Canvas").GetComponent<CanvasSetting>().koin >= 50)
        {
            temp = Instantiate(tower[jenisTower], transform.position, Quaternion.identity);
            GameObject.Find("Canvas").GetComponent<CanvasSetting>().koin -= 50;
        }
    }
}
