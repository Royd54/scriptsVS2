using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour {

    public float force;
    float actualForce;
    Rigidbody rigid;
    private float speed = 1000f;
    [SerializeField] private GameObject enemyHitParticle;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        transform.position += transform.forward * TimeManager.GetInstance().myTimeScale;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            print("hit " + other.name + "!");
            Instantiate(enemyHitParticle, this.transform.position, Quaternion.identity);
            other.gameObject.SendMessageUpwards("ApplyDamage", SendMessageOptions.DontRequireReceiver);
            Destroy(gameObject);
        }
        else
        {
            print("hit " + other.name + "!");
            other.gameObject.SendMessageUpwards("ApplyDamage", SendMessageOptions.DontRequireReceiver);
            Destroy(gameObject);
        }

        if (gameObject.tag == "Item")
        {
            print("hit " + other.name + "!");
            Instantiate(enemyHitParticle, this.transform.position, Quaternion.identity);
            other.gameObject.SendMessageUpwards("ApplyDamage", SendMessageOptions.DontRequireReceiver);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        print("hit " + other.gameObject.name + "!");
        other.gameObject.SendMessageUpwards("ApplyDamage", SendMessageOptions.DontRequireReceiver);
        Destroy(gameObject);
    }
}
