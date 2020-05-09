using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Challenge_006
{
    public class Player : MonoBehaviour
    {
        // Start is called before the first frame update
        Rigidbody _rb;
        MeshRenderer _meshRenderer;
        [SerializeField] private GameObject _floor;
        MeshRenderer _floorMeshRenderer;


        // Hint that tricked me in UI, drag script from gameObject to event and not from script asset folder
        // so that event discover method
        public void OnAction(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                _rb.useGravity = true;
            }

            _floorMeshRenderer.material.color = Color.red;
        }

        void Start()
        {
            // Get Rigidbody and remove gravity so that is does NOT fall
            _rb = gameObject.GetComponent<Rigidbody>();
            if (_rb == null)
            {
                _rb = gameObject.AddComponent<Rigidbody>();
            }
            _rb.useGravity = false;

            // Get MeshRenderer to Access Color
            _meshRenderer = gameObject.GetComponent<MeshRenderer>();

            // tag player because we will use the tag to identify the Player when it will hit the floor
            gameObject.tag = "Player";

            if (_floor != null)
            {
                _floorMeshRenderer = _floor.GetComponent<MeshRenderer>();    
            }
            else
            {
                throw new MissingComponentException("floor component is not assign in the inspector");
            }
            
        }
    }

}
