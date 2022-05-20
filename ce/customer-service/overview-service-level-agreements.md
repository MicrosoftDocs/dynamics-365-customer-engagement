---
title: "Overview of service-level agreements | MicrosoftDocs"
description: "Learn what are service-level agreements in Dynamics 365 Customer Service."
ms.date: 05/20/2022
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

# Overview of service-level agreements

Service-level agreements (SLAs) enable businesses to track support policies and ensure customers are being supported per the support policy to which they are entitled. Businesses use SLAs to govern support products that customers either receive as part of their purchase or add on to their purchase. What SLAs include are policy details such as how quickly a customer is entitled to receive support, how many support requests a customer can make, and how long after purchases a customer can be supported as part of the agreement.

You can define the level of service or support that your organization agrees to offer to a customer by using SLAs in Dynamics 365 Customer Service. Providing support based on service levels ensures that you're delivering measured and predictable service.

You can associate an SLA with an entitlement, so that when an entitlement is added to a case, the associated SLA is also applied. You can only associate SLAs that are created for the Case entity with entitlements. More information: [Create entitlements to define support terms](create-entitlement-define-support-terms-customer.md#create-entitlements-to-define-support-terms). You can also enable SLA for entities other than case. More information: [Enable entities for service level agreements](enable-entities-service-level-agreements.md#enable-entities-for-service-level-agreements).

Alternatively, you can set up a default SLA for the organization. More information: [Set an SLA as the default](define-service-level-agreements.md#set-an-sla-as-the-default).

## Benefits of service-level agreements

### Tracking

   - You can create SLA KPIs with target times by setting up customer holiday schedules or customer service schedules to calculate business hours to be considered during time calculation. 
   
  - You can also enable recalculation of SLAs, providing agents with sufficient time to work on their services. More information: [Enable recalculation of SLAs on reaching terminal status](enable-sla-recalculation.md#enable-recalculation-of-slas-on-reaching-terminal-status).
  
  - After you've configured the SLA KPIs, SLAs, and SLA items for an entity, you can add the SLA Timer control to display the SLA KPIs that are configured for the entity. You can customize the views to filter the KPIs and display only the relevant KPIs to agents. More information: [Add a timer control for SLA-enabled entities](add-timer-control-case-form-track-time-against-sla.md#add-a-timer-control-for-sla-enabled-entities). This helps agents monitor their service level performance and meet their service level goals.

### Prioritization

 You can define the set of conditions based on which KPIs are applied to a case, or the set of actions to take as a warning or in case of an SLA breach. More information: [Manage service configuration settings](/power-platform/admin/system-settings-dialog-box-service-tab).

### Reminders

  You can include detailed items to define metrics or key performance indicators (KPIs) to attain that service level. SLA KPIs help you get timely warnings about any issues your customer support team might be having. More information: [Create SLA KPIs](define-service-level-agreements.md#create-sla-kpis).

### See also

[Troubleshoot issues in SLAs](troubleshoot-sla-issues.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
