# Project Spotlight: 2D Platformer Adventure

I'm excited to present my **2D Platformer Adventure**, a comprehensive Unity-powered side-scrolling experience that showcases advanced character controller mechanics, intelligent enemy behaviors, and seamless level progression. This project demonstrates mastery of Unity's 2D toolset, including Cinemachine integration, Tilemap systems, and state-driven animations.

---

## Core Gameplay Mechanics

- **Fluid Character Movement:** Responsive player controls featuring running, jumping, and climbing with physics-based momentum and precise collision detection.
- **Multi-Layered Collision System:** Sophisticated ground detection, ladder climbing, and hazard avoidance using Unity's LayerMask system for precise environmental interaction.
- **Combat Integration:** Directional shooting mechanics with bullet physics that adapt to player orientation and movement state.
- **Environmental Challenges:** Carefully designed levels with hazards, enemies, and vertical climbing sections requiring skill and timing.

---

## Advanced Player Controller

- **Physics-Based Movement:** Rigidbody2D-driven character control with customizable run speed, jump force, and climbing velocity.
- **Intelligent Sprite Flipping:** Automatic character orientation based on movement direction with smooth visual transitions.
- **Gravity Manipulation:** Dynamic gravity control during ladder climbing sequences.
- **Death State Management:** Physics-based knockback effects and proper state cleanup ensuring consistent gameplay.

---

## Combat & Projectile System

- **Directional Bullet Mechanics:** Smart projectile spawning system that inherits player orientation for intuitive aiming.
- **Enemy Interaction:** Collision-based combat with immediate feedback, destruction, and cleanup.
- **Physics Integration:** Rigidbody2D-based bullets with realistic velocity and collision detection.
- **Environmental Collision:** Bullet destruction on contact with geometry ensuring performance and realism.

---

## Intelligent Enemy AI

- **Patrol Behavior:** Autonomous enemy movement with boundary detection and automatic reversal.
- **Visual Feedback Systems:** Sprite flipping to face movement direction for clear visuals.
- **Collision Response:** Trigger-based patrol zones with no complex pathfinding.
- **Movement Consistency:** Velocity-driven behavior for learnable enemy patterns.

---

## Collectible & Progression Systems

- **Coin Collection Mechanics:** Audio feedback, score integration, and cleanup to prevent duplicate pickups.
- **Score Management:** Real-time score updates with TextMeshPro formatting.
- **Audio Integration:** Spatial sound for immersive feedback.
- **State Protection:** Flags to prevent repeated item collection.

---

## Level Progression & Scene Management

- **Seamless Level Transitions:** Coroutine-based scene loading with delays.
- **Circular Level Design:** Scene indexing cycles back after final level.
- **State Persistence Management:** Cleanup of persistent objects between transitions.
- **Player-Triggered Progression:** Exit zones allow player-initiated advancement.

---

## Lives & Session Management

- **Persistent Game Session:** Singleton-based system retaining lives and score using `DontDestroyOnLoad`.
- **Life Management System:** Handles deaths, deductions, reloads, and game-over logic.
- **UI Integration:** Real-time updates to lives and score via TextMeshPro.
- **Session Reset Logic:** Clean restart handling.

---

## Advanced Unity Integration

- **Cinemachine Camera Systems:** Smooth following, boundaries, and transitions.
- **Tilemap Level Design:** Rapid prototyping and efficient layout building.
- **Animation State Management:** Animator-based states for movement and death.
- **Layer-Based Collision:** Organized layer setup for environment and enemies.

---

## Architecture & Design Patterns

- **Component-Based Design:** Modular architecture separating responsibilities.
- **Singleton Pattern Implementation:** Used for GameSession and ScenePersist.
- **Input System Integration:** Unity Input System for multi-device support.
- **State Machine Logic:** Clear transitions for alive, dead, and other states.

---

## Performance & Optimization

- **Efficient Component Caching:** Initialized `GetComponent` calls to avoid runtime cost.
- **Proper Object Cleanup:** Bullets, collectibles, and effects destroyed after use.
- **Layer-Based Collision:** Collision filtering using LayerMask.
- **Animation Optimization:** Parameter updates only on state change.

---

## Visual Polish & Effects

- **Smooth Sprite Animations:** Visually appealing transitions between actions.
- **Environmental Visual Feedback:** Clear indication of interactivity and hazards.
- **UI Integration Excellence:** Clean TextMeshPro UIs with consistent styling.
- **Death Effect Implementation:** Physics knockback and animation for visual feedback.

---

## Code Quality & Best Practices

- **SOLID Principles Application:** Clean, decoupled systems.
- **Null-Safe Programming:** Defensive coding with null checks and error handling.
- **Unity Lifecycle Mastery:** Efficient use of `Awake`, `Start`, and `Update`.
- **Clean Code Structure:** Clear naming conventions and modular logic.

---

## Technical Achievements

- **Advanced Physics Integration:** Realistic movement and interaction via Rigidbody2D.
- **Multi-State Character Controller:** Support for movement, jumping, climbing, shooting, and death.
- **Scene Persistence Management:** Cross-scene lifecycle handling with cleanup.
- **Input System Mastery:** Full Unity Input System support.

---

## Gameplay Design Excellence

- **Intuitive Control Scheme:** Natural and responsive input handling.
- **Progressive Challenge Design:** Balanced enemy and level design.
- **Clear Visual Communication:** Easily understandable game elements.
- **Rewarding Progression:** Strong feedback for achievements and progress.

---

## System Integration Highlights

- **Cinemachine Integration:** Professional-grade camera behavior and tracking.
- **Tilemap Workflow:** Efficient level iteration with Unity's Tilemap tools.
- **Animation Controller Logic:** Parameter-driven animation state machine.
- **Audio System Integration:** Location-aware audio feedback for events.

---

## Development Insights & Reflections

Building this **2D Platformer Adventure** provided hands-on experience across Unity's 2D pipeline. From robust player state management to seamless level transitions, this project emphasizes clean architecture and modular design.

The LayerMask-driven collision system allows complex environmental interactions with minimal performance overhead. Session persistence features tackle the challenges of cross-scene continuity and object lifecycle management.

This project encapsulates the full 2D game development cycle—from core movement to final polish—and serves as a showcase for Unity’s integrated systems working together to deliver professional, scalable experiences.

I’m open to collaboration and eager to discuss 2D platformer development, controller design, level design, or performance optimization strategies.

## Play Link

[![Watch the video](https://img.youtube.com/vi/GKzVNuhoyxY/maxresdefault.jpg)](https://youtu.be/GKzVNuhoyxY)
### [Gameplay Video](https://youtu.be/GKzVNuhoyxY)

![Image](https://github.com/user-attachments/assets/357e3600-fafc-4ae4-9f16-28e491abd6ec)

![Image](https://github.com/user-attachments/assets/d522b20f-6886-407b-9715-17d2a4a120fa)

![Image](https://github.com/user-attachments/assets/4e3fe09a-8ff9-4d6d-b58a-99e18fa4b6cc)

![Image](https://github.com/user-attachments/assets/6e24af67-834b-4f81-b4dd-b76715201bd6)

![Image](https://github.com/user-attachments/assets/bbf3071c-d49e-4780-8f40-6d3bfdc068b7)
