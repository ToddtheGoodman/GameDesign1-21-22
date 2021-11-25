using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{

    public Transform player;

    public float enemySpeed;
    private float chaseDis;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        chaseDis = Vector2.Distance(transform.position, player.position);

        // if my chaseDis is less than 4, move towards the player
        if (chaseDis < 4)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, enemySpeed * Time.deltaTime);
        }
    }
}
