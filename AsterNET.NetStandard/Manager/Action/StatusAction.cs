using System;
using CDRManagement.DataAccess.AsterNet.Manager.Event;

namespace CDRManagement.DataAccess.AsterNet.Manager.Action
{
    /// <summary>
    ///     The StatusAction requests the state of all active channels.<br />
    ///     For each active channel a StatusEvent is generated. After the state of all
    ///     channels has been reported a StatusCompleteEvent is generated.
    /// </summary>
    /// <seealso cref="Manager.Event.StatusEvent" />
    /// <seealso cref="Manager.Event.StatusCompleteEvent" />
    public class StatusAction : ManagerActionEvent
    {
        /// <summary>
        ///     Get the name of this action, i.e. "Status".
        /// </summary>
        public override string Action
        {
            get { return "Status"; }
        }

        public override Type ActionCompleteEventClass()
        {
            return typeof (StatusCompleteEvent);
        }
    }
}