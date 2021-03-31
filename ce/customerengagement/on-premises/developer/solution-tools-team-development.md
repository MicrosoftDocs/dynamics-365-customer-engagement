---
title: "Solution tools for team development (Developer Guide for Dynamics 365 Customer Engagement (on-premises))| MicrosoftDocs"
description: "This topic gives details about tools that can be used for team development of Dynamics 365 Customer Engagement solutions and for source code control"
ms.custom: 
ms.date: 03/29/2019
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: af0cb38e-58f4-4aa6-82c4-da67f07115f9
caps.latest.revision: 17
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Solution tools for team development

*This topic applies to Dynamics 365 Customer Engagement (on-premises). For the Power Apps version of this topic, see: [SolutionPackager tool](/power-platform/alm/solution-packager-tool)*

A Dynamics 365 Customer Engagement (on-premises) solution is a compressed (.zip) file that contains multiple customized components that have been exported from a Dynamics 365 Server so that they may be transported and imported into another server. However, a solution file is a single binary file that does not lend itself to source code control or team development. There is no way for multiple developers to work on the custom components in the solution.  
  
 The SolutionPackager tool resolves the problem of source code control and team development of solution files. The tool identifies individual components in the compressed solution file and extracts them out to individual files. The tool can also re-create a solution file by packing the files that had been previously extracted. This enables multiple people to work independently on a single solution and extract their changes into a common location. Because each component in the solution file is broken into multiple files, it becomes possible to merge customizations without overwriting prior changes. A secondary use of the SolutionPackager tool is that it can be invoked from an automated build process to generate a compressed solution file from previously extracted component files without needing an active Dynamics 365 Server.

 The SolutionPackager tool is distributed as part of the [Microsoft.CrmSdk.CoreTools](https://www.nuget.org/packages/Microsoft.CrmSdk.CoreTools) NuGet package. See [Download tools from NuGet](download-tools-nuget.md) for information about how to download it.
  
## In This Section  
 [Use the SolutionPackager Tool to Compress and Extract a Solution File](compress-extract-solution-file-solutionpackager.md)  
  
 [Use Source Control with Solution Files](use-source-control-solution-files.md)  
  
 [Solution Component File Reference (SolutionPackager)](solution-component-file-reference-solutionpackager.md)  
  
## Related Sections  
 [Developer Tools](developer-tools.md)  
  
 [Package and Distribute Extensions with Dynamics 365 Customer Engagement Solutions](package-distribute-extensions-use-solutions.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
