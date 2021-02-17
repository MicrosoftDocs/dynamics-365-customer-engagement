---
title: "Pass parameters to a URL using the SiteMap  (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Learn about passing parameters to a URL using the SiteMap"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 979da39a-2d15-4564-84d8-86dd0bcf3c38
caps.latest.revision: 23
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Pass parameters to a URL using the SiteMap

To give the target application information about the organization and the language context of the user and organization, 
pass parameters to the target URL for a `<SubArea>` element in the site map. 
All the parameters are passed if the `<SubArea>` element is configured by setting the `PassParams` attribute to `true`.  
  
 The following table shows the parameters that are passed.  
  
|Parameter|Name|Description|  
|---------------|----------|-----------------|  
|orgname|Organization Name|Unique name of the organization.|  
|userlcid|User Language Code|Language code ID that is used by the current user.|  
|orglcid|Organization Language Code|Language code identifier that represents the base language for the organization.|  
  
[!INCLUDE[languagecode](../../includes/languagecode.md)]
  
 **Example**  
  
 The following sample shows the URL without parameters.  
  
```  
https://myserver/mypage.aspx  
```  
  
 The following sample shows the URL with parameters.  
  
```  
https://myserver/mypage.aspx?orgname=AdventureWorksCycle&userlcid=1033&orglcid=1033  
```  
  
### Reading passed parameters  
 Webpage (HTML) web resources will accept these parameters. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Passing parameters to HTML web resources](../webpage-html-web-resources.md#BKMK_PassingParametersToWebResources)  
  
### See also  
 [Change Application Navigation using the SiteMap](change-application-navigation-using-sitemap.md)    
 [SiteMap schema](sitemap-schema.md)  


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]