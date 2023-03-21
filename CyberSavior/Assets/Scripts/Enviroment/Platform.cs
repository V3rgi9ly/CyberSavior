using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform
{
    public static Transform transform;
    public GameObject platfrom_object;
    public static void Move()
    {
        transform.Translate(0f, 2f * Time.deltaTime, 0f);
    }

}
