﻿using System.Collections;
using System.Collections.Generic;
using CitizenFX.Core;

namespace ELS.FullSync
{
    public class FullSync
    {
        protected FullSync()
        {

        }
    }

    internal class FullSyncManager
    {
        internal FullSyncManager()
        {
            
        }

        internal static void RequestData(long NetworkID)
        {
            BaseScript.TriggerServerEvent("ELS:FullSync:Request", NetworkID);
        }

        internal static void SendData(string SirenType,IDictionary dic,long NetworkID)
        {
            BaseScript.TriggerServerEvent("ELS:FullSync",SirenType,dic,NetworkID);
        }
    }
    internal static class SetData
    {
//        SetData()
//        {
//
//        }
    }

    internal interface IFullSyncComponent
    {
        void SetData(IDictionary<string, object> data);
        Dictionary<string, object> ToDic();
    }
}