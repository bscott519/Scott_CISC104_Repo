using System;
using UnityEngine;

public class GreenBallCollisionManager : BallCollisionManager
{
    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Green Ball Collision Manager Function");

        // Homework: Do something interesting here
        // Green Ball gets bigger when colliding with Blue Ball

        if (OtherBall.GetComponent<BlueBallCollisionManager>() != null)
        {
            Debug.Log("Green Ball Collided With Blue Ball");

            transform.localScale += new Vector3(1, 1, 1);
        }
            
    }
}

