using System.IO;
using CDRManagement.DataAccess.AsterNet.FastAGI.Command;
using CDRManagement.DataAccess.AsterNet.FastAGI.Exceptions;
using CDRManagement.DataAccess.AsterNet.IO;

namespace CDRManagement.DataAccess.AsterNet.FastAGI
{
    /// <summary>
    ///     Default implementation of the AGIWriter interface.
    /// </summary>
    public class AGIWriter
    {
        private readonly SocketConnection socket;

        public AGIWriter(SocketConnection socket)
        {
            lock (this)
                this.socket = socket;
        }

        public void SendCommand(AGICommand command)
        {
            string buffer = command.BuildCommand() + "\n";
            try
            {
                socket.Write(buffer);
            }
            catch (IOException e)
            {
                throw new AGINetworkException("Unable to send command to Asterisk: " + e.Message, e);
            }
        }
    }
}