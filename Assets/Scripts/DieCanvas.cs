using UnityEngine;

public class DieCanvas : MonoBehaviour
{public AudioSource audio2;
    public Canvas ShowCanvas;
    public Canvas HideCanvas;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Zombie"))
        { 
            GameObject Player = new GameObject();
            Destroy(Player,audio2.clip.length);
            ShowCanvas.gameObject.SetActive(true);
            HideCanvas.gameObject.SetActive(false);
            audio2.Play();
            Time.timeScale = 0;
             
        }

    }
}   