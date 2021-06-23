---
title: "Offline and Outlook filters and templates (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Data that should be synchronized between the Dynamics 365 Server and Dynamics 365 for Outlook is determined by Data Filters for Office Outlook"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 3711daa2-27e8-494a-8e3b-52ba7c12022e
caps.latest.revision: 28
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Offline and Outlook filters and templates

Data filters for [!INCLUDE[pn_MS_Outlook_Full](../../includes/pn-ms-outlook-full.md)] determine what data should be synchronized between the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] server and [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)]. [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] supports the ability to change the default filter using the SDK and push these changes to any or all users.  

 As part of the new support for filter customization, you can write code that allows administrators to create and publish filter templates. This allows a [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] administrator to create common or desirable filters that can be published to users for synchronizing with the [!INCLUDE[pn_MS_Outlook_Short](../../includes/pn-ms-outlook-short.md)] Store and offline database. This also provides a way to customize the default filter template that will be applied for users who are added to the system after the templates are originally published. The administrator also has the ability to update or delete user filters after they are published.  

 To support these customizations, there are four new query types for saved query (view). When you create a saved query (view) record, specify one of these types in the `SavedQuery.QueryType` attribute, using the <xref:Microsoft.Crm.Sdk.SavedQueryQueryType> enumeration. These are only accessible by using the methods described here; there is no UI available to change them. You can specify different filters so that you can avoid synchronizing everything to [!INCLUDE[pn_MS_Outlook_Short](../../includes/pn-ms-outlook-short.md)] for your mobile phone. Filter templates are solution aware so they can be exported along with a solution.  

 The following table lists the new query types used for filters and filter templates.  


|                          Query type                          |                                                                                                                                                           Description                                                                                                                                                           |
|--------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| <xref:Microsoft.Crm.Sdk.SavedQueryQueryType.OutlookFilters>  | Defines the subset of an entity to be synchronized with [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)]. The subset of data defined by these filters will synchronize to [!INCLUDE[pn_MS_Outlook_Short](../../includes/pn-ms-outlook-short.md)] folders such as Contacts, Calendar, and so on. |
| <xref:Microsoft.Crm.Sdk.SavedQueryQueryType.OfflineFilters>  |                                            Defines the subset of an entity to be synchronized with [!INCLUDE[pn_crm_outlook_offline_access](../../includes/pn-crm-outlook-offline-access.md)]. The subset of data defined by these filters will synchronize to the offline database.                                            |
| <xref:Microsoft.Crm.Sdk.SavedQueryQueryType.OutlookTemplate> |                                                                                    Defines a filter template applied to new users for synchronization with [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)].                                                                                    |
| <xref:Microsoft.Crm.Sdk.SavedQueryQueryType.OfflineTemplate> |                                                                               Defines a filter template applied to new users for synchronization with [!INCLUDE[pn_crm_outlook_offline_access](../../includes/pn-crm-outlook-offline-access.md)].                                                                               |

## Instantiate a filter  
 Default filter templates are automatically instantiated to the `UserQuery` entity for each user when the synchronization subscription is created. When synchronization to [!INCLUDE[pn_MS_Outlook_Short](../../includes/pn-ms-outlook-short.md)] or to the offline database is initiated, the filters for that user are collected and used to filter the collections of entries and attributes that are being synchronized. If multiple filters are specified for a particular entity, the resulting set of entries will be a union of results of individual filters.  

 There is a new privilege allowing the administrator to access other user's filters: `prvAdminFilter`. This is called Manage User Synchronization Filters in the Web application. The system administrator role includes this privilege because without it, only the user can see his or her filters. Calling the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*> method on the user query will retrieve records only for the owning user, unless the caller has the `prvAdminFilter` privilege The query must contain conditions where `QueryType` equals <xref:Microsoft.Crm.Sdk.SavedQueryQueryType.OutlookFilters> or <xref:Microsoft.Crm.Sdk.SavedQueryQueryType.OfflineFilters> AND `OwnerId` equals `UserId`, where the `UserId` is not equal to caller. If any other conditions are added to the query, this will not work.  

 New users automatically are given the filters from the filter templates that are marked as default in the `SavedQuery.IsDefault` attribute. Administrators need to know that they can change this value to affect this. Each entity can have only one filter template that is marked as default. There can be no default filters, only filter templates. If you create a custom entity, and set the <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.IsAvailableOffline> property, a default filter template is created automatically.  

 There is a new type of filter that administrators can define, called system filters. These filters are defined as `SavedQuery` records with the query type of <xref:Microsoft.Crm.Sdk.SavedQueryQueryType.OutlookFilters> or <xref:Microsoft.Crm.Sdk.SavedQueryQueryType.OfflineFilters>. System filters automatically apply to all users, and cannot be modified by the users.  

 There is a limit on the number of filters you can add. This setting is controlled by the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] deployment administrator to prevent users or administrators from creating too many filters, which affects server performance. The same limit setting is applied to all entities.  

 By default, there are unlimited settings for both system filters and user filters.  

## Instantiate a template  
 You can instantiate one or more filters per user. To do this manually, use the <xref:Microsoft.Crm.Sdk.Messages.InstantiateFiltersRequest> to instantiate a filter, creating a user query record. Each user query record contains a reference back to the filter. If you update the filter, you can call instantiate again to refresh or override the user’s changes to the filter (user query record).  

## Reset a user’s filters to the default  
 You can reset the filters for a user to the default by using the <xref:Microsoft.Crm.Sdk.Messages.ResetUserFiltersRequest>.  

### See also  
 [Extend Dynamics 365 for Outlook](../extend-customer-engagement-outlook.md)   
 [SavedQuery Entity Reference](../entities/savedquery.md)   
 [Sample: Retrieve Outlook Filters](sample-create-retrieve-outlook-filters.md)    
 <xref:Microsoft.Crm.Sdk.Messages.InstantiateFiltersRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.ResetUserFiltersRequest>


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]