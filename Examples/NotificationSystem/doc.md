# Notification System

## Idea

A notification system that sends notifications to users who subscribe to channels.  
The system supports multiple notification types, including SMS, Email, Push Notification, Facebook, etc.  
It can also send various kinds of messages such as alerts, reminders, and promotions.

## Documentation (Design Pattern Concepts)

* **Strategy Pattern**: Provides a set of interchangeable algorithms; changing one does not impact others.
* **Observer Pattern**: Creates a one-to-many relationship where observers are notified when the subject's state
  changes.
* **Decorator Pattern**: Wraps an object to add functionality before and/or after a method, without modifying the
  original.
* **Factory Method Pattern**: Defines an interface for creating an object, but lets subclasses decide which class to
  instantiate.

## Patterns and Responsibilities

* **Observer Pattern**: Used to notify all subscribers when a new message is sent.
* **Strategy Pattern**: Allows dynamic change of message content or format logic (e.g., alert, reminder, promotion).
* **Decorator Pattern**: Adds optional responsibilities to the send process, such as logging, encryption, or retry
  mechanisms.
* **Factory Method Pattern**: Creates the appropriate type of notification sender (e.g., EmailSender, SMSSender,
  PushSender).

## Summary

* Factory pattern: provide way to create notification by notification type
* Observer pattern: handle subscribe and notify
* Strategy patter: handle dynamic way to send notification and format of message
* Decorator pattern: add responsibility for sender at runtime