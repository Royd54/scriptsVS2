using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCheck : MonoBehaviour
{
    [SerializeField] private GameObject[] Enemy;
    [SerializeField] private int enemyCount;
    [SerializeField] private GameObject nextLevel;
    // Start is called before the first frame update
    void Start()
    {
        enemyCount = Enemy.Length + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyCount <= 0)
        {
            nextLevel.SetActive(true);
        }
    }

    public void EnemyDead()
    {
        enemyCount -= 1;
    }
}
