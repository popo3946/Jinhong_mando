using System;
using System.Collections.Generic;
using System.Text;

namespace NCDEnterprise
{
    /// <summary>
    /// Represents an identification of NCD board.
    /// </summary>
    public struct E3CIdentification
    {
        /// <summary>
        /// Represents device Id number part 1.
        /// </summary>
        public long id1;
        
        /// <summary>
        /// Represents device Id number part 2.
        /// </summary>
        public long id2;
        
        /// <summary>
        /// Represents device firmware version.
        /// </summary>
        public long version;
        
        /// <summary>
        /// Represents year of device manufacture.
        /// </summary>
        public long year;
        
        /// <summary>
        /// Represents E3C device number.
        /// </summary>
        public long deviceNumber;
    }

    /// <summary>
    /// Interface of E3C command.
    /// </summary>
    /// <remarks>
    /// <para>The E3C commands allow you to control up to 256 NCD devices from a single serial port.</para>
    /// <para>It is OK to mix different types of devices, as long as the devices are E3C compliant.</para>
    /// </remarks>
    public interface IE3C
    {
        /// <summary>
        /// Reports back the IE3C device Number of the currently enabled device.
        /// </summary>
        /// <returns>E3C Identification of device</returns>
        E3CIdentification RecallDeviceIdentification();

        /// <summary>
        /// Reads the stored device number from the controller.
        /// </summary>  
        /// <returns>-1: Failed <para>0-255: Device Number</para></returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,247</description>
        /// <description>Recall Device Number</description>
        /// </item>
        /// </list>
        /// </remarks>
        long RecallDeviceNumber();

        /// <summary>
        /// Tells all devices to respond to the commands.
        /// </summary>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,248</description>
        /// <description>Enable All devices</description>
        /// </item>
        /// </list>
        /// </remarks> 
        void EnableAllDevices();

        /// <summary>
        /// Tells all devices to ignore the commands.
        /// </summary>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,249</description>
        /// <description>Disable All Devices</description>
        /// </item>
        /// </list>
        /// </remarks>          
        void DisableAllDevices();

        /// <summary>
        /// Tells a specific device to listen to the commands.
        /// </summary>
        /// <param name="deviceId">Device Number: 0-255</param>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,250</description>
        /// <description>Enable a Selected Device</description>
        /// </item>
        /// </list>
        /// </remarks>  
        void EnableSpecificDevice(byte deviceId);

        /// <summary>
        /// Tells a specific device to ignore the commands.
        /// </summary>
        /// <param name="deviceId">Device Number: 0-255</param>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,251</description>
        /// <description>Disable a Selected Device</description>
        /// </item>
        /// </list>
        /// </remarks>
        void DisableSpecificDevice(byte deviceId);

        /// <summary>
        /// Tells a specific device to ignore the commands, all others will listen.
        /// </summary>
        /// <param name="deviceId">Device Number: 0-255</param>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,252</description>
        /// <description>Enable a Selected Device Only</description>
        /// </item>
        /// </list>
        /// </remarks>        
        void EnableAllDevicesExcept(byte deviceId);

        /// <summary>
        /// Tells a specific device to listen to the commands,
        /// all other devices will ignore the commands.
        /// </summary>
        /// <param name="deviceId">Device Number: 0-255</param>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,253</description>
        /// <description>Disable a Selected Device Only</description>
        /// </item>
        /// </list>
        /// </remarks>        
        void DisableAllDevicesExcept(byte deviceId);

        /// <summary>
        /// Programs the device number into the controller. 
        /// </summary>
        /// <param name="deviceId">Device Number: 0-255</param>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,255</description>
        /// <description>Program E3C Device Number</description>
        /// </item>
        /// </list>
        /// Only ONE controller should be attached to the computer at the time of programming. 
        /// Once programmed, use the IE3C commands to control which devices you are speaking to.
        /// </remarks>
        void ProgramDeviceNumber(byte deviceId);
    }



