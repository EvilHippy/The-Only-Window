using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PostDisplay : MonoBehaviour
{
    public Post post;
    public Text nameText;
    public Text messageText;
    public Button Agree;
    public Button Disagree;
    public Button Ignore;
    public Health hurt;
    public Health heal;
    public Health color;
    public Arrays order;
    
 
    

    void Start()
    {
        
        
        nameText.text = post.name;
        messageText.text = post.message;

        Button btn = Agree.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        Button btn2 = Disagree.GetComponent<Button>();
        btn2.onClick.AddListener(TaskOnClick2);

        

    } 

    void Update()
    {
      
    }

   
    

    void TaskOnClick()
    {
        if(post.protest == true) {
            hurt.TakeDamage(15);
            order.Next();
            color.DangerStatus(); 
        }
        else if (post.compliance == true) {
            heal.Healing(15);   
            color.DangerStatus(); 
            order.Next();
        }    
    }
    void TaskOnClick2()
    {
        if(post.protest == true) {
            heal.Healing(15);
            order.Next();
            color.DangerStatus(); 
        }
        else if (post.compliance == true) {
            hurt.TakeDamage(15);
            color.DangerStatus(); 
            order.Next();
        }    
    }
}
