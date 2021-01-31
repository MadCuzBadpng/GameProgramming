using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Size : MonoBehaviour
{
    public static float scale;
    public Slider slider;
    public GameObject playerObject;
    

    void Awake()
    {
        //Cache the Slider and the ParticleSystem variables
        slider = GameObject.Find("SizeSlider").GetComponent<Slider>();
        playerObject = GameObject.FindWithTag("Player");
    }
    public void OnEnable()
    {
        //Subscribe to the Slider Click event
        slider.onValueChanged.AddListener(delegate { sliderCallBack(slider); });
    }

    //Will be called when Slider changes
    public void sliderCallBack(Slider slider)
    {
        Debug.Log("Slider Changed: " + slider.value);
        scale = slider.value;
    }

    // Update is called once per frame
    private void Update()
    {
        
        playerObject.transform.localScale = new Vector3(scale, scale, scale);

    }

}
