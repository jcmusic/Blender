"## Blender##" 

How would you code a Blender?  This was an whiteboard interview question I heard many years ago in order to see how a developer would approach a problem.  When I ran accross the State design pattern, I immediately thought of that question.  So as an OOP design exercise, I decided to code it.  We learn thru doing.  

The state pattern is one thing, but one of the greater lessons here is dependency inversion.  Any appliance should present it's menu/command options to the user.  Therefore, the Blender should contain a menu and be able to present the menu.  And why should the menu be tightly coupled to the blender?  That would be brittle.  No, it's better to accept the menu in the constructor so that the dependency is injected (composition!), resulting in loose coupling.

The menu itself is a collection of states (Low, High, Off, etc).  The menu sets itself up using Reflection to generate the list of States (all concreate states derived from the abstract base class).  This allows for easily adding new states without needing to alter existing code.

The Open/Closed principle is respected here, allowing us to expand in the future to different blender types if we wish (budget, standard, and deluxe!).  All we need to do is create a factory class for the state collection and a config file!

