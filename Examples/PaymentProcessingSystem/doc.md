# Payment Processing System

## 1. Overview

Build a robust, extensible payment processing system that supports multiple payment methods (credit card, PayPal,
cryptocurrency) with a focus on flexibility, maintainability, and scalability.

## 2. Requirements

1. [x] Support multiple payment methods (Credit Card, PayPal, Crypto).
2. [x] Notify the system of payment status changes (success, failure).
3. [x] Support commands for payments like processing and refunding.
4. [x] Maintain a single point of payment gateway control.
5. [x] Support retries or undo of payments (refunds).

## 3. Technical Requirements

* Use a Factory pattern to create payment processors dynamically. => Use factory pattern to create abstract factory
  which create families of components include: processor and validator => **Done**

* Use Strategy pattern to implement payment processing logic per method. => It didn't apply strategy pattern

* Use Observer pattern to notify UI, accounting, and order subsystems of payment events. => **Done**

* Use Singleton for the payment gateway to centralize payment management. => **Done**

* Use Command pattern to encapsulate payment actions enabling retries or undo operations. => **Done**

## 4. Benefits of Using These Patterns in This Project

* Using Singleton pattern -> ensure only one gateway which handle all action -> consist data
* Observers pattern: allow auto send notification to observers when order status changed
* Command pattern: store commands, support rollback or undo, decoupled with action request
* Abstract factory: consist objects which in a family of component, decouple with subclass
