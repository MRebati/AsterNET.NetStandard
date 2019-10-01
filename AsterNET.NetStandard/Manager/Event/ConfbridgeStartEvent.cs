namespace AsterNET.NetStandard.Manager.Event
{
    public class ConfbridgeStartEvent : AbstractConfbridgeEvent
    {
        public ConfbridgeStartEvent(ManagerConnection source)
			: base(source)
		{
		}
    }
}
