using System;

namespace PVZ_Plugin
{
    class PVZPlugins
    {
        private uint processId = 0;
        private int[] SunConfig = { 0x00355F28,0x868,0x5578 };
        public uint ProcessId
        {
            get { return processId; }
            set { processId = value; }
        }

        public bool SetSun(int sun) {
            if (!inited())
            {
                throw new Exception("未找到植物大战僵尸的进程");
            }
            IntPtr sunptr = GetSunAddress();
            IntPtr handler = Util.OpenProcess(Util.PROCESS_ALL_ACCESS, true, (int)processId);
            IntPtr write;
            Util.WriteProcessMemory(handler, sunptr, new int[] { sun}, 4, out write);
            if(write.ToInt32() == 4)
            {
                return true;
            }
            return false;
        }

        public IntPtr GetSunAddress()
        {
            if (!inited())
            {
                throw new Exception("未找到植物大战僵尸的进程");
            }
            int[] addr = new int[1];
            IntPtr read;
            IntPtr handler = Util.OpenProcess(Util.PROCESS_ALL_ACCESS, true, (int)processId);
            IntPtr Baseaddr = Util.GetModuleBaseAddress((IntPtr)processId, "PlantsVsZombies.exe");
            Util.ReadProcessMemory(handler, IntPtr.Add(Baseaddr, SunConfig[0]), addr, 4, out read);
            Util.ReadProcessMemory(handler, IntPtr.Add((IntPtr)(addr[0]), SunConfig[1]), addr, 4, out read);
            return IntPtr.Add((IntPtr)(addr[0]), SunConfig[2]);
        }

        public int GetSun()
        {
            if (!inited())
            {
                throw new Exception("未找到植物大战僵尸的进程");
            }
            int[] sun = new int[1];
            IntPtr read;
            IntPtr handler =  Util.OpenProcess(Util.PROCESS_ALL_ACCESS,true, (int)processId);
        
            Util.ReadProcessMemory(handler,GetSunAddress(), sun, 4, out read);

            return sun[0];
        }
        public bool inited()
        {
            if (processId != 0)
            {
                return true;
            }
            else
            {
                uint id = Util.findProcessIdByname("PlantsVsZombies.exe");
                if (id != 0)
                {
                    processId = id;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}
