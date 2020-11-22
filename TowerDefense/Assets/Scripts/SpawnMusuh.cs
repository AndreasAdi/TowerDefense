using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMusuh : MonoBehaviour
{
    public GameObject GroupMusuh;
    public GameObject spawnPlace;
    public GameObject prefabs;

    float waktu = 3;

    public void buatMusuh()
    {
        GameObject obj = Instantiate(prefabs, spawnPlace.transform.position, spawnPlace.transform.rotation);
        obj.transform.parent = GroupMusuh.transform;
    }

    private void Update()
    {
        waktu -= Time.deltaTime;
        if (waktu<0)
        {
            buatMusuh();
            waktu = 3;
        }
    }
   /* private void Start()
    {
        buatMusuh();   
    }*/
}
