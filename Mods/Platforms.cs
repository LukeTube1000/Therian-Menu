using System;
using System.Collections.Generic;
using UnityEngine;

namespace TherianMenu.Mods
{
    internal class Platforms
    {
        private static Dictionary<Transform, GameObject> platforms = new Dictionary<Transform, GameObject>();

        public static void CreatePlatform(Transform hand) // Changed to public
        {
            var obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            obj.transform.localScale = new Vector3(0.0125f, 0.28f, 0.3825f);
            obj.GetComponent<Renderer>().material.color = Color.blue; // color of platforms
            obj.transform.position = hand.position;
            obj.transform.rotation = hand.rotation;

            // Set a name to differentiate right and left platforms
            obj.name = hand == GorillaTagger.Instance.rightHandTransform ? "Right_PLATFORM" : "Left_PLATFORM";

            // Store the created platform for future reference
            platforms[hand] = obj;
        }

        public static void Plats()
        {
            // Right hand logic
            if (ControllerInputPoller.instance.rightGrab)
            {
                if (!platforms.ContainsKey(GorillaTagger.Instance.rightHandTransform))
                {
                    CreatePlatform(GorillaTagger.Instance.rightHandTransform);
                }
            }
            else if (platforms.ContainsKey(GorillaTagger.Instance.rightHandTransform))
            {
                UnityEngine.Object.Destroy(platforms[GorillaTagger.Instance.rightHandTransform]);
                platforms.Remove(GorillaTagger.Instance.rightHandTransform);
            }

            // Left hand logic
            if (ControllerInputPoller.instance.leftGrab)
            {
                if (!platforms.ContainsKey(GorillaTagger.Instance.leftHandTransform))
                {
                    CreatePlatform(GorillaTagger.Instance.leftHandTransform);
                }
            }
            else if (platforms.ContainsKey(GorillaTagger.Instance.leftHandTransform))
            {
                UnityEngine.Object.Destroy(platforms[GorillaTagger.Instance.leftHandTransform]);
                platforms.Remove(GorillaTagger.Instance.leftHandTransform);
            }
        }
    }
}