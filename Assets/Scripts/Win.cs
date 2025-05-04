using UnityEngine;

public class Win : MonoBehaviour
{
    
    public Canvas ShowCanvas;
    
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
              
            ShowCanvas.gameObject.SetActive(true);
        }
    }
}

