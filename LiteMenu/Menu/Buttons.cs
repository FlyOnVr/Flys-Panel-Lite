using FlysPanelLite.Mods;
using StupidTemplate.Classes;
using StupidTemplate.Mods;
using static StupidTemplate.Settings;

namespace StupidTemplate.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "This button doesn't have a tooltip/tutorial.."},
                new ButtonInfo { buttonText = "Movement", method =() => SettingsMods.MovementMods1(), isTogglable = false, toolTip = "This button doesn't have a tooltip/tutorial.."},
                new ButtonInfo { buttonText = "Player", method =() => SettingsMods.RigMods(), isTogglable = false, toolTip = "This button doesn't have a tooltip/tutorial.."},
                new ButtonInfo { buttonText = "Master", method =() => SettingsMods.MasterMods(), isTogglable = false, toolTip = "This button doesn't have a tooltip/tutorial.."},
                new ButtonInfo { buttonText = "Room", method =() => SettingsMods.RoomMods(), isTogglable = false, toolTip = "This button doesn't have a tooltip/tutorial.."},
                new ButtonInfo { buttonText = "Adventage", method =() => SettingsMods.AdventageMods(), isTogglable = false, toolTip = "This button doesn't have a tooltip/tutorial.."},
                new ButtonInfo { buttonText = "Visual", method =() => SettingsMods.VisualMods(), isTogglable = false, toolTip = "This button doesn't have a tooltip/tutorial.."},
                new ButtonInfo { buttonText = "Fun", method =() => SettingsMods.FunMods(), isTogglable = false, toolTip = "This button doesn't have a tooltip/tutorial.."},
                new ButtonInfo { buttonText = "World", method =() => SettingsMods.WorldMods(), isTogglable = false, toolTip = "This button doesn't have a tooltip/tutorial.."},
                new ButtonInfo { buttonText = "Safety", method =() => SettingsMods.SafetyMods(), isTogglable = false, toolTip = "This button doesn't have a tooltip/tutorial.."},
                new ButtonInfo { buttonText = "Important", method =() => SettingsMods.ImportantMods(), isTogglable = false, toolTip = "This button doesn't have a tooltip/tutorial.."},
                new ButtonInfo { buttonText = "Overpowered", method =() => SettingsMods.OPMods(), isTogglable = false, toolTip = "This button doesn't have a tooltip/tutorial.."},
            },

            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
            },

            new ButtonInfo[] { // Movement
                new ButtonInfo { buttonText = "Return to Main", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Platforms", method =() => MovementMods.Platforms(), isTogglable = true, toolTip = "This button doesn't have a tooltip/tutorial.."},
                new ButtonInfo { buttonText = "Platform Spam", method =() => MovementMods.PlatformSpam(), isTogglable = true, toolTip = "This button doesn't have a tooltip/tutorial.."},

                new ButtonInfo { buttonText = "Noclip", method =() => MovementMods.Noclip(), isTogglable = true, toolTip = "This button doesn't have a tooltip/tutorial.."},
                new ButtonInfo { buttonText = "Grip Noclip", method =() => MovementMods.GripNoclip(), isTogglable = true, toolTip = "This button doesn't have a tooltip/tutorial.."},

                new ButtonInfo { buttonText = "Low Gravity", method =() => MovementMods.LowGravity(), isTogglable = true, toolTip = "This button doesn't have a tooltip/tutorial.."},
                new ButtonInfo { buttonText = "High Gravity", method =() => MovementMods.HighGravity(), isTogglable = true, toolTip = "This button doesn't have a tooltip/tutorial.."},
                new ButtonInfo { buttonText = "No Gravity", method =() => MovementMods.NoGravity(), isTogglable = true, toolTip = "This button doesn't have a tooltip/tutorial.."},

                new ButtonInfo { buttonText = "Force Tag Freeze", method =() => MovementMods.ForceTagFreeze(), isTogglable = true, toolTip = "This button doesn't have a tooltip/tutorial.."},
                new ButtonInfo { buttonText = "No Tag Freeze", method =() => MovementMods.NoTagFreeze(), isTogglable = true, toolTip = "This button doesn't have a tooltip/tutorial.."},
            },

            new ButtonInfo[] { // Player
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Back Head", method =() => RigMods.backhead(), enabled = false, disableMethod =() => RigMods.fixs(), isTogglable = true, toolTip = "This button doesn't have a tooltip/tutorial.."},
                new ButtonInfo { buttonText = "Upside Down Head", method =() => RigMods.UpsideDownHead(), enabled = false, disableMethod =() => RigMods.fixit(), isTogglable = true, toolTip = "This button doesn't have a tooltip/tutorial.."},
                new ButtonInfo { buttonText = "Spaz Monke", method =() => RigMods.SpazMonke(), enabled = false, isTogglable = true, toolTip = "This button doesn't have a tooltip/tutorial.."},
                new ButtonInfo { buttonText = "Hold Rig", method =() => RigMods.HoldRig(), enabled = false, isTogglable = true, toolTip = "This button doesn't have a tooltip/tutorial.."},
            },

            new ButtonInfo[] { // Master
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Nothing Yet!", isTogglable = false},
            },

            new ButtonInfo[] { // Room
                new ButtonInfo { buttonText = "Return to Main", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Nothing Yet!", isTogglable = false},
            },

            new ButtonInfo[] { // Advantage
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Nothing Yet!", isTogglable = false},
            },

            new ButtonInfo[] { // Visual
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Beacons", method =() => Visual.Beacons(), isTogglable = true},
                new ButtonInfo { buttonText = "Tracers", method =() => Visual.Tracers(), isTogglable = true},
            },

            new ButtonInfo[] { // Fun
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Nothing Yet!", isTogglable = false},
            },

            new ButtonInfo[] { // World
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Rain", enableMethod =() => World.Rain(), disableMethod =() => World.FixRain()},
            },

            new ButtonInfo[] { // Safety
                new ButtonInfo { buttonText = "Return to Main", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Nothing Yet!", isTogglable = false},
            },

            new ButtonInfo[] { // Important
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Mute All", method =() => Important.MuteAll(), isTogglable = false},
                new ButtonInfo { buttonText = "Report All", method =() => Important.ReportAll(), isTogglable = false},
            },

            new ButtonInfo[] { // Overpowered
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Nothing Yet!", isTogglable = false},
            },
        };
    }
}
