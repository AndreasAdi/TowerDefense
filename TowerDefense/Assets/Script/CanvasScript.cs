using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    public GameObject groupPasukan;
    public GameObject tempatSpawn;
    public GameObject prefabs;

    public GameObject tempatSpawnMusuh;
    public GameObject groupMusuh;
    private void Start() {
        buat_musuh(groupMusuh,tempatSpawnMusuh,prefabs);
    }
     public void buatMinotaur()
    {
        GameObject obj = Instantiate(prefabs,tempatSpawn.transform.position,tempatSpawn.transform.rotation);
        obj.transform.parent = groupPasukan.transform;
       
    }

    private void buat_musuh(GameObject groupPasukan,GameObject tempatSpawn,GameObject prefabs){
    GameObject obj = Instantiate(prefabs,tempatSpawn.transform.position,tempatSpawn.transform.rotation);
    obj.transform.parent = groupPasukan.transform;
    obj.tag ="musuh";
    }
}
