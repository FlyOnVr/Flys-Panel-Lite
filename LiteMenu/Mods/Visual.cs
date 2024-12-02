using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace FlysPanelLite.Mods
{
    internal class Visual
    {
        public static void Beacons()
        {
            if (PhotonNetwork.CurrentRoom != null)
            {
                foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
                {
                    if (vrrig != GorillaTagger.Instance.offlineVRRig)
                    {
                        GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                        UnityEngine.Object.Destroy(gameObject.GetComponent<BoxCollider>());
                        UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
                        UnityEngine.Object.Destroy(gameObject.GetComponent<Collider>());
                        gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color", UnityEngine.Color.green);
                        gameObject.transform.rotation = Quaternion.identity;
                        gameObject.transform.localScale = new Vector3(0.04f, 200f, 0.04f);
                        gameObject.transform.position = vrrig.transform.position;
                        gameObject.GetComponent<MeshRenderer>().material = vrrig.mainSkin.material;
                        UnityEngine.Object.Destroy(gameObject, Time.deltaTime);
                    }
                }
            }
        }

        public static void Tracers()
        {
            Transform rightControllerTransform = GorillaLocomotion.Player.Instance.rightControllerTransform;
            foreach (VRRig vrrig in GorillaParent.instance.vrrigs)
            {
                if (vrrig != GorillaTagger.Instance.offlineVRRig)
                {
                    GameObject lineObject = new GameObject("Line");


                    LineRenderer lineRenderer = lineObject.AddComponent<LineRenderer>();
                    lineRenderer.startColor = Color.green;
                    lineRenderer.endColor = Color.green;
                    lineRenderer.startWidth = 0.01f;
                    lineRenderer.endWidth = 0.01f;
                    lineRenderer.positionCount = 2;
                    lineRenderer.useWorldSpace = true;
                    lineRenderer.SetPosition(0, rightControllerTransform.position);
                    lineRenderer.SetPosition(1, vrrig.transform.position);
                    lineRenderer.material = vrrig.mainSkin.material;
                    UnityEngine.Object.Destroy(lineObject, Time.deltaTime);
                }
            }
        }
    }
}
