using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace MyTcpView
{
    public class WinAPI
    {
        [DllImport("iphlpapi.dll", SetLastError = true)]
        public static extern uint GetExtendedTcpTable(IntPtr pTcpTable, ref int dwOutBufLen, bool sort, int ipVersion, TCP_TABLE_CLASS tblClass, uint reserved = 0);
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TcpRow
    {
        // DWORD is System.UInt32 in C#
        public System.UInt32 state;
        public System.UInt32 localAddr;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] localPort;
        public System.UInt32 remoteAddr;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] remotePort;
        public System.UInt32 owningPid;
        public System.Net.IPAddress LocalAddress
        {
            get
            {
                return new System.Net.IPAddress(localAddr);
            }
        }
        public ushort LocalPort
        {
            get
            {
                return BitConverter.ToUInt16(
                new byte[2] { localPort[1], localPort[0] }, 0);
            }
        }
        public System.Net.IPAddress RemoteAddress
        {
            get
            {
                return new System.Net.IPAddress(remoteAddr);
            }
        }
        public ushort RemotePort
        {
            get
            {
                return BitConverter.ToUInt16(
                new byte[2] { remotePort[1], remotePort[0] }, 0);
            }
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct TcpTable
    {
        public uint dwNumEntries;
        TcpRow table;
    }

    public enum TCP_TABLE_CLASS
    {
        TCP_TABLE_BASIC_LISTENER,
        TCP_TABLE_BASIC_CONNECTIONS,
        TCP_TABLE_BASIC_ALL,
        TCP_TABLE_OWNER_PID_LISTENER,
        TCP_TABLE_OWNER_PID_CONNECTIONS,
        TCP_TABLE_OWNER_PID_ALL,
        TCP_TABLE_OWNER_MODULE_LISTENER,
        TCP_TABLE_OWNER_MODULE_CONNECTIONS,
        TCP_TABLE_OWNER_MODULE_ALL
    }
}
