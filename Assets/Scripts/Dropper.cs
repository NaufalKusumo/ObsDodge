using UnityEngine;

public class Dropper : MonoBehaviour
{
    void Update()
    {
        if (Time.time > 3)
        {
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
