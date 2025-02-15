using Code.UI;
using UnityEngine;

namespace Code.SwitchAreas
{
    public class SwitchArea : MonoBehaviour
    {
        [SerializeField]
        private SwitchObject[] _switchObjects;
        [SerializeField]
        private SwitchSeasonUI _uiForButtonImage;
        private bool _switchToWinter;

        private void Awake()
        {
            _uiForButtonImage.SwitchState(true);
        }

        private void OnTriggerEnter(Collider other)
        {
            _switchToWinter = true;
            _uiForButtonImage.SwitchState(!_switchToWinter);
        }

        private void OnTriggerExit(Collider other)
        {
            _switchToWinter = false;
            _uiForButtonImage.SwitchState(!_switchToWinter);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
                SwitchSeason(!_switchToWinter);
        }

        private void SwitchSeason(bool switchToWinter)
        {
            foreach (SwitchObject switchObject in _switchObjects) 
                switchObject.SwitchState(switchToWinter);
        }
    }
}
