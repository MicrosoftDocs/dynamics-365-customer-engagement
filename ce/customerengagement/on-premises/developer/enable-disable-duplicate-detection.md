---
title: "Enable and disable duplicate detection (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "This topic covers information on how to enable duplicate detection for all entities in an organization, for a specific entity and for specific operations and how to disable duplicate detection globally or for an entity type by unpublishing the duplicate detection rules or by deleting the published rules."
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
  - duplicate detection, enabling
  - "enabling duplicate detection, in three areas: globally; for entities; for specific operations"
  - "enabling duplicate detection, how to enable: messages; properties; and attributes to set"
  - enabling duplicate detection, rules must be published before running
ms.assetid: B8CD2072-F254-4BA8-9087-79EC79DFE48C
caps.latest.revision: 14
author: phecke
ms.author: pehecke
manager: shujoshi
search.audienceType: 
  - developer

---

# Enable and Disable duplicate detection

This topic covers information on how to enable and disable duplicate detection in Dynamics 365 Customer Engagement (on-premises).

<a name="bkmk_enable"></a>

## Enable duplicate detection

Before running duplicate detection, enable it for each of the following:  
  
-   Globally (for all entities in the organization).  
  
-   For an entity.  
  
-   For specific operations.  
  
> [!NOTE]
>  You must enable duplicate detection in all three areas to detect duplicates for an entity and for operations on an entity.  
  
### Enable duplicate detection globally  
  
-   Use the <xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> message to set the `Organization.IsDuplicateDetectionEnabled` attribute to `true`.
-   Read [Turn duplicate detection rules on or off for the whole organization](../admin/turn-duplicate-detection-rules-off-whole-organization.md) to find out how you can use the user interface to enable duplicate detection for the entire organization.
  
### Enable duplicate detection for an entity  
  
-   Use the <xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> message to set the <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.IsDuplicateDetectionEnabled> property to `true`.  
  
### Enable duplicate detection for specific operations  
  
- Set the following attributes to `true`:  
  
  - `Organization.IsDuplicateDetectionEnabledForOnlineCreateUpdate`. Create and update records in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] by using the Web application or [!INCLUDE[pn_crm_for_outlook_full](../includes/pn-crm-for-outlook-full.md)]. This attribute enables or disables duplicate detection for records created or updated with the <xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> and <xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> messages. However, it does not affect records created or updated with the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*> and <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*> methods.  
  
  - `Organization.IsDuplicateDetectionEnabledForOfflineSync`. Synchronize offline records when [!INCLUDE[pn_crm_for_outlook_full](../includes/pn-crm-for-outlook-full.md)] goes from offline to online.  
  
  - `Organization.IsDuplicateDetectionEnabledForImport`. Import bulk data.  
  
  > [!NOTE]
  >  You do not have to publish the duplicate detection rules to enable duplicate detection for these operations. However, you must publish the duplicate detection rules before you perform the operations.  

<a name="bkmk_disable"></a>

## Disable duplicate detection

Disable duplicate detection globally or for an entity type by unpublishing the duplicate detection rules or by deleting the published rules.  
  
 **Disable duplicate detection globally**  
  
 To disable duplicate detection globally, use the <xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> message to set the `Organization.IsDuplicateDetectionEnabled` attribute to `false`. This automatically unpublishes all duplicate detection rules for all entity types in the organization.  
  
 **Disable duplicate detection for an entity**  
  
 To disable duplicate detection for an entity type, do one of the following:  
  
-   Use the <xref:Microsoft.Xrm.Sdk.Messages.UpdateEntityRequest> message to set the <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.IsDuplicateDetectionEnabled> property to `false`. This automatically unpublishes all duplicate detection rules for an entity type. This removes duplicate detection support for the entity type and you cannot create a new duplicate detection rule for this entity type.  
  
-   Unpublish all duplicate detection rules for an entity type by using the <xref:Microsoft.Crm.Sdk.Messages.UnpublishDuplicateRuleRequest> message.  
  
**Delete published duplicate detection rules**  
  
Delete all published rules in the system to disable duplicate detection globally, or delete published rules for specific entity types by using the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*> method.  

## See Also

[Duplicate Detection](detect-duplicate-data-for-developers.md)  
[Running Duplicate Detection](run-duplicate-detection.md)   
[Duplicate Rule entities](duplicaterule-entities.md) 


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]