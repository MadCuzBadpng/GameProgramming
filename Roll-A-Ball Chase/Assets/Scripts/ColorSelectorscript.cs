
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSelectorscript : MonoBehaviour
{
    public Dropdown CDropdown;
    Renderer rend;
    Renderer rend2;

    Color Red = new Color(1,0,0);
    Color Green = new Color(1,1,0);
    Color Blue = new Color(0,0,1);
    public static Color Ballc;

   public void colorswitch(){
       switch(CDropdown.value)
        {  
            default:
            Ballc = Red;
            break;
            case 1:
            Ballc = Red;
            break;
            case 2:
            Debug.Log("this is blue");
            Ballc = Blue;            

            break;
            case 3:
            Ballc = Green;
            break;
            
       }
   }
}
