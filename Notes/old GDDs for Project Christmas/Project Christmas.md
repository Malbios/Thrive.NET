# GDD for Thrive

## 1) Game Overview

**Pitch:** *Thrive* is a fast-paced, top-down action roguelite set within a hostile digital network. From your persistent Home System hub, you compile unique **Programs** using a deep **Kernel System** where tools are built from code components. You then launch into procedural systems, where combat relies on **Cast & Recall**—physically hurling your hand-crafted Programs as projectiles to materialize units that fight for you. You must constantly juggle **Deploy** and **Recall** commands, as every Program deployed is a valuable asset you risk losing permanently if the network's escalating **TRACE** pressure forces a disastrous wipe. Succeed and use stolen data to research new Logic Kernels, unlocking the ability to compile more powerful tools for the next infiltration.

**Tagline**: Build the code. Breach the system. **Cast, fight, and Recall**, or lose the programs you brought.

**One-Line Pitch**: A top-down action roguelite where you inject hand-crafted **Programs** as physical projectiles to breach hostile digital systems, racing to manage the escalating **TRACE** and extract valuable code before your custom tools are deleted forever.

---

This is an excellent step. Design Pillars must reflect the game you are actually building. We need to retire the old "First-Person" focus and highlight the new **Cast & Recall** combat and **Kernel System** progression.

Here are the revised Design Pillars for *Thrive*, built around your core desires of high-stakes action and deep engineering:

## 2) Revised Design Pillars

| Design Pillar | Description | Success Test |
| :--- | :--- | :--- |
| **Kinaesthetic Command** | Player success relies on manual aiming, movement, and precise timing of the **Cast & Recall** cycle, not passive unit management. The control loop must feel like a skill-based action game. | The moment-to-moment combat rhythm is defined by the constant manual **Throw $\rightarrow$ Damage $\rightarrow$ Recall** cycle, forcing the player to actively manage the position of their **Programs** on the battlefield. |
| **Recursive Engineering** | Progression is driven by a component hierarchy: Players compile **Logic Kernels** (Tools) to use as ingredients for more complex **Programs**. Losing a Program is painful, but the acquired knowledge (Kernels/Blueprints) persists between runs. | No advanced Program (e.g., **Needle**) can be assembled without first acquiring and compiling a specific lower-tier **Kernel** or consuming a simpler Program (e.g., **Crawler**). |
| **Time is Currency** | Every choice—movement, hacking, and combat—must contribute to the escalating **TRACE** pressure, forcing the player to constantly weigh the reward of pushing deeper against guaranteed extraction. | The player can point to at least three simultaneous pressures (**TRACE** meter, **Alert** gain, and **Program Integrity** loss) that force the critical **Extract** decision. |
| **Diegetic Purity** | All game information, systems, and UI must be presented as in-world digital architecture or visual language, respecting the aesthetic of the living network. | Primary indicators (Program integrity, **TRACE** meter, **Alert** level) are communicated using in-world visual effects, projections, or simplified geometric UI, not abstract menus or traditional health bars. |

---

## 3) Core Loop

1.  **Engineer** - At the Home System hub, use discovered **Data** and **Source Code** to compile new **Logic Kernels** (Tools). Then, use these Kernels as ingredients to assemble your **Programs** (abilities) within the **Complexity** cap.
2.  **Route** - Scan the network map to reveal enemy types, defense distribution, and high-value nodes, charting an optimal path for the infiltration.
3.  **Breach** - Enter a node in a top-down 2.5D view. Combat begins immediately, requiring the player to use **Cast & Recall** mechanics to manage threats and Program position.
4.  **Commit & Fight** - Actively manage the battlefield by hurling **Programs** (LMB/RMB/Space) to deal damage while simultaneously starting objectives: **Hack** (open paths), **Download** (loot data), or **Recon** (reveal intel) and managing escalating **Alert/Trace** pressure.
5.  **Extract** - At any exit node, decide to **Push Deeper** and risk greater **TRACE** or **Initiate Extraction** to bank progress. If the risk is too high, attempt an **Emergency Extract** to save damaged Programs and partial resources before the run ends in a **Total Wipe**.
6.  **Research** - Convert stolen data into new **Logic Kernels** and **Blueprints** to unlock the ability to compile more powerful Programs for the next infiltration.

