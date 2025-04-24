using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float speed = 30.0f;
    public float destroyX = -88.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += Vector3.left * speed * Time.deltaTime;

        if (gameObject.transform.position.x < destroyX)
        {
            Debug.Log("Destroying pipe");
            Destroy(gameObject);
        }
    }
}
