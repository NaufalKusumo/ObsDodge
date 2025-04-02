using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    GameObject[] projectiles;

    void Start()
    {
        projectiles = GameObject.FindGameObjectsWithTag("Projectile");
        Debug.Log($"Found {projectiles.Length} projectiles");

    }
    void OnTriggerEnter(Collider other)
    {
        foreach(GameObject projectile in projectiles)
        {
            projectile.SetActive(true);
        }
    }
}
