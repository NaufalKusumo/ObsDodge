using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;
    void OnCollisionEnter(Collision collision)
    {
        score++;
        Debug.Log("The Score is " + score);
    }   
    
}
