---
title: "Export ribbon definitions (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn about exporting the ribbon definitions."
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
  - ribbon, ribbon data
ms.assetid: f3992ccf-72c5-4347-a7db-a6796f8a4df0
caps.latest.revision: 28
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Export ribbon definitions

To effectively define changes to the default RibbonXml, you must be able to reference the RibbonXml data that defines those ribbons.  
  
<a name="BKMK_AccessRibbonDefinitionsForYourOrganization"></a>   
## Access the ribbon definitions for your organization  
 If the Ribbon for your organization has been modified, you should export the current definitions if you intend to work with the customized ribbon elements. To do this, use the exportribbonxml sample located at `SampleCode\CS\Client\Ribbon\ExportRibbonXml`.  
  
<a name="BKMK_AccessDefaultRibbonData"></a>   
## Access the default ribbon data  
 The default ribbon definitions for [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] can be downloaded from [Microsoft Downloads: ExportedRibbonXml.zip](https://download.microsoft.com/download/C/2/A/C2A79C47-DD2D-4938-A595-092CAFF32D6B/ExportedRibbonXml.zip). 
  
 The applicationRibbon.xml file contains the definition of the core application ribbons.  
  
 The remaining files contain the definitions used by entities that have ribbon definitions that differ from the entity template. Each file is named according to the name of the entity: logical entity name + Ribbon.xml.  
  
 These files represent the output of two messages using the [Sample: Export Ribbon Definitions](sample-export-ribbon-definitions.md):  
  
 <xref:Microsoft.Crm.Sdk.Messages.RetrieveApplicationRibbonRequest>  
 This message retrieves the core application ribbons including the entity template.  
  
 <xref:Microsoft.Crm.Sdk.Messages.RetrieveEntityRibbonRequest>  
 This message retrieves the ribbon definition used for a specific entity.  
  
### Decompress the ribbon data  
 The ribbon data is exported as a compressed file. To decompress the file into XML you have to use the [System.IO.Packaging.ZipPackage](https://msdn.microsoft.com/library/system.io.packaging.zippackage.aspx) class. The following example is a helper method used in the SDK sample to decompress the file.  
  
 [!code-csharp[ExportRibbonXml#ExportRibbonXml2](../../snippets/csharp/CRMV8/exportribbonxml/cs/exportribbonxml2.cs#exportribbonxml2)]  

  
### Retrieve the application ribbon data  
 The application ribbon can be retrieved using the <xref:Microsoft.Crm.Sdk.Messages.RetrieveApplicationRibbonRequest> as shown in the following sample.  
  
 [!code-csharp[ExportRibbonXml#ExportRibbonXml3](../../snippets/csharp/CRMV8/exportribbonxml/cs/exportribbonxml3.cs#exportribbonxml3)]  

  
### Retrieve entity ribbons  
 To retrieve the ribbon definition for entities, you can just include the name of the entity as a parameter to the <xref:Microsoft.Crm.Sdk.Messages.RetrieveEntityRibbonRequest>.  
  
 To retrieve the ribbon definitions for all entities that support the ribbon you need a list of those system entities that have ribbon definitions that vary from the entity ribbon template. The following sample shows an array of all the system entities that have ribbon definitions.  
  
 [!code-csharp[ExportRibbonXml#ExportRibbonXml6](../../snippets/csharp/CRMV8/exportribbonxml/cs/exportribbonxml6.cs#exportribbonxml6)]  
  
 The following sample shows how to retrieve the ribbon definitions for a set of entities.  
  
 [!code-csharp[ExportRibbonXml#ExportRibbonXml4](../../snippets/csharp/CRMV8/exportribbonxml/cs/exportribbonxml4.cs#exportribbonxml4)]  
  
 Any custom entities also support ribbon customizations. To get a list of custom entities, use the <xref:Microsoft.Xrm.Sdk.Messages.RetrieveAllEntitiesRequest> and retrieve the names of custom entities. The following sample shows how to retrieve ribbon definitions for all custom entities.  
  
 [!code-csharp[ExportRibbonXml#ExportRibbonXml5](../../snippets/csharp/CRMV8/exportribbonxml/cs/exportribbonxml5.cs#exportribbonxml5)]  
  
### See also  
 [Customize the Ribbon for Microsoft Dynamics 365 Customer Engagement](customize-commands-ribbon.md)   
 [Command bar or ribbon presentation](command-bar-ribbon-presentation.md)   
 [Export, Prepare to Edit, and Import the Ribbon](export-prepare-edit-import-ribbon.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]