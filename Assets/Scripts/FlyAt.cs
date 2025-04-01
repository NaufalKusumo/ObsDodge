using UnityEngine;

public class FlyAt : MonoBehaviour
{
    [SerializeField] Transform PlayerPos;
    Vector3 playerPosition; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = PlayerPos.position;
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, 1f); 
    }
}
