---
title: Linking records to Microsoft Teams channels FAQs 
description: Discover answers to common questions about Linking Dynamics 365 records to Microsoft Teams channels.
ms.date: 03/15/2024
ms.topic: troubleshooting
author: sbmjais
ms.author: shjais
ms.reviewer: shjais 
ms.owner: shujoshi
ms.custom: bap-template
---

# Linking records to Microsoft Teams channels FAQs 

## Does the tenant admin need to do anything to set up Microsoft Teams Integration

The tenant admin must provide consent for the enterprise application to be created in Microsoft Entra ID and add delegate permissions for Teams. This happens automatically when the Enhanced Collaboration Experience is enabled in the system settings of your customer engagement app.

## The documentation refers to _Microsoft 365 tenant admin permissions_. What does this mean

Microsoft 365 tenant admin permissions means the directory admin or a tenant admin.
   
## Is the activation for Dynamics 365 for all environments or per environment

Consent is given to all instances within a tenant, but the admin needs to manually enable functionality for each instance.

## What active directory privileges are given to the customer engagement apps

- **Delegated permissions**:  Group.ReadWrite.All and User.Read.All
- **Dynamics 365 Microsoft Teams Collaboration Integration (Enterprise application), permissions**:  Group.ReadWrite.All and User.Read.All

## 5. Is it enough to have only Microsoft Teams admin privileges to activate this Microsoft Teams Integration

Enabling Microsoft Teams integration has nothing to with Teams admin privileges. You need to have tenant admin permission to enable Microsoft Teams integration. 

## 6. Which Service Principle (App ID) will receive this permission

The App used for this integration, which is the customer engagement app and Microsoft Teams integration.

## 7. What happens when the consent is provided

Apart from consent, a flag is set internally in your customer engagement app that indicates the feature is enabled. The flag is also used to control user interface behavior such as showing a user the **Collaborate**  command.