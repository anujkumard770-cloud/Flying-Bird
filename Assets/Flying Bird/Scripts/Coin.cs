using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check karein ki kya takrane wali cheez ka tag "Player" hai?
        if (other.CompareTag("Player"))
        {
            // ---- YAHAN BADLAV KIYA HAI ----
            // GameManager ko bolkar coin ka count badhayein
            if (GameManager.Instance != null)
            {
                GameManager.Instance.AddCoin();
            }
            // -------------------------------

            // Coin ko hide/disappear kar dein
            gameObject.SetActive(false);
        }
    }
}