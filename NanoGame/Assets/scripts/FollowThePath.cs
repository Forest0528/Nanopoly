using UnityEngine;

public class FollowThePath : MonoBehaviour {

    public Transform[] waypoints;

    [SerializeField]
    private float moveSpeed = 1f;

    [HideInInspector]
    public int waypointIndex = 0;

    public bool moveAllowed = false;

    private int _baseWayIndex = 0;

	// Use this for initialization
	private void Start () {
        transform.position = waypoints[waypointIndex].transform.position;
	}
	
	// Update is called once per frame
	private void Update () {
        if (moveAllowed)
            Move();        
    }

    private void Move()
    {
        
        if (waypointIndex <= waypoints.Length)
        {
            transform.position = Vector2.MoveTowards(transform.position,
            waypoints[waypointIndex].transform.position,
            moveSpeed * Time.deltaTime);

            //if (waypointindex == waypoints.length)
            //{
            //    waypointindex = 0;
            //}

            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex ++;
                moveAllowed = false;
            }
            /*if (transform.position == waypoints[39].transform.position && moveAllowed==true)
            {
                moveAllowed = false;                
            }*/
        }
    }
}
