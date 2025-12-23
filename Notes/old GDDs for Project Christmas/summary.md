## High-level game idea

**Working name:** Thrive (placeholder)

**Core fantasy:**
You’re a lone hacker in a corporately owned virtual web. From your home rig you:

* jack into remote systems
* steal / manipulate data
* do missions for corps or underground factions
* research new tech
* eventually get entangled in a bigger threat: **Cipher Vortex**, a rogue/invading AI presence in the web.

**Perspective & feel:**

* 2.5D / top-down action game
* **Not** a shooter – no twin-stick gunplay
* Real-time “action roguelite” with runs into systems and a persistent home base

---

## Structure & progression

You’ve moved away from “full MMO-style multiplayer” and are now aiming for:

* **Single-player core** as the primary design target
* With the option to later add **asynchronous / indirect multiplayer** (other players’ actions subtly affecting your world, ghost data, global meters, etc.)

Progression is conceptually:

1. **Learn the game**

   * Safer, simpler systems
   * Basic missions that teach movement, abilities, and hacking verbs
2. **Corps vs Underground**

   * Real missions for factions
   * Reputation system (corps vs underground)
   * Better gear, more complex systems
3. **Cipher Vortex invasion (late game)**

   * Anomalies, corrupted systems, special high-risk missions
   * The “meta threat” of the setting

For now this is all **single-player**, with the “your actions affect other worlds” idea explicitly parked as a **future expansion**, not something you need to solve now.

---

## Core loop & vertical slice shape

Basic loop you’ve accepted as the direction:

1. **Home base (your rig / apartment / workstation)**

   * 2.5D scene where you access terminals/UI
   * Do **research and crafting** here
   * Build / compile your **loadout of programs** within RAM/CPU limits
   * Pick missions (corps vs underground)

2. **Run into a system**

   * Enter a hostile system represented as some kind of networked space (nodes, enemies, obstacles)
   * Real-time action combat using your compiled programs
   * **Alertness / trace / heat** rises as you act
   * You grab bits/data/resources and try to extract before things get too dangerous

3. **Back home**

   * Cash in rewards
   * Advance **research** (unlock new programs, modifiers, rig upgrades)
   * Craft better future loadouts
   * Move deeper into the story/faction conflict

**Key roguelite rule:**
If you fail a run, you **lose the current build** (temporary in-run stuff + run-specific configuration), but **keep long-term progression** (research, rig improvements, unlocked programs).

---

## Combat & abilities – decisions so far

You’ve made a few important calls:

* You **do not** want:

  * gun-centric shooter combat (Ruiner / Neon Chrome style)
  * “intelligent bot” / swarm-based combat where AI does most of the work
  * building your entire kit only during the run (no “pure livecoding” concept)

* You **do** want:

  * **Action combat**, real-time
  * The player to be **actively responsible** (failure feels like *you* misplayed)
  * The **home base** to be where most complexity lives: research + crafting → build a **loadout of programs**
  * **In-run adjustments** as a spice:

    * small patches, overclocks, temporary modifiers
    * but not a full ability designer mid-run

* Structurally you like:

  * A “**compiled loadout**” concept:

    * Before a run, choose a small set of abilities (“programs”) within a rig budget (RAM/CPU).
    * In-run, find minor modifications or temporary boosts.
    * Death wipes that session’s build, but blueprints and rig upgrades persist.

You haven’t locked in a **specific combat verb set** yet (e.g. tethers, circuit drawing, interrupt timing), but you’ve narrowed constraints:

* Real-time top-down
* Not guns
* Programs feel like **hacks** (tethers, overloads, interrupts, signal manipulation, etc.) rather than bullets or generic magic
* Room for:

  * primary “attack” program,
  * 1–3 active abilities (mapped to keys),
  * a movement/defensive ability (dash/phase/teleport),
  * all defined by the compiled loadout.

---

## Systems & resources

You’ve implicitly set up these building blocks:

* **Programs**

  * Active abilities you equip in your loadout
  * Cost RAM/CPU
  * Can be modified by research and in-run patches

* **Research**

  * Long-term progression at home base
  * Unlocks:

    * new programs
    * new modifiers / patches
    * rig upgrades (more RAM, CPU, program slots, etc.)

* **Resources**

  * **Bits** – generic currency (upgrades, rerolls, mid-run services)
  * **Research Data** – feeds tech/research (often tied to specific corps/factions)
  * **Special keys/fragments** – gates to rare patches, elite systems, or Cipher-related stuff
  * **Alertness / Trace / Heat** – runs get more dangerous as this rises

---

## Multiplayers & “other worlds”

Current stance:

* You **are not** building realtime multiplayer now.
* You like the idea that **in the future**:

  * your runs could leave “scars” or data that show up in other players’ worlds,
  * global meters (corp influence, Vortex agitation) might aggregate everyone’s actions.

But for now, this is treated as:

* **Future expansion:**
  “Phase 2 – The Web Remembers”
* **Not** something that needs data models or networking decisions while you’re still prototyping core gameplay.