// Imports the UnityEngine namespace, 
//providing access to core Unity features like MonoBehaviour, GameObjects, and components.
using UnityEngine;

// Imports the UnityEngine.AI namespace, 
//which includes classes and components for navigation and pathfinding (e.g., NavMeshAgent).
using UnityEngine.AI;

// This script is attached to a GameObject to control its movement using a NavMeshAgent.
// Defines a class that inherits from MonoBehaviour, allowing it to be used as a Unity script.
public class AgentMover : MonoBehaviour
{
    // A public variable for assigning the target's Transform in the Inspector, 
    //  representing the destination for the NavMeshAgent.
    public Transform target;

    // A private reference to the NavMeshAgent component that will handle navigation for this GameObject.
    private NavMeshAgent agent;

    // The Start method is called once when the GameObject this script is attached to is enabled.
    void Start()
    {
        // Finds and stores the NavMeshAgent component attached to the same GameObject. 
        // This ensures the script can control the agent.
        agent = GetComponent<NavMeshAgent>();
    }

    // The Update method is called once per frame, 
    // making it suitable for real-time logic.
    void Update()
    {
        // Checks if a target Transform has been assigned to avoid errors 
        //                         if the target is missing or unassigned.
        if (target != null)
        {
            // Sets the agent's destination to the target's position. 
            // The NavMeshAgent calculates and follows the path to this position.
            agent.SetDestination(target.position);
        }
    }
}
