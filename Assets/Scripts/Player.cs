using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 7f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            inputVector.y += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector.y -= 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x += 1;
        }


        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y).normalized;
        Vector3 moveAmount = moveDir * moveSpeed * Time.deltaTime;

        // Hareketi uyguluyoruz
        transform.Translate(moveAmount, Space.World);
    }
}
