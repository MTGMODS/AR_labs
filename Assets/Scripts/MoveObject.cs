using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float distance = 1f;
    public float speed = 2f;

    private Vector3 startPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float offset = Mathf.Sin(Time.time * speed) * distance;

        transform.position = startPosition + new Vector3(0f, 0f, offset);
    }
}