---
title: "Image web resources (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Learn about using image web resources to make images available for use in Dynamics 365 Customer Engagement (on-premises). "
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
  - images
  - web resource, image
ms.assetid: dfa3f3e2-471e-4295-be47-ab6936189340
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Image web resources

Use image web resources to make images available for use in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  

There are 5 types of image web resources: 
* PNG Format
* JPG Format
* GIF Format
* ICO Format
* Vector Format (SVG)

> [!NOTE]
> Vector Format (SVG) web resources were added with the [!INCLUDE[../includes/pn-crm-9-0-0-online.md](../includes/pn-crm-9-0-0-online.md)].

  
<a name="BKMK_Capabilities"></a>   
## Capabilities of image web resources  
 With image web resources you can add images where you need them. Common uses include the following:  
  
- Custom entity icons  
- Icons for custom Ribbon controls and `SiteMap` subareas  
- Decorative graphics for entity forms and webpage web resources.  
- Background images that are used by CSS web resources.  

Use Vector Format (SVG) web resources for any icon presented in the application. Vector images are defined as Scalable Vector Graphics (SVG) an XML-based vector image format. The advantage of vector images over other image web resources is that they scale. You can define one vector image and re-use it rather than provide multiple sizes of images. You will use these in with a new <xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata>.<xref:Microsoft.Xrm.Sdk.Metadata.EntityMetadata.IconVectorName> property to define the icon for a custom entity instead of the `IconLargeName`, `IconMediumName`, or `IconSmallName` properties.
  
<a name="BKMK_Limitations"></a>   
## Limitations of image web resources  
 Like all web resources, image web resources use the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] security context. Only licensed [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] users who have the necessary privileges can access them.  
 
  
<a name="BKMK_ReferenceFromWebPageWebResource"></a>   
## Reference an image web resource from a webpage web resource  
 All web resources can use relative URLs to reference each other. In the following example, for the webpage (HTML) web resource named "new_/content/contentpage.htm" to reference the image web resource named "new_/Images/image1.png", add the following HTML image tag to the webpage (HTML) web resource named "new_/content/contentpage.htm":  
  
```html  
<img src="../Images/image1.png" />  
```  
  
<a name="BKMK_ReferenceFromForm"></a>   
## Reference an image web resource from a Dynamics 365 Customer Engagement (on-premises) form  
  
#### Add an image to an entity form  
  
1.  Navigate to the form editor for an entity.  
  
2.  Select where you want to add the image in the form.  
  
3.  On the **Insert tab**, click **Web Resource**.  
  
4.  On the **General** tab, select the web resource image that you want to add.  
  
5.  Specify a name for the web resource. You can also specify a label and alternative text.  
  
6.  On the **Formatting** tab, you can define:  
  
    -   The number of columns the images should use.  
  
    -   The number of rows the images should use, or if it should automatically expand to use available space.  
  
    -   The size of the image using the following options:  
  
        - **Stretch to fit**  
  
        - **Stretch to fit (maintain aspect ratio)**  
  
        - **Original**  
  
        - **Specific**  
  
    -   If you select “Specific,” you can enter the desired height and width in pixels.  
  
7.  Click **OK**.  
  
8.  You must save your changes and publish the form before users can see the image in the form.  
  
<a name="BKMK_ReferenceWithWebResourcedirective"></a>   
## Reference an image web resource from a ribbon element or from the Site Map subarea  
 Use the `$webresource:` directive to specify a web resource image to use as an icon in the ribbon or in the application navigation using Site Map. The following sample shows how to specify icons for a button in the ribbon.  
  
```xml  
<Button Id="MyISV.opportunity.form.actions.FlyoutAnchor.Button.1" Image16by16="$webresource:new_/icons/oneIcon16.png" Image32by32="$webresource:new_/icons/oneIcon32.png"/>  
```  
  
> [!NOTE]
>  Using the `$webresource:` directive adds a solution dependency that prevents the referenced image web resources from being deleted as long as they are used by another solution component.  
  
### See also  
 [Web Resources for Dynamics 365 Customer Engagement (on-premises)](web-resources.md)   
 [Using Web Page (HTML) Web Resources](webpage-html-web-resources.md)   
 [Using Style Sheet (CSS) Web Resources](css-web-resources.md)   
 [Using Script (JScript) Web Resources](script-jscript-web-resources.md)   
 [Using Data (XML) Web Resources](data-xml-web-resources.md)   
 [Using Silverlight (XAP) Web Resources](silverlight-xap-web-resources.md)   
 [Using Stylesheet (XSL) Web Resources](stylesheet-xsl-web-resources.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]