using UnityEngine;

public class CarMovements : MonoBehaviour
{
    float carSpeed;
    float carReverseSpeed;

    public Rigidbody2D rb;

    public GameObject _groundCheckScript;

    // Start is called before the first frame update
    void Start()
    {
        carSpeed = 4f;
        carReverseSpeed = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        if(_groundCheckScript.GetComponent<GroundCheck>().isGrounded == true)
        {
            if (Input.GetKey(KeyCode.D)) // move right, forwards
            {
                rb.AddForce(transform.right * carSpeed);
            }
            if (Input.GetKey(KeyCode.A)) // move left, backwards
            {
                rb.AddForce(transform.right * -carReverseSpeed);
            }
        }
    }
}