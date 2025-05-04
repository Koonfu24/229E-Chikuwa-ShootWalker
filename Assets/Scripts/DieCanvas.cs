using UnityEngine;

public class DieCanvas : MonoBehaviour
{
    public Canvas ShowCanvas;
    public Canvas HideCanvas;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Zombie"))
        {
            Destroy(gameObject);
            ShowCanvas.gameObject.SetActive(true);
            HideCanvas.gameObject.SetActive(false);

        }

    }
}   