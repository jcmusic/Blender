## Blender  
A Proof-of-Concept project for the State Design Pattern

### How would you code a Blender?  

<p align="left">
This was an whiteboard interview question I heard many years ago in order to see how a developer would approach a problem.  When I ran accross the <strong> State design pattern </strong>, I immediately thought of that question.  So as an OOP design exercise, I decided to code it.  We learn thru doing.</p>

<p align="left">
The state pattern is one thing, but one of the greater OOP lessons here are composition and dependency inversion, where the blender's behavior are provided externally. This way can be changed at runtime, cleanly, as each behavior is encapsulated in it's own state object.</p>
  
<p align="left">Any appliance needs to it's command menu/options to the user.  Therefore, the Blender should contain a menu and be able to present the menu.  But why should the menu be tightly coupled to the blender?  That would be brittle.  No, it's better to accept the menu in the constructor so that the dependency is injected (composition!), resulting in loose coupling.</p>

<p align="left">
The menu itself is a collection of states (Low, High, Off, etc).  The menu sets itself up internally using Reflection to discover and compose the list of States (all concrete states derived from the abstract base class and found in the assembly).  This allows for easily adding additional new states without the need to alter existing code.</p>
