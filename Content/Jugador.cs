using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace FireEmblem3H.Content
{

    /* Cuando haga usos y tecnicas tengo que cambiar algunos emblemas:
     * Blaiddyd
     * Charon
     * Daphnel
     * Gautier
     * Goneril
     * Riegan
     * Cichol
     * Chevalier
     * Seiros
     * 
     * Si divido el daño mágico entre ataque y recuperación tengo que cambiar algunos emblemas:
     * Dominic
     * Lamine
     * Cethlean
     * Noa
     * Timotheos
    */

    public class Jugador : ModPlayer
    {
        bool blaiddyd = false;
        bool charon = false;
        bool daphnel = false;
        bool dominic = false;
        bool fraldarius = false;
        bool gautier = false;
        bool gloucester = false;
        bool goneril = false;
        bool lamine = false;
        bool riegan = false;
        bool theBeast = false;
        bool cethleann = false;
        bool cichol = false;
        bool indech = false;
        bool macuil = false;
        bool aubin = false;
        bool chevalier = false;
        bool noa = false;
        bool timotheos = false;
        bool flames = false;
        bool seiros = false;
        bool ernest = false;

        string swordArt = "";
        string lanceArt = "";
        string axeArt = "";
        string bowArt = "";
        string fistArt = "";

        public bool Blaiddyd { get => blaiddyd; set => blaiddyd = value; }
        public bool Charon { get => charon; set => charon = value; }
        public bool Daphnel { get => daphnel; set => daphnel = value; }
        public bool Dominic { get => dominic; set => dominic = value; }
        public bool Fraldarius { get => fraldarius; set => fraldarius = value; }
        public bool Gautier { get => gautier; set => gautier = value; }
        public bool Gloucester { get => gloucester; set => gloucester = value; }
        public bool Goneril { get => goneril; set => goneril = value; }
        public bool Lamine { get => lamine; set => lamine = value; }
        public bool Riegan { get => riegan; set => riegan = value; }
        public bool TheBeast { get => theBeast; set => theBeast = value; }
        public bool Cethleann { get => cethleann; set => cethleann = value; }
        public bool Cichol { get => cichol; set => cichol = value; }
        public bool Indech { get => indech; set => indech = value; }
        public bool Macuil { get => macuil; set => macuil = value; }
        public bool Aubin { get => aubin; set => aubin = value; }
        public bool Chevalier { get => chevalier; set => chevalier = value; }
        public bool Noa { get => noa; set => noa = value; }
        public bool Timotheos { get => timotheos; set => timotheos = value; }
        public bool Flames { get => flames; set => flames = value; }
        public bool Seiros { get => seiros; set => seiros = value; }
        public bool Ernest { get => ernest; set => ernest = value; }

        public string SwordArt { get => swordArt; set => swordArt = value; }
        public string LanceArt { get => lanceArt; set => lanceArt = value; }
        public string AxeArt { get => axeArt; set => axeArt = value; }
        public string BowArt { get => bowArt; set => bowArt = value; }
        public string FistArt { get => fistArt; set => fistArt = value; }

        public override void ResetEffects()
        {
            blaiddyd = false;
            charon = false;
            daphnel = false;
            dominic = false;
            fraldarius = false;
            gautier = false;
            gloucester = false;
            goneril = false;
            lamine = false;
            riegan = false;
            theBeast = false;
            cethleann = false;
            cichol = false;
            indech = false;
            macuil = false;
            aubin = false;
            chevalier = false;
            noa = false;
            timotheos = false;
            flames = false;
            seiros = false;
            ernest = false;

            swordArt = "";
            lanceArt = "";
            axeArt = "";
            bowArt = "";
            fistArt = "";

            switch (Player.name.ToLower())
            {
                //Crest of Blaiddyd
                case String name
                when name.Contains("blaiddyd")
                || name.Contains("dimitri")
                || name.Contains("lambert")
                || name.Contains("loog")
                || name.Contains("klaus"):
                    blaiddyd = true;
                    break;
                //Crest of Charon
                case String name
                when name.Contains("charon")
                || name.Contains("cassandra")
                || name.Contains("catherine"):
                    charon = true;
                    break;
                //Crest of Daphnel
                case String name
                when name.Contains("daphnel")
                || name.Contains("ingrid"):
                    daphnel = true;
                    break;
                //Crest of Dominic
                case String name
                when name.Contains("dominic")
                || name.Contains("annete")
                || name.Contains("simon"):
                    dominic = true;
                    break;
                //Crest of Fraldarius
                case String name
                when name.Contains("fraldarius")
                || name.Contains("rodrigue")
                || name.Contains("felix"):
                    fraldarius = true;
                    break;
                //Crest of Gautier
                case String name
                when name.Contains("gautier")
                || name.Contains("matthias")
                || name.Contains("sylvain"):
                    gautier = true;
                    break;
                //Crest of Gloucester
                case String name
                when name.Contains("gloucester")
                || name.Contains("erwin")
                || name.Contains("lorenz"):
                    gloucester = true;
                    break;
                //Crest of Goneril
                case String name
                when name.Contains("goneril")
                || name.Contains("hilda"):
                    goneril = true;
                    break;
                //Crest of Lamine
                case String name
                when name.Contains("lamine")
                || name.Contains("mercededs")
                || name.Contains("jeritza")
                || name.Contains("death knight"):
                    lamine = true;
                    break;
                //Crest of Riegan
                case String name
                when name.Contains("riegan")
                || name.Contains("godfrey")
                || name.Contains("claude")
                || name.Contains("khalid"):
                    riegan = true;
                    break;
                //Crest of The Beast
                case String name
                when name.Contains("maurice")
                || name.Contains("marianne"):
                    theBeast = true;
                    break;
                //Crest of Cethleann
                case String name
                when name.Contains("cethleann")
                || name.Contains("flayn")
                || name.Contains("waldemar")
                || name.Contains("linhardt"):
                    cethleann = true;
                    break;
                //Crest of Cichol
                case String name
                when name.Contains("cichol")
                || name.Contains("seteth")
                || name.Contains("leopold")
                || name.Contains("ludwig")
                || name.Contains("ferdinand"):
                    cichol = true;
                    break;
                //Crest of Indech
                case String name
                when name.Contains("indech")
                || name.Contains("gregoire")
                || name.Contains("bernadetta")
                || name.Contains("hanneman"):
                    indech = true;
                    break;
                //Crest of Macuil
                case String name
                when name.Contains("macuil")
                || name.Contains("monica"):
                    macuil = true;
                    break;
                //Crest of Aubin
                case String name
                when name.Contains("aubin")
                || name.Contains("yuri"):
                    aubin = true;
                    break;
                //Crest of Chevalier
                case String name
                when name.Contains("chevalier")
                || name.Contains("balthus"):
                    chevalier = true;
                    break;
                //Crest of Noa
                case String name
                when name.Contains("noa")
                || name.Contains("constance"):
                    noa = true;
                    break;
                //Crest of Timotheos
                case String name
                when name.Contains("timotheos")
                || name.Contains("hapi"):
                    timotheos = true;
                    break;
                //Crest of Flames
                case String name
                when name.Contains("sothis")
                || name.Contains("nemesis")
                || name.Contains("byleth"):
                    flames = true;
                    break;
                //Crest of Seiros
                case String name
                when name.Contains("seiros")
                || name.Contains("rhea")
                || name.Contains("jeralt")
                || name.Contains("aelfric")
                || name.Contains("wilhelm")
                || name.Contains("lycaon"):
                    seiros = true;
                    break;
                //& Crest of Ernest
                case String name
                when name.Contains("anna"):
                    ernest = true;
                    break;
                //2 Crest
                //Crest of Charon & Crest of Gloucester
                case String name
                when name.Contains("lysithea"):
                    charon = true;
                    gloucester = true;
                    break;
                //Crest of Flames & Crest of Seiros
                case String name
                when name.Contains("edelgard"):
                    flames = true;
                    seiros = true;
                    break;
            }
        }

        // If the user doesnt hold a crest, it receives 10 True damage
        public void checkCrest()
        {
            if (blaiddyd
                || charon
                || daphnel
                || dominic
                || fraldarius
                || gautier
                || gloucester
                || goneril
                || lamine
                || riegan
                || theBeast
                || cethleann
                || cichol
                || indech
                || macuil
                || aubin
                || chevalier
                || noa
                || timotheos
                || flames
                || seiros
                || ernest)
            {
            }
            else
            {
                if (Main.masterMode)
                {
                    Player.Hurt(new Terraria.DataStructures.PlayerDeathReason(), (10 + (Player.statDefense)), 0, false, false, 0, false);
                }
                else if (Main.expertMode)
                {
                    Player.Hurt(new Terraria.DataStructures.PlayerDeathReason(), (10 + ((int)(Player.statDefense * 0.75f))), 0, false, false, 0, false);
                }
                else
                {
                    Player.Hurt(new Terraria.DataStructures.PlayerDeathReason(), (10 + ((int)(Player.statDefense * 0.5f))), 0, false, false, 0, false);
                }
            }
        }

        public override void ModifyManaCost(Item item, ref float reduce, ref float mult)
        {
            if (dominic
                || noa)
            {
                mult = 0.8f;
            }
            if (lamine
                || timotheos)
            {
                mult = 0.8f;
            }
        }

        public override float UseAnimationMultiplier(Item item)
        {
            if (blaiddyd)
            {
                if (item.DamageType == DamageClass.Melee
                    || item.DamageType == DamageClass.Ranged
                    || item.DamageType == DamageClass.MeleeNoSpeed
                    || item.DamageType == DamageClass.SummonMeleeSpeed)
                {
                    return 1.5f;
                }
                return 1;
            }
            if (indech)
            {
                if (item.DamageType == DamageClass.Melee
                   || item.DamageType == DamageClass.Ranged
                   || item.DamageType == DamageClass.MeleeNoSpeed
                   || item.DamageType == DamageClass.SummonMeleeSpeed)
                {
                    return 0.75f;
                }
                return 1;
            }
            return 1;
        }

        public override float UseTimeMultiplier(Item item)
        {
            if (blaiddyd)
            {
                if (item.DamageType == DamageClass.Melee
                    || item.DamageType == DamageClass.Ranged
                    || item.DamageType == DamageClass.MeleeNoSpeed
                    || item.DamageType == DamageClass.SummonMeleeSpeed)
                {
                    return 1.5f;
                }
                return 1;
            }
            if (indech)
            {
                if (item.DamageType == DamageClass.Melee
                   || item.DamageType == DamageClass.Ranged
                   || item.DamageType == DamageClass.MeleeNoSpeed
                   || item.DamageType == DamageClass.SummonMeleeSpeed)
                {
                    return 0.75f;
                }
                return 1;
            }
            return 1;
        }

        public override void ModifyHitNPCWithProj(Projectile proj, Terraria.NPC target, ref Terraria.NPC.HitModifiers modifiers)
        {
            if (riegan
                || chevalier)
            {
                if (proj.DamageType == DamageClass.Melee
                    || proj.DamageType == DamageClass.Ranged
                    || proj.DamageType == DamageClass.MeleeNoSpeed
                    || proj.DamageType == DamageClass.SummonMeleeSpeed)
                {
                    Player.Heal((int)(proj.damage * 0.15f));
                }
            }
            if (flames)
            {
                Player.Heal((int)(proj.damage * 0.1f));
            }
        }

        public override void ModifyHitNPCWithItem(Item item, Terraria.NPC target, ref Terraria.NPC.HitModifiers modifiers)
        {
            if (riegan
                || chevalier)
            {
                if (item.DamageType == DamageClass.Melee
                    || item.DamageType == DamageClass.Ranged
                    || item.DamageType == DamageClass.MeleeNoSpeed
                    || item.DamageType == DamageClass.SummonMeleeSpeed)
                {
                    Player.Heal((int)(item.damage * 0.15f));
                }
            }
            if (flames)
            {
                Player.Heal((int)(item.damage * 0.1f));
            }
        }

        public override void ModifyWeaponDamage(Item item, ref StatModifier damage)
        {
            if (blaiddyd)
            {
                if (item.DamageType == DamageClass.Melee
                   || item.DamageType == DamageClass.Ranged
                   || item.DamageType == DamageClass.MeleeNoSpeed
                   || item.DamageType == DamageClass.SummonMeleeSpeed)
                {
                    damage *= 1.7f;
                }
            }
            if (charon
                || daphnel
                || gautier
                || seiros)
            {
                if (item.DamageType == DamageClass.Melee
                    || item.DamageType == DamageClass.Ranged
                    || item.DamageType == DamageClass.MeleeNoSpeed
                    || item.DamageType == DamageClass.SummonMeleeSpeed)
                {
                    damage *= 1.4f;
                }
            }
            if (fraldarius
                || theBeast)
            {
                if (item.DamageType == DamageClass.Melee
                    || item.DamageType == DamageClass.Ranged
                    || item.DamageType == DamageClass.MeleeNoSpeed
                    || item.DamageType == DamageClass.SummonMeleeSpeed)
                {
                    damage *= 1.2f;
                }
            }
            if (gloucester
                || macuil)
            {
                if (item.DamageType == DamageClass.Magic)
                {
                    damage *= 1.1f;
                }
            }
            if (cethleann)
            {
                if (item.DamageType == DamageClass.Magic)
                {
                    damage *= 1.5f;
                }
            }
            if (flames)
            {
                damage *= 1.1f;
            }
        }
        public override void ModifyWeaponKnockback(Item item, ref StatModifier knockback)
        {
            if (goneril
                || cichol)
            {
                if (item.DamageType == DamageClass.Melee
                    || item.DamageType == DamageClass.Ranged
                    || item.DamageType == DamageClass.MeleeNoSpeed
                    || item.DamageType == DamageClass.SummonMeleeSpeed)
                {
                    knockback *= 1.25f;
                }
            }
            if (aubin
                || ernest)
            {
                if (item.DamageType == DamageClass.Melee
                    || item.DamageType == DamageClass.Ranged
                    || item.DamageType == DamageClass.MeleeNoSpeed
                    || item.DamageType == DamageClass.SummonMeleeSpeed)
                {
                    knockback *= 1.25f;
                }
            }
            if (flames)
            {
                knockback *= 1.1f;
            }
        }
    }
}
