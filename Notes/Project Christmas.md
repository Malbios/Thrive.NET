# Thrive

**Pitch:** A top-down action game set within a **living digital world**. From your own **home system**, you launch high-risk **infiltration runs**, where you rely on pre-programmed **scripts** to survive. Steal valuable data from hostile, interconnected systems, and extract before security deals with you permanently. Back home, you **research** and **craft** new scripts for your next run. Will you thrive or die?

**One-Liner:** A top-down extraction roguelite where you pre-program your avatar's abilities as scripts, then infiltrate living digital systems to steal data and escape before security wipes you from the network.

**Tagline:** Infiltrate. Manipulate. Dominate.

---

## 1. High-Level Concept

You’re a lone hacker operating in a corporately owned virtual network called **The Net**. From a persistent **home system**, you infiltrate randomly generated systems, steal or manipulate data, and gradually uncover a larger threat (Cipher Vortex).

Each target system is a **graph of nodes** (rooms) connected by **links** (data paths). Neutral **data packets** move along these links to do the system’s work (I/O, storage, processing, logging, etc.).

Your **avatar** usually enters these systems from an I/O node. You navigate the node graph, manipulate packets and nodes, try to complete objectives and extract before:

* local **ALERT** escalates security, or
* global **TRACE** triggers a hard lock and wipes your run.

At high **ALERT**, the system's operator goes in as a **SysOp avatar**, a direct, mobile countermeasure that hunts you down.

---

## 2. Design Pillars

1. **Scripted Agency**

   * The player should feel like they **programmed** how their avatar behaves, without writing code.
   * Pre-run, they create abilities as **Trigger → Filter → Effect** scripts. In-run, those scripts drive both active abilities and passive reactions.

2. **Infiltration Over Slaughter**

   * Conflict is about **bypassing**, **misdirecting**, and **sabotaging** security rather than mowing down endless enemies.
   * "Winning" a system usually means getting the data and escaping, not clearing every node, unless the player explicitly chooses to try and conquer it during late-game.

