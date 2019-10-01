using System;
using System.Collections.Generic;
using AsterNET.NetStandard.Manager.Event;

namespace AsterNET.NetStandard.Manager.Action
{
    public class MuteAction : ManagerActionEvent, IActionVariable
    {
        private Dictionary<string, string> variables;

        #region Action 

        public override string Action
        {
            get { return "MuteAudio"; }
        }

        #endregion

        #region Account 

        public string Account { get; set; }

        #endregion

        #region CallerId 
        
        public string CallerId { get; set; }

        #endregion

        #region Channel 
        
        public string Channel { get; set; }

        #endregion

        #region Context 
        
        public string Context { get; set; }

        #endregion

        #region Exten 

        
        
        
        
        public string Exten { get; set; }

        #endregion

        #region Priority 

        
        
        
        
        public string Priority { get; set; }

        #endregion

        #region Application 

        
        
        
        public string Application { get; set; }

        #endregion

        #region Data 

        
        
        
        
        
        public string Data { get; set; }

        #endregion

        #region Async 

        
        
        
        
        
        
        public bool Async { get; set; }

        #endregion

        #region ActionCompleteEventClass 

        public override Type ActionCompleteEventClass()
        {
            return typeof (OriginateResponseEvent);
        }

        #endregion

        #region Timeout 

        
        
        
        
        
        
        public int Timeout { get; set; }

        #endregion

        #region Variable 

        
        
        
        
        
        
        
        [Obsolete("Use GetVariables and SetVariables instead.", true)]
        public string Variable
        {
            get { return null; /* return Helper.JoinVariables(variables, Common.GET_VAR_DELIMITER(this.Server), "="); */ }
            set { /* variables = Helper.ParseVariables(variables, value, Common.GET_VAR_DELIMITER(this.Server)); */ }
        }

        public string Direction { get; set; }

        public string State { get; set; }

        #endregion

        #region GetVariables() 




        public Dictionary<string, string> GetVariables()
        {
            return variables;
        }

        #endregion

        #region SetVariables(IDictionary vars) 

        
        
        
        public void SetVariables(Dictionary<string, string> vars)
        {
            variables = vars;
        }

        #endregion

        #region GetVariable(string name, string val) 

        
        
        
        public string GetVariable(string key)
        {
            if (variables == null)
                return string.Empty;
            return variables[key];
        }

        #endregion

        #region SetVariable(string name, string val) 

        
        
        
        public void SetVariable(string key, string value)
        {
            if (variables == null)
                variables = new Dictionary<string, string>();
            if (variables.ContainsKey(key))
                variables[key] = value;
            else
                variables.Add(key, value);
        }

        #endregion
    }
}