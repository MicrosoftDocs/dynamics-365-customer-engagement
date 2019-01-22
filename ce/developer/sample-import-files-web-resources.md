---
title: "Sample: Import files as web resources (Developer Guide for Dynamics 365 for Customer Engagement apps) | MicrosoftDocs"
description: "The sample provides a simplified example of importing files as web resources."
keywords: 
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 0f9bca5b-b876-4f68-8e4e-e844da8598d6
author: JimDaly
ms.author: jdaly
manager: jdaly
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 19
topic-status: Drafting
search.audienceType: 
  - developer
search.app: 
  - D365CE
---

# Sample: Import files as web resources

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

When you develop a large number of files to use as Web resources you can save yourself the work of manually adding them through the application. Many Web resources can be developed and tested outside of [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] and then imported.  
  
 This sample provides a simplified example of this process. For a more complex sample that provides a WPF application you can use to import Web resources, see the [Sample: Web Resource Utility](sample-web-resource-utility.md).  
    
 <!--[!INCLUDE[pn-crm-2015-and-online-full](../includes/pn-crm-2015-and-online-full.md)] -->
<!-- [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)] -->
 
 Download the sample: [Import files as web resources](https://code.msdn.microsoft.com/Import-files-as-web-f84ad8dc). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
 The sample code included in the SDK download package includes the following files required by this sample:  
  
 **ImportJob.xml**  
 This file provides data about the Web Resource records that will be created. For each file it contains the following data:  
  
- **path:** The path to each file from the FilesToImport folder.  
  
- **displayName:** The display name for the Web resource.  
  
- **description:** A description of what each file does.  
  
- **name:** The name that will be used for the Web Resource.  
  
  > [!NOTE]
  > - Each of these names begin with an underscore character. The customization prefix of the solution publisher will be prepended to the name when the Web resource is created. Rather than hard-coding a specific customization prefix, this sample will detect the current customization prefix for a publisher record that may already exist in the organization.  
  >   - Because each of these files was developed outside of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] and depend on relative paths to access each other, the names include backslash “/” characters to create a virtual folder structure so the relative links will continue to function within [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
- **type:** Specifies the type of Web Resource to create using the integer values found in [Web Resource Types](web-resources.md#BKMK_WebResourceTypes).
  
  **FilesToImport/ShowData.htm**  
  This HTML Web resource requires each of the other files to display the following table.  
  
|||  
|-|-|  
|**First Name**|**Last Name**|  
|Apurva|Dalia|  
|Ofer|Daliot|  
|Jim|Daly|  
|Ryan|Danner|  
|Mike|Danseglio|  
|Alex|Darrow|  
  
 **FilesToImport/CSS/Styles.css**  
 This file provides the CSS Styles used in ShowData.htm.  
  
 **FilesToImport/Data/Data.xml**  
 This file contains the list of names that is displayed in the table.  
  
 **FilesToImport/Script/Script.js**  
 This file contains a JScript library that contains information about the relative location of the Data.xml file and the Transform.xslt file. It also contains the `showData` function that transforms the data and adds it to the ShowData.htm page.  
  
 **FilesToImport/XSL/Transform.xslt**  
 This file contains the XSL definition of how to transform the data into an HTML table.  
  
## Demonstrates  
  
### Creating Web Resources in the Context of a Solution  
 Web Resources are organization-owned records so they can be created using either the<xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Create*> method or by using the <xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> message and the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Execute*> method. This sample will show how to use the `SolutionUniqueName` optional parameter to associate a Web resource with a specific solution when it is created. This requires using the <xref:Microsoft.Xrm.Sdk.Messages.CreateRequest> message.  
  
### Uploading Files from Disk  
 The WebResource.Content property requires a Base 64 string representing the binary contents of the file. The following sample is the method used to convert the file into the required type.  
  
 [!code-csharp[ImportWebResources#ImportWebResources3](../snippets/csharp/CRMV8/importwebresources/cs/importwebresources3.cs#importwebresources3)]  
  
### Combining Web Resource Record Data with File Data  
 The ImportJob.xml file demonstrates how the data about the files being imported and the data about the Web Resource to create are combined. In particular, in order for relative links between related files to continue to function, the name of the Web resources you create must preserve information about the relative position of the files on disk using simulated directories in the file name. Because of the data in the ImportJob.xml file all these related Web resource files will be created under a common virtual folder.  
  
> [!NOTE]
>  It is not necessary to publish Web resources when they are created. It is necessary to publish them when they are updated.  
  
## Example  
 The following portion of the ImportWebResources.cs file expects the following variables:  
  
- `_customizationPrefix` : The customization prefix of the **Dynamics 365 for Customer Engagement apps SDK Samples** publisher. If this publisher does not exist it will be created with the customization prefix of “sample”.  
  
- `_ImportWebResourcesSolutionUniqueName` : The unique name of the **Import Web Resources Sample Solution** created in this sample. The value is `ImportWebResourcesSample`.  
  
  [!code-csharp[ImportWebResources#ImportWebResources1](../snippets/csharp/CRMV8/importwebresources/cs/importwebresources1.cs#importwebresources1)]  
  
  It is not necessary to publish Web resources when they are created. It is necessary to publish them when they are updated.  
  
### See also  
 [Sample: Web Resource Utility](sample-web-resource-utility.md)   
 [Web Resource Messages and Methods](webresource-entity-messages-methods.md)   
 [Web Resources for Dynamics 365 for Customer Engagement apps](web-resources.md)
