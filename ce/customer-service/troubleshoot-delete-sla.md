---
title: Fix an issue to disable sla associated with an entity in the Customer Service Hub app | Microsoft Docs
description: See how you can disable an sla associated with an entity in the Customer Service Hub app
keywords: Customer Service Hub; delete SLA; SLA associated with an entity; managed solution
author: anjgupta
applies_to: Dynamics 365 (online) 
ms.author: anjgup
manager: shujoshi
ms.date: 08/03/2018
ms.topic: article
ms.service: dynamics-365-customerservice
ms.assetid: 7453a275-9317-496b-9fea-efb6319cb39e
ms.custom: dyn365-customerservice
---
# Cannot disable an SLA enabled on an entity in a managed solution

## Issue

When an entity with SLA enabled is exported as a managed solution from one org and is imported in another org, the SLA cannot be disabled for the entity. This is applicable for both custom entities and out-of-the-box entities.

The issue can be further explained with the help of the following example:

Suppose, you have an entity called *Field work* created in one of your orgs. SLA is enabled on *Field work*. When you export *Field work* as a managed solution and import it in another org, you cannot disable SLA on *Field work*. 

## Workaround

SLA once enabled on an entity cannot be disabled. However, you can delete the entity and recreate it to have an entity which doesn't have SLA enabled. 

So, for the above example, you can delete *Field work* (has SLA enabled) and create another entity with SLA disabled.

> [!NOTE]
> This workaround will not work for out-of-the-box entities as you cannot delete out-of-the-box entities.


## More help

[Define Service Level Agreements (SLAs)](define-service-level-agreements.md)

[Entities in the Customer Service Hub](customer-service-hub-user-guide-basics.md#work-with-case-management-record-types-dashboards-and-tools)