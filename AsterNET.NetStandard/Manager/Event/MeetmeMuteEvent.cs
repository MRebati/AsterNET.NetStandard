namespace CDRManagement.DataAccess.AsterNet.Manager.Event
{
    public class MeetmeMuteEvent : AbstractMeetmeEvent
    {
        public MeetmeMuteEvent(ManagerConnection source)
            : base(source)
        {
        }

        public bool Status { get; set; }
    }
}