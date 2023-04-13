---
title: "Migrate service-level agreements in Dynamics 365 Customer Service | MicrosoftDocs"
description: "Learn why you should migrate service-level agreements in Dynamics 365 Customer Service."
ms.date: 06/16/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
  - intro-internal
---

# Migrate SLAs

Service-level agreements (SLAs) are deprecated in the web client. We recommend migrating standard and enhanced SLAs created in web client to Unified Interface. For more information on the deprecation, see [SLAs in web client are deprecated](deprecations-customer-service.md#slas-in-web-client-are-deprecated). The migration tool for automatic record creation rules and service-level agreements (SLAs) helps migrate the rules in the web client to Unified Interface.

Before you begin the migration, learn how migrating to Unified Interface helps:

|Standard or Enhanced SLA  | Unified Interface |
|---------|---------|
|Condition Control in SLA item isn't accessible compliant    | Condition Control in SLA item is accessible compliant   |
|Uses Workflows for Actions    | Uses **Workflows** and **Power Automate** flows for Actions    |
|**Pause configurations** can be set only at **Table Level**    |  **Pause configurations** can be set at **Table**, **KPI**, and **SLA Item Level** |
|Calendar is on SLA level    | Calendar is on SLA item level       |
|Can't configure parallel KPIs    |  Can configure parallel KPIs   |
|Can't configure SLA items with different **Applicable From**     | Can configure SLA items with different **Applicable From**   |
|Limited number of actions     | Multiple actions (as Power Automate allows)      |
|No support for Custom Time Calculation and Recalculation   | Support for Custom Time Calculation and Recalculation of Warning Time and Failure Time of SLA     |

## How migration works

To understand how you can migrate service-level agreements, see [Migrate automatic record creation rules and service-level agreements](migrate-automatic-record-creation-and-sla-agreements.md#migrate-automatic-record-creation-rules-and-service-level-agreements).

For queries about migration, see [Migration tool FAQ](migrate-tool-faqs.md#migration-tool-faq).

### See also

[Enable entities for service-level agreements](enable-entities-service-level-agreements.md)  
[Troubleshoot issues in SLAs](troubleshoot-sla-issues.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
