using Code.UI;
using UnityEngine;

namespace Code.SwitchAreas
{
    public class SwitcherArea : MonoBehaviour
    {
        [SerializeField]
        private SwitcherArea _switcherArea;
        [SerializeField]
        private SwitchObject[] _switchObjects;
        [SerializeField]
        private SwitchSeasonUI _uiForButtonImage;
        [SerializeField]
        private bool _switchToWinter;
        private bool _isActive;

        private void Awake()
        {
            _uiForButtonImage.gameObject.SetActive(false);
            _uiForButtonImage.SwitchState(_switchToWinter);
            SwitchSeason(_switchToWinter);
        }

        private void OnTriggerEnter(Collider other)
        {
            _isActive = true;
            _uiForButtonImage.gameObject.SetActive(_isActive);
        }

        private void OnTriggerExit(Collider other)
        {
            _isActive = false;
            _uiForButtonImage.gameObject.SetActive(_isActive);
        }

        private void Update()
        {
            if (_isActive && Input.GetKeyDown(KeyCode.E))
            {
                _switchToWinter = !_switchToWinter;
                _uiForButtonImage.SwitchState(_switchToWinter);
                
                SwitchSeason(!_switchToWinter);
            }
        }

        private void SwitchSeason(bool switchToWinter)
        {
            // _switcherArea.SwitchSeason(switchToWinter);
            foreach (SwitchObject switchObject in _switchObjects) 
                switchObject.SwitchState(switchToWinter);
        }
    }
}
