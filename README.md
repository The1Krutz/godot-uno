# godot-uno
Uno game in Godot

Planning to use this as a way to learn how to build UI in Godot, since a card game doesn't have physics, etc

## The plan

1. Convert some of the helper models from the old React version of this since they might still be useful
2. Learn enough Godot UI to slap together a basic card game interface
3. ???
4. Profit!

## Structure

### UnoGame

The Godot project with the actual game in it

### UnoGame.Test

Tests for the Godot project if I can get a unit testing framework to play nice

### UnoLib

Helper classes and data models that support Uno but are agnostic to Godot

### UnoLib.Test

Tests for the helpers
