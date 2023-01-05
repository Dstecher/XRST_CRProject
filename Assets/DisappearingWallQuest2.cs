using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRception
{
    public class DisappearingWallQuest2 : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            //Debug.Log("The second riddle has been solved: " + EventManager.secondRiddleComplete);
            if (EventManager.secondRiddleComplete)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
