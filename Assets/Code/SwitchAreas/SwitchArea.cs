using System;
using Code.UI;
using UnityEngine;

namespace Code.SwitchAreas
{
    public class SwitchArea : MonoBehaviour
    {
        [SerializeField]
        private GameObject[] areas;
        [SerializeField]
        private SwitchSeasonUI _uiForButtonImage;
        private bool _witchAreaIsAvailable;

        private void Awake()
        {
            _uiForButtonImage.SwitchState(true);
        }

        private void OnTriggerEnter(Collider other)
        {
            _witchAreaIsAvailable = true;
            _uiForButtonImage.SwitchState(true);
        }

        private void OnTriggerExit(Collider other)
        {
            _witchAreaIsAvailable = false;
            _uiForButtonImage.SwitchState(false);
        }

        private void Update()
        {
            if (_witchAreaIsAvailable && Input.GetKeyDown(KeyCode.E))
                SwitchToSamer();
            else if (Input.GetKeyDown(KeyCode.E)) 
                SwitchToWinter();
        }

        private void SwitchToWinter()
        {
            foreach (GameObject area in areas)
            {
                area.SetActive(false);
                SwitchObject switchObject = area.GetComponent<SwitchObject>();
                if(switchObject != null)
                    switchObject.SwitchState(true);
            }
        }

        private void SwitchToSamer()
        {
            foreach (GameObject area in areas)
            {
                area.SetActive(false);
                SwitchObject switchObject = area.GetComponent<SwitchObject>();
                if(switchObject != null)
                    switchObject.SwitchState(false);
            }
        }
    }
}
