using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;

public class move : MonoBehaviour
{
    Controller controller;
    float handPalmPitch;
    float handPalmYaw;
    float handPalmRoll;
    float handWristRot;

    // Update is called once per frame
    void Update()
    {
        controller = new Controller();
        Frame frame = controller.Frame();
        List<Hand> hands = frame.Hands;
        if (frame.Hands.Count > 0)
        {
            Hand firstHand = hands[0];
        }

        handPalmPitch = hands[0].PalmNormal.Pitch;
        handPalmRoll = hands[0].PalmNormal.Roll;
        handPalmYaw = hands[0].PalmNormal.Yaw;

        handWristRot = hands[0].WristPosition.Pitch;


        // Move Object
        if (handPalmYaw > -2f && handPalmYaw < 3.5f)
        {
            transform.Translate(new Vector3(0, 0, 1 * Time.deltaTime));
        }
        else if (handPalmYaw < -2.2f)
        {
            transform.Translate(new Vector3(0, 0, -1 * Time.deltaTime));
        }
    }
}