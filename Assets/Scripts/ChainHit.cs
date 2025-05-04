using UnityEngine;

public class ChainHit : MonoBehaviour
{
    public Canvas ShowCanvas;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            ShowCanvas.gameObject.SetActive(true);
        }
    }
}
