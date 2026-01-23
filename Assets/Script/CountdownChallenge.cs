using UnityEngine;

public class CountdownChallenge : MonoBehaviour
{
    int startSeconds = 10;
    float timer = 0.0f;
    float waitTime = 1.0f;
    Vector3 newPosition;
    Vector3 newSize;


    // This function prints an integer every second, scales the object, and moves the game object
    public void Update()
    {
        // add the amount of time passed since last framge
        timer += Time.deltaTime;

        // if time passes by 1 second, print countdown
        if (timer >= waitTime && startSeconds >= 0)
        {
            // print time left
            Debug.Log("Time left: " + startSeconds);

            // get the object's current x position, move the game object right every second
            newPosition = transform.position;
            newPosition.x++;
            transform.position = newPosition;

            // get the object's current scale, increase it every second
            newSize = transform.localScale;
            newSize.x++;
            newSize.y++;
            newSize.z++;
            transform.localScale = newSize;

            // update countdown value
            startSeconds--;

            // clear timer
            timer -= waitTime;
        }

        // if the timer reaches below 0, print TIMES UP
        else if (startSeconds == -1)
        {
            Debug.Log("TIMES UP");
            startSeconds--;
        }

    }
}
