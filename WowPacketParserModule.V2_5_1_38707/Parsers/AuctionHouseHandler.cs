using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;

namespace WowPacketParserModule.V2_5_1_38707.Parsers
{
    public static class AuctionHouseHandler
    {
        [Parser(Opcode.SMSG_AUCTION_OWNER_BID_NOTIFICATION)]
        public static void HandleAuctionOwnerBidNotification(Packet packet)
        {
            var mailListCount = packet.ReadUInt32("MailListCount");
            packet.ReadInt32("Field_04");

            for (var i = 0; i < mailListCount; i++)
                V7_0_3_22248.Parsers.MailHandler.ReadMailListEntry(packet, "MailListEntry", i);
        }
    }
}