    internal class CE3C : NCDBase , IE3C
    {
        public CE3C(NCDController objNCD): base(objNCD)
        {

        }

        /// <summary>
        /// Reports back the IE3C device Number of the currently enabled device.
        /// </summary>
        /// <returns>E3C Identification of device</returns>
        E3CIdentification  IE3C.RecallDeviceIdentification()
        {
            E3CIdentification id;
            //EnterCommand();
            //// 246 Recall device Identification
            //WriteByte(246);

            WriteBytes(254, 246);

            id.id1  = ReadByte2();
            id.id2  = ReadByte2();
            id.year = ReadByte2();
            id.version = ReadByte2();
            id.deviceNumber = ReadByte2();
            return id;
        }

        /// <summary>
        /// Reads the stored device number from the controller.
        /// </summary>  
        /// <returns>-1: Failed <para>0-255: Device Number</para></returns>        
        long IE3C.RecallDeviceNumber()
        {
            //EnterCommand();
            //// 247  Recall device Number
            //WriteByte(247);

            WriteBytes(254, 247);

            return ReadByte2();
        }

        /// <summary>
        /// Tells all devices to respond to the commands.
        /// </summary>
        void IE3C.EnableAllDevices()
        {
            //EnterCommand();
            //// 248 Enable All devices
            //WriteByte(248);

            WriteBytes(254, 248);

        }

        /// <summary>
        /// Tells all devices to ignore the commands.
        /// </summary>
        void IE3C.DisableAllDevices()
        {
            //EnterCommand();
            //// 249 Disable All devices
            //WriteByte(249);

            WriteBytes(254, 249);
        }

        /// <summary>
        /// Tells a specific device to listen to the commands.
        /// </summary>
        /// <param name="deviceId">Device Number: 0-255</param>
        void IE3C.EnableSpecificDevice(byte deviceId)
        {
            //EnterCommand();
            //// 250 Enable a Selected device
            //WriteByte(250);
            //WriteByte(deviceId);

            WriteBytes(254, 250, deviceId);

        }

        /// <summary>
        /// Tells a specific device to ignore the commands.
        /// </summary>
        /// <param name="deviceId">Device Number: 0-255</param>
        void IE3C.DisableSpecificDevice(byte deviceId)
        {
            //EnterCommand();
            //// 251 Disable Selected device
            //WriteByte(251);
            //WriteByte(deviceId);

            WriteBytes(254, 251, deviceId);
        }

        /// <summary>
        /// Tells a specific device to ignore the commands, all others will listen.
        /// </summary>
        /// <param name="deviceId">Device Number: 0-255</param>
        void IE3C.EnableAllDevicesExcept(byte deviceId)
        {
            //EnterCommand();
            //// 253 Disable a Selected device Only
            //WriteByte(253);
            //WriteByte(deviceId);

            WriteBytes(254, 253, deviceId);

        }

        /// <summary>
        /// Tells a specific device to listen to the commands,
        /// all other devices will ignore the commands.
        /// </summary>
        /// <param name="deviceId">Device Number: 0-255</param>
        void IE3C.DisableAllDevicesExcept(byte deviceId)
        {
            //EnterCommand();
            //// 252 Enable Selected device Only
            //WriteByte(252);
            //WriteByte(deviceId);

            WriteBytes(254, 252, deviceId);

        }

        /// <summary>
        /// Programs the device number into the controller. 
        /// </summary>
        /// <param name="deviceId">Device Number: 0-255</param>
        /// <remarks>
        /// Only ONE controller should be attached to the computer at the time of programming. 
        /// Once programmed, use the IE3C commands to control which devices you are speaking to.
        /// </remarks>
        void IE3C.ProgramDeviceNumber(byte deviceId)
        {
            //EnterCommand();
            //// 255 Program IE3C device Number
            //WriteByte(255);
            //WriteByte(deviceId);

            WriteBytes(254, 255, deviceId);

            ReadByte2();
        }

    }
}
