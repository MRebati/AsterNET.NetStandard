namespace CDRManagement.DataAccess.AsterNet.Manager.Event
{
    public class ConfbridgeListCompleteEvent : ResponseEvent
    {
        public ConfbridgeListCompleteEvent(ManagerConnection source)
			: base(source)
		{
		}
    }
}
