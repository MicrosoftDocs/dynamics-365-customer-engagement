---
title: "Change application navigation using the SiteMap (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The site map enables you to control the application navigation (menus) and other options in Dynamics 365 Customer Engagement such as editing labels, adding or changing icons, and adding or changing elements."
keywords: 
ms.date: 10/31/2017
ms.service: crm-online
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 6edb9094-bde0-4e5d-bb57-957676c86bec
author: KumarVivek
ms.author: kvivek
manager: amyla
ms.reviewer: pehecke
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 57
search.audienceType: 
  - developer
---

# Change application navigation using the SiteMap

The      site map enables you to control the application navigation (menus) and other options in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] such as editing labels, adding or changing icons, and adding or changing elements.  
  
<a name="BKMK_ApplicaitonNavigation"></a>   
## Application navigation  
 The `SiteMap` provides the structure for navigation in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)]. 
 It is evaluated together with your security privileges to display navigation options in the application. 
 If your security privileges do not provide read access to an entity specified in the SiteMap, that navigation option will not be displayed to you. 
 The `<Privilege>` element can also be used to specify privilege requirements to view a page that is not related to a specific entity.  
  
 To understand the data that defines the application navigation options, compare what you see in the application with the `sitemap` element exported from your organization.  
  
### Web application navigation bar  
 The following image shows the web application navigation bar. The default areas shown are **Sales** (SFA             ), **Service** (CS             ), **Marketing** (MA), **Settings**, and **Help Center** (HLP             ).  
  
 ![SiteMap shows Areas in Dynamics 365 Customer Engagement](../media/sitemap-areas.png "SiteMap shows Areas in Dynamics 365 Customer Engagement")  
  
 Selectable areas appear at the bottom of the navigation bar. When an             *area* is selected, the area displays as the             *selected area*. The most recently used             *subarea* for that area is automatically shown. When the selected area is chosen, the available groups and subareas are displayed as shown in the following image.  
  
 ![SiteMap shows groups and subareas in Dynamics 365 Customer Engagement](../media/sitemap-group-label.png "SiteMap shows groups and subareas in Dynamics 365 Customer Engagement")  
  
 In this image, the **Sales** (SFA) area is selected and the groups **My Work**, **Customers**, **Sales** (SFA), **Collateral**, **Marketing** (MA), **Goals**, and **Tools**are visible.  
  
 Each group contains a number of subareas. When a subarea is selected, the content defined in the site map for that subarea is displayed below the navigation bar.  
  
