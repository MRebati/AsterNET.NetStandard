namespace AsterNET.NetStandard.Manager.Event
{
    public class ConfbridgeListCompleteEvent : ResponseEvent
    {
        public ConfbridgeListCompleteEvent(ManagerConnection source)
			: base(source)
		{
		}
    }
}
