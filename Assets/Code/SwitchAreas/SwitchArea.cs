using UnityEngine;

namespace Code.SwitchAreas
{
    public class SwitchArea : MonoBehaviour
    {
        public GameObject[] areas;
        
        public void SwitchInteract()
        {
            Debug.Log("----------------");
        }

        private void SwitchToWinter()
        {
            foreach (GameObject area in areas) 
                area.SetActive(true);
        }
    }
}
