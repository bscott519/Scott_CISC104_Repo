using System;
using UnityEngine;

public class RedBallCollisionManager : BallCollisionManager
{
    public AudioSource audioPlayer;
   
    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Red Ball Collision Manager Function");

        // Homework: Do something interesting here
        // Red Ball makes a collision sound when colliding with Yellow Ball

        if (OtherBall.GetComponent<YellowBallCollisionManager>() != null)
        {
            Debug.Log("Red Ball Collided With Yellow Ball");

            audioPlayer.Play();
        }
    }
}

