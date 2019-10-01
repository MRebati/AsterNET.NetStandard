using System.Collections.Generic;

namespace AsterNET.NetStandard.Manager
{
    interface IActionVariable
    {
        Dictionary<string, string> GetVariables();
        void SetVariables(Dictionary<string, string> vars);
    }
}
