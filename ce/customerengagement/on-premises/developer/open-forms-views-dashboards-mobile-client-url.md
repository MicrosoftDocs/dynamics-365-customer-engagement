---
title: "Open forms, views, and dashboards in Dynamics 365 Customer Engagement (on-premises) mobile client with a URL (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Use the new application handler for Dynamics 365 Customer Engagement (on-premises) mobile clients to directly link to Dynamics 365 Customer Engagement forms, views, and dashboards from external applications so that when you click on the link in an external application, the target element opens in Dynamics 365 for phones or Dynamics 365 for tablets."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 5286807a-bca0-4d01-b08d-0fe4d56a3758
caps.latest.revision: 7
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer

---
# Open forms, views, and dashboards in Customer Engagement mobile client with a URL

Use the new application handler for [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] mobile clients to directly link to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] forms, views, and dashboards from external applications so that when you click on the link in an external application, the target element opens in [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] or [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)]. You can also open an empty form for creating an entity record.  
  
 If you are already signed in to your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] instance in [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] or [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)], the target record is displayed in the mobile client when you click the link in external application. Otherwise, you’re prompted to sign in to your Dynamics 365 Customer Engagement (on-premises) instance in the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] mobile client, and upon doing so, the target element is displayed. You must have [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] or [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)] installed on your mobile device to use this feature.  
  
<a name="Parameters"></a>

## Query string parameters for the URL

 Use the following application handler and query string parameters to compose the URL.  
  
```  
ms-dynamicsxrm://?pagetype=<VALUE>&etn=<VALUE>&id=<VALUE>  
```  
  
 The query string parameters shown in the following table are used.  
  
|Query string parameter|Description|  
|----------------------------|-----------------|  
|pagetype|Specify the page type to open. Valid values are `entity`, `view`, `dashboard`, and `create`.<br /><br /> This parameter is required.|  
|etn|Specify the logical name of the entity for which you want to open or create a record.  Logical name of entities are in lowercase, and defined in the <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.LogicalName> property.<br /><br /> This parameter is required if the `pagetype` parameter is set to `entity`, `view`, or `create`.|  
|id|Specify the ID of the entity, view, or dashboard record that you want to open.<br /><br /> This parameter is required if the `pagetype` parameter is set to `entity` or `dashboard`.<br /><br /> It is optional if the `pagetype` parameter is set to `view`. If you do not specify the view ID, the default view for the entity specified in the `etn` parameter is displayed.|  
  
<a name="Example"></a>

## Example URLs

 Here are some example URLs for opening forms, views, and dashboards.  
  
|Action|Example URL|  
|------------|-----------------|  
|Open an account entity with account record ID as 91330924-802A-4B0D-A900-34FD9D790829|`ms-dynamicsxrm://?pagetype=entity&etn=account&id=91330924-802A-4B0D-A900-34FD9D790829`|  
|Open a view with the view record ID as 899D4FCF-F4D3-E011-9D26-00155DBA3819 for the contact entity|`ms-dynamicsxrm://?pagetype=view&etn=contact&id=899D4FCF-F4D3-E011-9D26-00155DBA3819`|  
|Open a default view for the account entity|`ms-dynamicsxrm://?pagetype=view&etn=account`|  
|Open a dashboard with the dashboard record ID as 2E3D0841-FA6D-DF11-986C-00155D2E3002|`ms-dynamicsxrm://?pagetype=dashboard&id=2E3D0841-FA6D-DF11-986C-00155D2E3002`|  
|Open a form for creating an account record|`ms-dynamicsxrm://?pagetype=create&etn=account`|  
  
### See also

 [Open Forms, Views, Dialogs and Reports with a URL](open-forms-views-dialogs-reports-url.md)  
    
 [Extend Dynamics 365 Customer Engagement (on-premises) on the client](extend-client.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]