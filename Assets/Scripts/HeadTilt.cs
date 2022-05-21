using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class HeadTilt : MonoBehaviour
{
    [Range(0, 1)] public float maxInputValue = 1f;
    public float max_rotation_angle = 45.0f;

    public float headPitch = 0.0f;
    public float headYaw = 0.0f;
    public float headRoll = 0.0f;


    //private Transform neck;
    private Quaternion neck_quat;
    private float roll = 0, pitch = 0, yaw = 0;

    // Start is called before the first frame update
    void Start()
    {
        neck_quat = Quaternion.Euler(0, 90, -90);
    }

    // Parse the string received through TCP to
    // Update the parameters
    public void parseMessage(String message) {
        string[] res = message.Split(' ');

        roll = float.Parse(res[0]);
        pitch = float.Parse(res[1]);
        yaw = float.Parse(res[2]);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug
        //print(string.Format("Roll: {0:F}; Pitch: {1:F}; Yaw: {2:F}", roll, pitch, yaw));

        // do rotation at neck to control the movement of head
        HeadRotation();

    }

    void HeadRotation()
    {
        // clamp the angles to prevent unnatural movement
        float pitch_clamp = Mathf.Clamp(pitch, -max_rotation_angle, max_rotation_angle);
        float yaw_clamp = Mathf.Clamp(yaw, -max_rotation_angle, max_rotation_angle);
        float roll_clamp = Mathf.Clamp(roll, -max_rotation_angle, max_rotation_angle);

        // store values as floats between 0 and 1 to work best with the CarUserControl which is expecting analog values from a joystick.
        headPitch = Mathf.Clamp((pitch_clamp % max_rotation_angle), -maxInputValue, maxInputValue);
        headYaw = Mathf.Clamp((yaw_clamp % max_rotation_angle), -maxInputValue, maxInputValue);
        headRoll = Mathf.Clamp((roll_clamp % max_rotation_angle), -maxInputValue, maxInputValue);

    }

}
