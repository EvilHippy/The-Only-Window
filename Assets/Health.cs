using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount;
    public Image fill;
    public float AgroLimit;
    public float FakenessLimit;
    public GameObject NeutralText;
    public GameObject ProtestText;
    public GameObject ComplianceText;


void start()
{
  NeutralText.SetActive(true);
  ProtestText.SetActive(false);
  ComplianceText.SetActive(false);

}

private void Update()
{
    if(healthAmount <=0 || healthAmount >= 100)
    {
        SceneManager.LoadScene(2);
    }
    
    
}

public void Test(){
    Debug.Log("Hi there");
}

public void TakeDamage(float Damage)
{
    healthAmount -= Damage;
    healthBar.fillAmount = healthAmount / 100;
}

public void Healing(float healPoints)
{
    healthAmount += healPoints;
    healthAmount = Mathf.Clamp(healthAmount, 0, 100);
    

    healthBar.fillAmount = healthAmount / 100;
}
public void DangerStatus()
{
    if(healthAmount < AgroLimit) {
    
        NeutralText.SetActive(false);
        ProtestText.SetActive(true);
        ComplianceText.SetActive(false);
    }
    else if(healthAmount > FakenessLimit){
        
        NeutralText.SetActive(false);
        ProtestText.SetActive(false);
        ComplianceText.SetActive(true);
    }
    else{
       
        NeutralText.SetActive(true);
        ProtestText.SetActive(false);
        ComplianceText.SetActive(false);
    }
}

}