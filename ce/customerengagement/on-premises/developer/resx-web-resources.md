---
title: "String (RESX) web resources (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Learn about using string web resources to make localized strings available for use in Dynamics 365 Customer Engagement. "
ms.custom: 
ms.date: 12/28/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 2abb6e22-c64c-4f87-8b55-9f4405103cec
caps.latest.revision: 19
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# String (RESX) web resources

Use these web resources to manage localized strings in any user interface you define or with error messages you will display. 

> [!NOTE]
> String (RESX) web resources were added with the [!INCLUDE[../includes/pn-crm-9-0-0-online.md](../includes/pn-crm-9-0-0-online.md)].

## Using RESX web resources

<!-- 
Much of this content also found in developer/clientapi/reference/Xrm-Utility/getResourceString.md
If you change this, make sure that topic is in sync.
-->

RESX web resources contain the keys and localized string values for a single language defined using the RESX XML format. RESX is a common format for defining localized resources for windows applications, so there is common tooling available to work with this type of file and localization vendors will be familiar with working with them. When the file is published as a web resource in CRM, it will be converted to a JSON format, which will be downloaded to the application when needed.

When you create RESX web resources, you must explicitly set the language value and include the locale identifier (LCID) for the appropriate language in the name of the web resource. For example, `new_/strings/MyAppResources.1033.resx` would contain resources for English language. See [Microsoft Locale ID Values](/previous-versions/windows/embedded/ms912047(v=winembedded.10)) for a list of LCID values.

To extract the localized value, use the [Xrm.Utility.getResourceString](/powerapps/developer/model-driven-apps/clientapi/reference/Xrm-Utility/getResourceString) function. This function accepts two parameters: `WebResourceName` and `keyValue`. 

For example, `Xrm.Utility.getResourceString("new_/strings/MyAppResources","hello")` will return the localized string value for the resource key hello within the `new_/strings/MyAppResources.1033.resx` web resource if the user’s preferred language is English. Notice that the function doesn’t refer to any specific language or full name of any RESX web resource. This functionality depends on the RESX web resource being associated to the calling JavaScript web resource as a dependency. More information: [Web Resource dependencies](web-resource-dependencies.md).

The appropriate string value will be determined by the individual user’s language preference and the languages available in the organization. If a localized string is not found that matches the user’s language preference, the localized string will automatically fallback to the base language for the organization. If no matching localized string is found for the organizations base language, a null value will be returned.

### See also
[Web resources for Dynamics 365 Customer Engagement (on-premises)](web-resources.md)<br />
[Create accessible web resources](create-accessible-web-resources.md)<br />
[Create web resources and IFrame content for use with the Dynamics 365 Customer Engagement (on-premises) for mobile clients](create-web-resources-iframe-mobile.md)<br />
[Web resource dependencies](web-resource-dependencies.md)<br />
[Webpage (HTML) web resources](webpage-html-web-resources.md)<br />
[Silverlight (XAP) web resources](silverlight-xap-web-resources.md)<br />
[Script (JScript) web resources](script-jscript-web-resources.md)<br />
[Image (JPG, PNG, GIF, ICO) web resources](image-web-resources.md)<br />
[Stylesheet (XSL) web resources](stylesheet-xsl-web-resources.md)<br />
[Data (XML) Web resources](data-xml-web-resources.md)<br />
[CSS web resources](css-web-resources.md)<br />
[WebResource entity messages and methods](webresource-entity-messages-methods.md)<br />
[Sample: Pass multiple values to a  web resource through the data parameter](sample-pass-multiple-values-web-resource-through-data-parameter.md)<br />
[Sample: Import files as web resources](sample-import-files-web-resources.md)<br />
[Sample: Web resource utility](sample-web-resource-utility.md)<br />


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]