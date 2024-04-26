---
title: License compliance overview
description: Verify license compliance for Dynamics 365 tables, operations, messages, and controls using Power Apps solution checker.
ms.date: 03/19/2024
ms.topic: overview
author: vhorvathms
ms.author: vhorvath
ms.reviewer: mhart
---

# License compliance overview

[Solution checker](/power-apps/maker/data-platform/use-powerapps-checker) is an existing Power Apps capability that gives makers the ability to analyze their solutions, identifying potential issues and patterns against a predefined set of rules. With the latest enhancements, this tool now empowers makers to pinpoint tables, SDK operations, and UI controls requiring a Dynamics 365 license through a newly introduced category named "license." The license-checking rules aren't aware of user licenses within your organization. Instead, solution checker simply verifies the presence of any Field Service-related components in your solution that require a Dynamics 365 license. Should your users possess the appropriate license, you might disregard the messages from the solution checker. However, if your users lack the necessary license, your options include acquiring the license or removing the flagged components from your solution.

[Learn more about solution checker and how to run it](/power-apps/maker/data-platform/use-powerapps-checker).

For more information about the Dynamics 365 licenses and entitlements, see the [Licensing guide](https://go.microsoft.com/fwlink/?LinkId=866544&clcid=0x409).

## Field Service rules  

The rules provided highlight those that are specific to Field Service. For more information on the tables, operations, and UI controls, see [Objects validated by the solution checker](license-compliance-field-service.md).

### meta-license-fieldservice-sdkmessages

This rule runs on your solutions and checks for the plugin registrations with restricted SDK messages/operations that require an appropriate Dynamics 365 license.

### Recommendation

Ensure that you have the appropriate Dynamics 365 license to use the restricted SDK messages or remove them from your solution. For a list of SDK messages that require a Dynamics 365 license.

### meta-license-fieldservice-entity-operations

This rule runs on your solution and checks for the presence of tables with restricted SDK messages/operations that require a Dynamics 365 license.

### Recommendation

Ensure that you have the appropriate Dynamics 365 license to use the restricted operations on the tables or remove them from your solution. For a list of tables and operations that require a Dynamics 365 license.

### meta-license-fieldservice-customcontrols

This rule runs on your solution and checks for the presence of the controls that require a Dynamics 365 Field Service license.

### Recommendation

Ensure that you have the appropriate Dynamics 365 Field Service license to use the restricted controls or remove them from your solution. For a list of controls that require a Dynamics 365 Field Service license.

## See also

- [Use solution checker to validate your solutions](/power-apps/maker/data-platform/use-powerapps-checker)
- [Objects validated with solution checkers](license-compliance-field-service.md)
- [Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544&clcid=0x409)
