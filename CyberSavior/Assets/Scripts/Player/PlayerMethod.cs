using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    Transform transform;
    LayerMask maskPlatform;

    public GameObject player_object;
    public Rigidbody2D player_rb;

    public bool crash_collider;
    public float speedPlayer;

    
    public void Move()
    {
        //—оздаем переменную куда сохран€ем управление вправо/влево 
        //ѕосле чего вызываем метод Translate дл€ передвижени€ по координатам X, то есть горизонтали 
        float moveHorizontal = Input.GetAxis("Horizontal") * speedPlayer;
        transform.Translate(moveHorizontal * Time.deltaTime, 0f, 0f);


    }
    public void Jump()
    {
         maskPlatform = LayerMask.GetMask("");

        if (Input.GetKeyDown(KeyCode.W))
        {
            if (Physics2D.Raycast(transform.position, Vector2.down, 1.0f, maskPlatform))
            {
                player_rb.velocity = transform.up * speedPlayer;
                crash_collider = true;
                Debug.Log("Jump!");
            }
            else
            {
                crash_collider = false;
            }
        }

    }
    public void Shoot()
    {
        maskPlatform = LayerMask.GetMask("");

        if (Input.GetButton("Fire1")){

            if (Physics2D.Raycast(transform.position, Vector2.right, 3.0f, maskPlatform))
            {
                Platform.Move();
                Debug.Log("Shoot!");
            }
        }


    }

}
