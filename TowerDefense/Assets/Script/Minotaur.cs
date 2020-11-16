using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minotaur : MonoBehaviour
{
     Coroutine step;
    Rigidbody2D rb;
    Animator an;
    SpriteRenderer sp;
    float tempdx;
    float dx;
    float mudur;
    int darah;
    GameObject groupPasukan;
    Vector3 characterScale;
    float characterScaleX;

    float time;

    GameObject target;
    void Start()
    {
        characterScale = transform.localScale;
        characterScaleX = characterScale.x;
        darah = 3;
        an = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();

        if(gameObject.tag=="musuh"){
            dx=-1.5f;
            darah = 5;
            characterScale.x = -characterScaleX;
            transform.localScale = characterScale;
            groupPasukan = GameObject.Find("GroupMusuh").gameObject;
        }
        else{
            dx = 1.5f;
            groupPasukan = GameObject.Find("GroupPasukan").gameObject;
        }

        mudur = 0.3f;
        an.SetBool("sedangJalan",true);
        tempdx = dx;


        //an.SetBool("sedangJalan", true);

    }

    // Update is called once per frame

    private void Update() {
          Debug.Log(darah);
        
        if(darah<=0){
        
           
        }

        
    }

    private void FixedUpdate() {

     if (groupPasukan.transform.childCount > 0)
        {
            for (int i = groupPasukan.transform.childCount - 1; i >= 0; i--)
            {
                var target = groupPasukan.transform.GetChild(i).gameObject;
                Physics2D.IgnoreCollision(target.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            }
        }

          rb.velocity = new Vector2(dx, rb.velocity.y);

      
    }

    private void OnCollisionEnter2D(Collision2D other) {
          if(!other.gameObject.CompareTag("jalan")){

            time=2;
            an.SetBool("serang",true);
            dx=0;
             target = other.gameObject;
            if (target.CompareTag("musuh")){
                target.GetComponent<Minotaur>().kenaSerang();
            }
            if (target.CompareTag("pasukan")){
                target.GetComponent<Minotaur>().kenaSerang();
            }
    
           
        }

    }

    private void OnCollisionStay2D(Collision2D other) {

        time -=Time.deltaTime;
        if(time<=0){
       if(!other.gameObject.CompareTag("jalan")){
            an.SetBool("serang",true);
            dx=0;
            Debug.Log(target.GetComponent<Minotaur>());
            if (target.CompareTag("musuh")){
                target.GetComponent<Minotaur>().kenaSerang();
                if (target.GetComponent<Minotaur>().darah<=0){
                       Debug.Log("keluar");  
                        an.SetBool("serang",false);
                        an.SetBool("sedangJalan", true);
                        dx=1.5f;
                       
                }
            }
            if (target.CompareTag("pasukan")){
                target.GetComponent<Minotaur>().kenaSerang();
            }
        }
            time=2;
        }

    }
    private void OnCollisionExit(Collision other) {
        if(other.gameObject.CompareTag("musuh")){
        Debug.Log("keluar");
        an.SetBool("serang",false);
        an.SetBool("sedangJalan", true);
        dx=1.5f;
        }

    }

    public void kenaSerang()
    {
        darah = darah - 1;

        if (darah <= 0)
        {
            an.SetBool("sedangMati", true);
            an.SetBool("serang",false);
            GetComponent<Collider2D>().enabled = false;
        }
        an.SetBool("sedangJalan", false);
        dx = 0;
        sp.color = Color.red;
    }


}
