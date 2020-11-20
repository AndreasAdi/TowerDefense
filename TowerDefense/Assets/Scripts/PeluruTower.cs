using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeluruTower : MonoBehaviour
{
    // Start is called before the first frame update
    float kecepatan = 10f;

    Vector2 posisi;
    Transform musuh;

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
            GameObject target = collision.gameObject;
            target.GetComponent<BotGerak>().kenaSerang();
            Destroy(gameObject);
        }
    }

    private void Update()
    {  
        transform.position = Vector2.MoveTowards(transform.position, musuh.position, kecepatan * Time.deltaTime);
        //transform.position += (musuh.position - transform.position).normalized;
    }
}
