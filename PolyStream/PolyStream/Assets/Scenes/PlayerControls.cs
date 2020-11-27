// GENERATED AUTOMATICALLY FROM 'Assets/Scenes/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""GamePlay"",
            ""id"": ""0fd483da-91db-42c0-a303-a5064e243b7b"",
            ""actions"": [
                {
                    ""name"": ""Move Left"",
                    ""type"": ""Button"",
                    ""id"": ""44edfa68-6d25-45ca-b7f1-263e2f3ea65d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move Right"",
                    ""type"": ""Button"",
                    ""id"": ""9bea8d37-9b6f-44a9-b6ff-308d139fe24c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu Select"",
                    ""type"": ""Button"",
                    ""id"": ""57d43284-bdbe-4530-b5f0-1d0b45b6e730"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump A"",
                    ""type"": ""Button"",
                    ""id"": ""a6ad7c32-3c7e-4b2a-81e3-9a4ba2aba6be"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Boost RT"",
                    ""type"": ""Button"",
                    ""id"": ""5690b9e3-6841-4e0a-9fa3-f0898dfa76a0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Brake LT"",
                    ""type"": ""Button"",
                    ""id"": ""d7004c81-7d6e-47e5-8a2d-4d75ca399fe3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start Select"",
                    ""type"": ""Button"",
                    ""id"": ""c906ec53-16e7-4c5b-bb8f-733dcddea2c1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Level Select"",
                    ""type"": ""Button"",
                    ""id"": ""f4ff23a0-4266-4d72-aedb-14d2c2af50c6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Store Select"",
                    ""type"": ""Button"",
                    ""id"": ""ededd5df-5614-478e-b3cc-c4c3f9a2dee9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Credits Select"",
                    ""type"": ""Button"",
                    ""id"": ""e279eb76-6728-415a-9909-15f5b7f36cfe"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Retry X"",
                    ""type"": ""Button"",
                    ""id"": ""258a79aa-4bbb-4140-8d06-c860ca5869a5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Next Level RB"",
                    ""type"": ""Button"",
                    ""id"": ""63fb40b4-2b33-4820-903d-3488117094ea"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""df75f94d-3bfe-4cca-9278-e473af02ae0a"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""492d97f3-9d06-4017-a105-e0ccc3cd191d"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""44e5e896-3915-4a03-8263-27ab46b2af01"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96112540-f79a-400c-ada2-5aaaf2b63f27"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""87873b41-6dfc-4e25-b50d-8e081a582f63"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost RT"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d13cf6af-9cfa-4173-b9f7-b8a9d0ea9442"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake LT"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""abb153e8-fba7-46dc-888e-a0901cc79627"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b90613b-0ee0-4877-844e-61a9dcbd2a79"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Level Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""91723e87-1de8-42d8-afde-4e4693436005"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Store Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""251754ee-8698-40e4-8e84-1db07e279de0"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Credits Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a9296ba-3e15-4141-952e-61f358f438b8"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Retry X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a5aec83-702c-4e1e-9d70-300ad13c40e9"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next Level RB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Store"",
            ""id"": ""cbbc785f-de2e-4bf0-bd7f-198f869c5677"",
            ""actions"": [
                {
                    ""name"": ""FreeMoney_A"",
                    ""type"": ""Button"",
                    ""id"": ""5212e728-f4a6-417a-af12-95bd56cd1069"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu_Y"",
                    ""type"": ""Button"",
                    ""id"": ""92c2fd60-0ed7-480b-927f-6acda3191b06"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Restart_X"",
                    ""type"": ""Button"",
                    ""id"": ""6e118400-cfc0-4ce1-8d4a-e63f3d452a4d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Red_Up"",
                    ""type"": ""Button"",
                    ""id"": ""132d71d3-49c5-498e-bcec-f1f91634e4bc"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Green_Left"",
                    ""type"": ""Button"",
                    ""id"": ""b39b4cd8-a3f7-4c42-8328-6c4d284ba861"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Yellow_Down"",
                    ""type"": ""Button"",
                    ""id"": ""75e73f45-661a-46ad-859b-6281a1cdff9e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Orange_Right"",
                    ""type"": ""Button"",
                    ""id"": ""1cd6a8c4-3812-422d-a356-cf7d847e3b5f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Black_LB"",
                    ""type"": ""Button"",
                    ""id"": ""8e3003c8-1df3-42b5-856c-3d96eb857299"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Indigo_RB"",
                    ""type"": ""Button"",
                    ""id"": ""9dd9749a-c3fa-42ae-b0a1-bfb5a1687a05"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""df0c1f4a-02eb-4c92-bdf1-de5ffd6e1220"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FreeMoney_A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74846f6d-0f8e-48a4-bc15-6627846c0219"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu_Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f8b0762-54d1-47ac-8c89-3a6e9c1fd221"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Restart_X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e079a44-d724-47db-88f7-f66b53bc2aee"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Red_Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63012336-865a-481f-ac09-709133b05de5"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Green_Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6aecb159-d027-41aa-9c77-51af1ef101c2"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yellow_Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f5676a83-9808-4639-8adb-1355f96d59e7"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Orange_Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""963a8723-4a6a-45ef-b08e-58b5b489c943"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Black_LB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f944dcf-0611-43b3-8ff3-e15326cf33c7"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Indigo_RB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GamePlay
        m_GamePlay = asset.FindActionMap("GamePlay", throwIfNotFound: true);
        m_GamePlay_MoveLeft = m_GamePlay.FindAction("Move Left", throwIfNotFound: true);
        m_GamePlay_MoveRight = m_GamePlay.FindAction("Move Right", throwIfNotFound: true);
        m_GamePlay_MenuSelect = m_GamePlay.FindAction("Menu Select", throwIfNotFound: true);
        m_GamePlay_JumpA = m_GamePlay.FindAction("Jump A", throwIfNotFound: true);
        m_GamePlay_BoostRT = m_GamePlay.FindAction("Boost RT", throwIfNotFound: true);
        m_GamePlay_BrakeLT = m_GamePlay.FindAction("Brake LT", throwIfNotFound: true);
        m_GamePlay_StartSelect = m_GamePlay.FindAction("Start Select", throwIfNotFound: true);
        m_GamePlay_LevelSelect = m_GamePlay.FindAction("Level Select", throwIfNotFound: true);
        m_GamePlay_StoreSelect = m_GamePlay.FindAction("Store Select", throwIfNotFound: true);
        m_GamePlay_CreditsSelect = m_GamePlay.FindAction("Credits Select", throwIfNotFound: true);
        m_GamePlay_RetryX = m_GamePlay.FindAction("Retry X", throwIfNotFound: true);
        m_GamePlay_NextLevelRB = m_GamePlay.FindAction("Next Level RB", throwIfNotFound: true);
        // Store
        m_Store = asset.FindActionMap("Store", throwIfNotFound: true);
        m_Store_FreeMoney_A = m_Store.FindAction("FreeMoney_A", throwIfNotFound: true);
        m_Store_Menu_Y = m_Store.FindAction("Menu_Y", throwIfNotFound: true);
        m_Store_Restart_X = m_Store.FindAction("Restart_X", throwIfNotFound: true);
        m_Store_Red_Up = m_Store.FindAction("Red_Up", throwIfNotFound: true);
        m_Store_Green_Left = m_Store.FindAction("Green_Left", throwIfNotFound: true);
        m_Store_Yellow_Down = m_Store.FindAction("Yellow_Down", throwIfNotFound: true);
        m_Store_Orange_Right = m_Store.FindAction("Orange_Right", throwIfNotFound: true);
        m_Store_Black_LB = m_Store.FindAction("Black_LB", throwIfNotFound: true);
        m_Store_Indigo_RB = m_Store.FindAction("Indigo_RB", throwIfNotFound: true);
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

    // GamePlay
    private readonly InputActionMap m_GamePlay;
    private IGamePlayActions m_GamePlayActionsCallbackInterface;
    private readonly InputAction m_GamePlay_MoveLeft;
    private readonly InputAction m_GamePlay_MoveRight;
    private readonly InputAction m_GamePlay_MenuSelect;
    private readonly InputAction m_GamePlay_JumpA;
    private readonly InputAction m_GamePlay_BoostRT;
    private readonly InputAction m_GamePlay_BrakeLT;
    private readonly InputAction m_GamePlay_StartSelect;
    private readonly InputAction m_GamePlay_LevelSelect;
    private readonly InputAction m_GamePlay_StoreSelect;
    private readonly InputAction m_GamePlay_CreditsSelect;
    private readonly InputAction m_GamePlay_RetryX;
    private readonly InputAction m_GamePlay_NextLevelRB;
    public struct GamePlayActions
    {
        private @PlayerControls m_Wrapper;
        public GamePlayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveLeft => m_Wrapper.m_GamePlay_MoveLeft;
        public InputAction @MoveRight => m_Wrapper.m_GamePlay_MoveRight;
        public InputAction @MenuSelect => m_Wrapper.m_GamePlay_MenuSelect;
        public InputAction @JumpA => m_Wrapper.m_GamePlay_JumpA;
        public InputAction @BoostRT => m_Wrapper.m_GamePlay_BoostRT;
        public InputAction @BrakeLT => m_Wrapper.m_GamePlay_BrakeLT;
        public InputAction @StartSelect => m_Wrapper.m_GamePlay_StartSelect;
        public InputAction @LevelSelect => m_Wrapper.m_GamePlay_LevelSelect;
        public InputAction @StoreSelect => m_Wrapper.m_GamePlay_StoreSelect;
        public InputAction @CreditsSelect => m_Wrapper.m_GamePlay_CreditsSelect;
        public InputAction @RetryX => m_Wrapper.m_GamePlay_RetryX;
        public InputAction @NextLevelRB => m_Wrapper.m_GamePlay_NextLevelRB;
        public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
        public void SetCallbacks(IGamePlayActions instance)
        {
            if (m_Wrapper.m_GamePlayActionsCallbackInterface != null)
            {
                @MoveLeft.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMoveLeft;
                @MoveRight.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMoveRight;
                @MenuSelect.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMenuSelect;
                @MenuSelect.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMenuSelect;
                @MenuSelect.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnMenuSelect;
                @JumpA.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnJumpA;
                @JumpA.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnJumpA;
                @JumpA.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnJumpA;
                @BoostRT.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBoostRT;
                @BoostRT.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBoostRT;
                @BoostRT.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBoostRT;
                @BrakeLT.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBrakeLT;
                @BrakeLT.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBrakeLT;
                @BrakeLT.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBrakeLT;
                @StartSelect.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnStartSelect;
                @StartSelect.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnStartSelect;
                @StartSelect.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnStartSelect;
                @LevelSelect.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnLevelSelect;
                @LevelSelect.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnLevelSelect;
                @LevelSelect.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnLevelSelect;
                @StoreSelect.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnStoreSelect;
                @StoreSelect.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnStoreSelect;
                @StoreSelect.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnStoreSelect;
                @CreditsSelect.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCreditsSelect;
                @CreditsSelect.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCreditsSelect;
                @CreditsSelect.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnCreditsSelect;
                @RetryX.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRetryX;
                @RetryX.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRetryX;
                @RetryX.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRetryX;
                @NextLevelRB.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnNextLevelRB;
                @NextLevelRB.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnNextLevelRB;
                @NextLevelRB.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnNextLevelRB;
            }
            m_Wrapper.m_GamePlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
                @MenuSelect.started += instance.OnMenuSelect;
                @MenuSelect.performed += instance.OnMenuSelect;
                @MenuSelect.canceled += instance.OnMenuSelect;
                @JumpA.started += instance.OnJumpA;
                @JumpA.performed += instance.OnJumpA;
                @JumpA.canceled += instance.OnJumpA;
                @BoostRT.started += instance.OnBoostRT;
                @BoostRT.performed += instance.OnBoostRT;
                @BoostRT.canceled += instance.OnBoostRT;
                @BrakeLT.started += instance.OnBrakeLT;
                @BrakeLT.performed += instance.OnBrakeLT;
                @BrakeLT.canceled += instance.OnBrakeLT;
                @StartSelect.started += instance.OnStartSelect;
                @StartSelect.performed += instance.OnStartSelect;
                @StartSelect.canceled += instance.OnStartSelect;
                @LevelSelect.started += instance.OnLevelSelect;
                @LevelSelect.performed += instance.OnLevelSelect;
                @LevelSelect.canceled += instance.OnLevelSelect;
                @StoreSelect.started += instance.OnStoreSelect;
                @StoreSelect.performed += instance.OnStoreSelect;
                @StoreSelect.canceled += instance.OnStoreSelect;
                @CreditsSelect.started += instance.OnCreditsSelect;
                @CreditsSelect.performed += instance.OnCreditsSelect;
                @CreditsSelect.canceled += instance.OnCreditsSelect;
                @RetryX.started += instance.OnRetryX;
                @RetryX.performed += instance.OnRetryX;
                @RetryX.canceled += instance.OnRetryX;
                @NextLevelRB.started += instance.OnNextLevelRB;
                @NextLevelRB.performed += instance.OnNextLevelRB;
                @NextLevelRB.canceled += instance.OnNextLevelRB;
            }
        }
    }
    public GamePlayActions @GamePlay => new GamePlayActions(this);

    // Store
    private readonly InputActionMap m_Store;
    private IStoreActions m_StoreActionsCallbackInterface;
    private readonly InputAction m_Store_FreeMoney_A;
    private readonly InputAction m_Store_Menu_Y;
    private readonly InputAction m_Store_Restart_X;
    private readonly InputAction m_Store_Red_Up;
    private readonly InputAction m_Store_Green_Left;
    private readonly InputAction m_Store_Yellow_Down;
    private readonly InputAction m_Store_Orange_Right;
    private readonly InputAction m_Store_Black_LB;
    private readonly InputAction m_Store_Indigo_RB;
    public struct StoreActions
    {
        private @PlayerControls m_Wrapper;
        public StoreActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @FreeMoney_A => m_Wrapper.m_Store_FreeMoney_A;
        public InputAction @Menu_Y => m_Wrapper.m_Store_Menu_Y;
        public InputAction @Restart_X => m_Wrapper.m_Store_Restart_X;
        public InputAction @Red_Up => m_Wrapper.m_Store_Red_Up;
        public InputAction @Green_Left => m_Wrapper.m_Store_Green_Left;
        public InputAction @Yellow_Down => m_Wrapper.m_Store_Yellow_Down;
        public InputAction @Orange_Right => m_Wrapper.m_Store_Orange_Right;
        public InputAction @Black_LB => m_Wrapper.m_Store_Black_LB;
        public InputAction @Indigo_RB => m_Wrapper.m_Store_Indigo_RB;
        public InputActionMap Get() { return m_Wrapper.m_Store; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(StoreActions set) { return set.Get(); }
        public void SetCallbacks(IStoreActions instance)
        {
            if (m_Wrapper.m_StoreActionsCallbackInterface != null)
            {
                @FreeMoney_A.started -= m_Wrapper.m_StoreActionsCallbackInterface.OnFreeMoney_A;
                @FreeMoney_A.performed -= m_Wrapper.m_StoreActionsCallbackInterface.OnFreeMoney_A;
                @FreeMoney_A.canceled -= m_Wrapper.m_StoreActionsCallbackInterface.OnFreeMoney_A;
                @Menu_Y.started -= m_Wrapper.m_StoreActionsCallbackInterface.OnMenu_Y;
                @Menu_Y.performed -= m_Wrapper.m_StoreActionsCallbackInterface.OnMenu_Y;
                @Menu_Y.canceled -= m_Wrapper.m_StoreActionsCallbackInterface.OnMenu_Y;
                @Restart_X.started -= m_Wrapper.m_StoreActionsCallbackInterface.OnRestart_X;
                @Restart_X.performed -= m_Wrapper.m_StoreActionsCallbackInterface.OnRestart_X;
                @Restart_X.canceled -= m_Wrapper.m_StoreActionsCallbackInterface.OnRestart_X;
                @Red_Up.started -= m_Wrapper.m_StoreActionsCallbackInterface.OnRed_Up;
                @Red_Up.performed -= m_Wrapper.m_StoreActionsCallbackInterface.OnRed_Up;
                @Red_Up.canceled -= m_Wrapper.m_StoreActionsCallbackInterface.OnRed_Up;
                @Green_Left.started -= m_Wrapper.m_StoreActionsCallbackInterface.OnGreen_Left;
                @Green_Left.performed -= m_Wrapper.m_StoreActionsCallbackInterface.OnGreen_Left;
                @Green_Left.canceled -= m_Wrapper.m_StoreActionsCallbackInterface.OnGreen_Left;
                @Yellow_Down.started -= m_Wrapper.m_StoreActionsCallbackInterface.OnYellow_Down;
                @Yellow_Down.performed -= m_Wrapper.m_StoreActionsCallbackInterface.OnYellow_Down;
                @Yellow_Down.canceled -= m_Wrapper.m_StoreActionsCallbackInterface.OnYellow_Down;
                @Orange_Right.started -= m_Wrapper.m_StoreActionsCallbackInterface.OnOrange_Right;
                @Orange_Right.performed -= m_Wrapper.m_StoreActionsCallbackInterface.OnOrange_Right;
                @Orange_Right.canceled -= m_Wrapper.m_StoreActionsCallbackInterface.OnOrange_Right;
                @Black_LB.started -= m_Wrapper.m_StoreActionsCallbackInterface.OnBlack_LB;
                @Black_LB.performed -= m_Wrapper.m_StoreActionsCallbackInterface.OnBlack_LB;
                @Black_LB.canceled -= m_Wrapper.m_StoreActionsCallbackInterface.OnBlack_LB;
                @Indigo_RB.started -= m_Wrapper.m_StoreActionsCallbackInterface.OnIndigo_RB;
                @Indigo_RB.performed -= m_Wrapper.m_StoreActionsCallbackInterface.OnIndigo_RB;
                @Indigo_RB.canceled -= m_Wrapper.m_StoreActionsCallbackInterface.OnIndigo_RB;
            }
            m_Wrapper.m_StoreActionsCallbackInterface = instance;
            if (instance != null)
            {
                @FreeMoney_A.started += instance.OnFreeMoney_A;
                @FreeMoney_A.performed += instance.OnFreeMoney_A;
                @FreeMoney_A.canceled += instance.OnFreeMoney_A;
                @Menu_Y.started += instance.OnMenu_Y;
                @Menu_Y.performed += instance.OnMenu_Y;
                @Menu_Y.canceled += instance.OnMenu_Y;
                @Restart_X.started += instance.OnRestart_X;
                @Restart_X.performed += instance.OnRestart_X;
                @Restart_X.canceled += instance.OnRestart_X;
                @Red_Up.started += instance.OnRed_Up;
                @Red_Up.performed += instance.OnRed_Up;
                @Red_Up.canceled += instance.OnRed_Up;
                @Green_Left.started += instance.OnGreen_Left;
                @Green_Left.performed += instance.OnGreen_Left;
                @Green_Left.canceled += instance.OnGreen_Left;
                @Yellow_Down.started += instance.OnYellow_Down;
                @Yellow_Down.performed += instance.OnYellow_Down;
                @Yellow_Down.canceled += instance.OnYellow_Down;
                @Orange_Right.started += instance.OnOrange_Right;
                @Orange_Right.performed += instance.OnOrange_Right;
                @Orange_Right.canceled += instance.OnOrange_Right;
                @Black_LB.started += instance.OnBlack_LB;
                @Black_LB.performed += instance.OnBlack_LB;
                @Black_LB.canceled += instance.OnBlack_LB;
                @Indigo_RB.started += instance.OnIndigo_RB;
                @Indigo_RB.performed += instance.OnIndigo_RB;
                @Indigo_RB.canceled += instance.OnIndigo_RB;
            }
        }
    }
    public StoreActions @Store => new StoreActions(this);
    public interface IGamePlayActions
    {
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnMenuSelect(InputAction.CallbackContext context);
        void OnJumpA(InputAction.CallbackContext context);
        void OnBoostRT(InputAction.CallbackContext context);
        void OnBrakeLT(InputAction.CallbackContext context);
        void OnStartSelect(InputAction.CallbackContext context);
        void OnLevelSelect(InputAction.CallbackContext context);
        void OnStoreSelect(InputAction.CallbackContext context);
        void OnCreditsSelect(InputAction.CallbackContext context);
        void OnRetryX(InputAction.CallbackContext context);
        void OnNextLevelRB(InputAction.CallbackContext context);
    }
    public interface IStoreActions
    {
        void OnFreeMoney_A(InputAction.CallbackContext context);
        void OnMenu_Y(InputAction.CallbackContext context);
        void OnRestart_X(InputAction.CallbackContext context);
        void OnRed_Up(InputAction.CallbackContext context);
        void OnGreen_Left(InputAction.CallbackContext context);
        void OnYellow_Down(InputAction.CallbackContext context);
        void OnOrange_Right(InputAction.CallbackContext context);
        void OnBlack_LB(InputAction.CallbackContext context);
        void OnIndigo_RB(InputAction.CallbackContext context);
    }
}
