# Assessment-1-RPG-store
Zion Matthews
:----
s198031
Introduction to c# Assessment 1
RPG Store Simulator

## I. Requirments

1. Description of Problem
      
       -**Name**: RPG Store Simulator
       -**Problem Statement**: Create a text-based RPG store and allow the player to purchase items from, or sell items to, the store.
       -**Problem Specifications**-: The program must use variables, operators, expresssions, sequseter, selection, iteration, functions, two instances of arrays, and reading & writing to a text file.

2. Input Information

    - Use the keyboard to work the program.

3. Output Information

   - When the program starts, it will ask the user for a name.
   - Once the user gives a name. It then brings them to the shop.
   - In the shop the user is able to buy/sell weapons.
   - They can also check inventory and maybe access something secret.

4. User Interface Information

    - The program displays information and commmands through the console but not all information.
    -**Buy Items Menu**: The buy items menu gives you a selection of weapons, armor, potions, and pets to buy.
    -**Check Inventory**: This menu allows you to view your inventory.
    -**Sells Items**: Brings you to your inevntory to sell any type of item you have.
    -** Save**: Saves the items in your inventory to a file.
    -**Loads**: Loads the items.

## II. Design

1. System Archictecure

|Game Diagram
|:-
![Game Diagram](https://imgur.com/2Qs8C2f)

5. ### Object Information

Name: _name
Description: Holds name for item or user.
Type: string

Name: _cost
Description: Used for currency in my shop and player account.
Type: int

Name: _description
Description: used to be the description for an item.
Type: string

Name: _buff
Description: Used to describe the buffness of an item.
Type: int

Name: _protection
Description: Used to describe the protection of an item.
Type: int

Name: _support
Description: used to describe the support that an item gives.
Type: int

Name: _damage
Description: used to give weapon items damage.
Type: int

Name: _playerlists
Description: The name of the player array.
Visisbility: Private

Name: _itemLists
Description: The name of the shop array.
Visisbility: Private

Name: managerInv
Description: The name of the Manager array.
Visisbility: Private
