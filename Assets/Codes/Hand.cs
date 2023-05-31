using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using Unity.Mathematics;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public bool isLeft;
    public SpriteRenderer spriter;

    SpriteRenderer player;

    Vector3 rightPos = new Vector3(0.334f, -0.113f, 0);
    Vector3 rightPosReverse = new Vector3(-0.334f , -0.15f, 0);
    Quaternion leftRot = Quaternion.Euler(0, 0, 60);
    Quaternion leftRotReverse = Quaternion.Euler(0, 0, 160);


    private void Awake()
    {
        player = GetComponentsInParent<SpriteRenderer>()[1];
    }

    private void LateUpdate()
    {
        bool isReverse = player.flipX;

        if(!isLeft)
        {
            transform.localPosition = isReverse ? rightPosReverse : rightPos;
            spriter.flipX = isReverse;
            spriter.sortingOrder = isReverse ? 6 : 4;
        }
        else
        {
            transform.localRotation = isReverse ? leftRotReverse : leftRot;
            spriter.flipY = isReverse;
            spriter.sortingOrder = isReverse ? 4 : 6;
        }
    }
}
