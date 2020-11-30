using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotGerak : MonoBehaviour
{
  public float speed;
  private Waypoints wp;

  private int index =0;

    Coroutine step;
    Rigidbody2D rb;
    Animator an;
    SpriteRenderer sp;
    float tempdx;
    float dx;
    float mudur;

   public int darah;


    private void Start() {
        wp = GameObject.FindGameObjectWithTag("jalan").GetComponent<Waypoints>();
        an = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
        dx = 1.5f;
        mudur = 0.3f;
    }
    private void Update() {
        transform.position = Vector2.MoveTowards(transform.position,wp.waypoints[index].position,speed*Time.deltaTime);

        if(Vector2.Distance(transform.position,wp.waypoints[index].position)<0.1f){
            if(index<wp.waypoints.Length-1){
                index++;
            }
            else if (index==wp.waypoints.Length-1)
            {
                Destroy(gameObject);
            }
        }
    }

    public void kenaSerang(int damage)
    {
        darah = darah - damage;
        if (darah <= 0)
        {
            //an.SetBool("sedangMati", true);
            GetComponent<Collider2D>().enabled = false;
            an.SetBool("Mati", true);
            Destroy(gameObject, 1f);
            speed = 0;
       

            GameObject.Find("Canvas").GetComponent<CanvasSetting>().tambah_koin();
           
        }
        Vector2 localscale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        rb.AddForce(transform.up * 100 + transform.right * 1000 * localscale.x);

    }



    public void balik()
    {
        Vector2 localscale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        transform.localScale = localscale;
  
    }

}
