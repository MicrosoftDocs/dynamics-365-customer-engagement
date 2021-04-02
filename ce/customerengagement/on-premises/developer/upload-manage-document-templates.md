---
title: "Upload and manage document templates in Dynamics 365 Customer Engagement (on-premises)| MicrosoftDocs"
description: "Learn about manging document templates and exporting data as excel or word files using upload and manage document templates."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: cbe05ed2-dfe4-4128-9df0-658e9110ac76
caps.latest.revision: 10
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer

---
# Upload and manage document templates in Dynamics 365 Customer Engagement (on-premises)

Use document templates in [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] to export your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] data as [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] or [!INCLUDE[pn_ms_Word_short](../includes/pn-ms-word-short.md)] files, which can be used as templates to generate [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] or [!INCLUDE[pn_ms_Word_short](../includes/pn-ms-word-short.md)] documents with standardized and up-to-date [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] data for analysis and reporting purposes. Using document templates ensures consistent and standard data representation for your company and customers. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Work with templates](../admin/work-with-templates.md)  
  
 After you have created a document template using the web client, you can programmatically upload the template file (.xlsx or . docx) to your [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] instance, update the name or the template file associated with a document template record, retrieve the document template record, and delete the document template record. Use the `DocumentTemplate` entity to upload and manage organization-owned document templates, and the `PersonalDocumentTemplate` entity to upload and manage user-owned or personal document templates. You can share or assign personal document templates to other users.  
  
 To upload a document template, specify the path to the document, the name, the document type ([!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] or [!INCLUDE[pn_ms_Word_short](../includes/pn-ms-word-short.md)]), and the content (file to be uploaded) as a base-64 encoded string. The following code sample demonstrates how to upload an organization-owned [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] template. Before you upload the template, you must have created an [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] template file using the web client.  
  
```csharp  
string filePath = @"C:\ActiveAccounts.xlsx";  
DocumentTemplate myTemplate = new DocumentTemplate  
{   
      Name = "Sample Excel Document Template";   
      DocumentType = new OptionSetValue(1); // For uploading an Excel template.   
      Content = Convert.ToBase64String(File.ReadAllBytes   
         (Path.Combine(Directory.GetCurrentDirectory(), filePath)))   
};   
_templateID = _serviceProxy.Create(myTemplate);   
Console.WriteLine("Uploaded template: '{0}'.", myTemplate.Name);  
  
```  
  
 If you want to upload a Word template file instead, specify the path to a Word template file in the `filePath` variable, and change the `DocumentType` parameter, as shown in the following example.  
  
```csharp 
DocumentType = new OptionSetValue(2); // For uploading a Word template.  
```  
  
 After you upload a template, activate it so it can be used to generate documents. Use the <xref:Microsoft.Crm.Sdk.Messages.SetStateRequest> message to activate the entity instance that you just created.  
  
### See also  
 [DocumentTemplate Entity](entities/documenttemplate.md)   
 [PersonalDocumentTemplate Entity](entities/personaldocumenttemplate.md)   
 [Work with templates](../admin/work-with-templates.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]