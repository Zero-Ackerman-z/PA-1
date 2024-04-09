using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    [SerializeField] private float jumpForce = 5f;

    [Header("Raycast Properties")]
    [SerializeField] private LayerMask groundLayers;
    [SerializeField] private float rayDistance = 2f;
    [SerializeField] private Color rayDebugColor = Color.red;

    private Vector3 movement;
    private Rigidbody myRB;
    private bool canJump;
    private PlayerInputActions controls;
    float movimientoInput;
    private void Awake()
    {
        controls = new PlayerInputActions();
        controls.Game.Move.performed += ctx => Movimiento(ctx);
        controls.Game.Jump.performed += ctx => Salto(ctx);
    }
    private void OnEnable()
    {
        controls.Game.Enable();
        controls.ControlsPlayer.Enable();
    }
    private void OnDisable()
    {
        controls.Game.Disable();
        controls.ControlsPlayer.Disable();
    }
    void Start()
    {
        myRB = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(movimientoInput ,myRB.velocity.y);

        canJump = Physics.Raycast(transform.position, Vector3.down, rayDistance, groundLayers);

        Debug.DrawRay(transform.position, Vector3.down * rayDistance, rayDebugColor);        

    }

    private void FixedUpdate()
    {
        myRB.velocity = Vector3.Scale(movement, new Vector3(speed, 1, speed));


    }    
    public void Movimiento(InputAction.CallbackContext context)
    {
       // movimientoInput = context.ReadValue<Vector3>();
    }

    private void StopMovement()
    {
        //movimientoInput = Vector3.zero;
    }
    public void Salto(InputAction.CallbackContext context)
    {
        myRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

    }
    public void Cambio_player(InputAction.CallbackContext context)
    {

    }

}
