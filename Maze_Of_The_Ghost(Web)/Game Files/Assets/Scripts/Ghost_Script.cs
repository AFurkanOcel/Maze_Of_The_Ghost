using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost_Script : MonoBehaviour
{
    public bool ghoststopped = false; // Tracks if the ghost is stopped
    public GameObject player; // Reference to the player
    public float speed = 0.4f; // Movement speed of the ghost
    public float rotationspeed = 1f; // Rotation speed of the ghost

    void Update()
    {
        GhostMovement(); // Controls the ghost's movement
    }

    public void GhostMovement()
    {
        // Moves the ghost toward the player if not stopped
        if (!ghoststopped)
        {
            Vector3 direction = (player.transform.position - transform.position).normalized;
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * rotationspeed);
            transform.position += direction * speed * Time.deltaTime;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        // Stops the ghost if it collides with a snowball
        if (other.gameObject.tag == "snowball")
        {
            Destroy(other.gameObject);
            GhostStop();
        }
    }

    public void GhostStop()
    {
        ghoststopped = true; // Stops the ghost temporarily
        StartCoroutine(GhostStopBreak());
    }

    IEnumerator GhostStopBreak()
    {
        // Resumes ghost movement after a delay
        yield return new WaitForSeconds(5);
        ghoststopped = false;
    }
}
