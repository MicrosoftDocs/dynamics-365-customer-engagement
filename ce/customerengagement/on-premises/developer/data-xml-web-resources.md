---
title: "Data (XML) Web resources (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Learn about using data (XML) Web resources to save and access data."
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
  - web resource, xml
ms.assetid: beb9d687-1a93-4a93-a96f-86b28e5683a5
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Data (XML) Web resources

Use Data (XML) Web resources to save and access data.  
  
## Capabilities of XML Web resources  
 Use XML Web resources to cache data that you want to use in your solution.  
  
### Limitations of XML Web resources  
 Use XML Web resources to cache configuration settings or metadata for your solutions.  
  
 An XML Web resource does not represent a robust solution for data that is frequently updated by multiple users. While one user is updating an XML Web resource, another user (or automated process) could update the Web resource and that data would be lost when the first user saves their changes.  
  
 All XML files must use the .xml file name extension. Files that use XML data but do not use the .xml file name extension cannot be uploaded as Web resources unless the file name extension is changed.  
  
### See also  
 [Web Resources for Dynamics 365 Customer Engagement (on-premises)](web-resources.md)   
 [Using Web Page (HTML) Web Resources](webpage-html-web-resources.md)   
 [Using Style Sheet (CSS) Web Resources](css-web-resources.md)   
 [Using Script (JScript) Web Resources](script-jscript-web-resources.md)   
 [Using Image (JPG, PNG, GIF) Web Resources](image-web-resources.md)   
 [Using Silverlight (XAP) Web Resources](silverlight-xap-web-resources.md)   
 [Using Stylesheet (XSL) Web Resources](stylesheet-xsl-web-resources.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]