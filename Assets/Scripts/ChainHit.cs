using UnityEngine;

public class ChainHit : MonoBehaviour
{
    public Canvas ShowCanvas;
    public AudioSource HitSound;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Time.timeScale = 0;
            ShowCanvas.gameObject.SetActive(true);
            HitSound.Play();
        }
    }
}