---

## 4) Systems

### 4.1 Programs (Your Digital Combat Units)

**Structure:** `Chassis` (role + stats/AI) · `Behaviors` (autonomous actions) · `Augments` (modifiers)

#### Prototype Chassis (4)

* **Crawler (Skirmisher):** Fast, mobile damage. Circles targets at medium range, exploits openings. 
* **Bastion (Tank):** Defensive anchor. Gains 40 Shield every 6s, draws fire, reflects damage as pulses. 
* **Needle (Assassin):** Precision eliminator. +25% damage to isolated targets, seeks vulnerable enemies. 
* **Array (Support):** Force multiplier. 10m buff aura, spawns Microdrones on kills, heals nearby allies. 

#### Core Behaviors (Autonomous)

Programs act independently based on chassis and your marking:

* **Unmarked combat:** Engage nearest threats with basic tactics.
* **Marked target:** Prioritize your designated target.
* **Defensive mode:** Stay close while you hack.
* **Breach mode:** Focus fire on barriers/Firewalls. 

#### Behaviors (Automated, context-triggered)

Choose **2–3** per Program:

* **Pierce Burst** (cone, +50% vs Structures) · **Latch** (melee DoT + self-heal) · **Shield Wall** (forward barrier) · **Repair Pulse** (AoE heal, 8s) · **Backstab** (teleport behind isolated) · **Suppression** (cone ROF debuff) · **Mark Vulnerability** (team damage amp) · **EMP Burst** (AOE shield disable). 

#### Augments (Modifiers)

Equip **up to 3** per Program. Two kinds:

**A) Chassis Augments** (program-wide)

* **Lean Build** (−Integrity, +action speed)
* **Hardening** (+Shield, −move speed)
* **Silent Runner** (−Alert gain, −damage)
* **Overprovisioned** (+1 Augment slot, **+10 Complexity**)
* **Glass Cannon** (+damage, −shield effectiveness)
* **Failsafe** (on death: knockback + ally debuff cleanse). 

**B) Behavior Augments** (socket into one chosen Behavior)
> A single Behavior can hold **at most one** Behavior Augment.

* **Packet Splitter** (attacks chain to a 2nd target at 30% dmg)
* **Entropy Core** (+25% dmg; integrity drains while idle)
* **Mirror Cache** (first hit per node converts to Shield instead)
* **Compactor** (+30% AoE radius, −15% single-target dmg)
* **Auto-Patcher** (regenerates lowest ally at 8 HP/s)
* **Ghost Protocol** (2s stealth on node entry, +60% dmg on break). 

#### Slotting & Complexity

* **Per Program:** **2–3 Behaviors** + **up to 3 Augments**.
* **Complexity cap:** **20** per Program (unchanged). Chassis remain **6–8**. Behaviors cost **4** each. Augments cost **3** each. **Overprovisioned** adds **+1 Augment slot** and **+10 Complexity**.

---

### 4.2 First-Person Combat & Objectives

**Your Role During Infiltration**

You're physically present in each node, managing multiple tasks simultaneously:

* **Target Marking:** Look at an IC and mark it (right-click) for focused fire
* **Program Deployment:** Release Programs from your inventory into combat
* **Objective Completion:** Hack terminals, download data, disable security
* **Survival:** Avoid IC attacks targeting you directly (you have shields but no weapons)
* **Resource Management:** Decide when to deploy Programs vs saving them

**Combat Flow Example**

*You breach into a Databank node. The space materializes—server pillars, data streams, two terminals. A Firewall blocks the main data core. Two Sentries activate.*

