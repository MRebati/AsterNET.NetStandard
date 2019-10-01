namespace AsterNET.NetStandard.Manager.Event
{
    public class ConfbridgeListRoomsEvent : AbstractConfbridgeEvent
    {
        /// <summary>
        /// 
        /// </summary>
        public int Parties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Marked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Locked { get; set; }

        public ConfbridgeListRoomsEvent(ManagerConnection source)
			: base(source)
		{
		}
    }
}
