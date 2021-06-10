---
title: "Analyze data with dashboards (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The dashboard entities in Dynamics 365 Customer Engagement enable you to present data from various charts, grids, IFRAMES, or web resources simultaneously. Dashboards allow you to compare and analyze various pieces of customer information, and give you data snapshots."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 16f0dd2f-7dad-43be-86fd-f93c7905c8dd
caps.latest.revision: 29
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer

---
# Analyze data with dashboards

The dashboard entities in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] enable you to present data 
from various charts, grids, IFRAMES, or web resources simultaneously. Dashboards allow you to compare and analyze various pieces of 
customer information, and give you data snapshots.  
  
## Types of dashboards  
In [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)], there are two types of dashboards: organization-owned dashboards and user-owned dashboards.  
  
**Organization-owned dashboard.**

An organization-owned dashboard is represented by the `SystemForm` entity, and can’t be assigned or shared. 
These dashboards are solution-aware entities in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)]. 
When you perform an update operation on this entity, you must publish the changes for the updates to be available across the organization. 
When you publish customizations using the <xref:Microsoft.Crm.Sdk.Messages.PublishAllXmlRequest> message, the newly-created organization-owned dashboards are also published and become available across the organization. 
Alternatively, you can publish the changes done to a specific dashboard by using the <xref:Microsoft.Crm.Sdk.Messages.PublishXmlRequest> message, and specifying the dashboard ID as the parameter in the request message.  
  
**User-owned dashboard.**

A user-owned dashboard is represented by the `UserForm` entity, can be assigned and shared with other users, and can be viewed by other users depending on the dashboard’s access privileges.  
  
> [!NOTE]
> You can’t programmatically create or manage the new interactive dashboards introduced in [!INCLUDE[pn-crm-2016-shortest](../../includes/pn-crm-2016-shortest.md)]. 
> For information about working with interactive dashboards using the web client, see [Configure interactive experience dashboards](../../customize/configure-interactive-experience-dashboards.md)
  
### See also  
 [Using FormXML for Dashboards](understand-dashboards-dashboard-components-formxml.md)   
 [Actions on Dashboards](actions-dashboards.md)   
 [Create a Dashboard](create-dashboard.md)   
 [Sample Dashboards](sample-dashboards.md)   
 [Dashboard Entities](dashboard-entities.md)   
 [Sample: Create, Retrieve, Update and Delete (CRUD) a Dashboard](sample-create-retrieve-update-delete-dashboard.md)   
 [Sample: Assign a User-Owned Dashboard to Another User](sample-assign-user-owned-dashboard-another-user.md)   
 [Visualization data description schema](visualization-data-description-schema.md)     
 [Customize visualizations and dashboards](customize-visualizations-dashboards.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]