### [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] navigation  
 The following diagram shows the [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] navigation. [!INCLUDE[pn_MS_Outlook_Short](../../includes/pn-ms-outlook-short.md)] presents each navigation area in alphabetical order in a tree view instead of using the order specified in the             `SiteMap`. Each person can position the reading pane at the bottom as shown or on the side. They can also hide it. Each entity can be configured to determine whether it will display the reading pane. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Editable Entity Properties](../customize-entity-metadata.md#BKMK_OpenOptions)  
  
 ![SiteMap in Outlook](../media/sitemap-outlook-highlight.png "SiteMap in Outlook")  
  
<a name="BKMK_ConfigurationOptions"></a>   
## Configuration options available by using the SiteMap  
 The following sections describe common tasks that can be performed by using the `SiteMap`.  
  
<a name="BKMK_EditLabels"></a>   
### Edit labels  
 All of the text displayed in the default `SiteMap` uses a `ResourceId` attribute to specify the text. You should not change or remove the `ResourceId` attribute values. 
 If you want to change the label displayed in an element, use the `<Titles>` and `<Title>` elements to specify the text you want to use for your organization or solution. 
 Any title elements will override the `ResourceId` attribute values.  
  
<a name="BKMK_AddorChangeIcons"></a>   
### Add or change icons  
 Both `<Area>` and `<SubArea>` elements have an `Icon` attribute that you can use to specify the size and other characteristics of the image to display as the icon.  
  
 After [!INCLUDE[pn_crm_2015_sp_shortest](../../includes/pn-crm-2015-sp-shortest.md)], 
 the icons for the `<Area>` are 85x71 (width x height) pixel image, white in color, and with 18% opacity. The `<SubArea>` menus use 32x32 pixel image as entity icons.  
  
 ![Pixel sizes of the icons in Dynamics 365 Customer Engagement](../media/crm-icon-pixe-lsize.png "Pixel sizes of the icons in Dynamics 365 Customer Engagement")  
  
 You should use a GIF, PNG, or JPG image web resource as the source of your icon. When you reference the web resource, make sure that you use the web resource directive             ($webresource:). For example, use             `Icon="$webresource:sample_/icons/MyAreaIcon1.png"` when the name of the web resource is             “sample_/icons/MyAreaIcon1.png”. Using this directive will create a dependency so that the web resource can’t be deleted as long as your             `SiteMap` element requires it.  
  
<a name="BKMK_AddorRemoveElements"></a>   
### Add or remove elements  
 **To add elements**  
 When editing  XML elements in the `SiteMap`, you can to copy and paste existing XML elements to provide an advanced starting point.  
  
> [!IMPORTANT]
>  If you create a new element it must have a unique `Id` attribute value or importing your solution will fail. 
>  You should prepend an appropriate solution publisher customization prefix to the `Id` value of any new elements that you add.  
  
 [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Add new pages to an Area](change-application-navigation-using-sitemap.md#BKMK_AddPagesToArea)  
  
 **To remove elements**  
 Before you remove elements in the `SiteMap`, consider whether editing the security role privileges for users will achieve your goal. 
 Each `<SubArea>` element that is associated with an entity page is evaluated with the user’s privileges and only shown if a user is allowed to view records for that entity.  
  
 If the subarea displays a page, such as a web resource that is not associated with a specific entity, you can add `<Privilege>` elements to the subarea to associate that 
 page with privileges for a specific action or access to an entity.  
  
 If none of the subarea elements in a `<Group>` or `<Area>` can be viewed by a user because of their security privileges, that element will not be displayed.  
  
 If you use the `<SubArea>` `AvailableOffline` attribute to prevent a subarea from being displayed while the 
 [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] user is working offline, users can still navigate 
 to the subarea but they’ll see a message indicating that the page to display isn’t available offline.  
  
> [!NOTE]
>  We recommend that you use security role privileges to control access to areas of the application.  
  
 If you do not want to edit security roles, you can comment out the node in the `SiteMap` XML. Commenting out a node is better than deleting it because you can always 
 uncomment the node if you want to restore it in the future.  
  
<a name="BKMK_GroupLinksInAreas"></a>   
### Group links within areas  
 The **Workplace** and the **Settings** areas include multiple groups of links. You can use the `<Group>` element in a similar manner to create groups in the other areas. 
 A group element is required, but you must include the `<Title>` and `<Description>` elements for it to be displayed as a group. 
 Finally, you must edit the `<Area>` element to add the `ShowGroups` attribute and set it to `true`.  
  
<a name="BKMK_AddPagesToArea"></a>   
### Add new pages to an area  
 Use `<SubArea>` elements to add new pages to an area. If you want to include a grid for an entity, you include a unique ID, specify the entity by using the `Entity` attribute, 
 and then provide a title and description by using the `<Title>` and `<Description>` elements.  
  
 To display a custom page in the application, you must set the `Url` attribute instead of the `Entity` attribute. The `Url` attribute can reference a page on an external 
 website or an HTML web resource.  
  
 When referencing the  HTML web resource, make sure that you use the web resource directive  `$webresource:`. 
 For example, use `Icon="$webresource:sample_/Pages/MyCustomPage.htm"` when the name of the  HTML web resource is `sample_/Pages/MyCustomPage.htm`. 
 Using this directive will create a dependency so that the HTML web resource can’t be deleted as long as your `SiteMap` element requires it.  
  
  
 When adding an external page from the `SiteMap`, it’s a common requirement to pass data in the form of a query string to the page. 
 To pass information about your organization name and the language for the user and organization, use the `PassParams` attribute. 
 [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Passing Parameters to a URL Using SiteMap](pass-parameters-url-using-sitemap.md)  
  
### See also  
 [Customize Dynamics 365 Customer Engagement](customize-applications.md)    
 [Passing Parameters to a URL Using SiteMap](pass-parameters-url-using-sitemap.md)   
 [Extend the Metadata Model](../org-service/use-organization-service-metadata.md)   
 [Customize Entity Forms](customize-entity-forms.md)   
 [Customize Visualizations and Dashboards](customize-visualizations-dashboards.md)   
 [Customize Entity Views](customize-entity-views.md)   
 [Customize Global Option Sets](../org-service/customize-global-option-sets.md)   
 [Customize commands and the ribbon](customize-commands-ribbon.md)   
 [Service Calendar Appearance Configuration](service-calendar-appearance-configuration.md)   
 [Publish Customizations](publish-customizations.md)   
 [When to Edit the Customizations File](when-edit-customization-file.md)


[!INCLUDE[footer-include](../../../../includes/footer-banner.md)]
