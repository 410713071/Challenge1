using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(0, 2, -10);
    public float distanceUp = 2f;
    public float distanceAway = 10f;
    public float distanceback = 6f;
    public float smooth = 2f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = plane.transform.position + offset;

    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 dispos = plane.transform.position + Vector3.up * distanceUp + Vector3.right * distanceAway + Vector3.back * distanceback ;
        transform.position = Vector3.Lerp(transform.position, dispos, Time.deltaTime * smooth);
        transform.LookAt(plane.transform.position);
       


    }
}
