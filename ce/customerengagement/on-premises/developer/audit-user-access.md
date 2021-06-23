---
title: "Audit user access (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Support for the ability to audit user access, including user identification, access time, and client type."
ms.custom: audit
ms.date: 03/29/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 13c43edd-77ed-411e-a82e-3e60511c40e0
caps.latest.revision: 21
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Audit user access

[!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] support the ability to audit user access. The information that is recorded includes when the user started accessing [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] and if access originated from the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] web application, [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)], or SDK calls to the web services.  
  
## Enable user access auditing  
 Auditing of user access is enabled at the organization level. To enable or disable user access auditing, you must retrieve the target organization’s record, and update the `Organization.IsUserAccessAuditEnabled` attribute value for the organization. Global auditing on the organization must also be enabled by setting the `Organization.IsAuditEnabled` attribute to `true` in the organization record. To audit the origin of user access, for example: web application, [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] or SDK, you must enable auditing on the entities being accessed.  
  
 The frequency of auditing user access can be read or set using the `Organization.UserAccessAuditingInterval` attribute. The default attribute value of 4 indicates user access is audited once every 4 hours.  
  
 For more information about enabling auditing for an organization and entity, see [Configure Entities and Attributes for Auditing](configure-entities-attributes-auditing.md).  
  
## Filter on user access events  
 To search for audit records that are related to user access, your code should retrieve `Audit` records of an organization and filter on the value in `Audit.Action`. An enumeration named `AuditAction` is provided to identify supported audit actions. The actions related to user access are shown in the following list.  
  
- `AuditAction.UserAccessviaWeb`  
  
- `AuditAction.UserAccessviaWebServices`  
  
- `AuditAction.UserAccessAuditStarted`  
  
- `AuditAction.UserAccessAuditStopped`  
  
  `UserAccessviaWeb` indicates access from the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] web application or [!INCLUDE[pn_MS_Outlook_Short](../includes/pn-ms-outlook-short.md)]. `UserAccessviaWebServices` indicates a web service request from the SDK. The `AuditAction` enumeration is available to your code when you include `SampleCode\CS\HelperCode\OptionSets.cs` or `SampleCode\VB\HelperCode\OptionSets.vb` in your application’s project.  
  
### See also  
 [Audit Entity Data Changes in Dynamics 365 Customer Engagement (on-premises)](audit-entity-data-changes.md)   
 [Configure Entities and Attributes for Auditing](configure-entities-attributes-auditing.md)     
 [Sample: Audit Entity Data Changes](sample-audit-entity-data-changes.md)   
 [Sample: Audit User Access](sample-audit-user-access.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]