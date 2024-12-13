---
title: Reopen a resolved case in Dynamics 365 Customer Service
description: Learn how to reopen a resolved case instead of creating a new case for an incoming email activity in Dynamics 365 Customer Service.
author: snehasishlaik 
ms.author: sdas 
ms.reviewer: sdas
ms.topic: how-to 
ms.collection: 
ms.date: 12/13/2024
ms.custom: bap-template 
---


# Reopen a resolved case

By default, Dynamics 365 Customer Service supports creating records from an incoming email. Learn more about creating and configuring records in [Automatically create or update records](automatically-create-update-records.md).


This article explains how you can customize the Power Automate flow to monitor incoming emails for a resolved case and then reopen a resolved case. You can do this by adding a conditional rule item to an existing automatic record creation rule.

> [!NOTE]
> The customization doesn't work if you are trying to [create multiple cases from an email sent to multiple mailboxes](arc-multiple-cases.md#enable-creation-of-multiple-cases-from-an-email-sent-to-multiple-mailboxes).


## Create the resolved condition for an incoming email activity

Perform the following steps to create a new condition that checks if the incoming email is related to a resolved case.

1.  In the Customer Service admin center, go to the **Automatic record creation and update rules** and then select **Email to case - create new case** to edit the rule.

1. Go to the **Condition builder** tab and complete the following fields in the **Condition** panel.

    - **Condition name**: Enter an intuitive name for the condition.
    - **Condition that must pass to continue**: Select the **+Add** button to add a condition that checks if the incoming email is regarding a case that is in a **Resolved** state. 
        - Select the first condition field as **Regarding(Case)** and the function as **Contains data** from the dropdown.
        - Select the next dropdown after **And node** to add another condition.
        - Select the second condition field as **Status(Case)**, the next field as **Equals**, and the last field as **Resolved**.

1. Go to the **Actions to take** panel and select **Save and open Power Automate**. The Power Automate flow of the second rule item opens.


## Set the order of the rule item

Perform the following steps to set the right order for the new condition in Power Automate.

1. Open the Power Automate flow for the second rule item.

1. Select the **ellipsis** next to the existing **Create new case and update email** rule and select **Update**.

1. Select a **Table name (Cases)** from the drop-down list and set the value for **Row ID** value as **Regarding (Value)**.

1. Select a **Table name** (for example, Cases) from the dropdown and search for **Regarding (Value)** to add to the **Row ID** field.

1. Select **Show advanced options** at the bottom and select the **Status** as **Active**.

    > [!NOTE]
    > - Make sure the **reopen resolved case** rule item appears above the **create new case** rule in the **Step two: conditions to evaluate and actions to take** page, so it is evaluated first.
    > - Make sure the setting for **Wait for a specific amount of time after the connected case has been resolved** is set to **Yes** in Advanced settings tab of the **Rule 1 - Record Creation and Update Rule** page. There is no need to provide a time for the **Select the amount of time** field.
1. Select **Save**. 

1. On the **Record Creation and Update Rule** page, select **Activate**.



## Related information
 
[FAQ on activity monitor](arc-faqs.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]