*You deploy your Bastion and Crawler (Q and E keys). They materialize as geometric constructs and immediately engage the Sentries. Laser fire erupts. You sprint to a side terminal while combat rages, starting a 15-second download (hold F).*

*At 70% download, Alert threshold triggers—a Hunter IC warps in. You mark it (right-click) and deploy your Needle (R key) to eliminate it quickly. Download completes. You grab the data package and mark the Firewall. Your three Programs converge on it.*

*20 seconds later, the Firewall breaks. The path to the core opens. Your Crawler is at 40% integrity. Do you push deeper or extract?*

**Objective Types**

* **Data Downloads:** Hold interaction key for 10-30s while defended
* **Terminal Hacks:** Complete pattern-matching minigame (5-10s) under fire
* **Firewall Breach:** Programs must damage it for 20-45s while you survive
* **Resource Extraction:** Channel for 5s at specific points, can be interrupted
* **Security Disables:** Sequential terminals that must be activated in order
* **Intelligence Scans:** Reveal system map, requires 30s at central terminal

**Player Abilities (Limited, Upgradeable)**

* **Emergency Shield:** 3s of invulnerability (60s cooldown)
* **Overclock Program:** Target Program gets +50% speed for 5s
* **EMP Pulse:** Disables all shields in radius (once per node)
* **Mark Priority:** Next mark lasts 10s and adds +25% team damage
* **Tactical Recall:** Instantly return one Program to inventory

---

### 4.3 System Defense Architecture

**Finite Resource Pool**

Each system has limited ICs distributed across nodes:
* **Tier 1 System:** 15-20 total ICs
* **Tier 2 System:** 25-35 total ICs  
* **Tier 3 System:** 40-60 total ICs

**Dynamic Redistribution**

As Alert rises, the system redistributes its defenses:
* **0-30 Alert:** ICs remain at assigned posts
* **31-60 Alert:** Adjacent node ICs begin relocating
* **61-85 Alert:** System-wide convergence on your position
* **86-100 Alert:** Overclock mode—all ICs get +25% speed/damage
* **100+ Alert:** External reinforcements begin arriving

**IC Types (Prototype Set)**

* **Sentry:** Basic attacker, rushes position, moderate HP/damage
* **Daemon:** Controller, creates lockdown fields, disables Programs briefly
* **Firewall:** Structure, blocks paths, provides shield aura to other ICs
* **Hunter:** Assassin, targets player directly, phase-shifts to avoid damage
* **Warden:** Elite, appears at high Alert, multiple attacks + summons
* **Scanner:** Reveals your position to all ICs, raises Alert faster

**Node Security Levels**

* **Unsecured:** 0-1 ICs, basic loot, quick in/out
* **Standard:** 2-3 ICs, normal resources, 1-2 objectives
* **Fortified:** 4-5 ICs + Firewall, good loot, multiple paths
* **Critical:** 6+ ICs, system core/high-value target, complex layout

---

### 4.4 Alert & Trace (Pressure Systems)

**Alert (Node-Level Escalation)**
Builds during infiltration, redistributes system resources:

* **Gain Sources:**
  * +0.2/s while in combat
  * +1.0 when IC spots you
  * +2.0 when IC is destroyed (they send termination signal)
  * +5.0 when triggering security alarms
  * +0.5/s while hacking objectives

* **Thresholds:**
  * **30:** Adjacent node ICs start relocating
  * **50:** Hunter IC spawns at your node
  * **70:** All ICs get +15% speed, Daemons appear
  * **85:** Warden spawns, ICs overclock
  * **100:** Continuous reinforcements from external systems

* **Reduction:** -0.3/s when hidden/no combat (minimum 5s)

**Trace (Run-Level Consequence)**
Permanent escalation for this infiltration:

* **Gain Sources:**
  * +10 on Databank core access
  * +15 on System Map discovery
  * +5 per minute in system
  * +20 on Core Node breach attempt

* **Effects at 100:** 
  * Exit nodes lock after 60s warning
  * External Hunter squads arrive
  * System goes into permanent lockdown
  * Must extract immediately or lose everything

