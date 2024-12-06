---
title: SLA limitations
description: Learn the limitations of service-level agreements in Dynamics 365 Customer Service.
ms.date: 09/04/2024
ms.topic: article
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
ms.collection: get-started
---

# SLA limitations

The following limitations apply to SLAs created in Unified Interface apps:

- The **Applicable When** and **Success Conditions** don't work as expected if they're configured for related entities.

    - The **Applicable When** conditions, if defined on the related entity, work only the first time the conditions are met, and the KPI instance is set to **In Progress**. After that, any update to the related entity won't cancel the existing KPI instance if the conditions of the same SLA item are false. The update doesn't create a new KPI instance if there's a change in the SLA item.
    - The **Success Conditions** defined on the related entity won't ever be true and the KPI instance once set to **In Progress** won't succeed, even if conditions are met. It continues to be in **In Progress**, **Nearing NonCompliance**, or **Noncompliant** status.

    To use related entities, you can add the related attribute values to the parent entity.
    
- You can't define multiple SLA items with the same **Applicable When** criteria and KPI.
- You can’t use nested related entities with the **Under** or **Not Under** operator as part of the conditions for SLAs. So, you need to change the **Applicable When**, **Success**, and **Pause** conditions to add one level of related entities only with the **Under** or **Not Under** operator.
- You can’t directly use the **Under** or **Not-Under** operator as conditions when configuring **Applicable When** or **Success** conditions for SLA items, so use related entities when using the **Under** or **Not Under** operator.
- We recommend that you don't use the **Modified On** field in the target entity while configuring **Applicable When** or **Success** conditions of SLA items or as the **Applicable From** field of SLA KPI instances. Changes to the **Modified On** field in the target entity might not initiate SLAs and might result in incorrect updates to SLA KPI instances.
- For expired SLAs, even if the success criteria is met, the SLA success date isn't available because the SLA KPI Instance doesn't have a field that can display the date of the action.
- Out of the box, you can’t retrieve data for SLA related case fields, such as **Active Duration** and **Elapsed Time**.
- You can't edit or remove an SLA that's already assigned to a case. However, you can customize how SLAs can be assigned to other cases and pause the SLA timer.
- You can’t manually update SLA time.
- If you're migrating more than 1000 SLAs, they might not pass the premigration checkup that processes all legacy SLAs. You can use the **&flags=FCB.SkipPreMigrationCheckUp=true** flag in the URL to skip the premigration checkup. To access the URL, go to **Miscellaneous** **>** **ARC and SLA migration** in the Customer Service admin center site map.

### Related information

[Enable entities for service-level agreements](enable-entities-service-level-agreements.md)  
[Troubleshoot issues in SLAs](../troubleshoot-sla-issues.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
