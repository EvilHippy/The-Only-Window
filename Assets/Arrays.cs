using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Arrays : MonoBehaviour
{

    public GameObject[] post;
    public int i;
   

    void Start()
    {
        post[0].SetActive(true);
        post[1].SetActive(false);
        post[2].SetActive(false);
        post[3].SetActive(false);
        post[4].SetActive(false);
        post[5].SetActive(false);
        post[6].SetActive(false);
        post[7].SetActive(false);
        post[8].SetActive(false);
        post[9].SetActive(false);
        post[10].SetActive(false);
        post[11].SetActive(false);
        post[12].SetActive(false);
        post[13].SetActive(false);
        post[14].SetActive(false);
        post[15].SetActive(false);
        post[16].SetActive(false);
        post[17].SetActive(false);
        post[18].SetActive(false);
        post[19].SetActive(false);
        i = 0;
        
    }



    public void Next()
    {
        post[i].SetActive(false);
        if(i<19){
            i++;
            post[i].SetActive(true);
      
        }
        else {
            post[i].SetActive(false);
            SceneManager.LoadScene(3);
        }
        
        
    }
}
