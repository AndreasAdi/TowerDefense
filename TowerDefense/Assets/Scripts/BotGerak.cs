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

    int darah;


    private void Start() {
        wp = GameObject.FindGameObjectWithTag("jalan").GetComponent<Waypoints>();
        darah = 30;
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
        }
    }

    public void kenaSerang()
    {
        darah = darah - 1;
        if (darah <= 0)
        {
            //an.SetBool("sedangMati", true);
            GetComponent<Collider2D>().enabled = false;
            an.SetBool("Mati", true);
            Destroy(gameObject, 1f);
            speed = 0;
       

            GameObject.Find("Canvas").GetComponent<CanvasSetting>().tambah_koin();
           
        }
        //cek apakah localscale sekarang kemudian cari local scale untuk x dan dikalikan -1 supaya gerak nanti mundur karena nanti mau ditambahkan jarak mundurnya (lihat kodingan addforce)
        Vector2 localscale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        //efek mundur
        //penggunaan addforce selalu mengambil posisi transform saat ini/ kemudian menggunakan perintah up dan right untuk menggerakannya penggunaan localscale dilakukan agar bisa kembali
        //Debug.Log(localscale.x);
        rb.AddForce(transform.up * 100 + transform.right * 1000 * localscale.x);
       
      /*  dx = 0;
        sp.color = Color.red;
        step = StartCoroutine(delay2());*/
    }



    IEnumerator delay1()
    {
        yield return new WaitForSeconds(3f);
        dx = tempdx * -1;
        an.SetBool("sedangJalan", true);
        sp.color = Color.white;
    }

    public void diam()
    {
        an.SetBool("sedangJalan", false);
        //tempdx = dx;
        dx = 0;
    }

    /* public void jalanlagi()
     {
         dx = tempdx;
         an.SetBool("sedangJalan", true);
     }*/

    public void jalanlagi()
    {
        an.SetBool("sedangJalan", true);
        //karena default karakter jalan ke kanan (faceRight maka jika 1 adalah +)
        float cek = transform.localScale.x;
        if (cek > 0)
            dx = tempdx;
        else
            dx = -tempdx;
    }

    //lompat
    public void lompat()
    {
        //dicepatkan jalannya
        dx = dx * 3;
        float localscale = transform.localScale.x;
        rb.AddForce(transform.up * 300);
        step = StartCoroutine(delay2());
    }

    IEnumerator delay2()
    {
        yield return new WaitForSeconds(1.3f);
        //setelah selesai mau ngapain?
        //dx = -tempDx; --> dicek dulu dia ada dimana posisinya
        jalanlagi();
    }
}
