using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Player")) //other.gameObject.tag == "Player" can be usable, but not recommended 
        {
            GetComponent<MeshRenderer>().material.color = Color.red; 
            gameObject.tag = "Hit";
        }
    }
}
