using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRception
{
    public class DisappearingWall : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log("The first riddle has been solved: " + EventManager.firstRiddleComplete);
            if (EventManager.firstRiddleComplete)
            {
                gameObject.SetActive(false);
            }
        }
    }
}