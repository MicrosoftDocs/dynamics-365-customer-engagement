---
title: "Edit the customizations XML file with schema validation | MicrosoftDocs"
description: "The customizations.xml file is included within the compressed .zip file exported as a solution. Certain portions of the customizations.xml file can be edited manually. Information about the schema helps you confirm that any modifications you make are valid."
ms.custom: 
ms.date: 12/22/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - schemas
ms.assetid: d521a59d-a542-4dce-ab1a-43582756436c
caps.latest.revision: 19
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Edit the customizations XML file with schema validation

The customizations.xml file is included within the compressed .zip file exported as a solution. Certain portions of the customizations.xml file can be edited manually. Information about the schema helps you confirm that any modifications you make are valid.  
  
## XSD schema files  
 [!INCLUDE[schema_download](../../includes/schema-download.md)] for the XSD schema files used to validate the customization.xml file in a solution. The necessary files are:  
  
- CustomizationsSolution.xsd  
  
- fetch.xsd  
  
- FormXml.xsd  
  
- isv.config.xsd  
  
- RibbonCore.xsd  
  
- RibbonTypes.xsd  
  
- RibbonWSS.xsd  
  
- SiteMap.xsd  
  
- SiteMapType.xsd  
  
- VisualizationDataDescription.xsd  
  
  These files are also installed on the on-premises [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] server at: `[Install Drive]\Program Files\Microsoft Dynamics CRM\Server\ApplicationFiles`  
  
[!INCLUDE[cc_sdk_onpremises_note](../../includes/cc-sdk-onpremises-note.md)] CustomizationsSolution.xsd is the schema for the exported solution. It contains references to the other XSD files. All the files should be located in the same folder.  
  
<a name="BKMK_UseSchemaValidation"></a>   
## Using schema validation  
 Because the exported XML is a text file, you can edit it using a text editor such as [!INCLUDE[pn_Notepad](../../includes/pn-notepad.md)]. However, we strongly recommend that you use an application that supports XSD schema validation such as [!INCLUDE[pn_Visual_Studio](../../includes/pn-visual-studio.md)]. XSD validation in [!INCLUDE[pn_Visual_Studio](../../includes/pn-visual-studio.md)] or [Visual Studio Express 2012 for Web](https://www.microsoft.com/visualstudio/eng/products/visual-studio-express-for-web) provides [!INCLUDE[pn_IntelliSense](../../includes/pn-intellisense.md)] information and schema validation to help prevent errors.  
  
 The XSD schema files that are used to validate the customization.xml file in a solution are available here. [!INCLUDE[schema_download](../../includes/schema-download.md)]. Make sure to copy all the files from that folder into the same directory. You will need to associate the customizations.xml file to the CustomizationsSolution.xsd file. That file has links to all the other XSD files in the folder.  
  
1. Download the XSD schema files and copy all of them to your computer. Save them in the location that [!INCLUDE[pn_Visual_Studio](../../includes/pn-visual-studio.md)] uses for XSD validation files. This location is probably `[install drive]\Program Files (x86)\Microsoft Visual Studio X.0\Xml\Schemas` where `X` represents the version of [!INCLUDE[pn_Visual_Studio_short](../../includes/pn-visual-studio-short.md)].  
  
2. Right-click the customizations.xml file and select **Open With** and then select the version of [!INCLUDE[pn_Visual_Studio_short](../../includes/pn-visual-studio-short.md)].  
  
3. Select **View** and then select **Properties Window**.  
  
4. In the **Properties** window, in the **Schemas** field, click the ellipsis [**...**] button.  
  
5. In the **Xml Schemas** dialog box you should see the customizationsSolution.xsd. In the **Use** column, select **Use this schema**.  
  
   > [!NOTE]
   >  If you do not see it, click **Add** and browse to where you saved it.  
  
6. Click **OK**.  
  
   You are now ready to begin editing the XML with XSD validation.  
  
### See also

 [When to Edit the Customizations File for Dynamics 365 Customer Engagement](when-edit-customization-file.md)   
 [Ribbon core schema](ribbon-core-schema.md)
 [Ribbon types schema](ribbon-types-schema.md)
 [Ribbon WSS schema](ribbon-wss-schema.md)
 [SiteMap schema](sitemap-schema.md)   
 [Form XML schema](form-xml-schema.md)     
 [ISV Configuration File Schema](isv-configuration-file-schema.md)   
 [Build Queries with FetchXML](../org-service/build-queries-fetchxml.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]