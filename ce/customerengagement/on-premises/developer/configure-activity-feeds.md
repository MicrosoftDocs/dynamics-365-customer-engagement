---
title: "Configure activity feeds (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "The following sections contain information about how to configure your system for activity feeds."
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
  - configuring activity feeds, auto post rules; plug-ins; workflows; and wall controls
  - plug-ins and workflows, configuring activity feeds
  - wall controls, configuring activity feeds
  - auto post rules, configuring activity feeds
  - business entities to configure for activity feeds, list of
  - activity feeds, business entities for
  - activity feeds, configuring
  - activity feeds, installing
  - configuration entities, used for
  - activity feeds, configuration entities for
  - installing and configuring activity feeds
ms.assetid: 02d73faa-8261-4c6f-aeb6-77f200f57cee
caps.latest.revision: 74
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Configure activity feeds

The following sections contain information about how to configure your system for activity feeds.  
  
<a name="ConfigurationEntities"></a>   
## Configuration entities  
 The activity feeds configuration entities are used to enable entities for activity feeds, enable post rules for entities, and configure the user’s profile pictures.  
  
 To enable an entity for activity feeds, use the `msdyn_PostConfig` entity. Set the `msdyn_PostConfig.StateCode` attribute to Active (value 0) and the `msdyn_PostConfig.StatusCode` attribute to Active (value 1) by using the <xref:Microsoft.Crm.Sdk.Messages.SetStateRequest> message. Specify the logical name of the entity you want to enable in the `msdyn_PostConfig.EntityName` attribute. Set the `msdyn_PostConfig`.`msdyn_ConfigureWall` attribute to `true` to enable the wall on the entity form.  
  
> [!IMPORTANT]
>  If you are developing custom solutions in the activity feeds enabled environment, deactivate the activity feeds for all entities before you create, develop, and export the solution. After the solution is exported, reactivate the activity feeds.  
  
 To enable a post rule for an entity, use the `msdyn_PostRuleConfig` entity. Use the <xref:Microsoft.Crm.Sdk.Messages.SetStateRequest> message to activate a post rule for an entity.  
  
 To configure a user’s profile picture, use the `msdyn_PostAlbum` entity that contains user profile images as attachments. The `msdyn_Name` attribute contains the name of the profile album.  
  
 For activity feeds, you can enable customizable business entities and custom entities that are user-owned, team-owned or organization-owned.  
  
 For a list of entities that you can enable for activity feeds, see [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] web application. [!INCLUDE[cc_CRM_Settings](../includes/cc-crm-settings.md)] click **Post Configurations**. The **Post Configurations** area contains a list of entities that are configurable for activity feeds. You don’t need system administrator privileges to access the grid for viewing, but you do need administrator permissions to make modifications to items in the list, such as activating or deactivating post configurations for an entity or refreshing the list. Once you make changes, users will have to open a new tab or window to see these changes reflected.
  
> [!NOTE]
>  After you create a custom entity, you must press the **Refresh** button in the command bar of the **Post Configurations** area to include the new entity so that it can be configured.  
  
<a name="AutoPostRules"></a>   
## Auto post rules  
 You can programmatically enable or disable the post rules for an entity. These rules create localized, parameterized auto posts when events occur. For example, a post is created when an opportunity is added to an account, or a task is added to an opportunity.  
  
 For a list of the auto post rules available out-of-the-box, see [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] web application. [!INCLUDE[cc_CRM_Settings](../includes/cc-crm-settings.md)] Click **Post Rule Configurations**. For more information about how to activate and use auto post rules, see [Sample: Collaborate with Activity Feeds](sample-collaborate-with-activity-feeds.md).  
  
> [!TIP]
>  To make data import run faster, deactivate auto post rules for entities that are being imported.  
  
<a name="PluginsAndWorkflows"></a>   
## Plug-ins and workflows  
 The custom auto post rules in different user’s locales can’t be created programmatically. However, you can create auto posts (posts with the `Source` attribute set to “Auto Post”) by using plug-ins and workflows when events occur in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. With plug-ins and workflows you can create or delete posts, comments, and follows, or perform a specific action when posts, comments, or follows are created. For example, an email can be sent to the user when another user starts following them.  
  
 To mention a record in a post created by a workflow, use the dynamic values. For example, to mention a user who modified a post, use the following expression in the post entity `Text` field:   
`{Post URL(Dynamic)(Modified By (User))}`  
To add dynamic values, use the workflow designer **Form Assistant** in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] Web workflow designer.  
  
 For more information about plug-ins and workflows, see [Plug-ins for Extending Dynamics 365 Customer Engagement (on-premises)](write-plugin-extend-business-processes.md) and [Processes in Dynamics 365 Customer Engagement (on-premises) (formerly Workflows)](automate-business-processes-customer-engagement.md)  
  
<a name="WallControls"></a>   
## Wall controls  
 The activity feeds walls are web resources that can be embedded in dashboards in context with relevant grids and visualizations. For more information about how to use web resources in dashboards, see [Analyze Data with Dashboards](customize-dev/analyze-data-with-dashboards.md). For more information about web resources, see [Web Resources for Dynamics 365 Customer Engagement (on-premises)](web-resources.md).  
  
 To learn more about available out-of-the-box wall controls, see [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] Help.  
  
<a name="Exception"></a>   
## Lookup information for the post entity and post follow entity  
 You can add a post to a record or follow a record for the entities that are enabled for activity feeds.  Normally, you can find a list of entities available for the lookup, such as the list of entities enabled for activity feeds, in the `RegardingObjectId.Target` property of the referencing entity. However, for the `Post` entity and the `PostFollow` entity, the `RegardingObjectId.Target` property isn’t supported. For these entities, to obtain a list of entity types for the lookup, retrieve the `msdyn_PostConfig` records that are in the active state (`msdyn_PostConfig.StateCode` = Active (value 0) and `msdyn_PostConfig.StatusCode` = Active ( value 1). For retrieval, use the <xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> message. The `msdyn_PostConfig.EntityName` attribute contains the logical name of the entity enabled for activity feeds that you can use for the lookup.  
  
### See also  
 [msdyn_PostConfig Entity](entities/msdyn_postconfig.md)
 [msdyn_PostRuleConfig Entity](entities/msdyn_postruleconfig.md) 
 [Activity Feeds Entities](activity-feeds-entities.md)   
 [Introduction to Activity Feeds](introduction-activity-feeds.md)   
 [Sample: Collaborate with Activity Feeds](sample-collaborate-with-activity-feeds.md)   
 [Plug-ins for Extending Dynamics 365 Customer Engagement (on-premises)](write-plugin-extend-business-processes.md)   
 [Processes in Dynamics 365 Customer Engagement (on-premises) (formerly Workflows)](automate-business-processes-customer-engagement.md)   
 [Connect to Yammer](connect-yammer.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]