//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/PlayerInputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Game"",
            ""id"": ""f3b792d5-02ec-43d4-a413-e535aab6101e"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""8cc6a45b-0f64-4f94-913a-0323c8c8546b"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""28cc491f-764b-425e-8acc-666e828f4582"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""e183e276-8a8a-43d8-803f-5e76db4d86e2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""376e44eb-de19-4beb-8d70-a18f58e8f8a2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7de5b6e0-3e10-40c3-b988-da58a75a9391"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""83144dfd-e34f-41d9-9bdb-089d167e172c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a1526a75-2a74-4679-9546-ed2681176ebe"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d7451ddd-4168-4213-8fc5-62db5a5b2563"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ControlsPlayer"",
            ""id"": ""7f2f6325-2e42-45b0-bc00-eea92b96ec54"",
            ""actions"": [
                {
                    ""name"": ""LeftCharacter"",
                    ""type"": ""Button"",
                    ""id"": ""73c7eac1-d448-477b-a1a1-25cccf8a77de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RightCharacter"",
                    ""type"": ""Button"",
                    ""id"": ""619b5f41-3e6e-4b4c-bfdc-f0c7ffaa0d31"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""13b8239a-1d7d-4604-88b6-71df58f6cfc3"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftCharacter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""436e491b-5d10-40c2-997a-235b80688b01"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightCharacter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Game
        m_Game = asset.FindActionMap("Game", throwIfNotFound: true);
        m_Game_Move = m_Game.FindAction("Move", throwIfNotFound: true);
        m_Game_Jump = m_Game.FindAction("Jump", throwIfNotFound: true);
        // ControlsPlayer
        m_ControlsPlayer = asset.FindActionMap("ControlsPlayer", throwIfNotFound: true);
        m_ControlsPlayer_LeftCharacter = m_ControlsPlayer.FindAction("LeftCharacter", throwIfNotFound: true);
        m_ControlsPlayer_RightCharacter = m_ControlsPlayer.FindAction("RightCharacter", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Game
    private readonly InputActionMap m_Game;
    private List<IGameActions> m_GameActionsCallbackInterfaces = new List<IGameActions>();
    private readonly InputAction m_Game_Move;
    private readonly InputAction m_Game_Jump;
    public struct GameActions
    {
        private @PlayerInputActions m_Wrapper;
        public GameActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Game_Move;
        public InputAction @Jump => m_Wrapper.m_Game_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Game; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameActions set) { return set.Get(); }
        public void AddCallbacks(IGameActions instance)
        {
            if (instance == null || m_Wrapper.m_GameActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
        }

        private void UnregisterCallbacks(IGameActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
        }

        public void RemoveCallbacks(IGameActions instance)
        {
            if (m_Wrapper.m_GameActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameActions instance)
        {
            foreach (var item in m_Wrapper.m_GameActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameActions @Game => new GameActions(this);

    // ControlsPlayer
    private readonly InputActionMap m_ControlsPlayer;
    private List<IControlsPlayerActions> m_ControlsPlayerActionsCallbackInterfaces = new List<IControlsPlayerActions>();
    private readonly InputAction m_ControlsPlayer_LeftCharacter;
    private readonly InputAction m_ControlsPlayer_RightCharacter;
    public struct ControlsPlayerActions
    {
        private @PlayerInputActions m_Wrapper;
        public ControlsPlayerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftCharacter => m_Wrapper.m_ControlsPlayer_LeftCharacter;
        public InputAction @RightCharacter => m_Wrapper.m_ControlsPlayer_RightCharacter;
        public InputActionMap Get() { return m_Wrapper.m_ControlsPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControlsPlayerActions set) { return set.Get(); }
        public void AddCallbacks(IControlsPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_ControlsPlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ControlsPlayerActionsCallbackInterfaces.Add(instance);
            @LeftCharacter.started += instance.OnLeftCharacter;
            @LeftCharacter.performed += instance.OnLeftCharacter;
            @LeftCharacter.canceled += instance.OnLeftCharacter;
            @RightCharacter.started += instance.OnRightCharacter;
            @RightCharacter.performed += instance.OnRightCharacter;
            @RightCharacter.canceled += instance.OnRightCharacter;
        }

        private void UnregisterCallbacks(IControlsPlayerActions instance)
        {
            @LeftCharacter.started -= instance.OnLeftCharacter;
            @LeftCharacter.performed -= instance.OnLeftCharacter;
            @LeftCharacter.canceled -= instance.OnLeftCharacter;
            @RightCharacter.started -= instance.OnRightCharacter;
            @RightCharacter.performed -= instance.OnRightCharacter;
            @RightCharacter.canceled -= instance.OnRightCharacter;
        }

        public void RemoveCallbacks(IControlsPlayerActions instance)
        {
            if (m_Wrapper.m_ControlsPlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IControlsPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_ControlsPlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ControlsPlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ControlsPlayerActions @ControlsPlayer => new ControlsPlayerActions(this);
    public interface IGameActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IControlsPlayerActions
    {
        void OnLeftCharacter(InputAction.CallbackContext context);
        void OnRightCharacter(InputAction.CallbackContext context);
    }
}
