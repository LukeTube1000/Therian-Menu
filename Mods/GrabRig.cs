using System;
using System.Collections.Generic;
using System.Text;

namespace TherianMenu.Mods
{
    internal static class WristMenu
    {
        public static bool gripDownL { get; set; }
        public static bool gripDownR { get; set; }
    }

    internal class GrabRig
    {
        public static void GrabRigg()
        {
            if (WristMenu.gripDownL && !WristMenu.gripDownR)
            {
                DrawHandOrbs();
                GorillaTagger.Instance.offlineVRRig.enabled = false;
                GorillaTagger.Instance.offlineVRRig.transform.position = GorillaLocomotion.Player.Instance.leftControllerTransform.position;
            }
            else if (WristMenu.gripDownR && !WristMenu.gripDownL)
            {
                DrawHandOrbs();
                GorillaTagger.Instance.offlineVRRig.enabled = false;
                GorillaTagger.Instance.offlineVRRig.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.position;
            }
            else if (WristMenu.gripDownR && WristMenu.gripDownL)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }

        private static void DrawHandOrbs()
        {
            // Implementation of DrawHandOrbs method
        }
    }
}