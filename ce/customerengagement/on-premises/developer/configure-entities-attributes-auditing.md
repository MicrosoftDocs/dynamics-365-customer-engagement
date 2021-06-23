---
title: "Configure entities and attributes for auditing (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Explains configuration requirements to enable and disable auditing of entities and their attributes."
ms.custom: audit
ms.date: 03/29/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - enabling and disabling auditing, how to
  - configuring entities and attributes for auditing, required security roles for enabling or disabling auditing
  - enabling and disabling auditing, default settings for enabled auditing
  - configuring entities and attributes for auditing, auditable entities
  - configuring entities and attributes for auditing, difference between enabling for different levels
  - auditing, see 'auditing entity data changes in Microsoft Dynamics CRM'
  - enabling and disabling auditing, auditable entities
  - configuring entities and attributes for auditing, default settings for enabled auditing
  - auditing levels, descriptions of the three levels
  - enabling and disabling auditing, list of entities that cannot be audited
  - security roles for enabling or disabling auditing, required role levels
  - configuring entities and attributes for auditing, descriptions of the three auditing levels
  - configuring entities and attributes for auditing, list of entities that cannot be audited
ms.assetid: 4e36f9d4-08cd-4f57-a02b-33581e54ce5f
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Configure entities and attributes for auditing

There are three levels where auditing can be configured: organization, entity, and attribute. The organization level is the highest level, followed by the entity level, and finally the attribute level. For attribute auditing to take place, auditing must be enabled at the attribute, entity, and organization levels. For entity auditing to take place, auditing must be enabled at the entity and organization levels.  
  
 There is a slight difference in how auditing is enabled or disable for an organization compared to an entity or attribute. You enable or disable auditing at the organization level by setting a particular attribute value of the organization record. However, for entities and attributes, you set a property value of the entity or attribute metadata.  
  
 A user must be assigned the System Administrator or System Customizer role to enable or disable auditing.  
  
## Enabling auditing  
 By setting the <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.IsAuditEnabled> property of an entity’s metadata and the <xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata.IsAuditEnabled> property of each desired attribute’s metadata to `true`, data changes to records of those entities can be logged by the platform. However, when enabling auditing on an entity, all of the entity’s attributes are enabled for auditing by default. Of course you can explicitly disable auditing on any or all of the attributes as needed. The <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.IsAuditEnabled> property can be set when entity or attribute metadata is created or updated through the following requests: <xref:Microsoft.Xrm.Sdk.Messages.CreateEntityRequest>, <xref:Microsoft.Xrm.Sdk.Messages.UpdateEntityRequest>, <xref:Microsoft.Xrm.Sdk.Messages.CreateAttributeRequest>, <xref:Microsoft.Xrm.Sdk.Messages.UpdateAttributeRequest>.  
  
 After changing the entity attribute metadata, you must publish the entity by using <xref:Microsoft.Crm.Sdk.Messages.PublishXmlRequest>. Changing the <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.IsAuditEnabled> property at the entity level does not require publishing. Typically, customization and publishing is performed by the same user. However, if these tasks are performed by different users, auditing will record the publish action, the user that initiated the publish operation, and not the update action.  
  
 In addition, auditing is enabled at the organization level by setting the <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.IsAuditEnabled> attribute value of the target organization record to `true`.  
  
## Disabling auditing  
 To disable auditing, just set <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.IsAuditEnabled>, as described previously, to `false`. Publish the entity customizations if you have disabled auditing on any attributes. You can disable auditing for a whole organization by setting the <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.IsAuditEnabled> attribute to `false` in the target organization’s record.  
  
## Entities that can be audited  
 All custom and most customizable entities can be audited. For a list of customizable entities, see [Which Entities are Customizable?](which-entities-are-customizable.md).  
  
 The following table lists the non-customizable entities that cannot be audited. This table was obtained by testing for a `CanModifyAuditSettings` attribute value of `false` on each entity’s metadata.  
  
||  
|-|  
|ActivityPointer|  
|Annotation|  
|BulkOperation|  
|Calendar|  
|CalendarRule|  
|CustomerOpportunityRole|  
|Discount|  
|DiscountType|  
|IncidentResolution|  
|KbArticle|  
|KbArticleComment|  
|KbArticleTemplate|  
|Notification|  
|OpportunityClose|  
|OrderClose|  
|ProductPriceLevel|  
|QuoteClose|  
|RecurrenceRule|  
|Resource|  
|ResourceGroup|  
|ResourceGroupExpansion|  
|ResourceSpec|  
|SalesLiteratureItem|  
|SalesProcessInstance|  
|Service|  
|Subject|  
|Template|  
|UoM|  
|UoMSchedule|  
|Workflow|  
|WorkflowLog|  
  
### See also  
 [Data Management in Dynamics 365 Customer Engagement (on-premises)](manage-data.md)   
 [Audit entity data changes](audit-entity-data-changes.md)   
 [Retrieve and delete the history of audited data changes](retrieve-and-delete-the-history-of-audited-data-changes.md)   
 [Sample: Audit Entity Data Changes](sample-audit-entity-data-changes.md)   
 [Auditing Data Changes in Dynamics 365 Customer Engagement (on-premises)](audit-entity-data-changes.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]