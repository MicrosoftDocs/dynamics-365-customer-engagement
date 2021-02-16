---
title: Fix an issue to delete a managed solution with an associated entity in the Customer Service Hub app | Microsoft Docs
description: See how you can delete a managed solution with an associated entity in the Customer Service Hub app
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 08/07/2018
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---
# Unable to delete a managed solution consisting of an SLA-enabled entity

## Issue

Unable to delete a managed solution that contains an entity with a service-level agreement (SLA) enabled on it. This entity has been created as part of a previously imported solution.

## Summary

Use this example to understand the issue:

1. Create a new solution in *Org1* and name it *Field solution*.
2. Create a new entity in  *Field solution* and name it *Field work*.
3. Export *Field solution* as a managed solution.
4. Import *Field solution* into a new org named *Org2*.

Next: 

1. Create another solution in *Org1* and name it *Delta Field solution*.
2. Associate the entity *Field work* with *Delta Field solution*. Enable SLA on the entity.
3. Export *Delta Field solution* as a managed solution.
4. Import *Delta Field solution* into *Org2*.

Now, if you try to delete *Delta Field solution* from Org2, you won’t be able to because it has an entity *Field work* associated with it that has SLA enabled.

## Workaround

To be able to delete *Delta Field solution* in *Org2*, delete *Field solution* first. 

*Field solution* can be deleted because the entity associated with it —*Field work*— does not have SLA enabled. Deleting *Field solution* ensures that not just the SLA configuration, but also the entity is deleted.

## Conclusion

You can’t delete a managed solution that contains an entity that has SLA enabled on it, created as part of a previously imported solution. Once enabled on an entity, SLA can’t be disabled.

To delete a managed solution with an SLA-enabled entity, you need to first delete the previously imported managed solution that created the entity entry. This ensures that the entity entry is deleted. Then, you can create the entity again or reimport the managed solution.


> [!NOTE]
> This workaround won’t work for out-of-the-box (OOB) entities because you can’t delete OOB entities or managed solutions that have OOB entities associated with them.

## More help

[Define Service Level Agreements (SLAs)](define-service-level-agreements.md)

[Entities in the Customer Service Hub](customer-service-hub-user-guide-basics.md#work-with-case-management-record-types-dashboards-and-tools)


[!INCLUDE[footer-include](../includes/footer-banner.md)]