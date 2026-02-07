using System.Transactions;
using System.Xml.Schema;
using UnityEditor.SceneManagement;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] float MoveSpeed = 10f;
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

    void PrintInstruction()
    {
        Debug.Log("Hello Everyone");
    }
}
