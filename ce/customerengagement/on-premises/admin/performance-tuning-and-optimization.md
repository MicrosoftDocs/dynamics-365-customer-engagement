---
title: "Performance tuning and optimization | MicrosoftDocs"
ms.custom: 
ms.date: 09/12/2020
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 4ef042d3-fd5f-42e8-8209-0e8797ae2114
caps.latest.revision: 11
author: Mattp123
ms.author: matp
manager: kvivek
search.audienceType: 
  - admin

---
# Performance tuning and optimization

Use this information to help you plan and optimize application performance with Dynamics 365 Customer Engagement (on-premises).  

We recommend that you not run operations that require intensive database transactions concurrently. Similarly, don’t run operations that require intensive database transactions during normal business hours when users are most likely to access the system. 

Operations that require intensive database transactions examples:
- Enabling one or more language packs
- Solution import, upgrade, delete, or export
- Install or upgrade apps from [!INCLUDE [pn-microsoft-appsource](../includes/pn-microsoft-appsource.md)]
- Publishing customizations
- Large bulk record operations, such as a business unit change when the business unit has a very large number of records associated

### See also
[Verify network capacity and throughput for clients](verify-network-capacity-throughput-clients.md) <br />
[Key preparation and configuration tasks](key-preparation-and-configuration-tasks.md) <br />



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]