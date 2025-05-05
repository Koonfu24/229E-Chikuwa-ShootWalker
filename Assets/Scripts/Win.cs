using UnityEngine;

public class Win : MonoBehaviour
{public AudioSource audio2;
    
    public Canvas ShowCanvas;
    
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            ShowCanvas.gameObject.SetActive(true);
            audio2.Play();
        }
    }
}

