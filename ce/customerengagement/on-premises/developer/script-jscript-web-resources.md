---
title: "Script(JScript) web resources (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Learn about using JavaScript web resources to create a library of JavaScript functions that can be accessed from anywhere. "
ms.custom: 
ms.date: 03/02/2018
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - web resource, Jscript
ms.assetid: 882565b5-aa86-475e-971a-b5123bbadcf9
caps.latest.revision: 25
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Script(JScript) web resources

Use Script(JScript) web resources to create a library of [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] functions that can be accessed from anywhere.  
  
<a name="BKMK_capabilities"></a>   
## Capabilities of script web resources  
 With [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] web resources, you can more efficiently manage code used in form scripts, webpage (HTML) web resources, or ribbon commands by linking them to shared library of [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] functions.  
  
<a name="BKMK_limitations"></a>   
## Limitations of script web resources  
 Like all web resources, [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] web resources use the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] web application security context. Only licensed [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] users who have the necessary privileges can access them.  
  
> [!NOTE]
>  References included in code between web resources aren’t tracked as solution dependencies.  
  
<a name="BKMK_Using"></a>   
## Using JavaScript libraries  
 For information about developing and testing [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] libraries as well as how to associate them with ribbon commands and form events, see [Client scripting in Customer Engagement using JavaScript](clientapi/client-scripting.md).  
  
<a name="BKMK_Referencing"></a>   
## Referencing a script web resource from a webpage web resource  
 All web resources can use relative URLs to reference each other. In the following example, for the webpage web resource `new_/content/contentpage.htm` to reference the [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] web resource `new_/scripts/myScript.js`, add the following HTML code to the head element of `new_/content/contentpage.htm`.  
  
```html  
<script type="text/jscript" src="../scripts/myScript.js"></script>  
```  
  
 To reference a [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] from a different publisher, the path must include the customization prefix for that publisher. For example, for the `new_/content/contentpage.htm` page to reference the `MyIsv_/scripts/customscripts.js` page, the `src` attribute value should be `../../MyIsv_/scripts/customscripts.js`.  
  
### See also  
 [Use JavaScript with Customer Engagement (on-premises)](use-javascript.md)   
 [Client scripting in Customer Engagement (on-premises) using JavaScript](clientapi/client-scripting.md)   
 [Web Resources for Dynamics 365 Customer Engagement (on-premises)](web-resources.md)   
 [Using Web Page (HTML) Web Resources](webpage-html-web-resources.md)   
 [Using Style Sheet (CSS) Web Resources](css-web-resources.md)   
 [Using Data (XML) Web Resources](data-xml-web-resources.md)   
 [Using Image (JPG, PNG, GIF) Web Resources](image-web-resources.md)   
 [Using Silverlight (XAP) Web Resources](silverlight-xap-web-resources.md)   
 [Using Stylesheet (XSL) Web Resources](stylesheet-xsl-web-resources.md)   
 [Streamline web resource development using Fiddler AutoResponder](streamline-javascript-development-fiddler-autoresponder.md)    


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]