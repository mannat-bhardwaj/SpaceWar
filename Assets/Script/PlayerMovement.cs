using Unity.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 7f;

 

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        
        Vector2 movement = new Vector2(moveX, 0).normalized;
        transform.Translate(movement * moveSpeed * Time.deltaTime);
        float tempx=Mathf.Clamp(transform.position.x,-8f,8f);

        transform.position = new Vector3(tempx,transform.position.y,transform.position.z);

    }

}