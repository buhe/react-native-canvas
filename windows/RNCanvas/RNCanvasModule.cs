using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Com.Reactlibrary.RNCanvas
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNCanvasModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNCanvasModule"/>.
        /// </summary>
        internal RNCanvasModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNCanvas";
            }
        }
    }
}