---

### 4.5 Exploration Between Combat

**Node Traversal**

Moving between nodes happens in abstract network space:
* First-person navigation through data highways
* Can see node types, security levels (with scanning)
* Patrols move along links—avoid or engage
* Time passes continuously—Trace builds even while traveling

**Safe Zones (Temporary)**

After clearing a node's ICs:
* 60-90 seconds before reinforcements arrive
* Can explore, loot secondary objectives
* Set up forward position for next assault
* Repair Programs if you have Auto-Patcher module

**System Mapping**

Early infiltrations are blind—you only see adjacent nodes. Finding System Maps reveals:
* Full node layout and connections
* Security distribution (if upgraded scanner)
* High-value targets marked
* Optimal extraction routes

**Resource Discovery**

Not all resources are obvious:
* Primary objectives marked clearly
* Hidden caches require exploration
* Corrupted data needs decryption time
* Some resources only accessible after specific security disables

---

## 5) Progression & Economy

**Research Trees**

* **Program Parts:** New Chassis, Abilities, Modules, Enhancements
* **Player Abilities:** Emergency powers, enhanced marking, better shields
* **System Knowledge:** Scanning upgrades, IC weaknesses, node layouts
* **Home System:** Expand your safe space, add facilities, increase storage

**Resource Types**

* **Data (Common):** Basic currency for standard upgrades
* **Source Code (Uncommon):** Needed for Program modifications
* **Encryption Keys (Rare):** Required for advanced abilities
* **System Seeds (Epic):** Allows home system expansion

**Loss Mechanics**

* **Successful Extract:** Keep everything gathered + Programs survive
* **Emergency Extract:** Keep 50% of resources, Programs damaged
* **Wipe:** Lose all volatile resources, Programs destroyed (unless Backup Token)

---

## 6) Encounter Examples

### Example 1: Early Game Databank Raid

*You've scouted a Tier 1 system, identified an isolated Databank with 2 Sentries. You have a Bastion and Crawler, both with basic modules.*

You breach in. The room is small—one main terminal, one Firewall blocking a bonus cache. Sentries activate immediately. You deploy both Programs and rush to the terminal while they engage. 

The download takes 20 seconds. At 10 seconds, your Crawler drops to 50% integrity. You mark one Sentry for focused fire. At 15 seconds, Alert hits 30—you hear an IC warping in from an adjacent node. Download completes just as a Hunter materializes. 

You have 15 Data, but that bonus cache could have Source Code. Your Programs are damaged. The Hunter is closing on your position. Extract or risk it?

### Example 2: Mid-Game Multi-Node Chain

*Tier 2 system. You need components from a Research node, but it's heavily defended. You've identified a connected Security node that could be disabled first.*

Security node: 3 Sentries, 1 Daemon. You deploy all four Programs (added Needle and Array since early game). While they fight, you hack three terminals in sequence—each takes 8 seconds and must be done in order. 

Your Array's healing keeps the team up. After 40 seconds of combat, security is disabled. Alert at 55. You push immediately to the Research node.

Research node: Only 2 Sentries now (would have been 5). But Alert 55 means a Hunter spawns immediately. You mark it while starting a complex 30-second extraction. Your Programs are at 60% integrity average. 

At 20 seconds, a Warden warps in (Alert 70). You pop Emergency Shield and Overclock your Needle to burst it down. Extraction completes with Programs at critical health. Time to run.

### Example 3: Late Game Core Assault

*Tier 3 system core. You've spent 10 minutes disabling substations. Alert 80, Trace 60. This is it.*

The core room is massive. A Warden, 2 Daemons, 4 Sentries, multiple Firewalls. You deploy all six Programs (full late-game squad). Chaos erupts.

You sprint between three hack points while the battle rages. Each hack takes 15 seconds and reduces the core's shields. Your Bastion falls. You use Tactical Recall to save your Array from a Hunter pack.

