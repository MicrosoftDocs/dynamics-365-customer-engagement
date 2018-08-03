---
title: Fix an issue to delete a managed solution with an associated entity in the Customer Service Hub app | Microsoft Docs
description: See how you can delete a managed solution with an associated entity in the Customer Service Hub app
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
# Unable to delete a managed solution consisting an SLA enabled entity

## Issue

Unable to delete a managed solution which consists an entity with SLA enabled on it. This entity has been created as part of solution imported previously.

## Summary

Refer the example given below to understand the issue:

1. Create a new solution in *Org1* and call it as *Field solution*
2. Create a new entity in  *Field solution* and call it as *Field work*
3. Export *Field solution* as a managed solution
4. Import *Field solution* into a new org called *Org2*

Then, 

1. Create another solution in *Org1* and call it as *Delta Field solution*
2. Associate the entity *Field work* with *Delta Field solution*. Enable SLA on the entity
3. Export *Delta Field solution* as a managed solution
4. Import *Delta Field solution* into the org *Org2*

Now, if you try to delete *Delta Field solution* from *Org2*, you will not be able to delete it. This is because it has an entity *Field work* associated with it which has SLA enabled. 

## Workaround

To be able to delete *Delta Field solution* in *Org2*, delete *Field solution* first. 

*Field solution* can be deleted as the entity associated with it i.e. *Field work* does not have SLA enabled. Deleting *Field solution* ensures that not just the SLA configuration, but the entity is also deleted.

## Conclusion

You cannot delete a managed solution which consists an entity that has SLA enabled on it, created as a part of previously imported solution. SLA once enabled on an entity cannot be disabled.

To delete a managed solution with an SLA enabled entity, you need to first delete the previously imported managed solution which created the entity entry. This ensures that the entity entry is deleted. Now, you can create the entity again or re-import the managed solution. 

> [!NOTE]
> This workaround will not work for out-of-the-box (OOB) entities as you cannot delete OOB entities or managed solutions which have OOB entities associated with them.

## More help

[Define Service Level Agreements (SLAs)](define-service-level-agreements.md)

[Entities in the Customer Service Hub](customer-service-hub-user-guide-basics.md#work-with-case-management-record-types-dashboards-and-tools)