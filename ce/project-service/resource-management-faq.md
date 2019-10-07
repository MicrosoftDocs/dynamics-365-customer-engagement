---
title: Resource management FAQ
description: This topic provides answers to frequently asked questions about resource management.
author: ruhercul
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 03/28/2019
ms.topic: article
ms.prod: 
ms.technology: 
ms.author: ruhercul
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
---
# Resource management FAQ

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

## What is the difference between a team member and a resource requirement?

A project team member can be assigned to tasks, booked or overbooked, and set as an approver. A resource requirement can exist without a project team member, as a draft note of demand. 

## What is the difference between proposed and soft-booked hours?

Proposed hours and soft-booked hours differ in visibility. Proposed hours are visible only to resource managers and the project manager who initiated the demand by using a resource request. Soft-booked hours are visible to anyone who has access to the Schedule Board.

## How can I see the soft-booked hours for resources on a team?

Soft bookings can made when you book a resource requirement. Resources that are soft-booked on a project team appear as team members who have soft-booked hours. They also appear on the Schedule Board.

## How do I change the required hours, and the start and end dates, for a resource (generic or named) that I booked?

After resources are booked, select **Maintain Bookings** to make any changes that are required.

## What resources types does Project Service Automation support?

**User** and **Contact** are the only resource types that are supported in Dynamics 365 Project Service Automation. Although you can create other types of resources (for example, **Equipment** and **Group**), no end-to-end use case is supported for them.

## What is the difference between an assignment and a booking?

Assignments are the assignment of resources to project tasks in the project schedule. The resources can be either real or generic resources. Bookings are the hard or soft allocation of resources to a project. Hard bookings consume a resource's capacity. Ideally, for real resources, the bookings and assignments should agree, because they don't differ. However, PSA doesn't enforce this agreement. The Reconciliation view shows a project manager places where a resource's bookings and assignments don't agree.
