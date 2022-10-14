using System.Xml.Linq;

namespace DDOAliasSwitcher
{
    internal class Aliases
    {
        Dictionary<string, string> AliasLines = new Dictionary<string, string>();

        internal void ScrubFile(string fileLoc)
        {
            XDocument layoutFile = XDocument.Load(fileLoc);

            var query = from node in layoutFile.Descendants("Alias")
                        select node;
            query.ToList().ForEach(x => x.Remove());

            var query1 = from node in layoutFile.Descendants("Aliases")
                         select node;
            query1.ToList().ForEach(x => x.Remove());

            layoutFile.Save(fileLoc);
        }

        #region Alias Text
        internal Dictionary<string, string> CompileForRaidDay(string raidDay)
        {
            AliasColors();

            // Note: DDO has a limit of 50 Aliases per file.
            switch (raidDay)
            {
                case "Monday":
                    // No scheduled Monday raids

                    break;
                case "Tuesday":
                    // Lord of Blades

                    // Master Artificer

                    // Vision of Destruction
                    AliasLines.Add(";vdf", "/p ;pink Vision of Destruction has no flagging, questgiver is Tala Brin in the center of the marketplace by the bridge to your airship.");
                    AliasLines.Add(";vd1", "/p ;grey Vision of Destruction is an extended boss-fight raid. It's all in one room and there are waves of trash alongside the boss.");
                    AliasLines.Add(";vdc", "/p ;lblue Frequently the whole raid group will be cursed with a curse that stops healing. Chug Remove Curse pots as needed.");
                    AliasLines.Add(";vde", "/p ;lgreen Sometimes the boss drops circles on the ground that explode with electric damage after a few seconds. Try not to stand in them.");
                    AliasLines.Add(";vdt", "/p ;gold There are 8 trap boxes around the room. If left alone they will eventually spawn blade traps, but there's a long window to disarm them.");
                    AliasLines.Add(";vdo", "/p ;lpurple At the start and near the end of the raid 4 orthons will drop. They hit very hard, so use defensive clickies and let your tanks grab them.");
                    AliasLines.Add(";vdb", "/p ;blue Exploding Bats will drop in waves later on during the raid, they are very fragile but hit hard in an AoE so try to kill them first.");
                    AliasLines.Add(";vdd", "/p ;pink Barbazu Legionnaires drop across the raid, they are vulnerable to cc/instakills but otherwise fairly chunky with decent damage.");

                    // Killing Time


                    break;
                case "Wednesday":
                    // No scheduled Wednesday raids

                    break;
                case "Thursday":
                    // No scheduled Thursday raids

                    break;
                case "Friday":
                    // Mark of Death

                    // Vault of Night

                    // Zawabi's Revenge

                    // Fall of Truth


                    break;
                case "SaturdayAM1":
                    // Hound of Xoriat
                    AliasLines.Add(";hxf", "/p ;pink Hound of Xoriat has no flagging, questgiver is Niara Tonant in the Marketplace.");
                    AliasLines.Add(";hx1", "/p ;grey LHox is a group coordination raid. One designated person gathers quest items and charms the puppies to attack their mother since she is invulnerable to us until her hp is critical.");
                    AliasLines.Add(";hx2", "/p ;grey It is essential that the raid buffs, and does not kill the puppies. If charms wear off, we get a second set of puppies. If we fail two sets, we start the raid over.");
                    AliasLines.Add(";hxc", "/p ;lgreen The ideal charmer is a max level character that has as many Druid past lives as possible, Augment Summoning feat, and summon boosts from Druid and Primal Avatar.");
                    AliasLines.Add(";hxh", "/p ;lblue Make one loop around the main hall, pick up 4x Control Stones, then head to center. Target an uncharmed puppy and use the Control Stone to charm it, repeat until all are charmed. Note: Turn off Epic Def Fighting");
                    AliasLines.Add(";hxt", "/p ;gold This is a simple raid to tank, run to the center and grab Xy'zzy and pups. Adjust so your back is to the longest (East) hallway and hold still. Try to keep charmed puppies hitting Xy'zzy from behind.");
                    AliasLines.Add(";hxp", "/p ;lpurple Once charmed, the puppies should be buffed with GH, Bard buffs, Haste, Druid pet buffs, etc that enhance attack speed, STR, or damage.");

                    // Temple of the Deathwyrm
                    AliasLines.Add(";tdf", "/p ;pink Temple of the Deathwyrm requires defeating Sarva Bellistrae in the bottom of Thunderholme, questgiver is Thela Bonmar in the Thunder Peaks in Eveningstar.");
                    AliasLines.Add(";tdi", "/p ;grey Temple of Deathwyrm is a very long raid with many different (and varying) puzzles and challenges, ending with a group coordination-based fight against a Dracolich.");
                    AliasLines.Add(";tdp", "/p ;pink Puzzles vary by floor - there are 6 mirror puzzles and 2 portal options. For the portal options, only go left or right, NEVER straight.");
                    AliasLines.Add(";td1", "/p ;lpurple Mirror puzzles 1 and 2");
                    AliasLines.Add(";td2", "/p ;lblue Choice of two potential puzzles: L = Jumping Room / R = Traproom.");
                    AliasLines.Add(";td2p", "/p ;lblue L = Jump buff and feather fall are almost essential, wings/charge/spring attack/etc are very useful / R = Trappers essential, beware of traps and pull levers for group");
                    AliasLines.Add(";td3", "/p ;blue Mirror puzzles 3 and 4.");
                    AliasLines.Add(";td4", "/p ;pink Bone Guardian fight. Tank and spank fight, just beat him up like the loot pinata he is.");
                    AliasLines.Add(";td5", "/p ;grey Mirror puzzles 5 and 6.");
                    AliasLines.Add(";td6", "/p ;lgreen Choice of two potential puzzles: L = Red Light, Green Light / R = Shadow Tower.");
                    AliasLines.Add(";td6p", "/p ;lgreen L = Move when green, stop moving when yellow, stand still when red / R = High burst by phylactery, group up top. If you get purple hazy debuff, drop down to phylactery (hold block to not slowfall)");
                    AliasLines.Add(";td7", "/p ;red Shrine room - RAID LOCKOUT! Do not move until all players have entered this area.");
                    AliasLines.Add(";tde1", "/p ;gold Tank picks up dragon, kiter handles Kuldjargh when they spawn. Once kiter is hanging, raid begins hitting dragon until Shadows spawn. Stop dmg on dragon during shadow phases to avoid knocking players out of shadow phase.");
                    AliasLines.Add(";tde2", "/p ;gold Dps enter shadow portals and get in line to take turns going into the portal at the NE corner - type IN when entering and OUT when you've fully loaded out. Inside the inner portal, kill the phylactery. Repeat these steps until true phylactery is found.");
                    AliasLines.Add(";tde3", "/p ;lpurple Once the true phylactery has been found, a new shadow phase begins where you must enter the shadow realm to gather eight shards. Light the torches in the light phase with these flames to activate the levers on the NE and SE corners.");
                    AliasLines.Add(";tde4", "/p ;lpurple Once all torches are lit, tank pulls dragon to central mound to be executed by both corner levers. Both levers must be pulled at the same time when Aurglorasa lays down.");
                    AliasLines.Add(";tdt", "/p ;lblue Deathblock required (not Death Ward). Tank Aurgloroasa against the South wall for most of the fight. In the final phase, drag her to the center bone pile for killing.");
                    AliasLines.Add(";tdk", "/p ;lblue 5 Kuldjargh will spawn in a pentagonal pattern (NE, SW, NW, SE, W). A tank or highly mobile player picks them up, then kites them to the entrance. Jump and hang on the N side wall, then go get ice cream :)");

                    // Fire on Thunder Peak
                    AliasLines.Add(";fpf", "/p ;pink Fire on Thunder Peak requires defeating Dagan: Regent of Thunderholme in the upper part of Thunderholme, questgiver is Vaklos Halmar in the Thunder Peaks in Eveningstar.");
                    AliasLines.Add(";fp1", "/p ;grey Fire on Thunder Peak is a short raid which consists of one major boss encounter split on opposite sides of the arena. Both dragons must be separated, or they will be invulnerable.");
                    AliasLines.Add(";fp2", "/p ;grey The raid flow is dragon phase 1, trash phase, dragon phase 2, attack Meridian while unshielded until broken, then finish off dragons from final %5 hp.");
                    AliasLines.Add(";fpd1", "/p ;lblue Nevalarich (Fatty) enters first, attacking with mostly cleaving melee and some breath attacks. Strong tank or heavy kiting required for second dragon phase.");
                    AliasLines.Add(";fpd2", "/p ;pink Tharaxata (Skinny) enters second, attacking with more ranged fire attacks and some melee. Can be tanked by a ranged player with kiting or standing in one of the 'safe' spots.");
                    AliasLines.Add(";fpt", "/p ;lpurple When dragons fly away, the trash spawns must be handled smallest to largest. Once the Magma Volcanoes are dead, the dragons re-enter the arena for second dragon phase.");
                    AliasLines.Add(";fpm", "/p ;gold During second dragon phase, the Meridian's shield will occasionally drop at which time it will be vulnerable to damage for a brief period.  Burst it down over several shield-drop phases (Arcane Pulse is great here).");

                    break;
                case "SaturdayAM2":
                    // Old Baba's Hut
                    AliasLines.Add(";bhf", "/p ;pink Old Baba's Hut has no flagging, questgiver is Adrian Martikov upstairs in the Blue Water Inn in Ravenloft (House Jorasco).");
                    AliasLines.Add(";bh1", "/p ;grey Old Baba's Hut is a mostly split-party raid, requiring equally split resources on both sides to solve puzzles and defeat monsters when entering the hut. The end fight is a simple tank and spank with waves of trash.");
                    AliasLines.Add(";bhh", "/p ;red During the first and second phases in the clearing, the Hut will chase random people. If you have the debuff 'The Hut Hates You', kite the Hut around the outside of the clearing away from melee and tanks.");
                    AliasLines.Add(";bhi1", "/p ;lblue Between clearing phases, all players will enter the hut and split evenly between the left and right sides. Each side has floor tile puzzles and groups of trash to kill.");
                    AliasLines.Add(";bhi2", "/p ;pink During floor tile puzzles, small scarecrows must die at the same time to allow puzzle completion. Refrain from killing them alone, allow them to group up for a clean group kill.");
                    AliasLines.Add(";bhs", "/p ;red At the last two floor tile puzzles there will be a set of one, then two, red name scarecrows. One person should tank them, everyone else must leave them alone. Unless assigned, do NOT touch the red name scarecrows.");
                    AliasLines.Add(";bhe", "/p ;lpurple After the second time through the hut, you are dropped back in the clearing. Kill three sets of wisps and scarecrows then attack Baba. Raid leader will announce whether to focus Shambling Mounds or to rush Baba based on dps.");

                    // Lord of Blades

                    // Master Artificer

                    // The Codex and the Shroud


                    break;
                case "SaturdayPM":
                    // Too Hot to Handle
                    AliasLines.Add(";thf", "/p ;pink To flag for THTH you must complete all of the Masterminds of Sharn 1 and 2 quest chains. After doing so come to the Raid Staging Area and pick it up from Grem Alcorin.");
                    AliasLines.Add(";thw", "/p ;red The main mechanic of THTH is the Forgewraiths. There are three types: Spirits, Enraged, and Giants. Whenever they die, all nearby wraiths upgrade and fully heal. Let the sunbursters handle it.");
                    AliasLines.Add(";thc", "/p ;lblue The coolant tanks need to be solved after phase 1. If the left lever is pointed at the machine pull it, followed by the right and then center. Only pull levers pointed at the coolers.");
                    AliasLines.Add(";thp1", "/p ;gold The puzzles need to be solved at the beginning of phase 1, if they aren't solved quickly enough a stacking fire DoT will affect the raid. The center console after we enter the foundry has the solutions.");
                    AliasLines.Add(";thp2", "/p ;gold If you are assigned a puzzle, write the solution in chat (1 - RRYYBB) to avoid confusion. After the solution is input, pull the far right lever to check it. If the top light stays green for more than 5 seconds, you're good.");
                    AliasLines.Add(";tht", "/p ;grey At the beginning of phase 2, a trapper will go to each puzzle, disable the trap box, and pull the far right lever to confirm it. Do not disable the trap boxes before the top light is red.");
                    AliasLines.Add(";thb", "/p ;orange At the end of each phase a Forgewraith titan will emerge from the lava. The tank stands on one side, everyone else stands in melee range on the other side. Forge Skulls will occasionally spawn, and ranged dps/sunbursts will need to kill them.");
                    AliasLines.Add(";thp", "/p ;lpurple This raid has 3 main phases, each capped by the titan. The first phase is just puzzling, the second is trapping and coolant tanks, and the third is a Giant spawning near where the boss left.");
                    AliasLines.Add(";thm", "/p ;green The non-wraith trash mobs in this raid will attempt to throw themselves into lava, spawning Enraged Forgewraiths. We want to prevent that. Don't use Turn to Frog, as the frogs (and yourself) can jump in lava and spawn Wraiths.");

                    // Project Nemesis
                    AliasLines.Add(";pnf", "/p ;pink PN has no flagging, just get to the Raid Staging Area and talk to Zaira Dane. Enter the cogs, exit the center area going Northeast, and then travel South ASAP.");
                    AliasLines.Add(";pn1", "/p ;grey Project Nemesis is a coordination/puzzle raid. Basically, there's four minibosses, and we have to execute them with a laser to suck their soul out. Drop them to low HP, then wait for everything to be ready before we kill them.");
                    AliasLines.Add(";pn2", "/p ;grey After each miniboss is killed, their soul is dropped off and three of us will get a colored circle around your feet.");
                    AliasLines.Add(";pne", "/p ;lgreen If you get a colored circle at your feet after laser, walk into the corresponding circle at the edge of the room. You'll then fight an elemental miniboss. Avoid circles on the ground.");
                    AliasLines.Add(";png", "/p ;gold Gish is the gnoll minoboss. He periodically has a spin attack, but his real threat is that his attacks have a stacking debuff that reduces PRR and AC by -10 per stack (up to 20 stacks).");
                    AliasLines.Add(";pni", "/p ;lblue Irk is the goblin miniboss, on a flying platform. He sometimes drops mines, but his special attack is a homing crossbow bolt. If you get targeted, hide behind a pillar.");
                    AliasLines.Add(";pnr", "/p ;lpurple Rudus is the minotaur miniboss. He periodically jumps into the air, and smashed down with massive AoE damage. If you jump when he jumps you take no damage, otherwise stay far away.");
                    AliasLines.Add(";pnz", "/p ;pink Zulkis is the tiefling miniboss. He has some strong spell attacks, but his critical mechanic is that he'll dimension door away if you melee him. Don't melee him.");
                    AliasLines.Add(";pnp", "/p ;blue The puzzles in PN power the laser beam, but if the central circles are lit the raid will eventually fail. Make sure the central circles are unpowered.");
                    AliasLines.Add(";pnt", "/p ;blue If Zulkis is left for last and the two puzzles behind the laser are solved you can safely deactivate all the other puzzles.");
                    AliasLines.Add(";pnc", "/p ;red On E+ difficulties there's a periodic curse that strikes the whole party. Remove Curse within 5s or die.");

                    break;
                case "Sunday":
                    // Dryad and the Demigod
                    AliasLines.Add(";ddf", "/p ;pink Dryad and the Demigod has no flagging, questgiver is Hermia in the Southwest corner of Wynwood Hall.");
                    AliasLines.Add(";dd1", "/p ;grey Dryad is a miniquest raid, the main party goes to each corner fighting some mobs and doing a puzzle before returning to the center for a fight.");
                    AliasLines.Add(";ddu", "/p ;lgreen Three unicorns respawn and teleport around the center area. If one is following you bring it to the tank in the center.");
                    AliasLines.Add(";ddt", "/p ;gold To easily tank this raid grab unicorn aggro and kite around the edge of the central grassy area. Avoid circles dropped by unicorns.");
                    AliasLines.Add(";ddi", "/p ;gold One instakiller or burst dps ranged character will hang out in the center killing non-unicorns. Avoid dying and join the party for the bear phase.");
                    AliasLines.Add(";ddg", "/p ;lpurple At each corner of the raid there will be a guardian, sometimes they can be bluffed to skip them otherwise they have to be killed.");
                    AliasLines.Add(";dde", "/p ;lpurple If you see the guardian winding up for a powerful attack, jump to avoid the earthgrab effect.");
                    AliasLines.Add(";ddp", "/p ;darkgrey Puzzles get messed up if anything steps on them so try not to. 23412 and 43214 starting from the left (facing floating stones) will solve them. Green button up top is a reset.");
                    AliasLines.Add(";ddfb", "/p ;lblue The first fight is a swarm of fire beetles attempting to flee the portal. Try to cc and kill all of them, but there's a little leeway if a few escape.");
                    AliasLines.Add(";ddc", "/p ;blue The next miniboss has a super fun animation, it's worth standing in front of them if you haven't seen it before.");
                    AliasLines.Add(";ddb", "/p ;pink The next miniboss has a special attack that does more damage the further away you are. Crowd in and watch your HP.");
                    AliasLines.Add(";ddd", "/p ;red If a phase goes on too long in Dryad, a dance geas will hit the whole party. Follow the arrows above your head or take increasing damage.");
                    AliasLines.Add(";ddfk", "/p ;lgreen The final boss has a conical gaze attack, let the tank turn him away from the party before attacking.");
                    AliasLines.Add(";ddub", "/p ;orange During the boss fight a respawning unicorn wanders around and tries to shank squishy characters. Watch out for circles it drops.");

                    // Hunt or be Hunted

                    // Skeletons in the Closet


                    break;
                case "MyDefaultFile":
                    // TODO: Get Aliases from provided file and add them back as AliasLines
                    //string defaultFileLoc = form.DefaultFileLoc;

                    break;
            }

            return AliasLines;
        }