3. **Risky Curiosity**

   * The game should constantly tempt the player to go "one node/system deeper": better data, more secrets, more research material.
   * Rising **ALERT**/**TRACE** and the looming SysOp avatar are the pressure that forces difficult extraction decisions.

4. **Diegetic Systems**

   * UI and mechanics should feel like part of **The Net** itself: maps, meters, and alerts are in-world constructs or tools the player “runs”, not abstract overlay menus.

5. **Home is Where the Complexity Lives**

   * Heavy customization and “thinking work” happen in the **home system** (script building, research, long-term planning).
   * Runs are focused, readable, and played with a small, pre-selected set of scripts.

---

## 3. Player Role & Fantasy

You are:

* A freelance hacker with a custom rig and personal **home system** hub.
* Represented in **The Net** as a single, configurable **avatar program**.
* Hired or driven to:
  * steal or alter sensitive data,
  * sabotage and destabilize systems,
  * uncover hidden agendas and conspiracies across **corps**, **Cipher Vortex**, and **underground actors**.

Core fantasy:

> "I designed how my avatar behaves, then used those scripts in the moment, dodging security, twisting the system against itself, and barely escaping a living network that was actively trying to kill me."

Power arc:

* Early on, the player is a fragile intruder scraping by.
* Later, a seasoned infiltrator who can rewrite system behavior on the fly and stand their ground against SysOp avatars in the right circumstances.

---

## 4. Core Loop

**Outside runs (Home System):**

1. **Plan / Script**

   * Use a visual tool to assemble **Scripts** (Trigger → Filter → Effect) within your rig’s resource limits.
   * Assign resulting abilities to a small number of active and passive slots on your avatar.

2. **Research & Upgrade**

   * Spend data and bits on:

     * new Triggers, Filters, and Effects for scripts,
     * rig upgrades (RAM/CPU → more complex scripts; HDD → more loot capacity),
     * tools that reveal system info (maps, alert meters, node types).

3. **Select Target System**

   * Choose a system based on:

     * faction owner, tier, known/unknown difficulty, known rewards.
   * Optional: purchase or steal **System Map** / intel beforehand.

**During runs (inside a system):**

4. **Breach**

   * Spawn into an **I/O node** with minimal information (unless pre-scouted).
   * See only adjacent nodes / links until mapped.

5. **Explore & Infiltrate**

   * Move node-to-node through links, avoiding or engaging security.
   * Use your scripts to:

     * ride/alter packets,
     * probe nodes,
     * bypass gates and locks,
     * access and extract data.

6. **Escalation**

   * Your actions raise **Alert** (local, affects security behavior) and **Trace** (run-level pressure).
   * Security ramps from basic ICs to patrols, guardians, and finally a SysOp avatar.

7. **Extract or Overstay**

   * Use known exit nodes to **jack out** and bank rewards.
   * Or push deeper toward high-value nodes (e.g. core, research banks) for better loot and story progress, at the risk of SysOp intervention or lockout.

**Back home:**

8. **Resolve & Progress**

   * Successful extract: keep data/loot, advance research, maybe unlock new system tiers.
   * Wipe/forced lockout: lose run-specific gains, keep permanent unlocks, perhaps suffer temporary penalties (cooldown before revisiting that system).

---

## 5. World Structure

### 5.1 The Web

* Large network of **systems**, each owned by:

  * Corporate factions (MilSec, Titan Tech, etc.),
  * Underground or independent groups,
  * or (later) corrupted by **Cipher Vortex**.

* Systems are organized into **zones** (clusters of systems) with different security philosophies and aesthetics.

### 5.2 Individual Systems

Each system:

* Is a **graph of nodes**, not a linear dungeon:

  * Node types: I/O, Storage, Processing, Router, Firewall/Gate, Security, Core, Special (research, logging, etc.).
  * Links: directed or bidirectional data paths.

* Starts **unknown**:

  * Without intel, you only see your current node and immediate neighbors.
  * Finding or buying **System Maps** reveals more of the graph.

* Has a **finite, redistributeable security pool** (ICs and security features) that reacts to Alert. 

---

## 6. During a Run – Player Capabilities & Systems

### 6.1 Avatar Basics

* Single avatar per run.

* Movement, visibility, and exact camera (first-person vs 2.5D top-down) are **TBD**; design assumes:

  * real-time movement,
  * clear line-of-sight rules,
  * ability to interact with packets and nodes in your vicinity.

* A small number of **active abilities** (key-bound, cooldown/energy) and **passive scripts** that react to events.

### 6.2 Script System (Trigger → Filter → Effect)

Pre-run, the player composes scripts out of:

* **Triggers** (When does this run?)

  * Examples: on key press, on entering node, on detection event, on interacting with packet/node, on low integrity, etc.

* **Filters** (What does it select?)

  * Examples: self, current node, nearest gate, all packets on current link, nearest security entity, etc.

* **Effects** (What happens?)

  * Examples: movement/escape, stealth/spoofing, node manipulation, packet infection, disruption of security, information gathering.

Constraints:

* Each script has a **complexity cost** (abstracted via memory/CPU).
* The avatar has a **budget** per run; you pick a few scripts that fit.

Result:

* Some scripts are **manual actives** (mapped to keys).
* Others are **passive behaviors** (auto-triggered on conditions).

No numeric details here; design focuses on categories and relationships.

---

### 6.3 Data Packets

* Neutral entities traveling along links between nodes, representing the system’s normal operations (requests, results, logs, etc.).
* Visible to the player; flow patterns hint at node roles:

  * Many packets into a node → likely Storage / Core.
  * Heavy cross-node traffic → central routers / processors.

What the player can **do** with packets (conceptually):

* **Observe**: derive structure and behavior (e.g., discover routes by watching origins/destinations).
* **Infect**: attach payloads that:

  * report nodes visited (scouting),
  * weaken nodes they feed,
  * or trigger effects when enough infected packets hit a target.
* **Ride**: temporarily join packet flow to traverse guarded links.
* **Hijack/Redirect**: re-route packets to other nodes to cause overloads, starve certain nodes, or mislead security.

Specific effects & risks are determined by scripts, but packets are always **tools and signals**, not combatants.

---

### 6.4 Security (Non-Avatar)

Security is built from:

* **Static defenses**: firewalls, gates, turrets, scanners.
* **Mobile ICs**: patrols, watchdogs, guardians.

They:

* Guard specific nodes and sometimes patrol links.
* React to increasing Alert:

  * more spawn, move toward your location, gain new behaviors or buffs. 

Player interactions:

* Bypass (spoof identity, ride packets, use blind spots).
* Disrupt (jam, stun, confuse routing).
* Overload (indirectly via packet floods or node abuse).
* In some builds, directly damage/destroy.

Again, exact “moves” are left open; scripts define how you engage.

---

### 6.5 Alert & Trace

* **Alert** (system-local):

  * Rises when you are detected, force things, damage security, or perform noisy actions.
  * Drives:

    * IC redistribution / escalation,
    * thresholds where special defenses and the SysOp avatar appear.

* **Trace** (run-level):

  * Increases over time and on certain critical actions (accessing cores, maps, high-value nodes).
  * At high values:

    * exit nodes may begin to lock down,
    * external reinforcements arrive,
    * hard deadlines for extraction can trigger.

Pacing & numbers are tuning concerns; conceptually, these are your main pressure dials.

---

### 6.6 SysOp Avatar

High-alert response: a **mobile, intelligent opponent** representing the system operator.

* Spawns once Alert crosses a threshold or when you hit certain critical nodes.
* Moves through node graph toward your last known position.
* Has a small, clear ability kit aimed at:

  * tracking/locking you,
  * disabling your scripts in certain nodes,
  * purging infected packets or compromised nodes.

Intended role:

* **Soft timer / enrage**: early/mid game, you’re usually expected to extract once it’s on the field unless you’ve built specifically to stall or evade it.
* Optional **high-risk challenge** for advanced builds and certain missions.

Combat with the SysOp is handled with the same script system – your scripts vs its patterns – not a separate mode.

---

## 7. Progression & Meta Systems

### 7.1 Home System & Rig

* Physical-ish representation of your personal system:

  * RAM, CPU, HDD, Power, Net Connection, etc., define:

    * how many scripts you can run,
    * maximum script complexity,
    * how much data you can bring out per run.

* Upgrades purchased with:

  * **Bits** (money) and **Data** (various types) gathered in runs.

### 7.2 Research

* Long-term tree(s) that unlock:

  * new **Triggers**, **Filters**, **Effects** for scripts,
  * better **system intel tools** (scan upgrades, map reveal, difficulty indicators),
  * new node interactions (e.g. advanced infection, gate manipulation).

* High-tier research requires materials from higher-tier systems.

### 7.3 Factions & Missions

* Corporations, underground contacts, and later Cipher Vortex provide **missions**:

  * data theft, sabotage, planting spyware, tracing enemies, etc.
* **Reputation** systems influence mission offers and access to higher-tier systems.

(Details can come later; for the vertical slice, a small subset is enough.)

### 7.4 Roguelite Structure

* Each **run**:

  * uses your current script loadout and rig stats,
  * may discover new systems, maps, and resources,
  * risks losing the run’s gains on wipe.

* Permanent progression:

  * unlocked script components,
  * rig upgrades,
  * discovered systems and faction reputation. 

---

## 8. Scope for First Vertical Slice (high-level)

Focus on:

* 1–2 corp-owned systems (small graphs, 5–8 nodes each).

* Limited node types: I/O, Storage, Router, Firewall, Security, Exit.

* A handful of script components:

  * 2–3 Triggers (key press, on enter node, on detection),
  * 2–3 Filters (self, current node, nearest packet/gate),
  * 3–4 Effects (movement/escape, simple spoof, simple packet infection, simple node manipulation).

* One basic security set:

  * patrol IC, static gate, simple scanner, baseline Alert/Trace.

* SysOp avatar as a simple, telegraphed “chaser” that appears at high Alert (even if only partially implemented).

The goal of the slice:

> Let the player **build a couple of scripts at home**, run at least one **infiltration** where they see those behaviors play out in a small but real node graph, and feel the **risk of escalating Alert/Trace vs extracting with loot.**