using FireEmblem3H.Content.Items.Materials;
using Terraria;
/*using Terraria.GameContent.Bestiary;
using Terraria.GameContent.Events;*/
using Terraria.GameContent.ItemDropRules;
//using Terraria.GameContent.Personalities;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Utilities;

namespace FireEmblem3H.Content.NPC
{
    public class Dragon : ModNPC
    {
        public override void SetStaticDefaults()
        {

            Main.npcFrameCount[Type] = 4;

            NPCID.Sets.NPCBestiaryDrawModifiers value = new NPCID.Sets.NPCBestiaryDrawModifiers(0)
            { 
                Velocity = 1f
            };
            NPCID.Sets.NPCBestiaryDrawOffset.Add(Type, value);
        }

        public override void SetDefaults()
        {
            NPC.width = 80;
            NPC.height = 68;
            NPC.damage = 100;
            NPC.defense = 30;
            NPC.lifeMax = 1000;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath2;
            NPC.value = 4000;
            NPC.knockBackResist = 0.5f;
            NPC.aiStyle = NPCAIStyleID.Bat;

            AIType = NPCID.Hellbat;
            AnimationType = NPCID.Demon;
            Banner = Item.NPCtoBanner(NPCID.Demon);
            BannerItem = Item.BannerToItem(Banner);
        }

        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<CrestStone>(), 2));
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<DragonBone>(), 1, 20,100));
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (Terraria.NPC.downedMoonlord)
            {
                return SpawnCondition.Overworld.Chance * 0.015f;
            }
            return 0;// Spawn with 1/5th the chance of a regular zombie.
        }
    }
}
