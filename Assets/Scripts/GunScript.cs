using UnityEngine;

public class GunScript : MonoBehaviour
{
    public GameObject Bullet;
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Instantiate(Bullet, transform.position , transform.rotation);
        }
    }
}
