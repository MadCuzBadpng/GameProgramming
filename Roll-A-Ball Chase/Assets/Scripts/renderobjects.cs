using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class renderobjects : MonoBehaviour
{
    Renderer rend; 
    void Awake(){
        
    GameObject player = GameObject.FindWithTag("Player");
    rend = player.GetComponent<Renderer>();
    rend.material.SetColor("_Color", ColorSelectorscript.Ballc);
    player.transform.localScale = Sizer.ballsize;
    }
}
