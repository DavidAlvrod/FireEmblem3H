using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using FireEmblem3H.Content.Global;

namespace FireEmblem3H.Content.Global
{
    public class SwordArtSlot : ModAccessorySlot
    {
        public override bool CanAcceptItem(Item item, AccessorySlotType context)
        {
            if (item.wingSlot > 0)
            {
                return true;
            }
            return false;
        }

        public override bool DrawVanitySlot => false;
        public override bool DrawDyeSlot => false;
    }
}
