using System.Transactions;
using System.Xml.Schema;
using UnityEditor.SceneManagement;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // [SerializeField] float xValue = 0.05f;
    // [SerializeField] float yValue = 0.5f;
    // float zValue = 0.05f;
    [SerializeField] float MoveSpeed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * MoveSpeed * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;
        transform.Translate(xValue, 0f, zValue); 
        // transform.Rotate(50, 0, 0);
        
    }
}
