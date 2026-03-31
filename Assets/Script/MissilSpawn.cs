using UnityEngine;

public class MissileSpawn : MonoBehaviour
{
    public GameObject missilePrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(missilePrefab, transform.position, transform.rotation);
        }
    }
}