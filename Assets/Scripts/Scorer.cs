using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.name != "Ground")
        {
            if (gameObject.tag != "Hit")
            {
                score++;
                Debug.Log("Score is " + score);
                
            }

        }    
    }
}
