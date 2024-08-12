using UnityEngine;

public class FloatingDanger : MonoBehaviour
{
    public float speed = 2f; 
    public float distance = 3f; 

    private Vector2 startPosition; 

    void Start()
    {
        startPosition = transform.position; 
    }

    void Update()
    {
        float newY = startPosition.y + Mathf.PingPong(Time.time * speed, distance);
        transform.position = new Vector2(startPosition.x, newY);
    }
}