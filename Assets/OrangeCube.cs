using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRception
{
    public class OrangeCube : MonoBehaviour
    {
        public GameObject[] currentCollisions = null;

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            if (checkForQuestCompletion())
            {
                Debug.Log("[DEBUG] Quest complete!!");
                EventManager.firstRiddleComplete = true;
            }
        }

        bool checkForQuestCompletion()
        {
            Material cube_material = GetComponent<Renderer>().material;
            //Debug.Log("This is the cube material: " + cube_material.name);

            if (cube_material.name.Contains("VibrantOrange")) // just to make sure
            {
                CollisionDetector collisionDetector = GetComponent<CollisionDetector>();
                currentCollisions = collisionDetector.GetCurrentCollisions();
                //Debug.Log("[DEBUG] Those are the current collisions " + currentCollisions);
                if (currentCollisions.Length > 1)
                {
                    bool magentaExists = false;
                    bool pinkExists = false;
                    foreach (GameObject collisionObject in currentCollisions)
                    {
                        Material collisionMaterial = collisionObject.GetComponent<Renderer>().material;
                        if (collisionMaterial != null)
                        {
                            if (collisionMaterial.name.Contains("VibrantMagenta"))
                            {
                                magentaExists = true;
                            }
                            if (collisionMaterial.name.Contains("VibrantPink"))
                            {
                                pinkExists = true;
                            }
                        }
                    }
                    if (magentaExists && pinkExists)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}