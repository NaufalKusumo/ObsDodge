using System.Transactions;
using System.Xml.Schema;
using UnityEditor.SceneManagement;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // [SerializeField] float xValue = 0.05f;
    // [SerializeField] float yValue = 0.5f;
    // float zValue = 0.05f;
    [SerializeField] float speed = 0.05f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float yValue = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(xValue, yValue, 0f); 
        // transform.Rotate(50, 0, 0);
        
    }
}
