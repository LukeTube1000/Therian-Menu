using System;
using System.Collections.Generic;
using System.Text;
using ExitGames.Client.Photon;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

namespace TherianMenu.Mods
{
    internal class CrashGun
    {
        private static GameObject pointer;

        public static void CrashGun2()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                RaycastHit raycastHit;
                if (Physics.Raycast(GorillaLocomotion.Player.Instance.rightControllerTransform.position - GorillaLocomotion.Player.Instance.rightControllerTransform.up, -GorillaLocomotion.Player.Instance.rightControllerTransform.up, out raycastHit) && pointer == null)
                {
                    pointer = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    UnityEngine.Object.Destroy(pointer.GetComponent<Rigidbody>());
                    UnityEngine.Object.Destroy(pointer.GetComponent<SphereCollider>());
                    pointer.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                    pointer.GetComponent<Renderer>().material.color = Color.yellow;
                }
                if (pointer != null)
                {
                    pointer.transform.position = raycastHit.point;
                }
                if (ControllerInputPoller.instance.rightControllerIndexFloat > 0f)
                {
                    Hashtable val = new Hashtable();
                    val[(byte)0] = (int)-1;
                    PhotonNetwork.RaiseEvent(207, val, RaiseEventOptions.Default, SendOptions.SendReliable);
                }
            }
            else
            {
                if (pointer != null)
                {
                    UnityEngine.Object.Destroy(pointer);
                    pointer = null;
                }
            }
        }
    }
}