---
title: "Actions on SharePoint location records (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
ms.custom: 
ms.date: 06/14/2018
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
  - Dynamics 365 Customer Engagement (on-premises)
  - Dynamics CRM 2016
  - Dynamics CRM Online
ms.assetid: e4dd45e3-a9d4-4df2-9c2a-df64758620ce
caps.latest.revision: 38
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer

---
# Actions on SharePoint location records

You can perform the actions described in this topic on Microsoft SharePoint location records.
<a name="CRUDRecords"></a>

## Create, retrieve, update, and delete location records

Using the [!INCLUDE[cc-dyn365-ce-web-services](../../includes/cc-dyn365-ce-web-services.md)] messages on the [SharePointSite](../entities/sharepointsite.md) and [SharePointDocumentLocation](../entities/sharepointdocumentlocation.md) entities, you can create, retrieve, update, and delete records. To perform these operations on the `SharePointSite` entity, you must have the System Administrator role in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)]. For a list of supported messages, see [SharePointSite Entity](../entities/sharepointsite.md) and [SharePointDocumentLocation Entity](../entities/sharepointdocumentlocation.md).  

> [!NOTE]
> Performing these operations on [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] location records only manipulates the data in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)]. It does not create, update, or delete the locations on the [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] server.  
  
 The `SharepointSite.ValidationStatus` attribute shows the validation status of the [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] site URL. The possible values for this attribute are defined in the 
 `sharepoint_validationstatus` option set.  
  
 The `SharepointSite.ValidationStatusErrorCode` attribute shows the reason for the validation status of the SharePoint site URL. 
 The possible values for this attribute are defined in the `sharepoint_validationstatusreason` option set.  
  
 The storage locations on [!INCLUDE[pn_SharePoint_Server_short](../../includes/pn-sharepoint-server-short.md)] are hierarchical where the [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] site collection is the container that can contain multiple sites, and each site can contain multiple sites or document libraries. Each document library can contain multiple document folders. While creating location records in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)], specify the path or the URL of these locations on [!INCLUDE[pn_SharePoint_Server_short](../../includes/pn-sharepoint-server-short.md)].  
  
