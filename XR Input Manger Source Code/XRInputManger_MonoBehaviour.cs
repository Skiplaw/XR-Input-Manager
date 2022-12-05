using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class XRInputManger_MonoBehaviour : MonoBehaviour
{
    private InputDevice RightController;
    private InputDevice LeftController;

    [Tooltip("A bool if the Right XR Controller Primary Button is being pushed")]
    [HideInInspector] public bool RightController_PrimaryButton;
    [Tooltip("A bool if the Right XR Controller Secondary Button is being pushed")]
    [HideInInspector] public bool RightController_SecondaryButton;
    [Tooltip("A bool if the Right XR Controller JoyStick is being pushed")]
    [HideInInspector] public bool RightController_JoyStickClick;
    [Tooltip("A float of the Right XR Controller Grip pushed % (min 0, max 1)")]
    [HideInInspector] public float RightController_Grip;
    [Tooltip("A float of the Right XR Controller Trigger pushed % (min 0, max 1)")]
    [HideInInspector] public float RightController_Trigger;
    [Tooltip("A vector2 of the Right XR Controller JoyStick Position")]
    [HideInInspector] public Vector2 RightController_JoyStick_Position;


    [Tooltip("A bool if the Left XR Controller Primary Button is being pushed")]
    [HideInInspector] public bool LeftController_PrimaryButton;
    [Tooltip("A bool if the Left XR Controller Secondary Button is being pushed")]
    [HideInInspector] public bool LeftController_SecondaryButton;
    [Tooltip("A bool if the Left XR Controller JoyStick is being pushed")]
    [HideInInspector] public bool LeftController_JoyStickClick;
    [Tooltip("A float of the Left XR Controller Grip pushed % (min 0, max 1)")]
    [HideInInspector] public float LeftController_Grip;
    [Tooltip("A float of the Left XR Controller Trigger pushed % (min 0, max 1) ")]
    [HideInInspector] public float LeftController_Trigger;
    [Tooltip("A vector2 of the Left XR Controller JoyStick Position (x min -1 max 1, y min -1 max 1)")]
    [HideInInspector] public Vector2 LeftController_JoyStick_Position;

 
    public void GetInput()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDeviceCharacteristics rightControllerCharacteristics = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
        InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics, devices);


        List<InputDevice> devicesL = new List<InputDevice>();
        InputDeviceCharacteristics leftControllerCharacteristics = InputDeviceCharacteristics.Left | InputDeviceCharacteristics.Controller;
        InputDevices.GetDevicesWithCharacteristics(leftControllerCharacteristics, devicesL);


        foreach (var item in devices)
        {

        }
        if (devices.Count > 0)
        {
            RightController = devices[0];
        }
        if (devicesL.Count > 0)
        {
            LeftController = devicesL[0];
        }
        Input1();
    }

    void Input1()
    {
        RightController.TryGetFeatureValue(CommonUsages.primaryButton, out RightController_PrimaryButton);
        RightController.TryGetFeatureValue(CommonUsages.secondaryButton, out RightController_SecondaryButton);
        RightController.TryGetFeatureValue(CommonUsages.primary2DAxisClick, out RightController_JoyStickClick);
        RightController.TryGetFeatureValue(CommonUsages.trigger, out RightController_Trigger);
        RightController.TryGetFeatureValue(CommonUsages.grip, out RightController_Grip);
        RightController.TryGetFeatureValue(CommonUsages.primary2DAxis, out RightController_JoyStick_Position);

        LeftController.TryGetFeatureValue(CommonUsages.primaryButton, out LeftController_PrimaryButton);
        LeftController.TryGetFeatureValue(CommonUsages.secondaryButton, out LeftController_SecondaryButton);
        LeftController.TryGetFeatureValue(CommonUsages.primary2DAxisClick, out LeftController_JoyStickClick);
        LeftController.TryGetFeatureValue(CommonUsages.trigger, out LeftController_Trigger);
        LeftController.TryGetFeatureValue(CommonUsages.grip, out LeftController_Grip);
        LeftController.TryGetFeatureValue(CommonUsages.primary2DAxis, out LeftController_JoyStick_Position);
    }
}
