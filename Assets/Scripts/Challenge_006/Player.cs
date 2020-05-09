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

        // Hint that tricked me in UI, drag script from gameObject to event and not from script asset folder
        // so that event discover method
        public void OnAction(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                _rb.useGravity = true;
            }
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
            // _meshRenderer.material.color = Color.blue;

            // tag player because we will use the tag to identify the Player when it will hit the floor
            gameObject.tag = "Player";
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}
