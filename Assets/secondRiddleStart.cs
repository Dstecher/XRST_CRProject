using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace VRception
{
    public class secondRiddleStart : MonoBehaviour
    {
        // Update is called once per frame
        void Update()
        {
            Interactable inter = GetComponentInParent<Interactable>();
            bool selected = inter.IsSelected();

            if (selected)
            {
                EventManager.secondRiddleStart = true;
            }
        }
    }
}