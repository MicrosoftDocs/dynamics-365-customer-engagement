---
title: "Business Units FAQ for real-time marketing (Dynamics 365 Marketing) | Microsoft Docs"
description: "BU FAQ for real-time marketing in Dynamics 365 Marketing."
ms.date: 03/10/2023
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Business Units FAQ for real-time marketing

This article contains answers to common questions and solutions to known issues that can sometimes occur during the installation and management of customer journey.

### What are the key differences between Business Unit scoping support in outbound Marketing and real-time Marketing?
There are three key differences –
- After the Business Unit (BU) Scoping feature switch is turned on for real-time marketing, it can't be turned off.
- With BU scoping turned on, real-time marketing Journeys can only include/use segments, emails, SMS’, Push Messages that belong to the journey’s business unit. 
- With BU scoping turned on, real-time marketing emails, SMS Message, Templates, Content Blocks can only include/use artifacts from the same business unit.

### Why can’t I turn this feature off after it's turned on?
After BU scoping feature is turned on for real-time marketing, all the processes start relying on Business Units for segregation of the captured/generated data. For example, Consent data and Journey analytics data are segregated by business units. Turning off the feature would result in unexpected behavior across the board but most importantly in journeys.

### Would my journey target audience members from all BU in the journey owner’s business unit’s hierarchy?
No. In this release journeys and segments are strictly scoped to a single business unit and thus it can only act on the audience members that explicitly belong to the journey’s business unit. 

### What will happen to my existing journeys if I turn on this feature?
If left unedited, existing journeys continue to function as they were before and operate at the organization level. However, editing such journeys could potentially lead to validation errors because the BU scoping feature mandates the usage of segments, emails, SMSs, and push messages from the journey’s business unit alone. 

### Will BU scoping in journeys work for Customer Insights segments?
No. Customer Insights doesn’t currently support BU, so any journeys created using Customer Insights segments wouldn’t be business unit scoped.

### Why are users from one business unit able to see the analytics data of another business unit in the analytics dashboards?
There are certain areas of the product where the support for Business Units and Modernized Business Units is still being added. Analytics doesn’t currently support business units and thus any user will be able to see analytics data from any business unit, irrespective of their access. 

### I have modernized business units turned on for my environment. Can I change the business unit of any record in the marketing app?
While we have enabled support for modernized business units across most of the areas in the app, there are still some areas that see the support getting added in a later release. 

Areas that support business units but don't yet support modernized business units (that is, allowing users to modify the business unit of a record) include:
- Consent Center
- Settings > Customer engagement > Compliance
- Settings > Customer engagement > SMS providers
- Settings > Customer engagement > Custom channels
- Settings > Customer engagement > Push notifications
- Settings > Customer engagement > SMS keywords

Areas that don't yet support business units at all (that is, all records are created at the organization level) include:
- Domains 
- Audience configuration
