---
title: "Which entities are customizable? (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn about the entities properties that are customizable."
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
  - which entities are customizable?
  - entity metadata properties that control customization
  - customizing entities, fully customizable entities
  - customizing entities, properties of customizable entities
  - customizing entities, entity metadata properties that control customization
  - entities, which entities are customizable?
  - customizing entities, which entities are customizable?
ms.assetid: f9807600-8cfd-4879-9005-f3a2068aceb8
caps.latest.revision: 30
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Which entities are customizable?

Dynamics 365 Customer Engagement (on-premises) has 271 entities; of these, 98 entities are customizable. Any custom entities that you add are also customizable. Creators of managed solutions can use managed properties to select whether to enable customization of entities in their solutions. The specific customizations that are allowed for customizable entities are defined by other properties.  
  
<a name="properties"></a>   
## EntityMetadata properties that control customization  
 The following entity metadata properties define what types of customizations any entity will support.  
  
|Property|Description|  
|--------------|-----------------|  
|IsCustomizable|Specifies whether an entity allows customization.|  
|IsRenameable|Specifies whether you can change the display name for an entity in the application.|  
|CanBeRelatedEntityInRelationship|Specifies whether you can add a lookup attribute to an entity to establish a custom entity relationship.|  
|CanBePrimaryEntityInRelationship|Specifies whether you can set the entity to be the primary entity in a custom entity relationship.|  
|CanBeInManyToMany|Specifies whether the entity can participate in a many-to-many custom entity relationship.|  
|CanCreateForms|Specifies whether you can create custom forms for the entity.|  
|CanCreateCharts|Specifies whether you can create charts for the entity.|  
|CanCreateViews|Specifies whether you can create views for the entity.|  
|CanCreateAttributes|Specifies whether you can create attributes for the entity.|  
|CanModifyAdditionalSettings|Specifies whether any other entity properties not represented by a managed property can be changed.|  
  
<a name="fully"></a>   
## Fully customizable entities  
 The following table lists the entities that support all the customization capabilities. Any custom entities you add will support the same capabilities.  
  
|||||||  
|-|-|-|-|-|-|  
|Account|Campaign|CampaignActivity|CampaignResponse|Competitor|Connection|  
|Contact|Contract|Email|Fax|Goal|Incident|  
|Invoice|InvoiceDetail|Lead|Letter|List|Opportunity|  
|OpportunityProduct|PhoneCall|Product|QueueItem|Quote|QuoteDetail|  
|SalesLiterature|SalesOrder|SalesOrderDetail|ServiceAppointment|SystemUser|Task|  
|Territory||||||  
  
<a name="customizable_entity_properies"></a>   
## Customizable entity properties  
 The following table lists the customizable entities and the values for the entity metadata properties that control customizations.  
  
