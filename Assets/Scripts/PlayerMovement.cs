using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float moveSpeed;
    public int coinCount = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if coin count = 0 then game over scene
        if (coinCount < 1)
        {
            //game over scene
            SceneManager.LoadScene("Scenes/GameOver");
        }
        //if movement keys pressed
        if (Input.GetKey(KeyCode.W))
        {
            print("moving using w");
            rb.linearVelocity = Vector3.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.linearVelocity = Vector3.back * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = Vector3.left * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity = Vector3.right * moveSpeed * Time.deltaTime;
        }
        
    }
}
