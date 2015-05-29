# Hamburger

This game is based off of the Atari games Pressure Cooker. It is an arcade/simulation game where the player is the chef. The goal is to make the hamburgers with the ingredients shown in the list.

# Unity Objects

- One Camera
- Two empty objects
- Sprites (each food item, a chef, background)

# Unity Components

- Add the Burger.cs to one empty object (charts). Add each food item with a Box Collider 2D. Set the Is Trigger. Add FoodList.cs to each food item.
- Add the GameSetup.cs and GameScore.cs to one empty object (GM). Add five Box Colliders 2D. On one, set the Is Trigger, add the Trash.cs and the trash sprite.
- On the chef sprite, add the ChefControl.cs, add a Box Collider 2D, and a Rigidbody 2D (with 0 gravity).
- Add each food item sprite. Within each one, add the same food item sprite. Add a Box Collider 2D to all the objects. In the children food items, set the Is Trigger, and add the FoodControl.cs.
