// using UnityEngine;

// public class ScoreZone : MonoBehaviour
// {
//     private bool hasScored = false;
//     private void OnTriggerEnter2D(Collider2D collision)
//     {
//         if (hasScored) return;

//         if (collision.CompareTag("Player"))
//         {
//             hasScored = true;
//             GameManager.Instance.AddScore();
//         }
//     }
//     public void ResetScoreZone()
//     {
//         hasScored = false;
//     }
// }



using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    private bool hasScored = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (hasScored) return;

        // CRITICAL UNITY SETTING: Bird/Player GameObject ka Tag Inspector mein "Player" hona zaroori hai!
        if (collision.CompareTag("Player"))
        {
            hasScored = true;
            GameManager.Instance.AddScore();
        }
    }

    public void ResetScoreZone()
    {
        hasScored = false;
    }
}