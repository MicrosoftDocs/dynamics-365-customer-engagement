---
title: "Place child nodes by using shortcuts for a portal in Dynamics 365  | MicrosoftDocs"
description: "Instructions to place child nodes by using shortcuts for portals."
ms.custom:
  - dyn365-a11y
  - dyn365-portal
ms.date: 09/28/2017
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 63185ade-f789-40dc-9d22-c96919740748
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Place child nodes by using shortcuts for portals
Use shortcuts to place child nodes throughout your portal's sitemap that simply point to other nodes that exist in your sitemap, or to URLs external to your portal. In other words, webpages, web files, events, and forums can all be considered "solid" nodes of your portal's sitemap: they are added to your sitemap and when you navigate to them, you see the actual content of those nodes directly. Shortcuts, on the other hand, can be considered “intangible” nodes: they are also added to the sitemap (unlike web links, which are not), but when you navigate to them, you see the content for the target "solid" node that the shortcut points to, and that content is rendered by the page template for that node.

## Manage shortcuts in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)]

Creating, editing, and deleting shortcuts can be done within [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)].

1. Sign in to **[!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)]**. 
2. Go to **Portals** &gt; **Shortcuts**. 
3. To create a shortcut: Select **New**. 
4. To edit an existing Shortcut: Double-click to select the existing **Shortcut** listed in the grid. 
5. Enter values for the fields provided. 
6. Select **Save & Close**

### Attributes and relationships

| Name                               | Description                                                                                                                                                                                  |
|------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Name                               | A Descriptive Name for the shortcut. For internal use only.                                                                                                                                  |
| Website                            | The website that the shortcut belongs to.                                                                                                                                                    |
| Parent Page                        | The parent webpage of the shortcut entity in the sitemap. The shortcut will be added to the sitemap as a child of this page.                                                                 |
| External URL                       | Target of the shortcut to a URL of a resource outside of your organization.                                                                                                                  |
| Web Page                           | Target of the shortcut to an internal webpage.                                                                                                                                               |
| Web File                           | Target of the shortcut to a web file.                                                                                                                                                        |
| Event                              | Target of the shortcut to an event.                                                                                                                                                          |
| Forum                              | Target of the shortcut to a forum.                                                                                                                                                           |
| Title                              | The title for the shortcut. This is the name that will appear in the sitemap and child navigation view areas. If left blank, the title (or name) of the target entity will be shown instead. |
| Description                        | A description to appear in child nav views. Optional.                                                                                                                                        |
| Display Order                      | The front-side editable order that the shortcut will appear in sitemap and child nav views, in relation to other nodes in the site map.                                                      |
| Disable Shortcut Target Validation | If unchecked, the security of the shortcut will be based on the target. Otherwise, it will be based on the parent. For more details, see "Security" below.                                   |
||

>[!Note]
> A shortcut needs only to have **one** of the 'Target' fields (External URL, Web Page, Survey, Web File, Event, Forum) assigned a value, and a shortcut will only have one target. For example, a shortcut does not point at both a Web Page and a survey, or an External URL and a Web File. If more than one target attribute exists for a shortcut, the shortcut will just take the first one, ignoring all others. The order of priority for which target will be chosen is reflected on the main [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] shortcut form. So, it will first check if there exists an External URL for the shortcut, and if there is, then the shortcut's target will be the External URL and all other target attributes will be ignored. If there is no External URL, then the shortcut will check the Web Page, then the Survey, Web file, Event, and finally Forum. 

## Secure shortcuts

Security for shortcuts can be based either on the parent page of the shortcut or on the target of the shortcut. This will determine whether the shortcut will be visible in the sitemap. Naturally, if security is based off the parent, the write access of the target of the shortcut will still determine whether front-side editing will function after the shortcut has been used to navigate to the target of the shortcut. Therefore, shortcut security only affects navigation and edit rights for front-side editing of shortcuts. The security method used is specific to the shortcut. If you leave the Boolean value **Disable Shortcut Target Validation** unselected, the security of the shortcut will be based on the target; otherwise, it will be based on the parent.

## Navigate with shortcuts

After the shortcut entity has been created, it will appear in your website. In the above example, Basic Site has two additional pages, Page One and Page Two. Page Two Is a Child of Page One, which is a Child of the Home Page. Additionally, there is a shortcut that is a child of the Home page which points to Page Two.

### See also

[Configure a Dynamics 365 portal](configure-portal.md)  
[Configure site settings for portals](configure-site-settings.md)  
[Configure Dynamics 365 portal authentication](configure-portal-authentication.md)  
[Define entity forms and custom logic within the Dynamics 365 portal](entity-forms-custom-logic.md)  
[Manage web links in Dynamics 365 or on portals](manage-web-links.md)  
