---
title: Troubleshoot an issue faced when converting an email to a case | Microsoft Docs
description: See how you can fix an issue converting an email to a case in Dynamics 365 for Customer Service
keywords: Convert email to case; Customer Service; manage cases
author: anjgupta
applies_to: Dynamics 365 (online)
ms.author: anjgup
manager: shujoshi
ms.date: 10/01/2018
ms.topic: article
ms.service: dynamics-365-customerservice
ms.assetid: e0980408-9ba0-4465-b1c2-8371e9bd8732
ms.custom: dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Issue converting an email to a case

## Issue

Incoming email is not being converted to a case.


## Troubleshooting steps

If an incoming email is not being converted to a case, verify if the automatic record creation and update rules are configured correctly.
 
If the email to case converion is still not working, follow the below troubleshooting steps to diagnose and fix the issue:

**Step 1**. Check if the email is syncing with the system.
Navigate to **Activities** and look for Email activity.</br>

**Comment**: If email is not syncing with the system, there may be an issue with the email router or server side sync configuration.

**Step 2**.  Notice that an email activity is created but a related Queueitem is not found.  </br>

**Comment**: If an active Automatic Record Creation and Update Rule exists for a specific queue, Queueitem is marked as inactive and hence post conversaion, it disappears from the Queueitem View. 


**Step 3**. If the email is coming from an unknown sender,  check for the **Create contact for unknown sender** option. Go to **Automatic Record Creation and Update Rule** configuration and check if the **Create contact for unknown sender** box is checked. </br>

**Comment**: If **Create contact for unknown sender** check box is unchecked, incoming email from unknown sender will not be converted to a case.

**Step 4**: Check if **Automatic Record Creation and Update Rule** is configured properly. Go to system jobs and check for any failure message. 
 
The following options should be enabled in an ideal email to case conversion scenario:

- **Create contact for unknown sender** box should be checked.
- Condition criteria should be set to **Any incoming email**.
- Actions:
	Create case - > Click on View properties and set the case fields as per business use case


> [!NOTE]
>  The Customer field in the case entity can be a contact or an account. If a matching incoming email address is not found for a contact or an account, and **Create contact for unknown sender** box is checked, the system creates contact for incoming email address and links it to the case's customer field.

**Step 5**: Check if the contact and account exist with the same incoming email address. 
**Comment**: Case created from incoming email will resolve customer field on case as Account.

## Issue scenarios and resolution

Given below is a list of some common issue scenarios and their resolutions, where the configuration went wrong and the system failed to create a case.

#### Scenario 1

#### Scenario 2

#### Scenario 3


## Validation steps

You must validate the configuration and validation steps given in the following table to understand the main cause of the issue:


|Option in Automatic Record Creation and Update Rule in Service Management  |If selected as  |Validation steps  |Outcome  |
|---------|---------|---------|---------|
|Create a case if a valid entitlement exists for the customer     |  Yes     |  Validate that an active entitlement exists for the customer. Valid active entitlement is evaluated as below:  </br> - If the sender of the email is a contact with a parent account, then Dynamics 365 creates a case if the contact’s parent account has a valid entitlement, and the contact is listed in the Contacts section of the entitlement </br> OR </br> - If the Contacts section is empty (which means that the entitlement is applicable to all contacts for the customer) |   A case is created      |
|Create a case from an email sent by unknown senders     |   Yes       |        For any incoming email from an unknown sender |     - A case is created </br>  - A contact is also created for the unknown sender|
|     |   Yes      |    For an incoming email with email address of inactive account or contact     |   - A case is created </br> - An inactive account or contact is activated|
|     |   No      |     For an incoming email with email address of active account or contact   |  A case is created       |
|    |     No    |      For an incoming email sent by record type other than account or contact   |    No case is created     |
|  |   No      |     For an incoming email with email address of inactive account or contact    |  No case is created           |
|Create a case for activities associated with a resolved case     |    Yes     |   For an incoming email related to a resolved case      |    A case is created     |
|   |    Yes      |   For an incoming email related to an active case         |   No case is created      |
|  |         |         |         |

 
## More help

[Automatically create a case from an email](automatically-create-case-from-email.md)
