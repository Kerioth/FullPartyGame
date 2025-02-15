using UnityEngine;

namespace Code.UI
{
    public class SwitchSeasonUI : MonoBehaviour
    {
        [SerializeField] private GameObject _summerImage;
        
        public void SwitchState(bool stateToWinter)
        {
            _summerImage.SetActive(!stateToWinter);
        }
    }
}
