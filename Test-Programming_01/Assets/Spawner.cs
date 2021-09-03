using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int gridSize;

    public GameObject balls;
    public Transform gameTrans;

    // unitys awake function
    void Awake()
    {
        SpawnIT();
    }

    // spawn triangle
    void SpawnIT(int gridSizeee = 4)
    {
        for (int y = 0; y < gridSizeee; y++)
        {
            for (int x = y; x < 2 * gridSizeee - y - 1; x++)
            {
                Vector3 pos = new Vector3(x, y, 0f);
                var ballTri = Instantiate(balls, pos, Quaternion.identity);
                ballTri.transform.parent = gameTrans.transform;
                Debug.Log(balls);
            }
        }
    }
}