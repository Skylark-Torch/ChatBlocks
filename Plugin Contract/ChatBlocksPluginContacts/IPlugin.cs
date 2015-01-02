using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBlocksPluginContacts
{
    interface IPlugin
    {
        /// <summary>
        /// Identifying, human-readable name, as unique as possible.
        /// </summary>
        public String Name
        {
            get;
            set;
        }

        /// <summary>
        /// Version number of the plugin.
        /// </summary>
        public float Version
        {
            get;
            set;
        }

        /// <summary>
        /// Plugins aren't required to have GUI blocks. Specify if you need one or not.
        /// </summary>
        public bool UsesBlock
        {
            get;
            set;
        }

        /// <summary>
        /// Runs all logical updating for the plugin
        /// </summary>
        /// <returns>
        /// True if no errors, False if an error is reached. Please manage your own error handling cleanly.
        /// </returns>
        public bool Update();

        /// <summary>
        /// Generates the GUI block of the plugin, if using one.
        /// </summary>
        /// <returns>
        /// A GroupBox containing any other GUI elements needed. Effectively a constructor for the plugin in terms of GUI.
        /// </returns>
        public GroupBox BuildBlock();
    }
}
