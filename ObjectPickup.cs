using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPickup : MonoBehaviour
{
    [SerializeField] private int objectTipe;
    // Start is called before the first frame update

    public int getObjectTipe()
    {
        return objectTipe;
    }
}
