using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour
{
   public Text scoreText;
   private int score;

   public void AddScore()
   {
      score++;
      scoreText.text = "Score " + score;
   }
   
}
