using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationPanel : MonoBehaviour
{
    // Start is called before the first frame update
    int indexPage=0;
    List<Transform> conversationPanel= new List<Transform>();
    void Start()
    {
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
        if (indexPage >= transform.childCount) { 
            //startGame()
            
        }
    }
}
