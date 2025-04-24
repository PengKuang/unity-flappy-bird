using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnInterval = 10.5f;
    private float timer = 0.0f;
    public float heightOffset = 10.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > spawnInterval)
        {
            spawnPipe();
            timer = 0.0f;
        } else
        {
            timer += Time.deltaTime;
        }
    }
    
    void spawnPipe()
    {   
        float highestPoint = transform.position.y + heightOffset;
        float lowestPoint = transform.position.y - heightOffset;

        float positionY = Random.Range(lowestPoint, highestPoint);

        Instantiate(pipe, new Vector3(transform.position.x, positionY, 0), transform.rotation);
    }


}
