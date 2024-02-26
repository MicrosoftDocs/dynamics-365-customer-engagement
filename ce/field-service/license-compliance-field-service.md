---
title: Check dynamics 365 license with solution checker
description: Learn about the rules in the Power Apps solution checker that identify tables, operations, and UI components requiring a Dynamics 365 license.
author: vhorvath-msft
ms.author: vhorvath
ms.reviewer: mhart
ms.topic: conceptual
ms.collection: get-started
ms.date: 01/10/2024
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/10/2023
  - ai-gen-title
---

# Check dynamics 365 license with solution checkers

This article describes the rules in the Power Apps solution checker that identifies the tables, operations, and UI components/controls that require a Dynamics 365 license.

## rule name

This rule runs on your solutions and checks for the plugin registrations with restricted SDK messages/operations that require an appropriate Dynamics 365 license. 

### Recommendation

Ensure that you have the appropriate Dynamics 365 license to use the restricted SDK messages or remove them from your solution. For a list of SDK messages that require a Dynamics 365 license, see [Tables and operations that require a license](license-enforcement.md#tables-and-operations-that-require-a-license).

