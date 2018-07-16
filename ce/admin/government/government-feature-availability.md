---
title: "Dynamics 365 (online) Government - Feature availability | MicrosoftDocs"
ms.custom: ""
ms.date: 07/17/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics CRM Online"
ms.assetid: 5cf2c742-d2d7-46cd-9a97-67befd696820
caps.latest.revision: 16
author: "jimholtz"
ms.author: "jimholtz"
manager: "kvivek"
---
# Dynamics 365 (online) Government - Feature availability

[!INCLUDE[cc-applies-to-update-8-2-0](../../includes/cc_applies_to_update_8_2_0.md)]

Microsoft strives to maintain functional parity between our commercially available service and that which is servicing the U.S. Government Community Cloud (GCC) customer base.  However, there are notable exceptions to this, affected by dependent service or partner-solution availability, market priorities, or compliance regulations.

At this time, preview features in the commercial offering are not available to GCC customers. This is intentional, as the GCC is a community leveraging our generally available services, further protected with heightened compliance demands of our Government and Government community customers.   

Dynamics 365 Customer Engagement for Government Community Cloud currently supports the following versions:

- Dynamics 365, version 8.2
- Microsoft Dynamics CRM Online 2016, Update 1

There are certain experiences that are currently not available within the Government Community Cloud. We continue to evaluate these for incorporation into future releases. The following generally available features are not currently available:

- Activity Logging
- AppSource (ability to install Applications directly from AppSource)
- Data Export Service
- CAFEx Integration
- Connected Field Service
- Gamification
- Home.Dynamics.com
- Insights by Inside View
- Mobile Offline
- PowerBI “Embedded” User Dashboard Experience
- Relevance Search
- Resource Scheduling Optimization
- Versium Predict

In addition, please note that it is not possible to connect to a Dynamics 365 Customer Engagement GCC environment through PowerApps.  

<a name="BKMK_NetworkPorts"></a>   

## Network ports for [!INCLUDE[pn_CRM_Online_Government_shortest](../../includes/pn-crm-online-government-shortest.md)]  
 The following ports are open for outbound connections between [!INCLUDE[pn_CRM_Online_Government_shortest](../../includes/pn-crm-online-government-shortest.md)] and internet services.  

- 80 HTTP  
- 443 HTTPS  
- 465 Secure SMTP  
- 995 Secure POP3  

  Customizations or email configurations in [!INCLUDE[pn_CRM_Online_Government_shortest](../../includes/pn-crm-online-government-shortest.md)] can only use these ports.  

### See also  
 [Microsoft Dynamics 365 (online) Government](microsoft-dynamics-365-government.md)   
 [Important changes coming in Dynamics 365 Customer Engagement](https://docs.microsoft.com/dynamics365/get-started/whats-new/customer-engagement/important-changes-coming)
