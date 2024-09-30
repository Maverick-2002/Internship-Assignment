using UnityEngine;

public class Shape : MonoBehaviour
{
    public int points;
    public float spinSpeed = 50.0f;

    private void Update()
    {
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.Instance.AddPoints(points);
            Destroy(gameObject);
        }
    }
}
