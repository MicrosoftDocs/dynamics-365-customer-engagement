---
title: "Custom activities (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Custom activities support the communication needs of a business such as instant messaging (IM) and Short Message Service (SMS) in Dynamics 365 Customer Engagement"
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
  - creating custom entities for activities, property values to set
  - privileges and access rights for custom activities, activity entities
  - activity entities, privileges and access rights for custom activities
  - custom entities for activities, property values to set
  - activity entities, creating custom entities for activities
ms.assetid: dc817d07-1529-4c80-a91b-0e3fafbdfc68
caps.latest.revision: 29
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Custom activities

In [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], you can create custom activities to support the communication needs of a business such as instant messaging (IM) and Short Message Service (SMS). To create a custom activity in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)], create a custom entity, and specify it as an activity entity using the <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.IsActivity> property.  
  
 However, unlike other custom entities, you can’t specify a primary attribute for a custom activity because, by default, each custom activity must have a primary attribute named ”Subject”.  
  
 When you create a custom activity entity, all the properties and privileges of the `activitypointer` entity are inherited for the custom activity. Further, all the activity party types become available for the custom activity, and as a result the corresponding properties are also inherited.  
  
 You can create 1-to-Many (1:N) relationships for a custom activity just like any other activity, and also update the existing relationships.  
  
## Privileges and access rights  
 You require the same set of [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] privileges and access rights to work with custom activities as those required to work with custom entities. For more information about custom entities, see [Customize Entity Metadata](customize-entity-metadata.md).  
  
## Creating a custom activity  
 To create a custom activity entity, set the values of the properties listed in the following table.  
  
|Property name|Value|Notes|  
|-------------------|-----------|-----------|  
|<xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.IsActivity>|`true`|Specify the custom entity as an activity entity.|  
|<xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.IsAvailableOffline>|`true`|A custom activity entity must have offline availability.|  
|<xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.IsMailMergeEnabled>|`false`|A custom activity entity cannot have mail merge enabled.|  
|<xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.OwnershipType>|<xref:Microsoft.Xrm.Sdk.Metadata.OwnershipTypes>. TeamOwned<br />or<br /><xref:Microsoft.Xrm.Sdk.Metadata.OwnershipTypes>. UserOwned|A custom activity entity can be either team-owned or user-owned.|  
|<xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.ActivityTypeMask>|0 - None<br />or<br />1 – Communication Activity|(Optional) Specify whether a custom activity should appear in the activity menus in the web application.<br /><br /> -   Specify **0 (None)** to hide it from appearing in the activity menus. The custom activity will appear in the associated grids of only those entities with which it is associated (has relationship).<br />-   Specify **1 (Communication Activity)** to make it appear in the activity menus.<br /><br /> If you do not specify this property, the custom activity is created with the default property value: 1. That is, the custom activity is available in the activity menus. Moreover, `ActivityTypeMask` can be set at the activity creation time only, and once set, cannot be modified.|  
|<xref:Microsoft.Xrm.Sdk.Messages.CreateEntityRequest>.<xref:Microsoft.Xrm.Sdk.Messages.CreateEntityRequest.HasActivities>|`false`|A custom activity entity must not have a relationship with activities.|  
|<xref:Microsoft.Xrm.Sdk.Messages.CreateEntityRequest>.<xref:Microsoft.Xrm.Sdk.Messages.CreateEntityRequest.HasNotes>|`true`|A custom activity entity must have a relationship to notes.|  
|<xref:Microsoft.Xrm.Sdk.Messages.CreateEntityRequest>. <xref:Microsoft.Xrm.Sdk.Messages.CreateEntityRequest.PrimaryAttribute>|<xref:Microsoft.Xrm.Sdk.Metadata.AttributeMetadata.SchemaName> is “Subject”.|The schema name of the `PrimaryAttribute` for all activities must be “Subject”.|  
  
## Example  
 The following sample shows how you can create a custom activity.  
  
 [!code-csharp[Entities#CreateCustomActivityEntity2](../snippets/csharp/CRMV8/entities/cs/createcustomactivityentity2.cs#createcustomactivityentity2)]  
  
### See also  
 [Activity Entities](activity-entities.md)   
 [ActivityPointer (activity) entity](activitypointer-activity-entity.md)   
 [Sample: Create a Custom Activity](sample-create-custom-activity.md)   
 [Sample: Create and Update Entity Metadata](org-service/sample-create-update-entity-metadata.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]