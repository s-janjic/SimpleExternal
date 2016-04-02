﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using IniParser;
using IniParser.Model;

namespace Smurf.GlobalOffensive
{
    public class Settings
    {
        private static readonly FileIniDataParser Parser = new FileIniDataParser();
        private IniData _data;
        private WinAPI.VirtualKeyShort _reloadConfigKey;

        public Settings()
        {
            if (!File.Exists("Config.ini"))
            {
                CreateConfigFile();
            }
            _data = Parser.ReadFile("Config.ini");
        }


        public void Update()
        {
            _reloadConfigKey = (WinAPI.VirtualKeyShort)Convert.ToInt32(Core.Settings.GetString("Misc", "Reload Config Key"), 16);
            if (Core.KeyUtils.KeyWentDown(_reloadConfigKey)) //Tab Key, don't hard code key, will fix later.
            {
                _data = Parser.ReadFile("Config.ini");
            }
        }

        private void CreateConfigFile()
        {
            var snipersList = new List<string>
            {
                "AWP",
                "SSG08",
                "SCAR20",
                "G3SG1"
            };
            var machineGunList = new List<string>
            {
                "M249",
                "Negev"
            };

            var heavyList = new List<string>
            {
                "NOVA",
                "XM1014",
                "Sawedoff",
                "Mag7"
            };

            var smgList = new List<string>
            {
                "MAC10",
                "MP9",
                "MP7",
                "UMP45",
                "Bizon",
                "P90"
            };

            var pistolList = new List<string>
            {
                "DEagle",
                "Elite",
                "FiveSeven",
                "Glock",
                "P228",
                "P250",
                "HKP2000",
                "Tec9"
            };

            var rifleList = new List<string>
            {
                "GalilAR",
                "AK47",
                "SG556",
                "Famas",
                "M4A1",
                "Aug"
            };

            var builder = new StringBuilder();
            //Bunny Jump
            builder.AppendLine("[Bunny Jump]");
            builder.AppendLine("Bunny Jump Enabled = True");
            builder.AppendLine("Bunny Jump Key = 0x20").AppendLine();

            //Glow
            builder.AppendLine("[Glow ESP]");
            builder.AppendLine("Glow ESP Enabled = False");
            builder.AppendLine("Glow ESP Allies = False");
            builder.AppendLine("Glow ESP Enemies = False").AppendLine();

            //SoundESP
            builder.AppendLine("[Sound ESP]");
            builder.AppendLine("Sound ESP = True");
            builder.AppendLine("Sound Range = 10");
            builder.AppendLine("Sound Interval = 1000");
            builder.AppendLine("Sound Volume = 100").AppendLine();

            //Misc
            builder.AppendLine("[Misc]");
            builder.AppendLine("Radar = True");
            builder.AppendLine("InCross Trigger Bot = True");
            builder.AppendLine("No Flash = False");
            builder.AppendLine("Reload Config Key = 0x35").AppendLine();

            foreach (var weapon in pistolList)
            {
                builder.AppendLine("[" + weapon + "]");
                //Auto Pistol
                builder.AppendLine("Auto Pistol = False");
                builder.AppendLine("Auto Pistol Key = 0x12");
                builder.AppendLine("Auto Pistol Delay = 0").AppendLine();
                //RCS
                builder.AppendLine("Rcs Enabled = False");
                builder.AppendLine("Rcs Start = 1");
                builder.AppendLine("Rcs Force Yaw = 2");
                builder.AppendLine("Rcs Force Pitch = 2").AppendLine();
                //Trigger
                builder.AppendLine("Trigger Enabled = True");
                builder.AppendLine("Trigger Key = 0x12");
                builder.AppendLine("Trigger Dash = False");
                builder.AppendLine("Trigger When Zoomed = False");
                builder.AppendLine("Trigger Enemies = True");
                builder.AppendLine("Trigger Allies = False");
                builder.AppendLine("Trigger Spawn Protected = False");
                builder.AppendLine("Trigger Delay FirstShot = 35");
                builder.AppendLine("Trigger Delay Shots = 35").AppendLine();
            }
            foreach (var weapon in rifleList)
            {
                builder.AppendLine("[" + weapon + "]");
                //RCS
                builder.AppendLine("Rcs Enabled = True");
                builder.AppendLine("Rcs Start = 1");
                builder.AppendLine("Rcs Force Yaw = 2");
                builder.AppendLine("Rcs Force Pitch = 2").AppendLine();
                //Trigger
                builder.AppendLine("Trigger Enabled = True");
                builder.AppendLine("Trigger Key = 0x12");
                builder.AppendLine("Trigger Dash = False");
                builder.AppendLine("Trigger When Zoomed = False");
                builder.AppendLine("Trigger Enemies = True");
                builder.AppendLine("Trigger Allies = False");
                builder.AppendLine("Trigger Burst Enabled = False");
                builder.AppendLine("Trigger Spawn Protected = False");
                builder.AppendLine("Trigger Delay FirstShot = 35");
                builder.AppendLine("Trigger Delay Shots = 35").AppendLine();
            }
            foreach (var weapon in smgList)
            {
                builder.AppendLine("[" + weapon + "]");
                //RCS
                builder.AppendLine("Rcs Enabled = True");
                builder.AppendLine("Rcs Start = 1");
                builder.AppendLine("Rcs Force Yaw = 2");
                builder.AppendLine("Rcs Force Pitch = 2").AppendLine();
                //Trigger
                builder.AppendLine("Trigger Enabled = True");
                builder.AppendLine("Trigger Key = 0x12");
                builder.AppendLine("Trigger Dash = False");
                builder.AppendLine("Trigger When Zoomed = False");
                builder.AppendLine("Trigger Enemies = True");
                builder.AppendLine("Trigger Allies = False");
                builder.AppendLine("Trigger Burst Enabled = False");
                builder.AppendLine("Trigger Spawn Protected = False");
                builder.AppendLine("Trigger Delay FirstShot = 35");
                builder.AppendLine("Trigger Delay Shots = 35").AppendLine();
            }
            foreach (var weapon in snipersList)
            {
                builder.AppendLine("[" + weapon + "]");
                //RCS
                builder.AppendLine("Rcs Enabled = False");
                builder.AppendLine("Rcs Start = 1");
                builder.AppendLine("Rcs Force Yaw = 2");
                builder.AppendLine("Rcs Force Pitch = 2").AppendLine();
                //Trigger
                builder.AppendLine("Trigger Enabled = True");
                builder.AppendLine("Trigger Key = 0x12");
                builder.AppendLine("Trigger Dash = False");
                builder.AppendLine("Trigger When Zoomed = False");
                builder.AppendLine("Trigger Enemies = True");
                builder.AppendLine("Trigger Allies = False");
                builder.AppendLine("Trigger Burst Enabled = False");
                builder.AppendLine("Trigger Spawn Protected = False");
                builder.AppendLine("Trigger Delay FirstShot = 35");
                builder.AppendLine("Trigger Delay Shots = 35").AppendLine();
            }
            foreach (var weapon in machineGunList)
            {
                builder.AppendLine("[" + weapon + "]");
                //RCS
                builder.AppendLine("Rcs Enabled = False");
                builder.AppendLine("Rcs Start = 1");
                builder.AppendLine("Rcs Force Yaw = 2");
                builder.AppendLine("Rcs Force Pitch = 2").AppendLine();
                //Trigger
                builder.AppendLine("Trigger Enabled = True");
                builder.AppendLine("Trigger Key = 0x12");
                builder.AppendLine("Trigger Dash = False");
                builder.AppendLine("Trigger When Zoomed = False");
                builder.AppendLine("Trigger Enemies = True");
                builder.AppendLine("Trigger Allies = False");
                builder.AppendLine("Trigger Burst Enabled = False");
                builder.AppendLine("Trigger Spawn Protected = False");
                builder.AppendLine("Trigger Delay FirstShot = 35");
                builder.AppendLine("Trigger Delay Shots = 35").AppendLine();
            }
            foreach (var weapon in heavyList)
            {
                builder.AppendLine("[" + weapon + "]");
                //RCS
                builder.AppendLine("Rcs Enabled = False");
                builder.AppendLine("Rcs Start = 1");
                builder.AppendLine("Rcs Force Yaw = 2");
                builder.AppendLine("Rcs Force Pitch = 2").AppendLine();
                //Trigger
                builder.AppendLine("Trigger Enabled = True");
                builder.AppendLine("Trigger Key = 0x12");
                builder.AppendLine("Trigger Dash = False");
                builder.AppendLine("Trigger When Zoomed = False");
                builder.AppendLine("Trigger Enemies = True");
                builder.AppendLine("Trigger Allies = False");
                builder.AppendLine("Trigger Burst Enabled = False");
                builder.AppendLine("Trigger Spawn Protected = False");
                builder.AppendLine("Trigger Delay FirstShot = 35");
                builder.AppendLine("Trigger Delay Shots = 35").AppendLine();
            }


            if (!File.Exists("Config.ini"))
            {
                var sr = new StreamWriter(@"Config.ini");
                sr.WriteLine(builder);
                sr.Close();
            }
        }

