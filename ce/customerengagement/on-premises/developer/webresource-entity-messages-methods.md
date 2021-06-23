---
title: "WebResource entity messages and methods (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Learn about web resource that stores the data equivalent to files used in web development. Web resources are client-side components that provide custom user interface elements. The schema name for this entity is WebResource."
ms.custom: 
ms.date: 12/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 6472bf88-4948-49f3-9f53-a4ef13abb702
caps.latest.revision: 21
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# WebResource entity messages and methods

A *web resource* stores the data equivalent to files used in web development. Web resources are client-side components that provide custom user interface elements. These resources are stored in the [WebResource Entity](entities/webresource.md).  
  
 The following table describes the messages for this entity, which you use with the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Execute*> method.  
  
|Message|Description|  
|-------------|-----------------|  
|<xref:Microsoft.Xrm.Sdk.Messages.CreateRequest>|Creates a web resource. You can also call the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*> method.|  
|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRequest>|Deletes a web resource. You can also call the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Delete*> method.|  
|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest>|Retrieves a web resource. You can also call the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*> method.|  
|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest>|Retrieves a collection of web resources. You can also call the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*> method.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveUnpublishedRequest>|Retrieves the current saved definition of a web resource regardless whether it has been published.|  
|<xref:Microsoft.Crm.Sdk.Messages.RetrieveUnpublishedMultipleRequest>|Retrieves the current saved definition of web resources regardless whether they have been published.|  
|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest>|Updates a web resource. You can also call the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*> method.|  
  
### See also

 [Web Resources for Dynamics 365 Customer Engagement (on-premises)](web-resources.md)<br />
 [Sample: Pass Multiple Values to a  Web Resource Through the Data Parameter](sample-pass-multiple-values-web-resource-through-data-parameter.md)<br />


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]