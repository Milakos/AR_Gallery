// GENERATED AUTOMATICALLY FROM 'Assets/AR Input Actions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ARInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ARInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""AR Input Actions"",
    ""maps"": [
        {
            ""name"": ""ARTouchActions"",
            ""id"": ""973f5140-5f5b-4d3e-872c-94fe48339655"",
            ""actions"": [
                {
                    ""name"": ""PlaceObject"",
                    ""type"": ""Value"",
                    ""id"": ""dbfdf7a6-a8db-4c68-9e8c-2a3b67b9a94e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SelectObject"",
                    ""type"": ""Value"",
                    ""id"": ""8efc62c9-a1d6-49e5-903f-b5ee7a6cdd7e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveObject"",
                    ""type"": ""Value"",
                    ""id"": ""8d0cc19c-f04a-4343-bb15-bda29a2a4494"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ResizeObject"",
                    ""type"": ""PassThrough"",
                    ""id"": ""06f8bf70-a072-4e9e-8f17-6370f1c6486e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""072ebd51-873a-49fb-b81c-38fe4d5bc183"",
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
                    ""id"": ""d2589564-b13b-49b7-a23b-1eb1aaae3fc2"",
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
                    ""id"": ""3a1dfb50-4fe4-4197-9516-83c8764f04da"",
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
                    ""id"": ""3a022eb1-a6f3-4d16-9a8a-b211ec0ed537"",
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
        // ARTouchActions
        m_ARTouchActions = asset.FindActionMap("ARTouchActions", throwIfNotFound: true);
        m_ARTouchActions_PlaceObject = m_ARTouchActions.FindAction("PlaceObject", throwIfNotFound: true);
        m_ARTouchActions_SelectObject = m_ARTouchActions.FindAction("SelectObject", throwIfNotFound: true);
        m_ARTouchActions_MoveObject = m_ARTouchActions.FindAction("MoveObject", throwIfNotFound: true);
        m_ARTouchActions_ResizeObject = m_ARTouchActions.FindAction("ResizeObject", throwIfNotFound: true);
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

    // ARTouchActions
    private readonly InputActionMap m_ARTouchActions;
    private IARTouchActionsActions m_ARTouchActionsActionsCallbackInterface;
    private readonly InputAction m_ARTouchActions_PlaceObject;
    private readonly InputAction m_ARTouchActions_SelectObject;
    private readonly InputAction m_ARTouchActions_MoveObject;
    private readonly InputAction m_ARTouchActions_ResizeObject;
    public struct ARTouchActionsActions
    {
        private @ARInputActions m_Wrapper;
        public ARTouchActionsActions(@ARInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @PlaceObject => m_Wrapper.m_ARTouchActions_PlaceObject;
        public InputAction @SelectObject => m_Wrapper.m_ARTouchActions_SelectObject;
        public InputAction @MoveObject => m_Wrapper.m_ARTouchActions_MoveObject;
        public InputAction @ResizeObject => m_Wrapper.m_ARTouchActions_ResizeObject;
        public InputActionMap Get() { return m_Wrapper.m_ARTouchActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ARTouchActionsActions set) { return set.Get(); }
        public void SetCallbacks(IARTouchActionsActions instance)
        {
            if (m_Wrapper.m_ARTouchActionsActionsCallbackInterface != null)
            {
                @PlaceObject.started -= m_Wrapper.m_ARTouchActionsActionsCallbackInterface.OnPlaceObject;
                @PlaceObject.performed -= m_Wrapper.m_ARTouchActionsActionsCallbackInterface.OnPlaceObject;
                @PlaceObject.canceled -= m_Wrapper.m_ARTouchActionsActionsCallbackInterface.OnPlaceObject;
                @SelectObject.started -= m_Wrapper.m_ARTouchActionsActionsCallbackInterface.OnSelectObject;
                @SelectObject.performed -= m_Wrapper.m_ARTouchActionsActionsCallbackInterface.OnSelectObject;
                @SelectObject.canceled -= m_Wrapper.m_ARTouchActionsActionsCallbackInterface.OnSelectObject;
                @MoveObject.started -= m_Wrapper.m_ARTouchActionsActionsCallbackInterface.OnMoveObject;
                @MoveObject.performed -= m_Wrapper.m_ARTouchActionsActionsCallbackInterface.OnMoveObject;
                @MoveObject.canceled -= m_Wrapper.m_ARTouchActionsActionsCallbackInterface.OnMoveObject;
                @ResizeObject.started -= m_Wrapper.m_ARTouchActionsActionsCallbackInterface.OnResizeObject;
                @ResizeObject.performed -= m_Wrapper.m_ARTouchActionsActionsCallbackInterface.OnResizeObject;
                @ResizeObject.canceled -= m_Wrapper.m_ARTouchActionsActionsCallbackInterface.OnResizeObject;
            }
            m_Wrapper.m_ARTouchActionsActionsCallbackInterface = instance;
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
    public ARTouchActionsActions @ARTouchActions => new ARTouchActionsActions(this);
    public interface IARTouchActionsActions
    {
        void OnPlaceObject(InputAction.CallbackContext context);
        void OnSelectObject(InputAction.CallbackContext context);
        void OnMoveObject(InputAction.CallbackContext context);
        void OnResizeObject(InputAction.CallbackContext context);
    }
}