|`DisplayName`|`IsCustomizable`|`CanBeInManyToMany`|`CanBePrimaryEntityInRelationship`|`CanBeRelatedEntityInRelationship`|`CanCreateAttributes`|`CanCreateCharts`|`CanCreateForms`|`CanCreateViews`|`CanModifyAdditionalSettings`|`IsRenameable`|  
|-------------------|----------------------|-------------------------|----------------------------------------|----------------------------------------|---------------------------|-----------------------|----------------------|----------------------|-----------------------------------|--------------------|  
|Account|True|True|True|True|True|True|True|True|True|True|  
|ActivityMimeAttachment|True|False|False|False|False|False|False|False|True|False|  
|ActivityPointer|True|False|False|False|False|True|False|True|True|True|  
|Annotation|True|False|False|False|False|False|False|True|True|False|  
|Appointment|True|True|True|True|True|True|False|True|True|True|  
|BulkOperation|True|False|False|False|False|True|False|True|True|True|  
|BusinessUnit|True|True|True|True|True|False|True|True|True|True|  
|Campaign|True|True|True|True|True|True|True|True|True|True|  
|CampaignActivity|True|True|True|True|True|True|True|True|True|True|  
|CampaignResponse|True|True|True|True|True|True|True|True|True|True|  
|Competitor|True|True|True|True|True|True|True|True|True|True|  
|CompetitorAddress|True|False|False|False|False|False|False|False|True|False|  
|Connection|True|True|True|True|True|True|True|True|True|True|  
|ConnectionRole|True|False|False|False|False|False|False|False|True|True|  
|Contact|True|True|True|True|True|True|True|True|True|True|  
|Contract|True|True|True|True|True|True|True|True|True|True|  
|ContractDetail|True|True|True|True|True|False|True|True|True|True|  
|ContractTemplate|True|False|True|False|False|False|False|False|True|True|  
|CustomerAddress|True|True|True|True|True|False|True|True|True|True|  
|CustomerOpportunityRole|True|False|False|False|False|False|False|False|True|False|  
|Discount|True|True|False|False|False|False|False|False|True|False|  
|DiscountType|True|True|True|False|False|False|False|False|True|False|  
|DuplicateRule|True|False|False|False|False|False|False|False|True|False|  
|DuplicateRuleCondition|True|False|False|False|False|False|False|False|True|False|  
|Email|True|True|True|True|True|True|True|True|True|True|  
|EmailServerProfile|True|False|True|True|False|False|False|False|True|False|  
|Equipment|True|True|True|True|True|False|True|True|True|True|  
|Fax|True|True|True|True|True|True|True|True|True|True|  
|FieldPermission|True|False|False|False|False|False|False|False|True|False|  
|FieldSecurityProfile|True|False|False|False|False|False|False|False|True|False|  
|Goal|True|True|True|True|True|True|True|True|True|True|  
|GoalRollupQuery|True|True|True|True|False|True|False|True|True|True|  
|ImportMap|True|False|True|False|False|False|False|False|True|False|  
|Incident|True|True|True|True|True|True|True|True|True|True|  
|IncidentResolution|True|False|False|False|False|False|False|False|True|True|  
|InternalAddress|True|False|False|False|False|False|False|False|True|False|  
|Invoice|True|True|True|True|True|True|True|True|True|True|  
|InvoiceDetail|True|True|True|True|True|True|True|True|True|True|  
|KbArticle|True|True|True|True|True|True|False|True|True|True|  
|KbArticleTemplate|True|False|True|False|False|False|False|False|False|False|  
|Lead|True|True|True|True|True|True|True|True|True|True|  
|LeadAddress|True|False|False|False|False|False|False|False|True|False|  
|Letter|True|True|True|True|True|True|True|True|True|True|  
|List|True|True|True|True|True|True|True|True|True|True|  
|Mailbox|True|False|True|True|True|True|True|True|True|False|  
|MailMergeTemplate|True|True|True|True|True|False|True|True|True|True|  
|Metric|True|True|True|True|False|True|False|True|True|True|  
|Opportunity|True|True|True|True|True|True|True|True|True|True|  
|OpportunityClose|True|False|False|False|False|False|False|False|True|False|  
|OpportunityProduct|True|True|True|True|True|True|True|True|True|True|  
|OrderClose|True|False|False|False|False|False|False|False|True|False|  
|Organization|True|False|False|False|False|False|False|False|True|False|  
|PhoneCall|True|True|True|True|True|True|True|True|True|True|  
|PriceLevel|True|True|True|True|True|True|True|True|True|False|  
|ProcessSession|True|False|False|False|False|False|False|True|True|False|  
|ProcessStage|True|False|True|True|False|False|False|False|True|False|  
|ProcessTrigger|True|True|False|False|False|False|False|False|True|False|  
|Product|True|True|True|True|True|True|True|True|True|True|  
|ProductPriceLevel|True|True|False|False|False|False|False|False|True|False|  
|Publisher|True|False|False|False|False|False|False|False|True|False|  
|Queue|True|True|True|True|True|False|True|True|True|True|  
|QueueItem|True|True|True|True|True|True|True|True|True|True|  
|Quote|True|True|True|True|True|True|True|True|True|True|  
|QuoteClose|True|False|False|False|False|False|False|False|True|False|  
|QuoteProduct|True|True|True|True|True|True|True|True|True|True|  
|RecurringAppointmentMaster|True|True|True|True|True|True|False|True|True|True|  
|Report|True|False|False|False|False|True|False|True|True|True|  
|ReportCategory|True|True|True|True|True|False|True|True|True|False|  
|Resource|True|False|False|False|False|False|False|False|True|False|  
|ResourceGroup|True|False|False|False|False|False|False|False|True|False|  
|ResourceGroupExpansion|True|False|False|False|False|False|False|False|True|False|  
|Role|True|False|True|False|False|False|False|False|True|False|  
|RolePrivileges|True|False|False|False|False|False|False|False|True|False|  
|RollupField|True|False|False|False|False|False|False|False|True|True|  
|SalesLiterature|True|True|True|True|True|True|True|True|True|True|  
|SalesOrder|True|True|True|True|True|True|True|True|True|True|  
|SalesOrderDetail|True|True|True|True|True|True|True|True|True|True|  
|SavedQuery|True|False|False|False|False|False|False|False|True|False|  
|SavedQueryVisualization|True|False|False|False|False|False|False|False|True|False|  
|Service|True|False|True|False|False|True|False|True|True|False|  
|ServiceAppointment|True|True|True|True|True|True|True|True|True|True|  
|SharePointDocumentLocation|True|True|True|True|True|False|True|True|True|True|  
|SharePointSite|True|True|True|True|True|False|True|True|True|True|  
|Site|True|False|True|False|False|False|False|False|True|False|  
|Solution|True|False|False|False|False|False|False|False|True|False|  
|Subject|True|False|True|False|False|False|False|False|True|False|  
|SystemUser|True|True|True|True|True|True|True|True|True|True|  
|Task|True|True|True|True|True|True|True|True|True|True|  
|Team|True|True|True|True|True|True|True|True|True|False|  
|TeamTemplate|True|False|False|False|False|False|False|False|False|False|  
|Template|True|False|False|False|False|False|False|True|True|True|  
|Territory|True|True|True|True|True|True|True|True|True|True|  
|TransactionCurrency|True|True|True|False|False|False|False|False|True|True|  
|UoM|True|True|True|False|False|False|False|False|True|False|  
|UoMSchedule|True|False|True|False|False|True|False|True|True|False|  
|UserQuery|True|False|False|False|False|False|False|False|True|False|  
|UserQueryVisualization|True|False|False|False|False|False|False|False|True|False|  
|Workflow|True|False|True|False|False|False|False|False|True|False|  
  
### See also  
 [Using Managed Properties](use-managed-properties.md)   
 [Customize Entity Metadata](customize-entity-metadata.md)   
 [Create a Custom Entity](/powerapps/developer/data-platform/org-service/create-custom-entity)   
 [Change Entity Icons](modify-icons-entity.md)   
 [Change Entity Messages](modify-messages-entity.md)   
 [Sample: Create and Update Entity Metadata](/powerapps/developer/data-platform/org-service/create-custom-entity)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]