---
title: License compliance overview
description: Verify license compliance for Dynamics 365 tables, operations, messages, and controls using Power Apps solution checker.
ms.date: 03/30/2024
ms.topic: overview
author: vhorvathms
ms.author: vhorvath
ms.reviewer: mhart
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:02/26/2024
---

# License compliance overview

Use the Power Apps solution checker to verify that you have the appropriate license for the Dynamics 365 tables, operations, messages, and controls that you use in your solutions. This feature provides an added level of clarity and accountability for businesses using Dynamics 365. It ensures that customers are paying for what they're using and helps avoid any potential compliance issues.

For more information about the Dynamics 365 licenses and entitlements, see the [Licensing guide](https://go.microsoft.com/fwlink/?LinkId=866544&clcid=0x409).

## Use solution checker to validate your solutions

The license checking rules are part of the Power Apps solution checker. As an administrator or customizer (maker), run the solution checker on your solutions before deploying them and regularly thereafter. This practice helps ensure that you have the appropriate license for the Dynamics 365 tables, operations, messages, and controls that you're using. [Learn more about solution checker and how to run the same](/power-apps/maker/data-platform/use-powerapps-checker).

The license checking rules don't have access to the licenses in your organization. They check for the presence of any Field Service-related tables, operations, messages, and controls in your solution that require a Dynamics 365 license, regardless of whether you have the license or not. If you have the appropriate license, you can safely ignore the messages from the solution checker. If you don't have the appropriate license, either buy it or remove the flagged tables, operations, messages, and controls from your solution.

The following sections include the list of Dynamics 365 tables, operations, and controls that the license checking rules check for. The list is subject to change as we add more tables, operations, and controls to the licensed usage list.

## Tables and operations that require a license

The following table lists tables and the corresponding operations that require an appropriate Dynamics 365 Field Service license. When you run the solution checker on your solution, it checks for the presence of restricted tables and operations, and displays a message about the usage of restricted tables and operations. For more information about the required license, see the [Licensing guide](https://go.microsoft.com/fwlink/?LinkId=866544&clcid=0x409).

| Tables                     | Operations                                                                 |
|----------------------------|----------------------------------------------------------------------------|
| msdyn_workorder            | Create, update, delete                                                     |

## Controls that require a license

The following list includes controls that that require a Dynamics 365 Field Service license. When you run the solution checker on your solutions, it checks for the presence of these controls and displays a message about the usage of restricted controls.

| Control ID                                                      | Control Name                                      |
|-----------------------------------------------------------------|---------------------------------------------------|
| Control .ID              | Display name                        |

## See also

[Use solution checker to validate your solutions](/power-apps/maker/data-platform/use-powerapps-checker)  