namespace CDRManagement.DataAccess.AsterNet.Manager.Event
{
    public class ConfbridgeListRoomsCompleteEvent : ResponseEvent
    {

        public ConfbridgeListRoomsCompleteEvent(ManagerConnection source)
			: base(source)
		{
		}
    }
}
