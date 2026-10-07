using UnityEngine;

public class Coin : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            print("player hit coin");
            other.gameObject.GetComponent<PlayerMovement>().coinCount -= 1;
            Destroy(gameObject);
        }
        else
        {
            print(other.gameObject.name);
        }
    }
}
