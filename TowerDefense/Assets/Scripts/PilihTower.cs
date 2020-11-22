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
}
