using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRception
{
    public class secondRiddleLid : MonoBehaviour
    {
        private bool isOpen = false;
        // Update is called once per frame
        void Update()
        {
            if (EventManager.secondRiddleStart && !isOpen)
            {
                transform.position += new Vector3(0f, 0.5f, 0f);
            }
        }
    }
}