// 
// ALL RIGHTS RESERVED:
// ====================
// The contents of this file, and associated files in this directory, are 
// Copyright (C) Serial Port Tool(SPT) , all rights reserved, 2009.
// All software Source Code, Images, Database-Design and code, Graphics Design 
// and source files, and related content (collectively referred to as SOURCE) are 
// Copyright (C) SPT, 2009, All Rights Reserved.
// http://SerialPortTool.com
//
// 


using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections;
using System.ComponentModel;
using Microsoft.Win32;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Reflection;


using System.IO.Ports;
using System.Xml;
using System.Xml.Schema;
using System.Management;


namespace NCDEnterprise
{


    /// <summary>
    /// structure for serial port device, include serial port and modem
    /// </summary>
    public struct SerialDeviceInfo
    {
        public string FriendName; //Name of Friend
        public string PortName; //Port Name

    }

    /// <summary>
    /// ListPorts class is used to get information from ListPorts.exe
    /// </summary>
    public class ListPorts
    {
        public SerialDeviceInfo[] Infos;
        public static SerialDeviceInfo[] EnumPorts()
        {
            try
            {

                ArrayList list = new ArrayList();
                ManagementObjectSearcher searcher =

                                new ManagementObjectSearcher("root\\CIMV2",

                                "SELECT * FROM Win32_PnPEntity");

                if (searcher != null)
                {
                    foreach (ManagementObject queryObj in searcher.Get())
                    {
                        object obj = queryObj["Caption"];
                        if (obj != null)
                        {
                            if (obj.ToString().Contains("(COM"))
                            {
                                SerialDeviceInfo deviceInfo;
                                deviceInfo.FriendName = obj.ToString();
                                deviceInfo.PortName = FindComPortString(deviceInfo.FriendName);
                                list.Add(deviceInfo);
                            }

                        }

                    }
                    return (SerialDeviceInfo[])list.ToArray(typeof(SerialDeviceInfo));

                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {

            }
            return null;

        }


        /// <summary>
        /// finid the com port string 
        /// </summary>
        /// <param name="des"></param>
        /// <returns></returns>
        static string FindComPortString(string des)
        {
            int n1 = des.LastIndexOf('(');
            int n2 = des.LastIndexOf(')');
            return des.Substring(n1 + 1, n2 - n1 - 1);
        }


    }


}
