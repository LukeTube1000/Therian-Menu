using StupidTemplate.Classes;
using StupidTemplate.Mods;
using TherianMenu.Mods;
using UnityEngine;
using static StupidTemplate.Settings;

namespace StupidTemplate.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "Speed Boost", method =() => Speedboost.Speedboostmod(), toolTip = "More Speed"},
                new ButtonInfo { buttonText = "Crash All", method =() => CrashAll.CrashAll2(), toolTip = "Crashes the Lobby"},
                new ButtonInfo { buttonText = "Platforms", method = () => Platforms.Plats(), toolTip = "Toggle platform spawning" },
                new ButtonInfo { buttonText = "RGB Monke", method = () => Banned.MakeEveryoneRGB(), toolTip = "RGB Monke" }, // Corrected method name
                new ButtonInfo { buttonText = "Ban Monke", method = () => Banned.ChangeBannedText(), toolTip = "Changes the banned Text" },
                new ButtonInfo { buttonText = "regular placeholder 4", isTogglable = false},
                new ButtonInfo { buttonText = "togglable placeholder 4"},
                new ButtonInfo { buttonText = "regular placeholder 5", isTogglable = false},
                new ButtonInfo { buttonText = "togglable placeholder 5"},
                new ButtonInfo { buttonText = "regular placeholder 6", isTogglable = false},
                new ButtonInfo { buttonText = "togglable placeholder 6"},
            },

            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => StupidTemplate.Mods.Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => SettingsMods.MovementSettings(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "Projectile", method =() => SettingsMods.ProjectileSettings(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},
            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "Return to Menu", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
            },

            new ButtonInfo[] { // Movement Settings
                new ButtonInfo { buttonText = "Return to Menu", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
            },

            new ButtonInfo[] { // Projectile Settings
                new ButtonInfo { buttonText = "Return to Menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
            },
        };
    }
}
