using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStarter : MonoBehaviour
{
    Player player;

    private void Start()
    {
        player.player_rb = GetComponent<Rigidbody2D>();
        player.player_object = GetComponent<GameObject>();
    }

    private void Update()
    {
        player.Jump();
        player.Move();
    }
    private void FixedUpdate()
    {
        player.Shoot();
    }
}



