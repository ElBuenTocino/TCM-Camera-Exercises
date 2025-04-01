using UnityEngine;

public class ChangeMainCamera : MonoBehaviour
{
    public Camera[] cameras;

    void Start()
    {
        cameras[0].enabled = true;
        cameras[1].enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (cameras[0].enabled == true)
            {
                cameras[0].enabled = false;
                cameras[1].enabled = true;

            }
            else if (cameras[1].enabled == true) 
            {
                cameras[0].enabled = true;
                cameras[1].enabled = false;
            }
        }
    }
}
