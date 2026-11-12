using UnityEngine;

public class CameraTest : MonoBehaviour
{
    //Attach to Camera and it will pretty much automatically follow the player around,
    //We might need to change player camera to make the visibility a bit better, but its pretty much whatever we can figure out
    //We could also add an up and down rotation or a slight rotation to the camera itself using Q, E maybe
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 cameraPlacement = new Vector3(0f, 0f, 0f);

    private void Start()
    {
        if (player == null) {
            GameObject findPlayer = GameObject.FindGameObjectWithTag("Player");
            player = findPlayer.transform;
        }
    }
    private void LateUpdate()
    {
        if (player != null)
        {
            Vector3 goTo = player.position + cameraPlacement;
            transform.position = Vector3.Lerp(transform.position, goTo, 5 * Time.deltaTime);
        }
    }
}
