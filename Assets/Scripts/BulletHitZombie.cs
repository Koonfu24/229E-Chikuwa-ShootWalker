using System;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BulletHitZombie : MonoBehaviour
{
    public GetScore getScore;
    public GetScore getScore2;
    public GetScore getScore3;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
           Destroy(other.gameObject); 
           Destroy(gameObject);
           getScore.AddScore();
           getScore2.AddScore();
           getScore3.AddScore();
           
        }
    }
   
   
}
