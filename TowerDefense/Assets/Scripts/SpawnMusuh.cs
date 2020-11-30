using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMusuh : MonoBehaviour
{
    public GameObject GroupMusuh;
    public GameObject spawnPlace;
    public GameObject [] prefabs;
    public bool boss;
    public GameObject prefabsBoss;

    float waktu = 3;
    public int jumlahMusuh = 10;
    
    public void buatMusuh()
    {
        int i = Random.Range(0, prefabs.Length);
        GameObject obj = Instantiate(prefabs[i], spawnPlace.transform.position, spawnPlace.transform.rotation);
        obj.transform.parent = GroupMusuh.transform;
    }

    private void Update()
    {
      
        if (jumlahMusuh>0)
        {
            waktu -= Time.deltaTime;
            if (waktu < 0)
            {
                buatMusuh();
                jumlahMusuh--;
                waktu = 3;
            }

          
        }
       

    }
   /* private void Start()
    {
        buatMusuh();   
    }*/
}
