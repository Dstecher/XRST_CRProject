using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace VRception
{
    public class secondRiddleStartAppear : MonoBehaviour
    {

        // Update is called once per frame
        void Update()
        {
            if (gameObject.layer == 10 && EventManager.firstRiddleComplete)
            {
                gameObject.SetActive(true);
            }
        }
    }
}