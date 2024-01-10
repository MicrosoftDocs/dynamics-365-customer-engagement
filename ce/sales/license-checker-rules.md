---
title: Dynamics 365 Sales license checker rules
description: Identify Sales license requirements for tables, operations, and UI components/controls with the license checker.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: reference
ms.topic: conceptual
ms.collection: get-started
ms.date: 01/10/2024
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/10/2023
---

# Dynamics 365 license checker rules

This article describes the rules in the Power Apps solution checker that identifies the tables, operations, and UI components/controls that require a Dynamics 365 license.

## meta-license-sales-sdkmessages

This rule runs on your solutions and checks for the plugin registrations with restricted SDK messages/operations that require an appropriate Dynamics 365 license. 

### Recommendation

Ensure that you have the appropriate Dynamics 365 license to use the restricted SDK messages or remove them from your solution. For a list of SDK messages that require a Dynamics 365 license, see [Tables and operations that require a license](license-enforcement.md#tables-and-operations-that-require-a-license).

## meta-license-sales-entity-operations

This rule runs on your solution and checks for the presence of tables with restricted SDK messages/operations that require a Dynamics 365 license.

### Recommendation

Ensure that you have the appropriate Dynamics 365 license to use the restricted operations on the tables or remove them from your solution. For a list of tables and operations that require a Dynamics 365 license, see [Tables and operations that require a license](license-enforcement.md#tables-and-operations-that-require-a-license).

## meta-license-sales-customcontrols

This rule runs on your solution and checks for the presence of the controls that require a Dynamics 365 Sales license.

### Recommendation

Ensure that you have the appropriate Dynamics 365 Sales license to use the restricted controls or remove them from your solution. For a list of controls that require a Dynamics 365 Sales license, see [Controls that require a license](license-enforcement.md#controls-that-require-a-license).
