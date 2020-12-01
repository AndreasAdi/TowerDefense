using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSerang : MonoBehaviour
{
    public GameObject prefabs_peluru;

    float delayTembak;
    bool tembak;
    Transform musuh;


    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<SoundEffect>().playSound(0, false, 0.4f);
        delayTembak = 30f;
    }

    // Update is called once per frame

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("musuh"))
        {
            musuh = collision.gameObject.transform;
            delayTembak = delayTembak - 1;
            if (delayTembak < 0)
            {
                GameObject target = collision.gameObject;
                float posisi = target.transform.localScale.x;

                    buatPeluru(-2);
                gameObject.GetComponent<SoundEffect>().playSound(1, false, 0.4f);
                delayTembak = 30f;
            }
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
     
        /*if (collision.gameObject.CompareTag("musuh"))
        {
      
            delayTembak = delayTembak - 1;
            if (delayTembak < 0)
            {
                GameObject target = collision.gameObject;
                float posisi = target.transform.localScale.x;
                if (posisi == 1)
                    buatPeluru(-2);
                else
                    buatPeluru(2);

                delayTembak = 30f;
            }
        }*/
    }



    public void buatPeluru(float paramDx)
    {
        GameObject peluru_mc = Instantiate(prefabs_peluru, transform.position, transform.rotation);
        Vector2 posisi = new Vector2(paramDx, 0);
        peluru_mc.GetComponent<PeluruTower>().init(posisi,musuh);
        Destroy(peluru_mc, 3f);
    }

}
