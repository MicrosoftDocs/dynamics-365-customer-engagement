---
title: Business units FAQs for real-time marketing
description: Business units FAQ for real-time marketing in Dynamics 365 Marketing.
ms.date: 07/27/2023
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Business units FAQs for real-time marketing

[!INCLUDE[consolidated-sku-rtm-only](../includes/consolidated-sku-rtm-only.md)]

This article contains answers to common questions and solutions to known issues related to business units in real-time marketing.

### What are the key differences between business unit scoping support in outbound marketing and real-time marketing?

There are three key differences:
1. After the business unit scoping feature switch is turned on for real-time marketing, it can't be turned off.
1. With business unit scoping turned on, real-time marketing journeys can only include/use segments, emails, SMS messages, and push messages that belong to the journey’s business unit.
1. With business unit scoping turned on, real-time marketing emails, SMS messages, templates, and content blocks can only include/use artifacts from the same business unit.

### Why can’t I turn this feature off after it's turned on?

After the business unit scoping feature is turned on for real-time marketing, all processes start relying on business units for segregation of the captured/generated data. For example, consent data and journey analytics data are segregated by business units. Turning off the feature would result in unexpected behavior across the board but most importantly in journeys.

### Would my journey target audience members from all business units in the journey owner’s business unit’s hierarchy?

No. In this release journeys and segments are strictly scoped to a single business unit and thus the journey can only act on the audience members that explicitly belong to the journey’s business unit. 

### What will happen to my existing journeys if I turn on this feature?

If left unedited, existing journeys continue to function as they were before and operate at the organization level. However, editing such journeys could potentially lead to validation errors because the business unit scoping feature mandates the usage of segments, emails, SMS messages, and push messages from the journey’s business unit alone. 

### After enabling business units, what happens to a live journey if the owner or the owner's business unit changes?

The scoping business unit on a **Live** journey does not change even if the owner of the journey changes or if the business unit of the owner changes. If you edit a **Live** journey and publish a new version, the *new* journey version will take the current value of the business unit of the journey owner at the time of publication for scoping purposes. The previous version of the journey, however, retains the original business unit scoping.

### Will business unit scoping in journeys work for Customer Insights segments?

No. Customer Insights doesn’t currently support business units, so any journeys created using Customer Insights segments won’t be business unit scoped.

### Why are users from one business unit able to see the analytics data of another business unit in the analytics dashboards?

There are certain areas of the product where the support for business units and modernized business units is still being added. Analytics doesn’t currently support business units and thus any user will be able to see analytics data from any business unit, irrespective of their access. 

### I have modernized business units turned on for my environment. Can I change the business unit of any record in the marketing app?

While there is support for modernized business units across most of the areas in the app, there are some areas that won't be supported until a later release.

Areas that support business units but don't yet support modernized business units (that is, allowing users to modify the business unit of a record) include:
- Consent center
- Settings > Customer engagement > Compliance
- Settings > Customer engagement > SMS providers
- Settings > Customer engagement > Custom channels
- Settings > Customer engagement > Push notifications
- Settings > Customer engagement > SMS keywords

Areas that don't yet support business units at all (that is, all records are created at the organization level) include:
- Domains 
- Audience configuration

[!INCLUDE[footer-include](../includes/footer-banner.md)]
