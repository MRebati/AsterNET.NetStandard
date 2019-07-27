using System.Collections.Generic;

namespace CDRManagement.DataAccess.AsterNet.Manager
{
    interface IActionVariable
    {
        Dictionary<string, string> GetVariables();
        void SetVariables(Dictionary<string, string> vars);
    }
}