        public int GetInt(string section, string key)
        {
            try
            {
                var keyValue = _data[section][key];
                var setting = int.Parse(keyValue);
                return setting;
            }
            catch (Exception e)
            {
#if DEBUG
                Console.WriteLine("Error: {0},\nSection: {1}\nKey: {2}", e.Message, section, key);
#endif

            }
            return 0;
        }

        public string GetString(string section, string key)
        {
            try
            {
                var keyValue = _data[section][key];
                var setting = keyValue;
                return setting;
            }
            catch (Exception e)
            {
#if DEBUG
                Console.WriteLine("Error: {0},\nSection: {1}\nKey: {2}", e.Message, section, key);
#endif

            }
            return "M4A1";
        }

        public uint GetUInt(string section, string key)
        {
            var keyValue = _data[section][key];
            var setting = uint.Parse(keyValue);
            return setting;
        }

        public float GetFloat(string section, string key)
        {
            try
            {
                var keyValue = _data[section][key];
                var setting = float.Parse(keyValue);
                return setting;
            }
            catch (Exception e)
            {
#if DEBUG
                Console.WriteLine("Error: {0},\nSection: {1}\nKey: {2}", e.Message, section, key);
#endif

            }
            return 0;
        }

        public bool GetBool(string section, string key)
        {
            try
            {
                var keyValue = _data[section][key];
                var setting = bool.Parse(keyValue);
                return setting;
            }
            catch (Exception e)
            {
#if DEBUG
                Console.WriteLine("Error: {0},\nSection: {1}\nKey: {2}", e.Message, section, key);
#endif

            }
            return false;
        }

        public WinAPI.VirtualKeyShort GetKey(string section, string key)
        {
            try
            {
                var keyValue = _data[section][key];
                var button = (WinAPI.VirtualKeyShort)int.Parse(keyValue);
                return button;
            }
            catch (Exception e)
            {
#if DEBUG
                Console.WriteLine("Error: {0},\nSection: {1}\nKey: {2}", e.Message, section, key);
#endif

            }
            return WinAPI.VirtualKeyShort.ACCEPT;
        }
    }
}