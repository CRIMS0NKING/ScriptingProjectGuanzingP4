using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Twenty-First Century Schizoid Man!

        /*Hi There!
         * This is Two Lines
         * */
        Debug.Log(transform.position.x);

        if(transform.position.y <= 5f)
        {
            Debug.Log("Cats Foot, Iron Claw. Neurosurgeons Scream For More. Paranoia's Poison Door. 21st Century Schizoid Man!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
