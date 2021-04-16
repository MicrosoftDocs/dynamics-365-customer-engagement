---
title: "Annotation (note) entity | MicrosoftDocs"
description: "Learn about annotation entity to append additional information to any record in the database. The annotation  entity represents an annotation and contains the annotation text, who created and modified the annotation, and whether a file is attached to the annotation."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 662cf95d-3bca-464a-983b-54b572e79aa2
caps.latest.revision: 29
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Annotation (note) entity

The *annotations (notes)* provide easy ways to append additional information to any record in the 
[!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] database. An annotation (note) is a text entry that can be associated with any entity in 
[!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. However, you can associate annotations with only those custom entities that are created with 
the <xref:Microsoft.Xrm.Sdk.Messages.CreateEntityRequest.HasNotes> property set to `true` in the <xref:Microsoft.Xrm.Sdk.Messages.CreateEntityRequest> class. You can update a 
custom entity, which is not enabled for notes, to have notes by setting the <xref:Microsoft.Xrm.Sdk.Messages.UpdateEntityRequest>.<xref:Microsoft.Xrm.Sdk.Messages.UpdateEntityRequest.HasNotes> property to `true`.  

Using the Web API, set the `HasNotes` property of the <xref:Microsoft.Dynamics.CRM.EntityMetadata> EntityType controls this.
  
 The `Annotation` entity represents an annotation (note), and contains the following information:  
  
- Annotation (note) text  
  
- Who created and modified the annotation (note)  
  
- Whether a file is attached to the annotation (note)  
  
  An attached file can be any standard computer file format that includes [!INCLUDE[pn_MS_Word_Full](../includes/pn-ms-word-full.md)] documents, [!INCLUDE[pn_MS_Excel_Full](../includes/pn-ms-excel-full.md)] spreadsheets, CAD files, and PDF files. An attachment can be associated with any object, other than an annotation (note), in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].  
  
  To upload or remove an attachment, use the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*> method or <xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> message, setting the `Annotation.Filename` and `Annotation.MimeType` properties. This uploads an attachment that has been decoded into a base64 string format. The [System.Convert.ToBase64String](/dotnet/api/system.convert.tobase64string) method can be used to convert the contents of a data file into a base64-formatted string. [!INCLUDE[sdk_MaxUploadFileSize](../includes/sdk-maxuploadfilesize.md)]  
  
## In This Section  
 [Sample: Upload, Retrieve, and Download an Attachment](sample-upload-retrieve-download-attachment.md)  
  
### See also 
 [Annotation Entity](entities/annotation.md)   
 [Model Your Business Data](model-business-data.md)   
 [UserQuery (Saved View) Entity](userquery-saved-view-entity.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]