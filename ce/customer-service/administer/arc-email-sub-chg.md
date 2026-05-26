---
title: Create a new case when email subject changes
description: Define whether a new case should be created when the email subject changes on a reply or a forwarded email with regex expressions.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: how-to
ms.collection:
ms.date: 05/26/2026
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/09/2023
  - ai-gen-title
---

# Create a new case when email subject changes

When a customer changes or removes the subject in an email reply, Dynamics 365 associates the email with the existing case instead of creating a new one. This behavior occurs because the **InReplyTo** value of the reply email matches the **messageID** of an existing email, which maintains email correlation and associates the reply with the existing case. As a result, the automatic record creation and update rules don't create a new case, even if the subject changes.

Administrators can use regex expressions to define whether a new case should be created when the email subject changes on a reply or a forwarded email that has a related active or resolved case.

The article describes the customization steps that you can perform to create a new case when an email subject changes.

## Prerequisites

Enable the **Skipped** and **Ready for Power Automate** monitored options for the activity monitor in the Copilot Service admin center app. Learn more in [Use activity monitor to review and track rules](manage-activity-arc.md).

## How it works

A new default Boolean field, named correlatedsubjectchanged, is available for the email entity. The field is populated as true or false for inreplyto-correlated emails, and detects changes in the subject field of the email. A default regex is available that ignores the prefixes **Re:**, **re:**, or **RE:** in the email response, and then compares the subject with the correlated email’s subject. If the subject matches, the Boolean value, correlatedsubjectchanged, is set to false.

However, the default regex doesn’t ignore the prefixes **Fw:**, **FW:**, or **FWD:** in the forwarded email, so the Boolean value, correlatedsubjectchanged, is set to true in these cases, and if an email is forwarded, a new case is created. You can customize the default regex if it doesn't match your requirements. You can write regex expressions for multiple languages. Learn more in [Regular Expression Language - Quick Reference](/dotnet/standard/base-types/regular-expression-language-quick-reference). To edit the regex, use the OrgDbOrgSetting tool and follow the [guidance](https://github.com/seanmcne/OrgDbOrgSettings).

## Customization steps to create a new case

To define whether automatic record creation and update rules create a new case, add a condition that checks whether the correlatedsubjectchanged field is set to true.

If the value is true, configure the rule to create a new case by performing the following customization steps:

1. Go to https://make.powerautomate.com/ and select the environment in which you have automatic record creation and update rules configured.

1. From the site map, navigate to **My flows**, and then select **+New flow** > **Automated Cloud flow**.

    If using custom roles, the owner of the flow must have read/write/delete privileges to the activity monitor entity. The CSR manager and system administrator roles have the required privileges by default.

1. Name the flow, and then select the **When a row is added, modified, or deleted** trigger.

1. Expand **Advanced Options**.

1. Select the following values for the fields:

    - Change type: **Added**
    - Table name: **Activity monitors**
    - Scope: **Organizations**
    - Filter rows: The reason can be adjusted according to your business requirements. For example, currentstate eq 3 and (reason eq2 or reason eq3 or reason eq 4 or reason eq5).
    - Run as: **Modifying user**

1. Add a new step and select the **Get a row by ID** Dataverse action.
1. Select the following values for the fields:

    - Table name: **Email messages**
    - Enter **RowID** as **Monitored activity item (Value)**.

1. Add a new step and select **Initialize variable**.
1. Select the following values for the fields:
    - Name: **Queue Item Id**
    - Type: **String**
    - Value: **json(triggerOutputs()?['body/advancedsettings'])['queueitemid']**

1. Add a new step and select **Condition**.
1. For the first value select **Correlated subject changed**, **is equal to**, **true**.
1. Add an action in the **If yes** path.
1. Select the **Update a row** Dataverse action.
1. Select **Show advanced options**.
1. Select the following values for the fields:
    - Table Name: **Activity monitors**
    - Row ID: **Activity monitor id**
    - Current state: **Ready for Power Automate**
1. In the **If Yes** path, select **Add an action**.
1. Select the **Perform an unbound action** Dataverse action.
1. Select the following values for the fields:
    - Action Name: **msdyn_ExecuteARC**
    - CreatedEntityReference: **queueitems(@{variables('Queue Item Id')})**
    - Rule ID: **Rule Name (Value)**
1. Save the flow.
