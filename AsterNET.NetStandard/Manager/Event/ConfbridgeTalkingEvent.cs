namespace CDRManagement.DataAccess.AsterNet.Manager.Event
{
    public class ConfbridgeTalkingEvent : AbstractConfbridgeEvent
    {
        /// <summary>
        /// 
        /// </summary>
        public string TalkingStatus { get; set; }

        public ConfbridgeTalkingEvent(ManagerConnection source)
			: base(source)
		{
		}
    }
}
