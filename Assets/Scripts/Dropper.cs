using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 2f;
    private MeshRenderer mr;
    private Rigidbody rb;

    void Start() 
    {
        mr = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
        mr.enabled = false;
    }
    void Update()
    {
        if (Time.time > timeToWait)
        {
            rb.useGravity = true;
            mr.enabled = true;
        }
    }
}
