---
title: Fix an issue to delete a solution with an associated entity in the Customer Service Hub app | Microsoft Docs
description: See how you can delete a solution with an associated entity in the Customer Service Hub app
keywords: Customer Service Hub; delete solution; SLA associated with an entity; managed solution
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
# Cannot delete a managed solution consisting an SLA enabled entity

## Issue

Unable to delete a managed solution which consists an entity, and the entity has SLA enabled on it.

## Summary

Refer the example given below to understand the issue:

1. Create a new solution in *Org1* and call it as *Field solution*
2. Create a new entity in  *Field solution* and call it as *Field work1*
3. Export *Field solution* as a managed solution
4. Import *Field solution* in to a new org called *Org2*

Then, 

1. Create another solution in *Org1* and call it as *Delta Field solution*
2. Associate another entity *Field work2* with *Delta Field solution*  and enable SLA on it
3. Export *Delta Field solution* as a managed solution
4. Import *Delta Field solution* in to the new org *Org2*

Now, if you try to delete *Delta Field solution* from *Org2*, you will not be able to delete it. This is because it has an entity associated called *Field work2*, which has SLA enabled on it. 

## Workaround

To be able to delete *Delta Field solution* in *Org2*, delete *Field solution* first. 

*Field solution* can be deleted as the entity associated with it (*Field work1*) does not have SLA enabled.

## Conclusion

An entity which has SLA enabled cannot be deleted. You cannot delete a managed solution which consists an entity that has SLA enabled on it. Also, SLA once enabled on an entity cannot be disabled.

To delete an SLA enabled entity and to eventually delete a managed solution with an SLA enabled entity, you need to delete the managed solution where the entity doesnot have an SLA enabled. 

> [!NOTE]
> This workaround will not work for out-of-the-box entities as you cannot delete out-of-the-box entities.

## More help

[Define Service Level Agreements (SLAs)](define-service-level-agreements.md)

[Entities in the Customer Service Hub](customer-service-hub-user-guide-basics.md#work-with-case-management-record-types-dashboards-and-tools)