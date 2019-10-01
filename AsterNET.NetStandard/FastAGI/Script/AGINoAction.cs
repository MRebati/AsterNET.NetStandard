namespace AsterNET.NetStandard.FastAGI.Script
{
	class AGINoAction : AGIScript
	{
		public override void Service(AGIRequest request, AGIChannel channel)
		{
			base.Hangup();
		}
	}
}
