using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] private Transform projectileParent; // Assign this in Inspector
    private GameObject[] projectiles;

    void Start()
    {
        // Get all children of the parent, even inactive ones
        projectiles = new GameObject[projectileParent.childCount];
        for(int i = 0; i < projectileParent.childCount; i++)
        {
            projectiles[i] = projectileParent.GetChild(i).gameObject;
        }
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


    // GameObject[] projectiles;

    // void Start()
    // {
    //     projectiles = GameObject.FindGameObjectsWithTag("Projectile");
    //     Debug.Log($"Found {projectiles.Length} projectiles");

    // }