### Absolute URL of the SharePoint location records  
 This is the complete URL of a storage location on [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)]. You can specify the absolute URL using the `SharePointSite.AbsoluteURL` or `SharePointDocumentLocation.AbsoluteURL` property.  
  
 To create a `SharePointSite` record by specifying the absolute URL:  
  
 [!code-csharp[SharePointIntegration#CRUDSharePointLocationRecords2](../../snippets/csharp/CRMV8/sharepointintegration/cs/crudsharepointlocationrecords2.cs#crudsharepointlocationrecords2)] 
  
 Similarly, to create a [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] document location record by specifying the absolute URL:  
  
```csharp  
SharePointDocumentLocation spDocLoc = new SharePointDocumentLocation  
{  
    Name = "Sample SharePoint Document Location",  
    Description = "Sample SharePoint Document Location record",  
    AbsoluteUrl = "https://www.example.com/spdocloc"     
};  
_spDocLocId = _serviceProxy.Create(spDocLoc);  
```  
  
 Absolute URLs are typically provided for the [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] site records because these are the container or parent objects under which you want to create other locations for storing and managing your documents.  
  
> [!NOTE]
>  The `SharePointDocumentLocation.LocationType` attribute determines whether a `SharePointDocumentLocation` record points to a [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] folder (0) or to a [!INCLUDE[pn_onenote](../../includes/pn-onenote.md)] file (1). When you create a `SharePointDocumentLocation` instance (record), the value of the `SharePointDocumentLocation.LocationType` attribute is set to 0 by default to indicate that it points to a [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] folder. For more information about the OneNote support, see [Integrate Microsoft Dynamics 365 Customer Engagement (on-premises) with OneNote](integrate-onenote.md).  
  
### Relative URL of the SharePoint location records  
 This is the relative location of a location record with respect to its parent location record on the [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] server. When you specify a relative URL for a [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] location record, you must also specify the parent object under which it should be created. [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] internally uses the URL of the parent object to determine the absolute URL for the child object. For example, to create a record for a [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] document location under the [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] site created in the previous example, you must specify the following:  
  
 [!code-csharp[SharePointIntegration#CRUDSharePointLocationRecords3](../../snippets/csharp/CRMV8/sharepointintegration/cs/crudsharepointlocationrecords3.cs#crudsharepointlocationrecords3)]  
  
 The absolute URL of the child object (document location in this example) is: “*Parent_URL*/*Relative_URL*”. So, in this example, the absolute URL of the document location is  `https://www.example.com/spdocloc`.  
  
 Relative URLs are typically provided when you want to create a location record lower down the hierarchy or as a child record.  
  
 The benefit of using the relative URL is that if you decide to move to a different [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] server to store your documents, you just need to update the absolute URL of the parent object location record (probably a site collection or site record) in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)], and all the other records down the hierarchy will continue functioning as before because the absolute URLs (determined automatically by [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)]) will not be broken. If you had used absolute URLs for these child location records, you would have to fix the URLs individually.  
  
<a name="SetAsDefault"></a>

## Set a site location record as default

 You can set a [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] site location record as default so that all the document locations created using [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] will be automatically created under this site. To create a site location record as default, use the `SharePointSite.IsDefault` property, and set it to `true`. You can set a site location record as default while creating or updating a site location record.  
  
> [!NOTE]
> Automatic creation of document location records is possible only if the target site is a [!INCLUDE[pn_ms_SharePoint_2010_short](../../includes/pn-ms-sharepoint-2010-short.md)] or [!INCLUDE[pn_sharepoint_2013](../../includes/pn-sharepoint-2013.md)] server and [!INCLUDE[pn_crm_list_component_sharepoint_server](../../includes/pn-crm-list-component-sharepoint-server.md)] is installed on the target [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] Site Collection. For more information about the [!INCLUDE[pn_list_component_short](../../includes/pn-list-component-short.md)], see [Microsoft Dynamics 365 Customer Engagement (on-premises) list component for Microsoft SharePoint Server](get-started-sharepoint-integration.md#CRMListComponent).  
  
<a name="AssociateRecord"></a>

## Associate a document location record with an entity record  
 You can associate a document location record with an entity record. When you do this, all the documents for the entity record are stored at this location on the [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] server. You can associate a [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] document location record with an entity using the `SharePointDocumentLocation.RegardingObjectId` property. The following sample shows how you can do this:  
  
 [!code-csharp[SharePointIntegration#CRUDSharePointLocationRecords3](../../snippets/csharp/CRMV8/sharepointintegration/cs/crudsharepointlocationrecords3.cs#crudsharepointlocationrecords3)]  
  
<a name="RetrieveUrls"></a>   
## Retrieve absolute and site collection URLs for a location record  
 As explained earlier, [!INCLUDE[pn_SharePoint_Server_short](../../includes/pn-sharepoint-server-short.md)] follows a hierarchical model to store records. If you want to retrieve the absolute (complete) URL of a location record in the hierarchy and the `SiteCollection` URL under which the location record is present, you can use the <xref:Microsoft.Crm.Sdk.Messages.RetrieveAbsoluteAndSiteCollectionUrlRequest> message to do so.  
  
 The <xref:Microsoft.Crm.Sdk.Messages.RetrieveAbsoluteAndSiteCollectionUrlRequest> message will work properly only if both are true:  
  
- The [!INCLUDE[pn_crm_list_component_sharepoint_server](../../includes/pn-crm-list-component-sharepoint-server.md)] is installed on the [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] site collection on the target [!INCLUDE[pn_ms_SharePoint_2010_short](../../includes/pn-ms-sharepoint-2010-short.md)] or [!INCLUDE[pn_sharepoint_2013](../../includes/pn-sharepoint-2013.md)] server. For more information, see [Microsoft Dynamics 365 Customer Engagement (on-premises) list component for Microsoft SharePoint Server](get-started-sharepoint-integration.md#CRMListComponent).  
  
- The location record for the parent [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)] site collection exists in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)], and the `SharePointSite.IsGridPresent` property was set to `true` while creating the parent location record.  
  
  Otherwise, you will get a blank value or an incorrect value for the <xref:Microsoft.Crm.Sdk.Messages.RetrieveAbsoluteAndSiteCollectionUrlResponse.SiteCollectionUrl> property.  
  
  For more information, see <xref:Microsoft.Crm.Sdk.Messages.RetrieveAbsoluteAndSiteCollectionUrlRequest>.  
  
  The following sample shows how to use the `RetrieveAbsoluteAndSiteCollectionUrl` message:  
  
  [!code-csharp[SharePointIntegration#RetrieveAbsoluteAndSiteCollectionURLs2](../../snippets/csharp/CRMV8/sharepointintegration/cs/retrieveabsoluteandsitecollectionurls2.cs#retrieveabsoluteandsitecollectionurls2)]  
  
### See Also  
 <xref:Microsoft.Crm.Sdk.Messages.RetrieveAbsoluteAndSiteCollectionUrlRequest>  
 <xref:Microsoft.Crm.Sdk.Messages.RetrieveAbsoluteAndSiteCollectionUrlResponse> 
 [Integrate Dynamics 365 Customer Engagement (on-premises) with SharePoint](integrate-sharepoint.md)   
 [Introduction to SharePoint Integration](get-started-sharepoint-integration.md)   
 [Enable Document Management for Entities](enable-document-management-entities.md)    
 [Sample: Enable Document Management for Entities](sample-enable-document-management-entities.md)   
 [Sample: Create, Retrieve, Update, and Delete (CRUD) a SharePoint Location Record](sample-create-retrieve-update-delete-sharepoint-location-record.md)   
 [Sample: Retrieve Absolute URL and Site Collection URL of a Location Record](sample-retrieve-absolute-url-and-site-collection-url-of-a-location-record.md)   
 [Integrate Microsoft Dynamics 365 Customer Engagement (on-premises) with OneNote](integrate-onenote.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]