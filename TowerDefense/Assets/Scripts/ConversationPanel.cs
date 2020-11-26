using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationPanel : MonoBehaviour
{
    // Start is called before the first frame update
    int indexPage=0;
    List<Transform> conversationPanel= new List<Transform>();
    GameObject camera;
    void Start()
    {
        camera = GameObject.Find("Camera");
        camera.GetComponent<SoundEffect>().playSound(0, true, 1);
        Time.timeScale = 0;
        Debug.Log("child Count "+transform.childCount);
        //transform.GetChild(0).gameObject.SetActive(false);
        for (int i = transform.childCount-1; i >= 0; i--)
        {
            conversationPanel.Add(transform.GetChild(i));
        }
        Debug.Log("arrayChild "+conversationPanel.Count);
    }
    public void nextPage() {
        conversationPanel[indexPage].gameObject.SetActive(false);
        indexPage++;
        if (indexPage == 1) {
            camera.GetComponent<SoundEffect>().playSound(1, true, 1);
        }
        
        if (indexPage >= transform.childCount) {
            //startGame()
            Time.timeScale = 1;
            camera.GetComponent<SoundEffect>().playSound(2, true, 1);
        }
    }
}
