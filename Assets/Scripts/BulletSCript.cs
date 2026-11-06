using UnityEngine;

public class BulletSCript : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private GameObject wall;
    [SerializeField] private GameObject enemy;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
            rb = GetComponent<Rigidbody>();
            wall = GameObject.FindWithTag("Wall");
            enemy = GameObject.FindWithTag("Enemy");
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3 (1f, 0f, 0f);
            rb.AddForce(direction);
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
        if (other.CompareTag("Enemy"))
        {
            Destroy(enemy);
            Destroy(gameObject);
        }
    }
}
