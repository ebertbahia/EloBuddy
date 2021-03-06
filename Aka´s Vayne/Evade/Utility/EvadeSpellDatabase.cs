﻿﻿// Copyright 2014 - 2015 Esk0r
// EvadeSpellDatabase.cs is part of Evade.
// 
// Evade is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// Evade is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with Evade. If not, see <http://www.gnu.org/licenses/>.

using System.Collections.Generic;
using System.Linq;
using EloBuddy;
using EloBuddy.SDK;

namespace Aka_s_Vayne_reworked.Evade.Utility
{
    public class EvadeSpellDatabase
    {
        public static List<EvadeSpellData> Spells = new List<EvadeSpellData>();

        static EvadeSpellDatabase()
        {
            //Add available evading spells to the database. SORTED BY PRIORITY.
            EvadeSpellData spell;

            #region Champion SpellShields

            #region Sivir

            if (Variables._Player.ChampionName == "Sivir")
            {
                spell = new ShieldData("Sivir E", SpellSlot.E, 100, 1, true);
                Spells.Add(spell);
            }

            #endregion

            #region Nocturne

            if (Variables._Player.ChampionName == "Nocturne")
            {
                spell = new ShieldData("Nocturne E", SpellSlot.E, 100, 1, true);
                Spells.Add(spell);
            }

            #endregion

            #endregion

            //Walking.
            spell = new EvadeSpellData("Walking", 1);
            Spells.Add(spell);

            #region Champion MoveSpeed buffs

            #region Blitzcrank

            if (Variables._Player.ChampionName == "Blitzcrank")
            {
                spell = new MoveBuffData(
                    "Blitzcrank W", SpellSlot.W, 100, 3,
                    () =>
                        Variables._Player.MoveSpeed *
                        (1 + 0.12f + 0.04f * Variables._Player.Spellbook.GetSpell(SpellSlot.W).Level));
                Spells.Add(spell);
            }

            #endregion

            #region Draven

            if (Variables._Player.ChampionName == "Draven")
            {
                spell = new MoveBuffData(
                    "Draven W", SpellSlot.W, 100, 3,
                    () =>
                        Variables._Player.MoveSpeed *
                        (1 + 0.35f + 0.05f * Variables._Player.Spellbook.GetSpell(SpellSlot.W).Level));
                Spells.Add(spell);
            }

            #endregion

            #region Evelynn

            if (Variables._Player.ChampionName == "Evelynn")
            {
                spell = new MoveBuffData(
                    "Evelynn W", SpellSlot.W, 100, 3,
                    () =>
                        Variables._Player.MoveSpeed *
                        (1 + 0.2f + 0.1f * Variables._Player.Spellbook.GetSpell(SpellSlot.W).Level));
                Spells.Add(spell);
            }

            #endregion

            #region Garen

            if (Variables._Player.ChampionName == "Garen")
            {
                spell = new MoveBuffData("Garen Q", SpellSlot.Q, 100, 3, () => Variables._Player.MoveSpeed * (1.35f));
                Spells.Add(spell);
            }

            #endregion

            #region Katarina

            if (Variables._Player.ChampionName == "Katarina")
            {
                spell = new MoveBuffData(
                    "Katarina W", SpellSlot.W, 100, 3,
                    () =>
                        ObjectManager.Get<AIHeroClient>().Any(h => h.IsValidTarget(375))
                            ? Variables._Player.MoveSpeed *
                              (1 + 0.10f + 0.05f * Variables._Player.Spellbook.GetSpell(SpellSlot.W).Level)
                            : 0);
                Spells.Add(spell);
            }

            #endregion

            #region Karma 

            if (Variables._Player.ChampionName == "Karma")
            {
                spell = new MoveBuffData(
                    "Karma E", SpellSlot.E, 100, 3,
                    () =>
                        Variables._Player.MoveSpeed *
                        (1 + 0.35f + 0.05f * Variables._Player.Spellbook.GetSpell(SpellSlot.E).Level));
                Spells.Add(spell);
            }

            #endregion

            #region Kennen

            if (Variables._Player.ChampionName == "Kennen")
            {
                spell = new MoveBuffData("Kennen E", SpellSlot.E, 100, 3, () => 200 + Variables._Player.MoveSpeed);
                //Actually it should be +335 but ingame you only gain +230, rito plz
                Spells.Add(spell);
            }

            #endregion

            #region Khazix

            if (Variables._Player.ChampionName == "Khazix")
            {
                spell = new MoveBuffData("Khazix R", SpellSlot.R, 100, 5, () => Variables._Player.MoveSpeed * 1.4f);
                Spells.Add(spell);
            }

            #endregion

            #region Lulu

            if (Variables._Player.ChampionName == "Lulu")
            {
                spell = new MoveBuffData(
                    "Lulu W", SpellSlot.W, 100, 5,
                    () => Variables._Player.MoveSpeed * (1.3f + Variables._Player.FlatMagicDamageMod / 100 * 0.1f));
                Spells.Add(spell);
            }

            #endregion

            #region Nunu

            if (Variables._Player.ChampionName == "Nunu")
            {
                spell = new MoveBuffData(
                    "Nunu W", SpellSlot.W, 100, 3,
                    () =>
                        Variables._Player.MoveSpeed *
                        (1 + 0.1f + 0.01f * Variables._Player.Spellbook.GetSpell(SpellSlot.W).Level));
                Spells.Add(spell);
            }

            #endregion

            #region Ryze

            if (Variables._Player.ChampionName == "Ryze")
            {
                spell = new MoveBuffData("Ryze R", SpellSlot.R, 100, 5, () => 80 + Variables._Player.MoveSpeed);
                Spells.Add(spell);
            }

            #endregion

            #region Shyvana

            if (Variables._Player.ChampionName == "Sivir")
            {
                spell = new MoveBuffData("Sivir R", SpellSlot.R, 100, 5, () => Variables._Player.MoveSpeed * (1.6f));
                Spells.Add(spell);
            }

            #endregion

            #region Shyvana

            if (Variables._Player.ChampionName == "Shyvana")
            {
                spell = new MoveBuffData(
                    "Shyvana W", SpellSlot.W, 100, 4,
                    () =>
                        Variables._Player.MoveSpeed *
                        (1 + 0.25f + 0.05f * Variables._Player.Spellbook.GetSpell(SpellSlot.W).Level))
                {
                    CheckSpellName = "ShyvanaImmolationAura"
                };
                Spells.Add(spell);
            }

            #endregion

            #region Sona

            if (Variables._Player.ChampionName == "Sona")
            {
                spell = new MoveBuffData(
                    "Sona E", SpellSlot.E, 100, 3,
                    () =>
                        Variables._Player.MoveSpeed *
                        (1 + 0.12f + 0.01f * Variables._Player.Spellbook.GetSpell(SpellSlot.E).Level +
                         Variables._Player.FlatMagicDamageMod / 100 * 0.075f +
                         0.02f * Variables._Player.Spellbook.GetSpell(SpellSlot.R).Level));
                Spells.Add(spell);
            }

            #endregion

            #region Teemo ^_^

            if (Variables._Player.ChampionName == "Teemo")
            {
                spell = new MoveBuffData(
                    "Teemo W", SpellSlot.W, 100, 3,
                    () =>
                        Variables._Player.MoveSpeed *
                        (1 + 0.06f + 0.04f * Variables._Player.Spellbook.GetSpell(SpellSlot.W).Level));
                Spells.Add(spell);
            }

            #endregion

            #region Udyr

            if (Variables._Player.ChampionName == "Udyr")
            {
                spell = new MoveBuffData(
                    "Udyr E", SpellSlot.E, 100, 3,
                    () =>
                        Variables._Player.MoveSpeed *
                        (1 + 0.1f + 0.05f * Variables._Player.Spellbook.GetSpell(SpellSlot.E).Level));
                Spells.Add(spell);
            }

            #endregion

            #region Zilean

            if (Variables._Player.ChampionName == "Zilean")
            {
                spell = new MoveBuffData("Zilean E", SpellSlot.E, 100, 3, () => Variables._Player.MoveSpeed * 1.55f);
                Spells.Add(spell);
            }

            #endregion

            #endregion

            #region Champion Dashes

            #region Aatrox

            if (Variables._Player.ChampionName == "Aatrox")
            {
                spell = new DashData("Aatrox Q", SpellSlot.Q, 650, false, 400, 3000, 3) { Invert = true };
                Spells.Add(spell);
            }

            #endregion

            #region Akali

            if (Variables._Player.ChampionName == "Akali")
            {
                spell = new DashData("Akali R", SpellSlot.R, 800, false, 100, 2461, 3)
                {
                    ValidTargets = new[] { SpellValidTargets.EnemyChampions, SpellValidTargets.EnemyMinions }
                };
                Spells.Add(spell);
            }

            #endregion

            #region Alistar

            if (Variables._Player.ChampionName == "Alistar")
            {
                spell = new DashData("Alistar W", SpellSlot.W, 650, false, 100, 1900, 3)
                {
                    ValidTargets = new[] { SpellValidTargets.EnemyChampions, SpellValidTargets.EnemyMinions }
                };
                Spells.Add(spell);
            }

            #endregion

            #region Caitlyn

            if (Variables._Player.ChampionName == "Caitlyn")
            {
                spell = new DashData("Caitlyn E", SpellSlot.E, 490, true, 250, 1000, 3) { Invert = true };
                Spells.Add(spell);
            }

            #endregion

            #region Corki

            if (Variables._Player.ChampionName == "Corki")
            {
                spell = new DashData("Corki W", SpellSlot.W, 790, false, 250, 1044, 3);
                Spells.Add(spell);
            }

            #endregion

            #region Fizz

            if (Variables._Player.ChampionName == "Fizz")
            {
                spell = new DashData("Fizz Q", SpellSlot.Q, 550, true, 100, 1400, 4)
                {
                    ValidTargets = new[] { SpellValidTargets.EnemyMinions, SpellValidTargets.EnemyChampions }
                };
                Spells.Add(spell);
            }

            #endregion

            #region Gragas

            if (Variables._Player.ChampionName == "Gragas")
            {
                spell = new DashData("Gragas E", SpellSlot.E, 600, true, 250, 911, 3);
                Spells.Add(spell);
            }

            #endregion

            #region Gnar

            if (Variables._Player.ChampionName == "Gnar")
            {
                spell = new DashData("Gnar E", SpellSlot.E, 50, false, 0, 900, 3) { CheckSpellName = "GnarE" };
                Spells.Add(spell);
            }

            #endregion

            #region Graves

            if (Variables._Player.ChampionName == "Graves")
            {
                spell = new DashData("Graves E", SpellSlot.E, 425, true, 100, 1223, 3);
                Spells.Add(spell);
            }

            #endregion

            #region Irelia

            if (Variables._Player.ChampionName == "Irelia")
            {
                spell = new DashData("Irelia Q", SpellSlot.Q, 650, false, 100, 2200, 3)
                {
                    ValidTargets = new[] { SpellValidTargets.EnemyChampions, SpellValidTargets.EnemyMinions }
                };
                Spells.Add(spell);
            }

            #endregion

            #region Jax

            if (Variables._Player.ChampionName == "Jax")
            {
                spell = new DashData("Jax Q", SpellSlot.Q, 700, false, 100, 1400, 3)
                {
                    ValidTargets =
                        new[]
                        {
                            SpellValidTargets.EnemyWards, SpellValidTargets.AllyWards, SpellValidTargets.AllyMinions,
                            SpellValidTargets.AllyChampions, SpellValidTargets.EnemyChampions,
                            SpellValidTargets.EnemyMinions
                        }
                };
                Spells.Add(spell);
            }

            #endregion

            #region LeBlanc

            if (Variables._Player.ChampionName == "LeBlanc")
            {
                spell = new DashData("LeBlanc W1", SpellSlot.W, 600, false, 100, 1621, 3)
                {
                    CheckSpellName = "LeblancSlide"
                };
                Spells.Add(spell);
            }

            if (Variables._Player.ChampionName == "LeBlanc")
            {
                spell = new DashData("LeBlanc RW", SpellSlot.R, 600, false, 100, 1621, 3)
                {
                    CheckSpellName = "LeblancSlideM"
                };
                Spells.Add(spell);
            }

            #endregion

            #region LeeSin

            if (Variables._Player.ChampionName == "LeeSin")
            {
                spell = new DashData("LeeSin W", SpellSlot.W, 700, false, 250, 2000, 3)
                {
                    ValidTargets =
                        new[]
                        { SpellValidTargets.AllyChampions, SpellValidTargets.AllyMinions, SpellValidTargets.AllyWards },
                    CheckSpellName = "BlindMonkWOne"
                };
                Spells.Add(spell);
            }

            #endregion

            #region Lucian

            if (Variables._Player.ChampionName == "Lucian")
            {
                spell = new DashData("Lucian E", SpellSlot.E, 425, false, 100, 1350, 2);
                Spells.Add(spell);
            }

            #endregion

            #region Nidalee

            if (Variables._Player.ChampionName == "Nidalee")
            {
                spell = new DashData("Nidalee W", SpellSlot.W, 375, true, 250, 943, 3) { CheckSpellName = "Pounce" };
                Spells.Add(spell);
            }

            #endregion

            #region Pantheon

            if (Variables._Player.ChampionName == "Pantheon")
            {
                spell = new DashData("Pantheon W", SpellSlot.W, 600, false, 100, 1000, 3)
                {
                    ValidTargets = new[] { SpellValidTargets.EnemyChampions, SpellValidTargets.EnemyMinions }
                };
                Spells.Add(spell);
            }

            #endregion

            #region Riven

            if (Variables._Player.ChampionName == "Riven")
            {
                spell = new DashData("Riven Q", SpellSlot.Q, 222, true, 250, 560, 3) { RequiresPreMove = true };
                Spells.Add(spell);

                spell = new DashData("Riven E", SpellSlot.E, 250, false, 250, 1200, 3);
                Spells.Add(spell);
            }

            #endregion

            #region Tristana

            if (Variables._Player.ChampionName == "Tristana")
            {
                spell = new DashData("Tristana W", SpellSlot.W, 900, true, 300, 800, 5);
                Spells.Add(spell);
            }

            #endregion

            #region Tryndamare

            if (Variables._Player.ChampionName == "Tryndamere")
            {
                spell = new DashData("Tryndamere E", SpellSlot.E, 650, true, 250, 900, 3);
                Spells.Add(spell);
            }

            #endregion

            #region Vayne

            if (Variables._Player.ChampionName == "Vayne")
            {
                spell = new DashData("Vayne Q", SpellSlot.Q, 300, true, 100, 910, 2);
                Spells.Add(spell);
            }

            #endregion

            #region Wukong

            if (Variables._Player.ChampionName == "MonkeyKing")
            {
                spell = new DashData("Wukong E", SpellSlot.E, 650, false, 100, 1400, 3)
                {
                    ValidTargets = new[] { SpellValidTargets.EnemyChampions, SpellValidTargets.EnemyMinions }
                };
                Spells.Add(spell);
            }

            #endregion

            #endregion

            #region Champion Blinks

            #region Ezreal

            if (Variables._Player.ChampionName == "Ezreal")
            {
                spell = new BlinkData("Ezreal E", SpellSlot.E, 450, 350, 3);
                Spells.Add(spell);
            }

            #endregion

            #region Kassadin

            if (Variables._Player.ChampionName == "Kassadin")
            {
                spell = new BlinkData("Kassadin R", SpellSlot.R, 700, 200, 5);
                Spells.Add(spell);
            }

            #endregion

            #region Katarina

            if (Variables._Player.ChampionName == "Katarina")
            {
                spell = new BlinkData("Katarina E", SpellSlot.E, 700, 200, 3)
                {
                    ValidTargets =
                        new[]
                        {
                            SpellValidTargets.AllyChampions, SpellValidTargets.AllyMinions, SpellValidTargets.AllyWards,
                            SpellValidTargets.EnemyChampions, SpellValidTargets.EnemyMinions,
                            SpellValidTargets.EnemyWards
                        }
                };
                Spells.Add(spell);
            }

            #endregion

            #region Shaco

            if (Variables._Player.ChampionName == "Shaco")
            {
                spell = new BlinkData("Shaco Q", SpellSlot.Q, 400, 350, 3);
                Spells.Add(spell);
            }

            #endregion

            #region Talon

            if (Variables._Player.ChampionName == "Talon")
            {
                spell = new BlinkData("Talon E", SpellSlot.E, 700, 100, 3)
                {
                    ValidTargets = new[] { SpellValidTargets.EnemyChampions, SpellValidTargets.EnemyMinions }
                };
                Spells.Add(spell);
            }

            #endregion

            #endregion

            #region Champion Invulnerabilities

            #region Elise

            if (Variables._Player.ChampionName == "Elise")
            {
                spell = new InvulnerabilityData("Elise E", SpellSlot.E, 250, 3)
                {
                    CheckSpellName = "EliseSpiderEInitial",
                    SelfCast = true
                };
                Spells.Add(spell);
            }

            #endregion

            #region Vladimir

            if (Variables._Player.ChampionName == "Vladimir")
            {
                spell = new InvulnerabilityData("Vladimir W", SpellSlot.W, 250, 3) { SelfCast = true };
                Spells.Add(spell);
            }

            #endregion

            #region Fizz

            if (Variables._Player.ChampionName == "Fizz")
            {
                spell = new InvulnerabilityData("Fizz E", SpellSlot.E, 250, 3);
                Spells.Add(spell);
            }

            #endregion

            #region MasterYi

            if (Variables._Player.ChampionName == "MasterYi")
            {
                spell = new InvulnerabilityData("MasterYi Q", SpellSlot.Q, 250, 3)
                {
                    MaxRange = 600,
                    ValidTargets = new[] { SpellValidTargets.EnemyChampions, SpellValidTargets.EnemyMinions }
                };
                Spells.Add(spell);
            }

            #endregion

            #endregion

            //Flash
            if (Variables._Player.GetSpellSlotFromName("SummonerFlash") != SpellSlot.Unknown)
            {
                spell = new BlinkData("Flash", Variables._Player.GetSpellSlotFromName("SummonerFlash"), 400, 100, 5, true);
                Spells.Add(spell);
            }

            //Zhonyas
            spell = new EvadeSpellData("Zhonyas", 5);
            Spells.Add(spell);

            #region Champion Shields

            #region Karma

            if (Variables._Player.ChampionName == "Karma")
            {
                spell = new ShieldData("Karma E", SpellSlot.E, 100, 2) { CanShieldAllies = true, MaxRange = 800 };
                Spells.Add(spell);
            }

            #endregion

            #region Janna

            if (Variables._Player.ChampionName == "Janna")
            {
                spell = new ShieldData("Janna E", SpellSlot.E, 100, 1) { CanShieldAllies = true, MaxRange = 800 };
                Spells.Add(spell);
            }

            #endregion

            #region Morgana

            if (Variables._Player.ChampionName == "Morgana")
            {
                spell = new ShieldData("Morgana E", SpellSlot.E, 100, 3) { CanShieldAllies = true, MaxRange = 750 };
                Spells.Add(spell);
            }

            #endregion

            #endregion
        }

        public static EvadeSpellData GetByName(string name)
        {
            name = name.ToLower();
            return Spells.FirstOrDefault(evadeSpellData => evadeSpellData.Name.ToLower() == name);
        }
    }
}