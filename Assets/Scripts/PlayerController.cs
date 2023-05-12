using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody rb;
    public float speed;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if ( Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow) )
        {
            rb.AddForce(speed * Time.deltaTime, 0, 0);
        }
        else if ( Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow) )
        {
            rb.AddForce(-speed * Time.deltaTime, 0, 0);
        }
        else if ( Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, -speed * Time.deltaTime);
        }
        else if ( Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        score += 50;
        Debug.Log("Score: " + score);
        if (other.gameObject.CompareTag("Pickup"))
        {
            Destroy(other.gameObject);
        }
    }
}
