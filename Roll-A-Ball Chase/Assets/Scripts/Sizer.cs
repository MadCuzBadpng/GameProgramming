using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sizer : MonoBehaviour
{

    public Toggle toggle;
    public GameObject playerObject;
    public static Vector3 ballsize;

    // Start is called before the first frame update
    void Start()
    {
        toggle = GameObject.Find("Toggle").GetComponent<Toggle>();
        playerObject = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    public void Update()
    {
        if(toggle.isOn)
        {
            ballsize = new Vector3(3, 3, 3);
        }
        else
        {
            ballsize = new Vector3(1, 1, 1);
        }
    }
}
