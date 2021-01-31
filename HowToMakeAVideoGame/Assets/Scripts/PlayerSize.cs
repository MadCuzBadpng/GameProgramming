using UnityEngine.UI;
using UnityEngine;

public class PlayerSize : MonoBehaviour
{
    public GameObject playerObject;

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        playerObject.transform.localScale = new Vector3(Size.scale, Size.scale, Size.scale);
    }
}
