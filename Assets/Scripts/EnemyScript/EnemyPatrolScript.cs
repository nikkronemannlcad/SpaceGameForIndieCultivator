using UnityEngine;
using System.Collections;

public class EnemyPatrolScript : MonoBehaviour
{
    //Reused code from the rabbit in my game jam game if you have questions about how it fuinctions ask me
    //TLDR: Place down Empty's or Cubes without Collision and Use those as waypoints for transforms, Must stay on same Y level as 
    //Other wise the cubes will move up and down, so only change Y level if you want the cube to like follow the player up a hill or something
    //Probably will update the enemy so it can move up and down against walls naturally? 
    //And then maybe add a follow player script when it gets close enough? I did a similar thing for the boar AI in the game jam game too.

    [SerializeField] private Transform[] waypoints;
    [SerializeField] private float speed = 5f;
    [SerializeField] private float idleTime = 1f;
    [SerializeField] private int currentPatrolPoint = 0;
    private Transform target;

    void Start()
    {
        if (waypoints != null && waypoints.Length > 0 && waypoints[0] != null)
        {
            StartCoroutine(FollowPathRoutine());
        }
    }
    IEnumerator FollowPathRoutine()
    {
        while (true)
        {
            target = waypoints[currentPatrolPoint];

            while (Vector3.Distance(transform.position, target.position) > 0.05f)
            {
                transform.LookAt(target);
                transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
                yield return null;
            }
            transform.position = target.position;
            yield return new WaitForSeconds(idleTime);
            currentPatrolPoint = (currentPatrolPoint + 1) % waypoints.Length;
        }
    }
}
