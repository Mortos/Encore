using System.Diagnostics.Contracts;
using Trinity.Encore.Game.Network;
using Trinity.Encore.Game.Network.Handling;
using Trinity.Encore.Game.Network.Transmission;
using Trinity.Network.Connectivity;

namespace Trinity.Encore.WorldService.Handlers
{
    public static class ConnectionHandler
    {
        //[WorldPacketHandler(WorldOpCode.ClientConnectionPing)]
        public static void HandlePing(IClient client, IncomingWorldPacket packet)
        {
            Contract.Requires(client != null);
            Contract.Requires(packet != null);

            packet.ReadInt32(); // latency
            var sequence = packet.ReadInt32();

            SendPong(client, sequence);
        }

        public static void SendPong(IClient client, int sequence)
        {
            Contract.Requires(client != null);

            using (var packet = new OutgoingWorldPacket(WorldOpCode.ServerConnectionPong, 4))
            {
                packet.Write(sequence);

                client.Send(packet);
            }
        }
    }
}
