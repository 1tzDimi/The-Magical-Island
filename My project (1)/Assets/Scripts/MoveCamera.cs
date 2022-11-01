using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MoveCamera : MonoBehaviour
{

    public Transform player;

    void Update()
    {
        transform.position = player.transform.position;
    }
}