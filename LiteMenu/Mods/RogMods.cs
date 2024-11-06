using StupidTemplate.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.InputSystem;

namespace FlysPanelLite.Mods
{
    internal class RigMods
    {
        public static void fixs()
        {
            RigManager.GetOwnVRRig().head.trackingRotationOffset.y = 0f;
        }
        public static void fixit()
        {
            RigManager.GetOwnVRRig().head.trackingRotationOffset.z = 0f;
        }
        public static void backhead()
        {
            GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.y = 180f;
        }
        public static void UpsideDownHead()
        {
            GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.z = 180f;
        }

        public static void HoldRig()
        {
            if (ControllerInputPoller.instance.rightGrab || Mouse.current.rightButton.isPressed)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
                GorillaTagger.Instance.offlineVRRig.transform.position = GorillaTagger.Instance.rightHandTransform.position;
                GorillaTagger.Instance.offlineVRRig.transform.rotation = GorillaTagger.Instance.rightHandTransform.rotation;
                return;
            }
            GorillaTagger.Instance.offlineVRRig.enabled = true;
        }

        public static void SpazMonke()
        {
            GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new UnityEngine.Vector3((float)UnityEngine.Random.Range(0, 360), (float)UnityEngine.Random.Range(0, 360), (float)UnityEngine.Random.Range(0, 360));
            GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new UnityEngine.Vector3((float)UnityEngine.Random.Range(0, 360), (float)UnityEngine.Random.Range(0, 360), (float)UnityEngine.Random.Range(0, 360));
            GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new UnityEngine.Vector3((float)UnityEngine.Random.Range(0, 360), (float)UnityEngine.Random.Range(0, 360), (float)UnityEngine.Random.Range(0, 360));
            GorillaTagger.Instance.offlineVRRig.head.rigTarget.eulerAngles = new UnityEngine.Vector3((float)UnityEngine.Random.Range(0, 360), (float)UnityEngine.Random.Range(0, 180), (float)UnityEngine.Random.Range(0, 180));
            GorillaTagger.Instance.offlineVRRig.leftHand.rigTarget.eulerAngles = new UnityEngine.Vector3((float)UnityEngine.Random.Range(0, 360), (float)UnityEngine.Random.Range(0, 180), (float)UnityEngine.Random.Range(0, 180));
            GorillaTagger.Instance.offlineVRRig.rightHand.rigTarget.eulerAngles = new UnityEngine.Vector3((float)UnityEngine.Random.Range(0, 360), (float)UnityEngine.Random.Range(0, 180), (float)UnityEngine.Random.Range(0, 180));
        }
    }
}
