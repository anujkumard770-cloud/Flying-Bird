// using UnityEngine;

// public class PipeController : MonoBehaviour
// {

//     [SerializeField] private float moveSpeed = 1f;
//     [SerializeField] private float hideXPosition = -10f;

//     private PipeSpawner spawner;
//     private ScoreZone scoreZone;

//     void Awake()
//     {
//         scoreZone = GetComponentInChildren<ScoreZone>();
//     }

//     void OnEnable()
//     {
//             scoreZone.ResetScoreZone();
//     }

//     private void Update()
//     {
//         if (GameManager.Instance.GameState != GameState.Playing) 
//          return;

//         transform.position += Vector3.left * moveSpeed * Time.deltaTime;

//         if (transform.position.x < hideXPosition)
//         {
//             spawner.ReturnToPool(this);
//         }
//     }

//     public void Initialize(PipeSpawner pipeSpawner)
//     {
//         spawner = pipeSpawner;
//     }
// }





using UnityEngine;

public class PipeController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] private float hideXPosition = -10f;
    [SerializeField] private GameObject coinObject;

    private PipeSpawner spawner;
    private ScoreZone scoreZone;
    void Awake()
    {
        // Safe check: Component yahan dhoondhein
        scoreZone = GetComponentInChildren<ScoreZone>();
    }

    void OnEnable()
    {
        // FIX: Agar Awake mein nahi mila, to ab dhoondhein aur tabhi reset karein jab null na ho
        if (scoreZone == null)
        {
            scoreZone = GetComponentInChildren<ScoreZone>();
        }

        if (scoreZone != null)
        {
            scoreZone.ResetScoreZone();
        }

        // if (CoinZone == null)
        // {
        //     CoinZone = GetComponentInChildren<CoinZone>();
        // }

        // if (coinZone != null)
        // {
        //     CoinZone.ResetCoinZone();
        // }
    }

    private void Update()
    {
        if (GameManager.Instance.GameState != GameState.Playing)
            return;

        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < hideXPosition)
        {
            if (spawner != null)
            {
                spawner.ReturnToPool(this);
            }
        }
    }

    public void Initialize(PipeSpawner pipeSpawner)
    {
        spawner = pipeSpawner;
    }
}