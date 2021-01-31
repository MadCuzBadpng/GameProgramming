using UnityEngine;
using UnityEngine.UI;

public class name : MonoBehaviour
{

    public Text Name;

    public void Awake()
    {
        Name = GetComponent<Text>();
        Name.text = PlayerPrefs.GetString("Username");
    }

}