Second hack done. Alert 95. Reinforcements streaming in. You Overclock your Needle and Crawler for a damage burst on the exposed core. Your fingers fly through the final hacking minigame as your last two Programs fall.

Core breached. System conquered. You extract with 5% shield remaining.

---

## 7) Technical Scope & Tuning

**Performance Targets**
* 4-8 ICs active simultaneously
* 3-6 Programs in combat
* Node spaces: ~500-1500 square meters
* Combat duration: 30s-3min per node
* Full run time: 5-20 minutes depending on depth

**Initial Balance**
* Player shields: 100 (no health, shields regenerate out of combat)
* Program integrity: 80-200 depending on chassis
* IC damage: 5-15 per hit
* Download times: 10-30 seconds
* Hack minigames: 5-10 seconds
* Alert gain: tuned so reaching 100 takes ~10 minutes of aggressive play

**Difficulty Scaling**
* Early game: 2-3 Programs vs 2-3 ICs
* Mid game: 4 Programs vs 4-6 ICs with objectives under fire
* Late game: 6 Programs vs 8+ ICs with complex multi-stage objectives
* System tiers determine IC health/damage multipliers, not just quantity

---

## 8) UI/UX in First Person

**HUD Elements**
* **Center:** Minimal crosshair, interaction prompts
* **Top Left:** Program status bars (integrity/shields/abilities)
* **Top Right:** Alert meter, Trace meter
* **Bottom:** Deployed Programs (Q/E/R keys), Player abilities (1-3 keys)
* **Objective:** Current objective + timer when actively hacking
* **Combat:** Damage indicators, IC health bars when marked

**Visual Language**
* Programs: Geometric constructs with faction-colored energy
* ICs: Industrial/militaristic designs, red/orange threat colors
* Objectives: Blue data streams, green when accessible
* Threats: Red highlighting on dangerous ICs
* Safe zones: Subtle green tint when area is temporarily clear

**Audio Cues**
* Program deployment: Digital materialization sound
* Combat: Each Program type has distinct attack sounds
* Alerts: Rising tension music as Alert increases
* Objectives: Progress tones during downloads/hacks
* Warnings: Stings for IC spawns, Program damage, high Alert

---

## 9) Prototype Content

**Core Set**
* 4 Chassis (Crawler, Bastion, Needle, Array)
* 8 Abilities (2 per chassis)
* 6 Modules
* 4 Enhancements
* 5 IC types (Sentry, Daemon, Firewall, Hunter, Warden)
* 3 System tiers with 5-7 nodes each
* 5 Objective types (Download, Hack, Breach, Extract, Disable)
* 3 Player abilities (Emergency Shield, Overclock, Mark Priority)

**Minimum Viable Gameplay**
* Tutorial: Your abandoned home system (1 node, teaches basics)
* First target: Tier 1 system (5 nodes, introduce full loop)
* Progression: Unlock 2 new Programs, 4 modules
* Challenge: Tier 2 system with mini-boss Warden
* Goal: Gather enough resources to repair home system's Research Lab

---

## 10) Victory/Loss Conditions

**Successful Run**
* Extract from any exit node
* Keep all gathered resources
* Programs survive (may be damaged)
* System remains available for future raids (unless conquered)

**Emergency Extraction**
* Triggered at 100 Trace or critical Program losses
* Keep 50% of gathered resources
* Programs heavily damaged (50% integrity)
* System enters high alert for next run

**Total Wipe**
* All Programs destroyed or player shields depleted
* Lose all volatile resources from this run
* Programs lost permanently (unless Backup Token)
* System locks you out temporarily

---

## 11) Post-Prototype Expansion Paths

* **System Conquest:** Take over systems permanently for passive resources
* **Program Personalities:** Programs gain traits through survival
* **Faction Warfare:** Systems fight back, attempt to raid YOUR system
* **Cooperative Mode:** 2 players infiltrate together, double the chaos
* **Endless Mode:** See how deep into a mega-system you can go
* **Program Crafting:** Combine destroyed Programs into new variants