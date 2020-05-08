---
title: "Connected Customer Service - Overview | MicrosoftDocs"
description: "Overview of ."
author: lalexms
ms.author: lalexms
manager: shujoshi
ms.date: 05/08/2020
ms.topic: article
ms.service: 
  - "dynamics-365-customerservice"
ms.custom: 
  - ""
applies_to: 
  - ""
---

### Upcoming changes to the Service Scheduling experience

As previously announced, the legacy service scheduling experience is currently being depricated, inline with the expected UCI transition date of 12/01/2020. However, there are now two approaches you can take to transition to a new scheduling experience. 

#### Option #1: Migrate to Core Service Scheduling experience

The established approach is to migrate to the Core Service Scheduling experience built on Universal Resource Scheduling. More information: . This approach is best if you are a new Customer Service user, have already migrated, or are not otherwise blocked by the absence of the features listed in the [Cons of migrating to the Core Service Scheduling experience](#cons-of-migrating-to-the-core-service-scheduling-experience) section below.

Consider the following pros and cons before deciding to migrate.

##### Pros of migrating to the Core Service Scheduling experience:
- It aligns with the URS long-term strategy
- Scheduling interoperability is available across Customer Service, Field Service, and Project Service Automation applications

##### Cons of migrating to the Core Service Scheduling experience:
- Appointment, Recurring Service Appointment, and Customer preferred selection are not supported
- Schedule boards are not customizable
- There isn't a public extended API for supporting Appointment adn Recurring Service Appointment features
- Legacy customer administrators must run the migration tool and install the Core Service Scheduling package before using URS
- You cannot roll back once the migration tool executes.

#### Option #2: Wait for the Unified Interface in August 2020

For customers who are blocked by the absence of the features outlined above, we are offering an incremental option to wait for a “UCIfied” scheduling experience. “UCIfied” means that the product team will update the existing service scheduling experience for Unified Interface while continuing to use the legacy APIs. The timeline for this UCIfied scheduling experience is 2020 Release Wave 2, with Early Access in August. For the time being, please use legacy service scheduling. 

Target customer: Legacy Service Scheduling customers who are blocked by absence of certain features in URS or face COVID-19 related capacity constraints that hinder migration to URS 

Pros 

No feature gaps between legacy web client experience and UCI  

Same scheduling process 

No manual migration needed for customers to start using the UCIfied experience 

No action for customers who have or are currently building a custom UI that is calling the legacy scheduling API 

Cons 

URS engine design is different from the legacy scheduling engine. URS Schedule Board and UCIfied Service Calendar are not interoperable. 

Does not align with long term URS product direction, so customers will still need to migrate to URS at a later date (timeline TBD in 2021). 

 

Here’s a table summarizing the approaches: 
