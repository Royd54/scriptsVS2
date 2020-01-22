using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class vrMovementCheck : MonoBehaviour
{
    private TimeManager tm;
    private Interactable interactable;

    float targetScale;
    float lerpSpeed = 2;
    [SerializeField] private GameObject timeManager;
    [SerializeField] private float speed;
    [SerializeField] private float firstSpeed;
    [SerializeField] private Rigidbody rb;
    [SerializeField] Camera vrCam;
    [SerializeField] Transform firstRot;
    [SerializeField] Transform secondRot;
    [SerializeField] GameObject enemyDebug1;
    [SerializeField] GameObject enemyDebug2;
    [SerializeField] GameObject enemyDebug3;
    private float slowMo = 0.2f;
    private float normTime = 0.8f;
    private bool doSlowMo = false;
    // Start is called before the first frame update
    void Start()
    {
        tm = TimeManager.GetInstance();
        rb = GetComponent<Rigidbody>();
        firstSpeed = speed;
        firstRot = GameObject.Find("RightHand").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(GameObject.Find("VRCamera").GetComponent<Camera>().velocity.magnitude);
        if (GameObject.Find("VRCamera").GetComponent<Camera>().velocity.magnitude > 1f)
        {
            Debug.Log("hurz");
                if (doSlowMo)
                {
                    Time.timeScale = normTime;
                    Time.fixedDeltaTime = 0.02f * Time.timeScale;
                    doSlowMo = false;
                }
            }
            else
            {
                if (!doSlowMo)
                {
                    Time.timeScale = slowMo;
                    Time.fixedDeltaTime = 0.02f * Time.timeScale;
                    doSlowMo = true;
                }
            }
        }
}