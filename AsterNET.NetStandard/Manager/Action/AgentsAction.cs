using System;
using CDRManagement.DataAccess.AsterNet.Manager.Event;

namespace CDRManagement.DataAccess.AsterNet.Manager.Action
{
    /// <summary>
    ///     The AgentsAction requests the state of all agents.<br />
    ///     For each agent an AgentsEvent is generated.
    ///     After the state of all agents has been reported an AgentsCompleteEvent is generated.<br />
    ///     Available since Asterisk 1.2
    /// </summary>
    /// <seealso cref="AgentsEvent" />
    /// <seealso cref="AgentsCompleteEvent" />
    public class AgentsAction : ManagerActionEvent
    {
        #region Action 

        /// <summary>
        ///     Get the name of this action, i.e. "Agents".
        /// </summary>
        public override string Action
        {
            get { return "Agents"; }
        }

        #endregion

        #region ActionCompleteEventClass 

        public override Type ActionCompleteEventClass()
        {
            return typeof (AgentsCompleteEvent);
        }

        #endregion

        #region AgentsAction() 

        #endregion
    }
}