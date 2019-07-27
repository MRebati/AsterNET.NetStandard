namespace CDRManagement.DataAccess.AsterNet.Manager.Event
{
    /// <summary>
    ///     An AgentRingNoAnswerEvent is triggered when an agent is rung out.<br />
    ///     To enable AgentRingNoAnswerEvents you have to set eventwhencalled = yes in queues.conf.<br />
    ///     This event is implemented in apps/app_queue.c
    /// </summary>
    public class AgentRingNoAnswerEvent : AbstractAgentVariables
    {
        public AgentRingNoAnswerEvent(ManagerConnection source)
            : base(source)
        {
        }

        public string Queue { get; set; }

        public string AgentName { get; set; }

        public string AgentCalled { get; set; }

        public string ChannelCalling { get; set; }

        public string DestinationChannel { get; set; }

        public string CallerId { get; set; }

        /// <summary>
        ///     Get/Set the Caller*ID number of the calling channel.
        /// </summary>
        public string CallerIdNum { get; set; }

        /// <summary>
        ///     Get/Set the Caller*ID name of the calling channel.
        /// </summary>
        public string CallerIdName { get; set; }

        public string Context { get; set; }

        public string Extension { get; set; }

        public string Priority { get; set; }
    }
}