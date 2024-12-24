using System;
using System.Collections.Generic;
using ExitGames.Client.Photon;
using HarmonyLib;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

namespace TherianMenu.Mods
{
    internal class CrashAll
    {
        public static void CrashAll2()
        {
            try
            {
                GameObject city = GameObject.Find("Environment Objects/LocalObjects_Prefab/City_WorkingPrefab");
                GameObject THing = GameObject.Find("Player Objects/Player VR Controller/GorillaPlayer/TurnParent/Main Camera/LHAHV.");
                if (THing != null)
                {
                    THing.SetActive(false);
                }

                GameObject bundle = GameObject.Find("Environment Objects/LocalObjects_Prefab/City_WorkingPrefab/CosmeticsRoomAnchor/nicegorillastore_prefab/DressingRoom_Mirrors_Prefab/TryOnStand/Console Center/Bottom/BundleButton Group 1/BundleFittingRoomButton-1");
                if (!ControllerInputPoller.instance.rightGrab)
                {
                    GorillaTagger.Instance.offlineVRRig.enabled = true;
                    return;
                }
                GorillaTagger.Instance.offlineVRRig.enabled = false;
                GorillaTagger.Instance.offlineVRRig.transform.position = new Vector3(-51.4244f, 16.9144f, -120.2181f);
                if (city != null)
                {
                    city.SetActive(true);
                }
                TryOnBundleButton tryon = bundle?.GetComponent<TryOnBundleButton>();
                if (tryon != null && !tryon.isOn)
                {
                    tryon.ButtonActivationWithHand(false);
                }
                var elfLaunchers = UnityEngine.Object.FindObjectsOfType<ElfLauncher>();
                TherianMenu.Mods.Global.RpcCleanUp(); // Fully qualified name
                ElfLauncher launcher = GameObject.Find("Player Objects/Local VRRig/Local Gorilla Player/RigAnchor/rig/body/TransferrableItemRightShoulder/DropZoneAnchor/ElfLauncherAnchor(Clone)/LMANE.")?.GetComponent<ElfLauncher>();
                if (launcher != null)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        var args = new object[]
                        {
                            (int)Traverse.Create(((RubberDuckEvents)Traverse.Create(launcher).Field("_events").GetValue()).Activate).Field("_eventId").GetValue(),
                            new Vector3(float.NaN, float.NaN, float.NaN),
                            Vector3.down
                        };

                        PhotonNetwork.RaiseEvent(176, args, new RaiseEventOptions { Receivers = ReceiverGroup.Others }, new SendOptions { Reliability = false, Encrypt = true });
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.LogError($"Error in CrashAll2: {ex.Message}");
            }
        }
    }

    internal static class Global
    {
        public static void RpcCleanUp()
        {
            // Implementation of RpcCleanUp method
        }
    }
}