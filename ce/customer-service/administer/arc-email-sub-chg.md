---
title: Create a new case when email subject changes
description: Define whether a new case should be created when the email subject changes on a reply or a forwarded email with regex expressions.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: how-to
ms.collection:
ms.date: 11/01/2023
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/09/2023
  - ai-gen-title
---

# Create a new case when email subject changes

When a customer replies to an email after modifying or removing the content in the subject, a new case isn't created in Dynamics 365. This behavior happens because the InReplyTo value of the reply email matches the messageID of the previous email that’s already in Dynamics 365. This creates an email correlation, and the case associated with the previous email is linked with the reply email. As a result, the automatic record creation and update rule skips the case creation, even if the subject changes.

Administrators can use regex expressions to define whether a new case should be created when the email subject changes on a reply or a forwarded email that has a related active or resolved case.

This topic describes the customization steps that you can perform to create a new case when an email subject changes.

## Prerequisites

Make sure to enable the **Skipped** and **Ready for Power Automate** monitored options for the activity monitor in the Customer Service admin center app. More information: [Use activity monitor to review and track rules](manage-activity-arc.md)

## How it works

A new default Boolean field, named correlatedsubjectchanged, is available for the email entity. The field is populated as true or false for inreplyto-correlated emails, and detects changes in the subject field of the email. A default regex is available that ignores the prefixes **Re:**, **re:**, or **RE:** in the email response, and then compares the subject with the correlated email’s subject. If the subject matches, the Boolean value, correlatedsubjectchanged, is set to false. 

However, the default regex doesn’t ignore the prefixes **Fw:**, **FW:**, or **FWD:** in the forwarded email, so the Boolean value, correlatedsubjectchanged, is set to true in these cases, and if an email is forwarded, a new case is created. You can customize the default regex if it doesn't match your requirements. You can write regex expressions for multiple languages. For more information, go to [Regular Expression Language - Quick Reference](/dotnet/standard/base-types/regular-expression-language-quick-reference). To edit the regex, use the OrgDbOrgSetting tool and follow the [guidance](https://github.com/seanmcne/OrgDbOrgSettings).

## Customization steps to create a new case

To define whether automatic record creation and update rules must create a new case, you can add a condition to check if the correlatedsubjectchanged field is true and create a case by performing the customization steps:

1. Go to https://make.powerautomate.com/ and select the environment in which you have automatic record creation and update rules configured.

1. Navigate to **My flows** from the site map, and then select **+New flow** > **Automated Cloud flow**.

    If using custom roles, the owner of the flow must have read/write/delete privileges to the activity monitor entity. The CSR manager and system administrator roles have the required privileges by default.

1. Name the flow, and then select the **When a row is added, modified or deleted** trigger.

1. Select **Create**.

1. Create a custom flow that is triggered when case creation is skipped for an email and there's an entry in the activity monitor table with the **Skipped** state.

1. Check for the email subject change within the flow and execute automatic record creation and update rules child flow to create the case.
    
    1. Select the following values for the fields:
        
        - Change type: **Added**
        - Table name: **Activity monitors**
        - Scope: **Organizations**
        - Run as: **Modifying user**
        - Filter rows: The reason can be adjusted according to your business requirements. For example, currentstate eq 3 refers to the **Skipped** activity monitor state, and the reason can be any of the following:
            
            - An existing entity is already connected with this record.
            - An active case is already connected with this record.
            - A resolved case is already connected with this record.
            - The rule requires a connected case to be resolved for a specific amount of time before creating a new one. This connected case has been resolved for less than the amount of time selected.

    1. Retrieve the email record. Enter **RowID** as **Monitored activity item (Value)**.
    
    1. Add a conditional check to verify whether the correlatedsubjectchanged attribute is set to true and proceed only if yes; otherwise, cancel. If you have complex conditional logic, we recommend that you write your logic in an unbound custom action that gives certain simple structured output, such as Boolean. Check the Boolean value and define case creation based on condition.
    
    1. Update the activity monitor status. If the correlatedsubjectchanged attribute is set to true from step 6c (subject doesn't match), update the current state of that activity monitor ID to **Ready for Power Automate**, and then set the **Reason** to **blank**.
    
    1. Continue executing automatic record creation and update rules and create case. Perform an unbound action and add the fields as shown in the screenshot.
    
        :::image type="content" source="../media/arc_sub_change.png" alt-text="Screenshot describes the email subject change flow."lightbox="../media/arc_sub_change.png":::
        
    By performing the steps, the automatic record creation and update rule can be conditionally bypassed (based on email subject change condition) and a new case can be created.
