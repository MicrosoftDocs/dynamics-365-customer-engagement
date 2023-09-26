---
title: Dynamics 365 Sales license checker rules
description: Verify and ensure that you have the appropriate Dynamics 365 license with the Dynamics 365 license checker.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: reference
ms.topic: conceptual
ms.collection: get-started
ms.date: 09/26/2023
---

# Dynamics 365 Sales license checker rules

This article describes the rules in the Power Apps solution checker that identifies the entities, operations, and controls that require a Dynamics 365 Sales license.

## meta-license-sales-premium-sdkmessages

This rule runs on your plugins and checks for the presence of the SDK messages/operations that require a Dynamics 365 Sales license.  

### Recommendation

Ensure that you have the appropriate Dynamics 365 Sales license to use the restricted SDK messages or remove them from your plugin. For a list of SDK messages that require a Dynamics 365 Sales license, see [Entities and operations that require a license](license-enforcement.md#entities-and-operations-that-require-a-license).

## meta-license-sales-premium-entity-operations

This rule runs on your solution and checks for the presence of the entities and operations that require a Dynamics 365 Sales license.

### Recommendation

Ensure that you have the appropriate Dynamics 365 Sales license to use the restricted entities and operations or remove them from your solution. For a list of entities and operations that require a Dynamics 365 Sales license, see [Entities and operations that require a license](license-enforcement.md#entities-and-operations-that-require-a-license).

## meta-license-sales-premium-customcontrols

This rule runs on your solution and checks for the presence of the controls that require a Dynamics 365 Sales license.

### Recommendation

Ensure that you have the appropriate Dynamics 365 Sales license to use the restricted controls or remove them from your solution. For a list of controls that require a Dynamics 365 Sales license, see [Controls that require a license](license-enforcement.md#controls-that-require-a-license).