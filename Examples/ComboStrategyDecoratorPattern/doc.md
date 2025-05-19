# Notifier system

System have many notify type: Mail, SMS, Social media,

* Strategy: encapsulate set of behavior which are interchangeable, and can vary at runtime without impact to where use it
* Decorator: add behaviors to main behavior of object by wrapping object inside decorator which add functionality before and/or after main functions like DbContext of EFcore

entity with Behavior is A

in process i need change behavior to B and add piece of logic before behavior execute

Calculate money

Guess: calculate by sum
VIP calculate by sum with discount and update a VIP discount percent
