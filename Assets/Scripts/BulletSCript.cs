using Unity.Mathematics;
using UnityEngine;

public class BulletSCript : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private GameObject wall;
    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject player;
    [SerializeField] private float rotateX;
    [SerializeField] private float rotateY;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        wall = GameObject.FindWithTag("Wall");
        player = GameObject.FindWithTag("Player");
        //enemy = GameObject.FindWithTag("Enemy");
        rotateX = Mathf.Cos(player.transform.rotation.y);
        rotateY = Mathf.Sin(player.transform.rotation.y);
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3 (rotateY, 0f, 0);
        rb.AddForce(direction);

        Debug.Log(direction);
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
        if (other.CompareTag("Enemy"))
        {
            enemy = other.gameObject;
            Destroy(enemy);
            Destroy(gameObject);
        }
    }
}

