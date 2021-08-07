using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform player;
    Vector3 camOffset;

    // Start is called before the first frame update
    void Start()
    {
        camOffset = new Vector3(0f, 3f, -10f);
    }

    // unitys lateUpdate function
    void LateUpdate()
    {
        transform.position = player.position + camOffset;
        transform.LookAt(player.position);
    }   
}
