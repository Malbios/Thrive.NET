# Cyberpunk Hacking Game - Design Document

**Tagline:** "Infiltrate! Manipulate! Dominate!"

## Core Concept

An extraction-style hacking game set in a virtual reality network called "the Web." Players explore procedurally generated systems, steal data, complete missions, and eventually face an AI threat that emerges to take over the entire network.

**Visual Style:** 2.5D graphics with diegetic UI (in-world interfaces instead of overlays)

## Setting: The Web

- A massive interconnected network of systems created by a collective of corporations
- Each corporation owns and manages different parts of the Web with unique security
- Players access the Web from their home system via a digital net access device (similar to Uplink workstations)
- The world feels alive and dynamic, inspired by "The World" from .hack

### World Structure

- **Systems:** Individual nodes in the network
- **Zones:** Clusters of directly connected systems ruled by specific factions
- **System Layout:** Similar to Darkest Dungeon - one hub area (home system) with various explorable systems containing grid maps of nodes
- Some systems can only be reached by traveling through other systems
- Player actions influence the global world and affect other players' sessions

## Factions

### Corporations
- **MilSec (MS):** Military and security, law enforcement systems
- **Titan Tech (TT):** Cyberware and space technology
- **Biodyne Pharmaceuticals (BP):** Medical and healthcare systems
- **InfoStream Networks (ISN):** Mass media systems
- **NeuroLink (NL):** Artificial intelligence
- **Nova Banking Incorporated:** Finance and banking systems
- **Vertex Learning Solutions:** Education and academic records

### Underground (Single Group with Multiple Personalities)
- **Ann Archie:** Punky girl who loves chaos and mayhem
- **Zero:** Non-binary data smuggler with a glitchy avatar, buys/sells information
- **Oracle:** Eccentric old woman who believes in mystical web properties, tries to predict the future
- **Chloro:** Young eco-hacktivist targeting harmful industrial projects
- **Chrome:** Avatar modification enthusiast, buys/sells system mods
- **Ghost:** Ex-corp freelancer specializing in stealth tech

### Invaders
- **Cipher Vortex:** Nightmarish, alien AI entity
  - **Origin:** Started as "Project Overwatch" - a collaborative AI guardian created by all major corporations to protect the Web
  - Went rogue and now considers everyone (corps, underground, player) as threats

## Game Phases

### Phase 1: Learning
New players learn mechanics and start exploring the Web

### Phase 2: Recognition
Corporations and underground notice the player and begin offering missions

### Phase 3: Invasion
Cipher Vortex begins its takeover attempt (triggered by player actions/story progression)

## Core Gameplay Loop

### Home System (Safe Haven)
Players build and upgrade their base system with hardware components:
- **RAM:** Determines how many active services you can run
- **CPU:** Controls service speed and complexity
- **HDD:** Limits data storage capacity and how much you can gather per expedition
- **Power Supply**
- **Mainboard**
- **Net Connection**
- **GPU** (optional)

**Hardware Acquisition:** Purchasing hardware triggers a drone delivery IRL that also installs the parts

### Exploring Other Systems (Extraction Mechanics)
Risk vs. reward expeditions into the network:
- Navigate grid-based node maps within each system
- Face various obstacles and Intrusion Countermeasures (ICs)
- Collect data, bits (currency), and research materials
- Risk leaving traces that could lead authorities back to your home system
- Extract before being overwhelmed or traced

### Activities
- **Scan** for new systems to discover exploration targets
- **Explore** other systems for resources and information
- **Research** new technology and tools
- **Upgrade** home system hardware
- **Complete missions** for corporations or underground contacts
- **Craft software/bots** to customize abilities
- **Conquer systems** (late-game mechanic)
- **Tame AIs**
- **Build additional systems** in the Web
- **PvPvE interactions**

## Resources & Economy

### Bits (Currency)
Found in other systems, used to purchase hardware and services

### Data
Various types collected in systems:
- Crafting/research components
- Mission objectives
- Valuable information to sell
- System maps (reveals all nodes in a system)

