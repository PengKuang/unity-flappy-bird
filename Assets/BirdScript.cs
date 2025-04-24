using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpForce = 10.0f;
    public bool isAlive = true;
    public LogicScript logic;

    void Start()
    {
        logic = GameObject.FindWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * jumpForce;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            logic.gameOver();
            isAlive = false;
    }
}
