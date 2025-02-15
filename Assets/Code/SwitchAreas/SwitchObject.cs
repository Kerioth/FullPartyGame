using UnityEngine;

namespace Code.SwitchAreas
{
    public class SwitchObject : MonoBehaviour
    {
        [SerializeField] private GameObject[] _winterObject;
        [SerializeField] private GameObject[] _summerObject;
        public void SwitchState(bool stateToWinter)
        {
            SwitchForObjects(stateToWinter, _winterObject);
            SwitchForObjects(!stateToWinter, _summerObject);
        }

        private static void SwitchForObjects(bool state, GameObject[] objectsForSwitch)
        {
            foreach (GameObject objectForSwitch in objectsForSwitch) 
                objectForSwitch.SetActive(state);
        }
    }
}