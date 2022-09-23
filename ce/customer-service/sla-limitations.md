---
title: "Learn the limitations of service-level agreements in Dynamics 365 Customer Service | MicrosoftDocs"
description: "Learn the limitations of service-level agreements in Dynamics 365 Customer Service."
ms.date: 09/23/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
  - intro-internal
---

# SLA limitations

The following limitations apply to the Unified Interface apps:

- The **Applicable When** and **Success Conditions** won't work as expected, if they are configured for related entities.

    - **Applicable when** conditions, if defined on the related entity, will work only for the first time when the conditions are met, and the KPI instance will be set to **In Progress**. After that, any update to the related entity won't cancel the existing KPI instance if the conditions of the same SLA item are false, nor will it create a new KPI instance if there is a change in the SLA item.
    - **Success Conditions** defined on the related entity will never be true and the KPI instance once set to **In Progress** will never succeed, even if conditions are met. It will continue to be in **In Progress**, **Nearing NonCompliance**, or **Noncompliant** status.

  To use related entities, you can add the related attribute values to the parent entity.
    
- Multiple SLA items can't be defined with the same **Applicable When** criteria and same KPI in Unified Interface SLA.
- You can’t use nested related entities with **Under**/**Not Under** operator as part of the conditions in Unified Interface SLA. Therefore, you'll need to change the **Applicable**/**Success**/**Pause** conditions to add one level of related entities only with **Under**/**Not Under** operator.
- You can’t use **Under**/**Not-Under** in direct conditions in Unified Interface SLA, so you need to use related entities when using **Under**/**Not Under** operator.

### See also

[Enable entities for service-level agreements](enable-entities-service-level-agreements.md)  
[Troubleshoot issues in SLAs](troubleshoot-sla-issues.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
