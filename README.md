# DnD-Hub-V2

![dnd](https://user-images.githubusercontent.com/29739357/153893679-ba1e5a04-d280-4009-bb78-50bb21b932ad.png)

##  Current Status: 

Save entire profile to JSON file

Load profile from JSON

Generate seed data to create initial file 

Actions, Saving Throws, Skills, and Abilities boxes to automatically roll

Roll string box

Roll box for ad-hoc rolls

## JSON 

The overall save profile has 5 main categories: Character, Actions, Skills, SavingThrows, and Abilities

Samples of each be seen below. Proper schema documentation needs to be done. 

Assume values in quotes are strings, true/false is a bool, and all others are ints. Putting in negatives for ints needs to be tested thoroughly. 

All fields _should_ be included, but probably aren't necessary.
 
#### Character
``` JSON
"Character": {
	"Name": "Lorenzo Tortishelli",
	"CurrentHP": 12,
	"MaximumHP": 18,
	"Level": 3,
	"Initiative": 2,
	"SavingThrows": null,
	"Skills": null,
	"Actions": null,
	"Abilities": null,
	"PassivePerception": 0,
	"WalkingSpeed": 30,
	"ArmorClass": 17,
	"ProficiencyBonus": 0
},
```
#### Actions
``` JSON
"Actions": 
[
	{
		"Name": "Unarmed Strike",
		"RollString": "1d4 + 3",
		"Description": "Melee attack, basic hit",
		"Damage": 0
	},
	{
		"Name": "Pole",
		"RollString": "1d6 + 1",
		"Description": "Weapon attack, basic hit",
		"Damage": 0
	}
],
```
### Skills
``` JSON
"Skills": 
[
	{
		"Name": "Acrobatics",
		"Bonus": 0,
		"Modifier": {
			"AbilityType": 1,
			"Value": 0
		},
		"Proficient": false
	},
	{
		"Name": "Animal Handling",
		"Bonus": 0,
		"Modifier": {
			"AbilityType": 4,
			"Value": 0
		},
		"Proficient": false
	},
	{
		"Name": "Arcana",
		"Bonus": 0,
		"Modifier": {
			"AbilityType": 3,
			"Value": 0
		},
		"Proficient": false
	},
	{
		"Name": "Athletics",
		"Bonus": 0,
		"Modifier": {
			"AbilityType": 0,
			"Value": 0
		},
		"Proficient": false
	},
	{
		"Name": "Deception",
		"Bonus": 0,
		"Modifier": {
			"AbilityType": 5,
			"Value": 0
		},
		"Proficient": false
	},
	{
		"Name": "History",
		"Bonus": 0,
		"Modifier": {
			"AbilityType": 3,
			"Value": 0
		},
		"Proficient": false
	},
	{
		"Name": "Insight",
		"Bonus": 0,
		"Modifier": {
			"AbilityType": 4,
			"Value": 0
		},
		"Proficient": false
	},
	{
		"Name": "Intimidation",
		"Bonus": 0,
		"Modifier": {
			"AbilityType": 5,
			"Value": 0
		},
		"Proficient": false
	},
	{
		"Name": "Investigation",
		"Bonus": 0,
		"Modifier": {
			"AbilityType": 3,
			"Value": 0
		},
		"Proficient": false
	},
	{
		"Name": "Medicine",
		"Bonus": 0,
		"Modifier": {
			"AbilityType": 4,
			"Value": 0
		},
		"Proficient": false
	},
	{
		"Name": "Nature",
		"Bonus": 0,
		"Modifier": {
			"AbilityType": 3,
			"Value": 0
		},
		"Proficient": false
	},
	{
		"Name": "Perception",
		"Bonus": 0,
		"Modifier": {
			"AbilityType": 4,
			"Value": 0
		},
		"Proficient": false
	},
	{
		"Name": "Performance",
		"Bonus": 0,
		"Modifier": {
			"AbilityType": 5,
			"Value": 0
		},
		"Proficient": false
	},
	{
		"Name": "Persuasion",
		"Bonus": 0,
		"Modifier": {
			"AbilityType": 5,
			"Value": 0
		},
		"Proficient": false
	},
	{
		"Name": "Religion",
		"Bonus": 0,
		"Modifier": {
			"AbilityType": 3,
			"Value": 0
		},
		"Proficient": false
	},
	{
		"Name": "Sleight of Hand",
		"Bonus": 0,
		"Modifier": {
			"AbilityType": 1,
			"Value": 0
		},
		"Proficient": false
	},
	{
		"Name": "Stealth",
		"Bonus": 0,
		"Modifier": {
			"AbilityType": 1,
			"Value": 0
		},
		"Proficient": false
	},
	{
		"Name": "Survival",
		"Bonus": 0,
		"Modifier": {
			"AbilityType": 4,
			"Value": 0
		},
		"Proficient": false
	}
],
```
### SavingThrows
``` JSON
"SavingThrows": [
	{
		"Name": "Strength",
		"Modifier": {
			"AbilityType": 0,
			"Value": 0
		},
		"Value": 12
	},
	{
		"Name": "Dexterity",
		"Modifier": {
			"AbilityType": 1,
			"Value": 0
		},
		"Value": 12
	},
	{
		"Name": "Constitution",
		"Modifier": {
			"AbilityType": 2,
			"Value": 0
		},
		"Value": 12
	},
	{
		"Name": "Intelligence",
		"Modifier": {
			"AbilityType": 3,
			"Value": 0
		},
		"Value": 12
	},
	{
		"Name": "Wisdom",
		"Modifier": {
			"AbilityType": 4,
			"Value": 0
		},
		"Value": 12
	},
	{
		"Name": "Charisma",
		"Modifier": {
			"AbilityType": 5,
			"Value": 0
		},
		"Value": 12
	}
],
```
### Abilities
``` JSON
"Abilities": 
[
	{
		"Name": "Strength",
		"AbilityType": 0,
		"Value": 12,
		"Modifier": 0
	},
	{
		"Name": "Dexterity",
		"AbilityType": 1,
		"Value": 12,
		"Modifier": 0
	},
	{
		"Name": "Constitution",
		"AbilityType": 2,
		"Value": 12,
		"Modifier": 0
	},
	{
		"Name": "Intelligence",
		"AbilityType": 3,
		"Value": 12,
		"Modifier": 0
	},
	{
		"Name": "Wisdom",
		"AbilityType": 4,
		"Value": 12,
		"Modifier": 0
	},
	{
		"Name": "Charisma",
		"AbilityType": 5,
		"Value": 12,
		"Modifier": 0
	}
]
```
##  Need to add: 

Make general rolls more reliable

Change MODs to use abbreviated text (STR instead of Strength)

(More) Pictures of the project


