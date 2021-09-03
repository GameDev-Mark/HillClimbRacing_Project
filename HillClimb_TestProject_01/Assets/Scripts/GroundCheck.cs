using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [SerializeField] public bool isGrounded;

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        isGrounded = false;
    }
}