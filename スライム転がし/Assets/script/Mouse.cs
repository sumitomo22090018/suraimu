using UnityEngine;
using UnityEngine.UIElements;


public class ObjectRotator : MonoBehaviour
{
    public float mouse_x_delta;
    public float mouse_y_delta;
    public float mouse_z_delta;

    public int mouse_xy_plus = 2;
    public int mouse_Wheel_plus = 50;
    
    void Start()
    {

    }

    void Update()
    {

        mouse_x_delta = Input.GetAxis("Mouse X");
        mouse_y_delta = Input.GetAxis("Mouse Y");
        mouse_z_delta = Input.GetAxis("Mouse ScrollWheel");

        if (Input.GetMouseButton(0))
        {
            transform.Rotate(new Vector3(0, -mouse_x_delta * mouse_xy_plus, -mouse_y_delta * mouse_xy_plus), Space.World);
        }
        else
        {
            transform.Rotate(new Vector3(-mouse_z_delta * mouse_Wheel_plus, 0, 0), Space.World);
        }


    }
}

