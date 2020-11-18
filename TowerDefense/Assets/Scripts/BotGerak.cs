using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotGerak : MonoBehaviour
{
  public float speed;
  private Waypoints wp;

  private int index =0;

    private void Start() {
          wp = GameObject.FindGameObjectWithTag("jalan").GetComponent<Waypoints>();
        
    }
    private void Update() {
        transform.position = Vector2.MoveTowards(transform.position,wp.waypoints[index].position,speed*Time.deltaTime);

        if(Vector2.Distance(transform.position,wp.waypoints[index].position)<0.1f){
            if(index<wp.waypoints.Length-1){
                index++;
            }
        }
    }
}
