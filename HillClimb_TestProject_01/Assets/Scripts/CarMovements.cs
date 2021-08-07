using UnityEngine;

public class CarMovements : MonoBehaviour
{
    float carSpeed;

    // Start is called before the first frame update
    void Start()
    {
        carSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D)) // move right
        {
            transform.position = Vector3.right * carSpeed * Time.deltaTime;
        }
    }
}
