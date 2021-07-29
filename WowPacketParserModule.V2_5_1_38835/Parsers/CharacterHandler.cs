using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;

namespace WowPacketParserModule.V2_5_1_38835.Parsers
{
    public static class CharacterHandler
    {
        [Parser(Opcode.CMSG_PLAYER_LOGIN)]
        public static void HandlePlayerLogin(Packet packet)
        {
            packet.ReadPackedGuid128("PlayerGUID");
            packet.ReadSingle("FarClip");
            packet.ReadBit("UnkBit");
        }
    }
}