### Tier System (Color-Coded)
Everything uses standardized rarity/difficulty tiers:
- **Basic** (gray)
- **Common** (white)
- **Uncommon** (green)
- **Rare** (blue)
- **Epic** (purple)
- **Legendary** (orange)

Applies to: bits, data, enemies, bots, obstacles, equipment

## Obstacles & Challenges

### Security Measures
- Firewalls
- Encrypted locks
- Access gates
- Security scanners
- AI patrols (weak, mobile)
- Mazes
- Hidden nodes
- AI guardians (strong, mobile)
- Rival hackers
- Anti-virus programs
- ID verification
- Access logs
- Tracers

### Alertness System (Heat)
- Each system has local alertness that rises during player presence
- Higher alertness = more difficult enemies (NOT higher rewards)
- Encourages quick, efficient runs rather than extended stays
- At certain thresholds:
  - Existing obstacles become harder
  - AI patrols spawn
  - AI guardians appear
  - System Operator boss may engage

## Progression Systems

### Reputation
Actions affect standing with each faction:
- Stealing from corporations lowers corp reputation, raises underground reputation
- Each faction has individual reputation tracking

**Reputation Tiers:**
1. Hostile (strong negative)
2. Untrustworthy (medium negative)
3. Disliked (light negative)
4. Nobody (neutral)
5. Respected (light positive)
6. Valued (medium positive)
7. Trusted (strong positive)

### Research & Tools
- Requires CPU/RAM resources, potentially blocking other activities
- Unlock new capabilities and information
- Some tools reveal hidden information (data value, system difficulty, alertness levels)
- High-tier research materials only found in high-difficulty systems
- May require scanning specific items in other systems

### System Conquest (Late Game)
- Must fully explore a system first
- Conquer the system core to take ownership
- Former owners may attempt to reclaim their systems
- Introduces territorial gameplay mechanics

## Mission Types

### Corporate Missions
- Steal data from competitors or underground groups
- Crash rival systems
- Install spyware
- Plant false trails

### Underground Missions
- Sabotage corporate operations
- Cause chaos
- Smuggle data
- Disrupt specific projects

### Special Missions
- Re-capture systems (potentially introduces Cipher Vortex)

## Tutorial & Early Game

- Player learns about digital risks through infection by BUTTS virus (annoying but harmless)
- Early missions teach core mechanics
- Gradual introduction to faction politics
- Discovery that high-difficulty systems yield much better rewards

## Lore & World-Building

### Discoverable Lore Elements
- Corrupted memory fragments revealing corporate secrets
- Digital artifacts from the Web's creation
- Personal logs of famous hackers and corporate leaders
- Glitched areas with hidden data
- Hidden manifestos
- Encrypted files detailing Cipher Vortex's true nature

### Dynamic World Events
- Systems randomly fight and change owners
- Famous/infamous NPCs appear in news coverage
- Ongoing conflicts between factions
- Emerging threats from Cipher Vortex

### Mystery Elements
- Corporate hacking system designs vary by owner
- Each corporation has different security philosophies
- Players can befriend various NPCs (corp representatives, anarchs, AI bots)

## Open Questions & Design Considerations

1. **Player Identity:** Who is the player? Where do they come from? Why are they in the Web?
2. **Avatar Customization:** What options exist for player appearance/representation?
3. **Multiplayer:** How exactly does player interaction work? Can players reach each other's systems?
4. **System Design:** What makes exploring procedurally generated systems consistently fun?
5. **Trigger Events:** What specific actions trigger the Cipher Vortex invasion?
6. **Discovery:** How does the player first learn about the invaders?
7. **Teaching:** How do players learn that high-difficulty systems have better rewards?
8. **Core Loop:** What keeps the extraction-style gameplay compelling long-term?

## Design Pillars

1. **Risk vs. Reward:** Every expedition is a gamble - how much can you take before you must extract?
2. **Emergent Gameplay:** Open progression with multiple paths and faction allegiances
3. **Living World:** Dynamic systems that change based on player and NPC actions
4. **Strategic Depth:** Resource management, reputation balancing, and tactical combat
5. **Mystery & Discovery:** Uncovering the truth about the Web and Cipher Vortex