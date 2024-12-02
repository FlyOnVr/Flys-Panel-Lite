using ExitGames.Client.Photon;
using Photon.Pun;
using Photon.Realtime;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.InputSystem;
using UnityEngine;

namespace FlysPanelLite.Mods
{
    internal class MovementMods
    {
        public static void Platforms()
        {
            PlatformStuff(ref leftPlatform, ControllerInputPoller.instance.leftGrab, GorillaLocomotion.Player.Instance.leftControllerTransform, false);
            PlatformStuff(ref rightPlatform, ControllerInputPoller.instance.rightGrab, GorillaLocomotion.Player.Instance.rightControllerTransform, false);
        }

        public static void PlatformStuff(ref GameObject platform, bool isGrabbing, Transform controllerTransform, bool InvisPlat)
        {
            if (isGrabbing)
            {
                if (platform == null)
                {
                    platform = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    platform.transform.localScale = new Vector3(0.28f, 0.015f, 0.28f);
                    platform.transform.position = controllerTransform.position + new Vector3(0f, -0.02f, 0f);
                    platform.transform.rotation = controllerTransform.rotation * Quaternion.Euler(0f, 0f, -90f);
                    platform.GetComponent<Renderer>().material.color = Color.blue;
                    platform.AddComponent<GorillaSurfaceOverride>().overrideIndex = GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/sky jungle entrance 2/ElevatorClouds/Cloud_Platform_001 Variant").GetComponent<GorillaSurfaceOverride>().overrideIndex;

                    if (InvisPlat == true)
                    {
                        platform.GetComponent<Renderer>().enabled = false;
                    }
                }
            }
            else if (platform != null)
            {
                GameObject.Destroy(platform);
                platform = null;
            }
        }

        public static GameObject leftPlatform;
        public static GameObject rightPlatform;

        public static void PlatformSpam()
        {
            if (ControllerInputPoller.instance.leftGrab || Mouse.current.rightButton.isPressed)
            {
                GameObject platform = GameObject.CreatePrimitive(PrimitiveType.Cube);
                UnityEngine.Object.Destroy(platform.GetComponent<BoxCollider>());
                platform.GetComponent<Renderer>().material.color = UnityEngine.Color.blue;
                platform.transform.localScale = new UnityEngine.Vector3(0.28f, 0.015f, 0.28f);
                platform.transform.position = GorillaTagger.Instance.leftHandTransform.position;
                platform.transform.rotation = GorillaTagger.Instance.leftHandTransform.rotation;
                UnityEngine.Object.Destroy(platform, 1f);
                PhotonNetwork.RaiseEvent(69, new object[2] { platform.transform.position, platform.transform.rotation }, new RaiseEventOptions { Receivers = ReceiverGroup.Others }, SendOptions.SendReliable);
            }
            if (ControllerInputPoller.instance.rightGrab || Mouse.current.rightButton.isPressed)
            {
                GameObject platform = GameObject.CreatePrimitive(PrimitiveType.Cube);
                UnityEngine.Object.Destroy(platform.GetComponent<BoxCollider>());
                platform.GetComponent<Renderer>().material.color = UnityEngine.Color.blue;
                platform.transform.localScale = new UnityEngine.Vector3(0.28f, 0.015f, 0.28f);
                platform.transform.position = GorillaTagger.Instance.rightHandTransform.position;
                platform.transform.rotation = GorillaTagger.Instance.rightHandTransform.rotation;
                UnityEngine.Object.Destroy(platform, 1f);
                PhotonNetwork.RaiseEvent(69, new object[2] { platform.transform.position, platform.transform.rotation }, new RaiseEventOptions { Receivers = ReceiverGroup.Others }, SendOptions.SendReliable);
            }
        }

        public static void LowGravity()
        {
            GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.AddForce(UnityEngine.Vector3.up * (Time.deltaTime * (6.5f / Time.deltaTime)), ForceMode.Acceleration);
        }

        public static void NoGravity()
        {
            GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().AddForce(-Physics.gravity, ForceMode.Acceleration);
        }

        public static void HighGravity()
        {
            GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.AddForce(UnityEngine.Vector3.down * (Time.deltaTime * (14f / Time.deltaTime)), ForceMode.Acceleration);
        }
        public static void ForceTagFreeze()
        {
            GorillaLocomotion.Player.Instance.disableMovement = true;
        }

        public static void NoTagFreeze()
        {
            GorillaLocomotion.Player.Instance.disableMovement = false;
        }

        public static void Strafe()
        {
            Vector3 funnyDir = GorillaTagger.Instance.bodyCollider.transform.forward * GorillaLocomotion.Player.Instance.maxJumpSpeed;
            GorillaTagger.Instance.bodyCollider.attachedRigidbody.velocity = new Vector3(funnyDir.x, GorillaTagger.Instance.bodyCollider.attachedRigidbody.velocity.y, funnyDir.z);
        }

        public static void Dash()
        {
            if (ControllerInputPoller.instance.rightControllerSecondaryButton || Mouse.current.rightButton.isPressed)
            {
                Vector3 funnyDir = GorillaTagger.Instance.bodyCollider.transform.forward * GorillaLocomotion.Player.Instance.maxJumpSpeed;
                GorillaTagger.Instance.bodyCollider.attachedRigidbody.velocity = new Vector3(funnyDir.x, GorillaTagger.Instance.bodyCollider.attachedRigidbody.velocity.y, funnyDir.z);
            }
        }

        public static void Noclip()
        {
            foreach (MeshCollider m in Resources.FindObjectsOfTypeAll<MeshCollider>())
            {
                if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.1f || Mouse.current.rightButton.isPressed)
                {
                    m.enabled = false;
                }
                else
                {
                    m.enabled = true;
                }
            }
        }

        public static void GripNoclip()
        {
            foreach (MeshCollider m in Resources.FindObjectsOfTypeAll<MeshCollider>())
            {
                if (ControllerInputPoller.instance.rightGrab || Mouse.current.rightButton.isPressed)
                {
                    m.enabled = false;
                }
                else
                {
                    m.enabled = true;
                }
            }
        }
    }
}
