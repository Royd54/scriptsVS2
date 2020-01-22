using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMouseLook : MonoBehaviour
{
    private Vector2 mouseLook;
    private Vector2 smoothV;
    private float sensitivity = 2.0f;
    private float smoothing = 2.0f;
    [SerializeField] private GameObject cam;
    public void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;//Lockes the cursor
    }

    void Update()
    {
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
        mouseLook.y = Mathf.Clamp(mouseLook.y, -90f, 90f);//this is to make sure the player cant do a loopedloop with the cam
        mouseLook += smoothV;

        cam.transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);//only moves the camera in the y
        this.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, this.transform.up);//moves the intiere player object
    }
}
