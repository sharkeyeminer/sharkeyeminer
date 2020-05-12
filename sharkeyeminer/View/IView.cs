using SharkEye.Core.Interfaces;
using SharkEye.View.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharkEye.View
{

    interface IView
    {
        void InitializeView();
        void StartView();
        void UpdateMinerList();
        void UpdateSettingsCarousal();
        void UpDateMinerState();
        void ShowHardwareMissingError();
        void RegisterForTimer(SharkEyeTimerEvent fun);
        TSQueue<DownloadRequest> DownloadRequestQueue { get; set; }

    }
}
