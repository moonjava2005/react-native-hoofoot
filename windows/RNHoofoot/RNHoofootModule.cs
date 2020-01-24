using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Hoofoot.RNHoofoot
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNHoofootModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNHoofootModule"/>.
        /// </summary>
        internal RNHoofootModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNHoofoot";
            }
        }
    }
}
