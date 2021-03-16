---
title: "Fiscal calendar and territory entities (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn about fiscal calendar and territory entities. Depending on the fiscal year settings that are defined by the Organization entity, you can use one of the following fiscal calendar entities to set the sales quotas: AnnualFiscalCalendar, FixedMonthlyFiscalCalendar, MonthlyFiscalCalendar, QuarterlyFiscalCalendar, and SemiAnnualFiscalCalendar."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - quotas, definition
  - salepersons, definition
  - setting sales quotas, goal management entities
  - goal management entities, using for setting sales quotas
  - goal management entities, more versatile than the fiscal calendar entities
  - fiscal calendar; fiscal year; and fiscal periods entities, definition
  - territory entity, definition
ms.assetid: 1a695f80-f042-4a56-a698-72fd1055f01e
caps.latest.revision: 22
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Fiscal calendar and territory entities

You can use the *fiscal calendar* entities and the *territory* entity to track sales information for a salesperson. A salesperson is a user in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] who has to meet sales objectives, such as sales quotas. A territory is a geographical area that is assigned to a salesperson. The fiscal calendar entities define sales quotas for a salesperson. A quota is a revenue objective for a salesperson. A quota is defined as a specific currency amount for a particular fiscal period. A fiscal calendar is a span of time during which the financial activities of an organization are calculated. A fiscal year is divided into fiscal periods, typically defined as semesters, quarters, or months. Depending on the fiscal year settings that are defined by the `Organization` entity, you can use one of the following fiscal calendar entities to set the sales quotas:  `AnnualFiscalCalendar`, `FixedMonthlyFiscalCalendar`,  `MonthlyFiscalCalendar`,  `QuarterlyFiscalCalendar`, and `SemiAnnualFiscalCalendar`. Each of these entities has one or more money type attributes that you can use to specify a quota for a particular time period. For example, to set a quota for a full fiscal year period, use the `AnnualFiscalCalendar.Period1` attribute. To set monthly quotas, use the `MonthlyFiscalCalendar` entity that contains twelve periods.  
  
> [!IMPORTANT]
>  The create action (<xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*> method and <xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> message) for fiscal calendar entities is deprecated in [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. We encourage you to use new *goal management* entities for setting sales quotas. The goal management entities are much more versatile and offer many more capabilities than the fiscal calendar entities.  
  
### See also  
 [Business Management Entities](business-management-entities.md)   
 [Territory Entity](entities/territory.md)   
 [AnnualFiscalCalendar Entity](entities/annualfiscalcalendar.md)   
 [FixedMonthlyFiscalCalendar Entity](entities/fixedmonthlyfiscalcalendar.md)   
 [MonthlyFiscalCalendar Entity](entities/monthlyfiscalcalendar.md)   
 [QuarterlyFiscalCalendar Entity](entities/quarterlyfiscalcalendar.md)   
 [SemiAnnualFiscalCalendar Entity](entities/semiannualfiscalcalendar.md)   
 [Goal Management Entities](goal-management-entities.md)   
 [Organization Entities](organization-entities.md)   
 [Queue Entities](queue-entities.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]