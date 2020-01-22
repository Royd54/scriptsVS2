using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPickupAnimation : MonoBehaviour
{
    public float transitionSpeed;
    public Transform currentView;

    void Start()
    {
        currentView = gameObject.transform;
    }


    void LateUpdate()
    {
        //Lerp position
        transform.position = Vector3.Lerp(transform.position, currentView.position, Time.deltaTime * transitionSpeed);

        Vector3 currentAngle = new Vector3(
         Mathf.LerpAngle(transform.rotation.eulerAngles.x, currentView.transform.rotation.eulerAngles.x, Time.deltaTime * transitionSpeed),
         Mathf.LerpAngle(transform.rotation.eulerAngles.y, currentView.transform.rotation.eulerAngles.y, Time.deltaTime * transitionSpeed),
         Mathf.LerpAngle(transform.rotation.eulerAngles.z, currentView.transform.rotation.eulerAngles.z, Time.deltaTime * transitionSpeed));

        transform.eulerAngles = currentAngle;

    }

    //these fucntions set the current view to lerp to
    public void focusPlayer()
    {
        currentView = GameObject.Find("WeaponHand").GetComponent<Transform>();
    }

}
