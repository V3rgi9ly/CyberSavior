using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy
{
    public int health_Enemy;
    public float speedMove_Enemy;
    //����� ������, ��� ��� �������� �����
    public abstract void MoveEnemy();

    public abstract void ShootEnemy();

}




