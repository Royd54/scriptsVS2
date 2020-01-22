using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyingObjectRotation : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float AngularSpeed;
    [SerializeField] private bool setter;
    protected Rigidbody rb;
    // Start is called before the first frame update
    void Awake()
    {
        this.transform.rotation = Random.rotation;
    }
}