        private void AliasColors()
        {
            AliasLines.Add(";babyblue", "&lt;rgb=#66CCFF>");
            // &amp;lt;rgb=#66CCFF&gt;
            AliasLines.Add(";black", "&lt;rgb=#000000>");
            AliasLines.Add(";blue", "&lt;rgb=#0000FF>");
            AliasLines.Add(";darkgrey", "&lt;rgb=#666666>");
            AliasLines.Add(";gold", "&lt;rgb=#FFD700>");
            AliasLines.Add(";green", "&lt;rgb=#00FF00>");
            AliasLines.Add(";grey", "&lt;rgb=#999999>");
            AliasLines.Add(";lblue", "&lt;rgb=#66CCFF>");
            AliasLines.Add(";lgreen", "&lt;rgb=#99FF99>");
            AliasLines.Add(";pink", "&lt;rgb=#FF99CC>");
            AliasLines.Add(";purple", "&lt;rgb=#800080>");
            AliasLines.Add(";red", "&lt;rgb=#FF0000>");
            AliasLines.Add(";sgreen", "&lt;rgb=#339999>");
            AliasLines.Add(";white", "&lt;rgb=#FFFFFF>");
            AliasLines.Add(";yellow", "&lt;rgb=#FFFF00>");
        }
        #endregion
    }
}
