using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class inputname : MonoBehaviour
{
    public static string Playername;
    public Text showPlayername;
    public InputField PlayerNameInput;
    public Text text;

    void Awake(){
        DontDestroyOnLoad(this.gameObject);
        showPlayername.text = Playername;

    }

    public void UpdateName(){
        
        Playername = PlayerNameInput.text;
        showPlayername.text = Playername;
        Debug.Log(name);
    }


    public void ShowName(){
        
        showPlayername.text = Playername;
        
    
    }

}
