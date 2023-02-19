// GENERATED AUTOMATICALLY FROM 'Assets/Admin/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""RetroGame"",
            ""id"": ""5648bc72-f2a4-4d39-ac0d-25fdb5bb7b5e"",
            ""actions"": [
                {
                    ""name"": ""Mouse_PointerLocation"",
                    ""type"": ""Value"",
                    ""id"": ""67a39dce-760f-4e73-ac9e-48d09ed8eed4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mouse_LeftButton"",
                    ""type"": ""Button"",
                    ""id"": ""9a1f6759-287c-4961-b8da-0add888699d9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Keyboard_Escape"",
                    ""type"": ""Button"",
                    ""id"": ""f7e6c60b-3582-4ca4-80b6-9260963341f1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Keyboard_AnyKey"",
                    ""type"": ""Button"",
                    ""id"": ""5569a8cc-818a-421d-9d1c-323c09de428e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a2b0e271-437e-4af2-b11e-5b61970134dc"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse_PointerLocation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f7342ea4-e078-4eab-91cf-7b9efdfffba6"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse_LeftButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eec3e6fb-ed58-44df-930d-d7b89bc79335"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Keyboard_AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6130e540-cf43-4480-92a6-631220555993"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Keyboard_Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // RetroGame
        m_RetroGame = asset.FindActionMap("RetroGame", throwIfNotFound: true);
        m_RetroGame_Mouse_PointerLocation = m_RetroGame.FindAction("Mouse_PointerLocation", throwIfNotFound: true);
        m_RetroGame_Mouse_LeftButton = m_RetroGame.FindAction("Mouse_LeftButton", throwIfNotFound: true);
        m_RetroGame_Keyboard_Escape = m_RetroGame.FindAction("Keyboard_Escape", throwIfNotFound: true);
        m_RetroGame_Keyboard_AnyKey = m_RetroGame.FindAction("Keyboard_AnyKey", throwIfNotFound: true);
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

    // RetroGame
    private readonly InputActionMap m_RetroGame;
    private IRetroGameActions m_RetroGameActionsCallbackInterface;
    private readonly InputAction m_RetroGame_Mouse_PointerLocation;
    private readonly InputAction m_RetroGame_Mouse_LeftButton;
    private readonly InputAction m_RetroGame_Keyboard_Escape;
    private readonly InputAction m_RetroGame_Keyboard_AnyKey;
    public struct RetroGameActions
    {
        private @PlayerControls m_Wrapper;
        public RetroGameActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Mouse_PointerLocation => m_Wrapper.m_RetroGame_Mouse_PointerLocation;
        public InputAction @Mouse_LeftButton => m_Wrapper.m_RetroGame_Mouse_LeftButton;
        public InputAction @Keyboard_Escape => m_Wrapper.m_RetroGame_Keyboard_Escape;
        public InputAction @Keyboard_AnyKey => m_Wrapper.m_RetroGame_Keyboard_AnyKey;
        public InputActionMap Get() { return m_Wrapper.m_RetroGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RetroGameActions set) { return set.Get(); }
        public void SetCallbacks(IRetroGameActions instance)
        {
            if (m_Wrapper.m_RetroGameActionsCallbackInterface != null)
            {
                @Mouse_PointerLocation.started -= m_Wrapper.m_RetroGameActionsCallbackInterface.OnMouse_PointerLocation;
                @Mouse_PointerLocation.performed -= m_Wrapper.m_RetroGameActionsCallbackInterface.OnMouse_PointerLocation;
                @Mouse_PointerLocation.canceled -= m_Wrapper.m_RetroGameActionsCallbackInterface.OnMouse_PointerLocation;
                @Mouse_LeftButton.started -= m_Wrapper.m_RetroGameActionsCallbackInterface.OnMouse_LeftButton;
                @Mouse_LeftButton.performed -= m_Wrapper.m_RetroGameActionsCallbackInterface.OnMouse_LeftButton;
                @Mouse_LeftButton.canceled -= m_Wrapper.m_RetroGameActionsCallbackInterface.OnMouse_LeftButton;
                @Keyboard_Escape.started -= m_Wrapper.m_RetroGameActionsCallbackInterface.OnKeyboard_Escape;
                @Keyboard_Escape.performed -= m_Wrapper.m_RetroGameActionsCallbackInterface.OnKeyboard_Escape;
                @Keyboard_Escape.canceled -= m_Wrapper.m_RetroGameActionsCallbackInterface.OnKeyboard_Escape;
                @Keyboard_AnyKey.started -= m_Wrapper.m_RetroGameActionsCallbackInterface.OnKeyboard_AnyKey;
                @Keyboard_AnyKey.performed -= m_Wrapper.m_RetroGameActionsCallbackInterface.OnKeyboard_AnyKey;
                @Keyboard_AnyKey.canceled -= m_Wrapper.m_RetroGameActionsCallbackInterface.OnKeyboard_AnyKey;
            }
            m_Wrapper.m_RetroGameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Mouse_PointerLocation.started += instance.OnMouse_PointerLocation;
                @Mouse_PointerLocation.performed += instance.OnMouse_PointerLocation;
                @Mouse_PointerLocation.canceled += instance.OnMouse_PointerLocation;
                @Mouse_LeftButton.started += instance.OnMouse_LeftButton;
                @Mouse_LeftButton.performed += instance.OnMouse_LeftButton;
                @Mouse_LeftButton.canceled += instance.OnMouse_LeftButton;
                @Keyboard_Escape.started += instance.OnKeyboard_Escape;
                @Keyboard_Escape.performed += instance.OnKeyboard_Escape;
                @Keyboard_Escape.canceled += instance.OnKeyboard_Escape;
                @Keyboard_AnyKey.started += instance.OnKeyboard_AnyKey;
                @Keyboard_AnyKey.performed += instance.OnKeyboard_AnyKey;
                @Keyboard_AnyKey.canceled += instance.OnKeyboard_AnyKey;
            }
        }
    }
    public RetroGameActions @RetroGame => new RetroGameActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IRetroGameActions
    {
        void OnMouse_PointerLocation(InputAction.CallbackContext context);
        void OnMouse_LeftButton(InputAction.CallbackContext context);
        void OnKeyboard_Escape(InputAction.CallbackContext context);
        void OnKeyboard_AnyKey(InputAction.CallbackContext context);
    }
}
