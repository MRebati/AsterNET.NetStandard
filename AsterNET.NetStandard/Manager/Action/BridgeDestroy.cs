namespace AsterNET.NetStandard.Manager.Action
{
    
    public class BridgeDestroy : ManagerAction
    {
        /// <summary>
        /// Deletes the bridge, causing channels to continue or hang up.
        /// </summary>
        /// <param name="bridgeUniqueId">Bridge UniqueId</param>
        public BridgeDestroy(string bridgeUniqueId)
        {
            BridgeUniqueId = bridgeUniqueId;
        }

        public override string Action
        {
            get { return "Bridge"; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string BridgeUniqueId { get; set; }
    }
}