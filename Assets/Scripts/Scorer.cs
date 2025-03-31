using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Ground")
        {
            score++;
            Debug.Log("The Score is " + score);
        }

    }   
    
}
