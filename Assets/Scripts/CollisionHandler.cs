using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
        void OnCollisionEnter(Collision other)
        {
            switch (other.gameObject.tag)
            {
                case "Finish":
                    Debug.Log("You reached the finish.");
                    break;
                case "Friendly":
                    Debug.Log("This object is friendly. Yay!");
                    break;
                case "Fuel":
                    Debug.Log("You picked up some fuel.");
                    break;
                default:
                    Debug.Log("You bumped into something. Ouch!");
                    break;
            }
        }
}
