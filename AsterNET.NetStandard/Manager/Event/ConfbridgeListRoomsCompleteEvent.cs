namespace AsterNET.NetStandard.Manager.Event
{
    public class ConfbridgeListRoomsCompleteEvent : ResponseEvent
    {

        public ConfbridgeListRoomsCompleteEvent(ManagerConnection source)
			: base(source)
		{
		}
    }
}
