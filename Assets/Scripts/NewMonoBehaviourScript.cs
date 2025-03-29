using System.Transactions;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f; // Speed of movement in units per second

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.01f, 0f, 0f); 
        transform.Rotate(50, 0, 0);
    }
}
