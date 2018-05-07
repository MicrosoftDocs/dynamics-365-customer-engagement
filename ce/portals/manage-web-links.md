---
title: "Manage web links in Dynamics 365 or on portals in Dynamics 365 | MicrosoftDocs"
description: "Instructions to manage web links in Dynamics 365 or on portals."
ms.custom:
  - dyn365-portal
ms.date: 09/28/2017
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 70c3e73d-c426-4bdd-b5cd-5fa2f410fd9b
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Manage web links in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] or on portals

A web link can link to any URL or it can link to another webpage within the same website. When a web link is to a webpage, the security and publishing state of the webpage will apply to the web link as well. Web links are always part of a web link set. A web link set is a group of links such as a primary navigation or a group of footer links. Web link sets allow internal, regardless of placement in the site map, and external links to be grouped together and ordered.

## Manage web links in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)]

For [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] users, once the portal customizations have been imported into the [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] organization, Web links can be managed in the Portals section.

## Manage web links in a portal

To modify a web link set, you need appropriate permissions and the web link set you want to modify must be part of the page template. To edit a web link set, point to the web link set and select the blue edit button that appears. Drag and drop the move icon to reorder the web links. Select the paper & pencil icon to edit a web link. Select the red minus icon to delete a web link from the set. Select the green plus icon to add a new web link to the set.

## Multilevel web link sets

Web link sets can support a multilevel tree of web links. This allows the creation of multilevel link menus and navigation elements.

Links can be moved to their desired level and position using drag-and-drop, in the same way that they are re-ordered. A light blue placeholder indicates where the link will be dropped. Any light yellow placeholders that appear during the drag indicate that the web link above has no child links, and the dragged web link can be dropped here to make it a child of that link.

## Web link set attributes and relationships

The table below explains many of the standard Web Link Set properties used by portals. It is important to note that the way in which many of the content/display-oriented properties are rendered is controlled by the page template used.

| Name    | Description                                                                                                                                                                                  |
|---------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Name    | The descriptive name of the web link set. This value usually describes the placement of the set in the page template such as "Primary Navigation." This field is required.                   |
| Website | The website to which the entity belongs. This field is required.                                                                                                                             |
| Title   | An optional title for the web link set. This value can be used on the portal if it's part of the page template. It could be something like "Our Partners" and be displayed in a side bar.    |
| Copy    | An optional description for the web link set. This value can be used on the portal if it's part of the page template. It could further describe something like "Our Partners" in a side bar. |
||

## Web link attributes and relationships

The table below explains many of the standard Web Link properties used by [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] portals. It is important to note that the way in which many of the content/display-oriented properties are rendered is controlled by the page template used.

| Name                     | Description                                                                                                                                                                                                                             |
|--------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Name                     | The title for the web link. This value will be used as the web link title in most templates. This field is required.                                                                                                                    |
| Web Link Set             | The web link set to which the entity belongs. This field is required.                                                                                                                                                                   |
| Parent Web Link          | The parent web link of the entity, in a multilevel web link set. If no parent web link is specified, the entity is at the top/root level of the web link set.                                                                           |
| Page                     | An optional webpage from the same website to link to.
  External URL             | An optional URL to link to. This value can be any properly formatted URL.                                                                                                                                                               |
| Description              | An optional summary for the web link. This value can be used on the portal if it's part of the page template.                                                                                                                           |
| Publishing State         | The current publishing workflow state of the web link, which may dictate whether the web link is visible on the site. The most common use of this feature is to provide "published/draft" control over content. This field is required.  |                                                                       |
| Robots Follow Link       | Indicates whether or not search indexers should follow and index the contents of the link. This field is required.                                                                                                                      |
| Display Order            | An integer value indicating the order in which the web link will be placed, relative to other web links within the same web link set.                                                                                                   |
| Display Page Child Links | In a template that supports multilevel web link sets, generate child links for this entity using the portal site map provider. Note that this option is only valid for web links that refer to internal pages, and not external URLs.   |
| Open in New Window       | Indicates whether selecting the link will load the link in a new browser window.                                                                                                                                                        |
| Disable Page Validation  | Indicates whether the security of a linked webpage will be applied to the web link as well.                                                                                                                                             |
| Image URL                | An optional URL to an image. The linked image can be used on the portal if it's part of the page template; for example, as an icon.                                                                                                     |
| Image Height             | An optional height for the image from the Image URL property.                                                                                                                                                                           |
| Image Width              | An optional width for the image from the Image URL property.                                                                                                                                                                            |
| Image Alt Text           | An optional description for the image from the Image URL property.                                                                                                                                                                      |
| Display Image Only       | Indicates that the template should render only an image link for this web link, rather than both the image and link name together.                                                                                                      |
||

> [!Note]
> - When a web link is to a webpage, the security and publishing state of the webpage will apply to the web link as well. This validation can be disabled with the "Disable Page Validation" option. 
 - Users with content management permissions may be granted the ability to use "Preview Mode", which allows these users to see ("preview") unpublished content.

### See also

[Get started with the portal content editor](get-started-portal-content-editor.md)  
[Customize content by using content snippets](customize-content-snippets.md)
