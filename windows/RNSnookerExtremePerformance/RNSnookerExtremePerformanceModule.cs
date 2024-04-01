using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Snooker.Extreme.Performance.RNSnookerExtremePerformance
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNSnookerExtremePerformanceModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNSnookerExtremePerformanceModule"/>.
        /// </summary>
        internal RNSnookerExtremePerformanceModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNSnookerExtremePerformance";
            }
        }
    }
}
