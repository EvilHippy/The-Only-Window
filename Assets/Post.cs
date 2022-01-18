using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [CreateAssetMenu(fileName = "New Post", menuName = "Post")]
public class Post : ScriptableObject {

    public string name;
    public string message;
    public bool protest;
    public bool compliance;
    
}