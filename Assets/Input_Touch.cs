// GENERATED AUTOMATICALLY FROM 'Assets/Input_Touch.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Input_Touch : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Input_Touch()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input_Touch"",
    ""maps"": [
        {
            ""name"": ""ARToucActions"",
            ""id"": ""f88729b2-3b15-4fbe-8bc4-56945ec6fe4f"",
            ""actions"": [
                {
                    ""name"": ""PlaceObject"",
                    ""type"": ""Value"",
                    ""id"": ""0b3ebc6e-72c0-4c60-a0cb-8ce34b354d51"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SelectObject"",
                    ""type"": ""Value"",
                    ""id"": ""179bbeae-2ee4-4f04-8c1e-5d37bc1f70c7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveObject"",
                    ""type"": ""Value"",
                    ""id"": ""5085d41f-9ca1-4a09-8726-3957baaf48d4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ResizeObject"",
                    ""type"": ""PassThrough"",
                    ""id"": ""99dfa17b-c154-49e9-9658-3755100b4ff0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1989a41c-2196-4ec3-9f2b-1509c6b62864"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlaceObject"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a15877d-894f-4146-988b-2bf2b29a6db2"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectObject"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""300db0cb-3850-4261-afb2-750ce648183d"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveObject"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6d0f9fd1-3c5d-48b6-a2db-1d31c6909efb"",
                    ""path"": ""<Touchscreen>/touch1/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ResizeObject"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ARToucActions
        m_ARToucActions = asset.FindActionMap("ARToucActions", throwIfNotFound: true);
        m_ARToucActions_PlaceObject = m_ARToucActions.FindAction("PlaceObject", throwIfNotFound: true);
        m_ARToucActions_SelectObject = m_ARToucActions.FindAction("SelectObject", throwIfNotFound: true);
        m_ARToucActions_MoveObject = m_ARToucActions.FindAction("MoveObject", throwIfNotFound: true);
        m_ARToucActions_ResizeObject = m_ARToucActions.FindAction("ResizeObject", throwIfNotFound: true);
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

    // ARToucActions
    private readonly InputActionMap m_ARToucActions;
    private IARToucActionsActions m_ARToucActionsActionsCallbackInterface;
    private readonly InputAction m_ARToucActions_PlaceObject;
    private readonly InputAction m_ARToucActions_SelectObject;
    private readonly InputAction m_ARToucActions_MoveObject;
    private readonly InputAction m_ARToucActions_ResizeObject;
    public struct ARToucActionsActions
    {
        private @Input_Touch m_Wrapper;
        public ARToucActionsActions(@Input_Touch wrapper) { m_Wrapper = wrapper; }
        public InputAction @PlaceObject => m_Wrapper.m_ARToucActions_PlaceObject;
        public InputAction @SelectObject => m_Wrapper.m_ARToucActions_SelectObject;
        public InputAction @MoveObject => m_Wrapper.m_ARToucActions_MoveObject;
        public InputAction @ResizeObject => m_Wrapper.m_ARToucActions_ResizeObject;
        public InputActionMap Get() { return m_Wrapper.m_ARToucActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ARToucActionsActions set) { return set.Get(); }
        public void SetCallbacks(IARToucActionsActions instance)
        {
            if (m_Wrapper.m_ARToucActionsActionsCallbackInterface != null)
            {
                @PlaceObject.started -= m_Wrapper.m_ARToucActionsActionsCallbackInterface.OnPlaceObject;
                @PlaceObject.performed -= m_Wrapper.m_ARToucActionsActionsCallbackInterface.OnPlaceObject;
                @PlaceObject.canceled -= m_Wrapper.m_ARToucActionsActionsCallbackInterface.OnPlaceObject;
                @SelectObject.started -= m_Wrapper.m_ARToucActionsActionsCallbackInterface.OnSelectObject;
                @SelectObject.performed -= m_Wrapper.m_ARToucActionsActionsCallbackInterface.OnSelectObject;
                @SelectObject.canceled -= m_Wrapper.m_ARToucActionsActionsCallbackInterface.OnSelectObject;
                @MoveObject.started -= m_Wrapper.m_ARToucActionsActionsCallbackInterface.OnMoveObject;
                @MoveObject.performed -= m_Wrapper.m_ARToucActionsActionsCallbackInterface.OnMoveObject;
                @MoveObject.canceled -= m_Wrapper.m_ARToucActionsActionsCallbackInterface.OnMoveObject;
                @ResizeObject.started -= m_Wrapper.m_ARToucActionsActionsCallbackInterface.OnResizeObject;
                @ResizeObject.performed -= m_Wrapper.m_ARToucActionsActionsCallbackInterface.OnResizeObject;
                @ResizeObject.canceled -= m_Wrapper.m_ARToucActionsActionsCallbackInterface.OnResizeObject;
            }
            m_Wrapper.m_ARToucActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PlaceObject.started += instance.OnPlaceObject;
                @PlaceObject.performed += instance.OnPlaceObject;
                @PlaceObject.canceled += instance.OnPlaceObject;
                @SelectObject.started += instance.OnSelectObject;
                @SelectObject.performed += instance.OnSelectObject;
                @SelectObject.canceled += instance.OnSelectObject;
                @MoveObject.started += instance.OnMoveObject;
                @MoveObject.performed += instance.OnMoveObject;
                @MoveObject.canceled += instance.OnMoveObject;
                @ResizeObject.started += instance.OnResizeObject;
                @ResizeObject.performed += instance.OnResizeObject;
                @ResizeObject.canceled += instance.OnResizeObject;
            }
        }
    }
    public ARToucActionsActions @ARToucActions => new ARToucActionsActions(this);
    public interface IARToucActionsActions
    {
        void OnPlaceObject(InputAction.CallbackContext context);
        void OnSelectObject(InputAction.CallbackContext context);
        void OnMoveObject(InputAction.CallbackContext context);
        void OnResizeObject(InputAction.CallbackContext context);
    }
}
