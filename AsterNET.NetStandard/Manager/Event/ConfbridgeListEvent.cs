namespace AsterNET.NetStandard.Manager.Event
{
    public class ConfbridgeListEvent : AbstractConfbridgeEvent
    {
        
        /// <summary>
        /// 
        /// </summary>
        public string CallerIDNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CallerIDName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Admin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string MarkedUser { get; set; }

        public ConfbridgeListEvent(ManagerConnection source)
			: base(source)
		{
		}
    }
}
