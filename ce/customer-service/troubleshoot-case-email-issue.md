---
title: Fix an issue converting an email to a case | Microsoft Docs
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


## Troubleshoot

If an incoming email is not being converted to a case even after configuring automatic record creation and update rules, validate the configurations and validation steps given in the following table:


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
