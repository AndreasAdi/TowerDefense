using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeluruTower : MonoBehaviour
{
    // Start is called before the first frame update
    float kecepatan = 6f;

    Vector2 posisi;
    Transform musuh;

    GameObject target;

    public int damage =1;

    public void init(Vector2 posisi,Transform musuh)
    {
        this.musuh = musuh;
        this.posisi = posisi;

        //GetComponent<Rigidbody2D>().AddForce(posisi * kecepatan, ForceMode2D.Impulse);


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("musuh"))
        {
             target = collision.gameObject;
            if (target!=null)
            {
                target.GetComponent<BotGerak>().kenaSerang(damage);
            }
         
            Destroy(gameObject,0.5f);
        }
    }

    private void Update()
    {
        if (musuh!=null)
        {
            transform.position = Vector2.MoveTowards(transform.position, musuh.position, kecepatan * Time.deltaTime);

        }
        if(musuh==null)
        {
            Destroy(gameObject);
        }
     
        //transform.position += (musuh.position - transform.position).normalized;
    }
}
