using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject StarPrefab;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Instantiate(StarPrefab, transform.position, transform.rotation);
        }
    }
}