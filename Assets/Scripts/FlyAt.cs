using UnityEngine;

public class FlyAt : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] Transform PlayerPos;
    Vector3 playerPosition; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPosition = PlayerPos.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed); 
    }
}
