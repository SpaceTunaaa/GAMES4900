using UnityEngine;

public class UpdateTimer : MonoBehaviour
{
    float timer = 0.0f;
    float waitTime = 1.0f;
    int counter =0;

    public void Update()
    {
        // Add the timer passed since the last frame to our timer
        timer += Time.deltaTime;

        // Check if the timer has reached out target (1 second)
        if (timer >= waitTime)
        {
            Debug.Log("counter value = " + counter);
            
            // Reset the timer
             timer -= waitTime;

            // change the position of the cube
            transform.position = new Vector3(counter, 0, 0);
            
            // Increment the counter
            counter++;
        }
        
        

    }
}
