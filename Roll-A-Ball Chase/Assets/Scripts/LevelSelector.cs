using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    
    public static int theScene=0;
    public Slider slider;

    public void Awake()
    {
        slider = GameObject.FindWithTag("speed").GetComponent<Slider>();
        

    }

    public void OnEnable()
    {
        slider.onValueChanged.AddListener(delegate { sliderCallBack(slider); });
    }

   

    public void sliderCallBack(Slider slider)
    {
        PlayerController.speed = slider.value;
    }

    public void Easy()
    {
        theScene = 1;
    }

    public void Normal()
    {
        theScene = 2;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(theScene);
    }

}
