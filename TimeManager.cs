using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float myDelta;
    public float myFixedDelta;
    public float myTimeScale = 1;

    public static TimeManager instance;

    public static TimeManager GetInstance()
    {
        return instance;
    }

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    private void FixedUpdate()
    {
        myFixedDelta = Time.fixedDeltaTime * myTimeScale;
    }

    // Update is called once per frame
    void Update()
    {
        myDelta = Time.deltaTime * myTimeScale;
    }
}
