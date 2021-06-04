using System;
using System.Collections.Generic;
using System.Text;

using NCDEnterprise.ProXR;

namespace NCDEnterprise
{
    /// <summary>
    /// Represents the interface of ProXR.
    /// </summary>
    public  interface IProXR
    {
        /// <summary>
        /// Turn on report mode.
        /// </summary>
        /// <returns><para>True for success</para></returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,27</description>
        /// <description>Turn On Report Mode</description>
        /// </item>
        /// </list>
        /// <para>Reporting mode, by default, is ON, meaning every time a command is sent to the controller, 
        /// the controller will send an 85 back to the computer, indicating that the command has finished executing 
        /// your instructions.</para> 
        /// <para>We recommend leaving it on, but doing so requires 2-Way communication with the controller. 
        /// You should turn it off if you intend to use 1-Way communication only. </para>
        /// <para>A delay between some commands may be required when using 1-Way communications. </para>
        /// <para>For optimum reliability, leave reporting mode on and use 2-Way communications with the IProXR Series controllers.</para>
        /// </remarks>
        bool TurnOnReportMode();

        /// <summary>
        /// Turn off report mode.
        /// </summary>
        /// <returns><para>True for success</para></returns>
        /// <remarks>
        /// <list type="table">
        /// <listheader>
        /// <term>Command</term>
        /// <term>Function</term>
        /// </listheader>
        /// <item>
        /// <description>254,28</description>
        /// <description>Turn Off Report Mode</description>
        /// </item>
        /// </list>
        /// <para>Reporting mode, by default, is ON, meaning every time a command is sent to the controller, 
        /// the controller will send an 85 back to the computer, indicating that the command has finished executing 
        /// your instructions.</para> 
        /// <para>We recommend leaving it on, but doing so requires 2-Way communication with the controller. 
        /// You should turn it off if you intend to use 1-Way communication only. </para>
        /// <para>A delay between some commands may be required when using 1-Way communications. </para>
        /// <para>For optimum reliability, leave reporting mode on and use 2-Way communications with the IProXR Series controllers.</para>
        /// </remarks>
        bool TurnOffReportMode();
        
        /// <summary>
        /// Represents Advance Configuration object.
        /// </summary>
        IAdvanceConfiguration AdvanceConfiguration
        {
            get;
        }

        /// <summary>
        /// Represents the relay banks.
        /// </summary>
        IRelayBanks RelayBanks
        {
            get;
        }

        /// <summary>
        /// Represents Timer object.
        /// </summary>
        ITimers Timers
        {
            get;
        }

        /// <summary>
        /// AD 12 object
        /// </summary>
        IAD12 AD12
        {
            get;
        }

        /// <summary>
        /// AD 8 object
        /// </summary>
        IAD8 AD8
        {
            get;
        }

        /// <summary>
        /// Potentiometer object
        /// </summary>
        IPotentiometer Pot
        {
            get;
        }

        /// <summary>
        /// Motion detection object
        /// </summary>
        IMotionDetection Motion
        {
            get;
        }

        /// <summary>
        /// IScan Object
        /// </summary>
        IScan Scan
        {
            get;
        }

        /// <summary>
        /// Keypad object
        /// </summary>
        IKeypad Keypad
        {
            get;
        }
    }
   

    internal class CPROXR : NCDBase , IProXR
    {

        private CRelayBanks mRelayBanks;
        private CTimers mTimers;
        private CAdvanceConfiguration mAdvancedConfiguration;
        private IAD12 mAD12 = null;
        private IAD8  mAD8 = null;
        private IPotentiometer mPot = null;
        private IMotionDetection mMotion = null;
        private IScan mScan = null;
        private IKeypad mKeypad = null;

        public CPROXR(NCDController objNCD) : base(objNCD)
        {
            mAdvancedConfiguration = new CAdvanceConfiguration(objNCD);
            mRelayBanks = new CRelayBanks(objNCD);
            mTimers = new CTimers(objNCD);
            mAD12 = new AD12(objNCD);
            mAD8 = new AD8(objNCD);
            mPot = new Potentiometer(objNCD);
            mMotion = new MotionDetection(objNCD);
            mScan = new Scan(objNCD);
            mKeypad = new Keypad(objNCD);
        }


        IRelayBanks IProXR.RelayBanks
        {
            get 
            {
                return mRelayBanks;
            }
        }

        ITimers IProXR.Timers
        {
            get
            {
                return mTimers;
            }
        }

        IAdvanceConfiguration IProXR.AdvanceConfiguration
        {
            get
            {
                return mAdvancedConfiguration;
            }
        }

        IAD12 IProXR.AD12
        {
            get
            {
                return mAD12;
            }
        }

        IAD8 IProXR.AD8
        {
            get
            {
                return mAD8;
            }
        }

        IPotentiometer IProXR.Pot
        {
            get
            {
                return mPot;
            }
        }

        IMotionDetection IProXR.Motion
        {
            get
            {
                return mMotion;
            }
        }

        IScan IProXR.Scan
        {
            get
            {
                return mScan;
            }
        }

        IKeypad IProXR.Keypad
        {
            get
            {
                return mKeypad;
            }
        }

        /// <summary>
        /// Turn on report mode.
        /// </summary>
        bool IProXR.TurnOnReportMode()
        {
            //  27 Turn Reporting Mode ON
            //WriteBytes(254, 27);
            return true;
            return mNCD.GetAck();
        }

        /// <summary>
        /// Turn off report mode.
        /// </summary>
        bool IProXR.TurnOffReportMode()
        {
            // 28 Turn Reporting Mode OFF
            WriteBytes(254, 28);

            return true;    // alwasy return true
        }
    }
}
