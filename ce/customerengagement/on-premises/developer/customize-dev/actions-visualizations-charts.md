---
title: "Actions on visualizations (charts) (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Using the Dynamics 365 Customer Engagement web services (SDK), you can perform the following actions on the visualization entities."
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
  - charts, charts, actions
ms.assetid: c0b866d1-d7a6-4ee4-bc36-69bf3a5398dd
caps.latest.revision: 29
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Actions on visualizations (charts)

Using the [!INCLUDE[cc-dyn365-ce-web-services](../../includes/cc-dyn365-ce-web-services.md)], you can perform the following actions on the visualization entities.  
  
## Actions on organization-owned visualizations  
 To perform actions on an organization-owned visualization (`SavedQueryVisualization`), you must have the System Administrator or the System Customizer role. You can perform the following actions on an organization-owned visualization:  
  
- Create, retrieve, update, and delete an organization-owned visualization. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Create a Visualization](create-visualization-chart.md)  
  
  > [!NOTE]
  >  After updating an organization-owned visualization, you must publish the metadata changes to make it visible across the organization by using the <xref:Microsoft.Crm.Sdk.Messages.PublishAllXmlRequest> message. Alternatively, whenever you publish an entity, all the unpublished organization-owned visualizations that are attached to the entity are published automatically.  
  
- Query and retrieve all the organization-owned visualizations that are attached to an entity using the `SavedQueryVisualization.PrimaryEntityTypeCode` attribute. Multiple organization-owned visualizations can be attached to a single entity. For a list of entities with which you can attach a visualization, see [Entities Supported for Visualizations](view-data-with-visualizations-charts.md#SupportedVisualizationEntities). For a code sample that demonstrates how to retrieve all the organization-owned visualizations attached to an entity, see [Sample: Retrieve all Charts Attached to an Entity](sample-retrieve-all-charts-attached-entity.md).  
  
  > [!NOTE]
  >  You cannot change or update a visualization to attach it with a different entity after you have created the visualization. It implies that the `SavedQueryVisualization.PrimaryEntityTypeCode` attribute is not valid for the update action on the organization-owned visualization.  
  
- Specify an organization-owned visualization as the default visualization for the associated entity by setting the `SavedQueryVisualization.IsDefault` attribute to `true`. When you set an organization-owned visualization as the default visualization for an entity, the visualization is displayed by default when you select to view the visualizations for this entity in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)].  
  
  > [!NOTE]
  >  Using the [!INCLUDE[cc-dyn365-ce-web-services](../../includes/cc-dyn365-ce-web-services.md)], if you set an organization-owned visualization as default for an entity that already has another visualization set as default, both the visualizations are marked as default visualizations for the entity.  To set a visualization as a default visualization for an entity, make sure that no other visualization is set as the default visualization for the entity.  
  
  For a list of supported messages on the organization-owned visualization entity, see [SavedQueryVisualization Entity](../entities/savedqueryvisualization.md).  
  
## Actions on user-owned visualizations  
 You can perform the following actions on a user-owned visualization (`UserQueryVisualization`):  
  
- Create, retrieve, update, and delete a user-owned visualization. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Create a Visualization](create-visualization-chart.md)  
  
- Query and retrieve all the user-owned visualizations that are attached to an entity using the `UserQueryVisualization.PrimaryEntityTypeCode` attribute. Multiple user-owned visualizations can be attached to an entity. For a list of entities with which you can attach a visualization, see [Entities Supported for Visualizations](view-data-with-visualizations-charts.md#SupportedVisualizationEntities).  
  
  > [!NOTE]
  >  You cannot change or update a visualization to attach it with a different entity after you have created the visualization. It implies that the `UserQueryVisualization.PrimaryEntityTypeCode` attribute is not valid for the update action on the user-owned visualization.
  
- Change the ownership of a user-owned visualization by assigning it to another user or team using <xref:Microsoft.Crm.Sdk.Messages.AssignRequest>.  
  
- Retrieve the access that the specified security principal (user or team) has to a user-owned visualization using <xref:Microsoft.Crm.Sdk.Messages.RetrievePrincipalAccessRequest>. You can also retrieve all the security principals (users or teams) that have access to a user-owned visualization, along with their access rights to the user-owned visualization using the <xref:Microsoft.Crm.Sdk.Messages.RetrieveSharedPrincipalsAndAccessRequest>.  
  
- Collaborate with other users and teams on specific areas by sharing a user-owned visualization with them using <xref:Microsoft.Crm.Sdk.Messages.GrantAccessRequest>, <xref:Microsoft.Crm.Sdk.Messages.ModifyAccessRequest>, and <xref:Microsoft.Crm.Sdk.Messages.RevokeAccessRequest>.  
  
  For a list of supported messages on the user-owned visualization entity, see [UserQueryVisualization Entity](../entities/userqueryvisualization.md).

### See also  
 [Charts](view-data-with-visualizations-charts.md)   
 [Understanding Charts: Underlying Data and Chart Representation](understand-charts-underlying-data-chart-representation.md)   
 [Create a Chart](create-visualization-chart.md)   
 [Sample Charts](sample-charts.md)   
 [Sample: Create, Retrieve, Update, and Delete (CRUD) a Chart](sample-create-retrieve-update-delete-chart.md)   
 [Sample: Retrieve all Charts Attached to an Entity](sample-retrieve-all-charts-attached-entity.md)   
 [Sample: Assign a Chart to Another User](sample-assign-chart-another-user.md)   
 [SavedQueryVisualization Entity](../entities/savedqueryvisualization.md)   
 [UserQueryVisualization Entity](../entities/userqueryvisualization.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]