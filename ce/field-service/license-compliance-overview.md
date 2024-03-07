---
title: License compliance overview
description: Verify license compliance for Dynamics 365 tables, operations, messages, and controls using Power Apps solution checker.
ms.date: 03/07/2024
ms.topic: overview
author: vhorvathms
ms.author: vhorvath
ms.reviewer: mhart
---

# License compliance overview

The solution checker in Power Apps lets makers and admins verify that you have the appropriate license for the Dynamics 365 tables, operations, messages, and controls that you use in your solutions. This feature helps provide clarity and accountability for businesses using Dynamics 365. It ensures that users are appropriately licensed and helps avoid any potential compliance issues.

For more information about the Dynamics 365 licenses and entitlements, see the [Licensing guide](https://go.microsoft.com/fwlink/?LinkId=866544&clcid=0x409).

## Use solution checker to validate your solutions

The license checking rules are part of the Power Apps solution checker. As an administrator or customizer (maker), run the solution checker on your solutions before deploying them and regularly thereafter. This practice helps ensure that you have the appropriate license for the Dynamics 365 tables, operations, messages, and controls that you're using.

[Learn more about solution checker and how to run it](/power-apps/maker/data-platform/use-powerapps-checker).

The license checking rules don't have access to the licenses in your organization. They check for the presence of any Field Service-related tables, operations, messages, and controls in your solution that require a Dynamics 365 license, regardless of whether you have the license or not. If you have the appropriate license, you can safely ignore the messages from the solution checker. If you don't have the appropriate license, either buy it or remove the flagged tables, operations, messages, and controls from your solution.

## See also

- [Use solution checker to validate your solutions](/power-apps/maker/data-platform/use-powerapps-checker)
- [Objects validated with solution checkers](license-compliance-field-service.md)
- [Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544&clcid=0x409)
- 