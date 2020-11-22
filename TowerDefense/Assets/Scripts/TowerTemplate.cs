using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerTemplate : MonoBehaviour
{

    [SerializeField]
    private GameObject finalObject;

    [SerializeField]
    private LayerMask allTilesLayer;

    private Vector2 mousePos;
    bool kosong = true;
    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(Mathf.Round(mousePos.x), Mathf.Round(mousePos.y));
        //transform.position = new Vector2(mousePos.x,mousePos.y);

        Vector2 mouseRay = Camera.main.ScreenToWorldPoint(transform.position);
        RaycastHit2D raycastHit = Physics2D.Raycast(mousePos, Vector2.zero, Mathf.Infinity);
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(raycastHit.collider.gameObject.name);

            if (raycastHit.collider.gameObject.tag == "GrassTile")
            {
                Instantiate(finalObject, transform.position, Quaternion.identity);
                Destroy(GameObject.Find("Canvas").GetComponent<PilihTower>().temp);
            }

        }

    }



}
