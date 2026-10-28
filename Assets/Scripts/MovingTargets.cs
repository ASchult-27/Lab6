using UnityEngine;

public class MovingTargets : MonoBehaviour
{
    public float speed = 2f;
    public float distance = 3f;

    private float startX;
    private bool movingRight = true;

    void Start()
    {
        startX = transform.position.x;
    }

    void Update()
    {
        float movement =
            speed * Time.deltaTime;

        if (movingRight)
        {
            transform.Translate(
                movement,
                0f,
                0f
            );

            if (transform.position.x >=
                startX + distance)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.Translate(
                -movement,
                0f,
                0f
            );

            if (transform.position.x <=
                startX - distance)
            {
                movingRight = true;
            }
        }
    }
}
