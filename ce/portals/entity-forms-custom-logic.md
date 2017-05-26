---
title: "Define entity forms and custom logic within a portal in Dynamics 365 | MicrosoftDocs"
description: ""
ms.custom: ""
ms.date: 05/22/2017
ms.service: crm-online
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 4da44fa7-ace1-4c7c-a989-867d7b91cff0
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Define entity forms and custom logic within the Dynamics 365 portal



A data driven configuration to allow end users to add a form to collect data in the portal without the need for a developer to surface the form in the portal. Entity Forms are created in Dynamics 365 and then placed into webpages in the Portal or used in conjunction with Sub-Grids and Entity Lists to build out complete web applications. More information: [Add a webpage to render a list of records](add-webpage-render-list-records.md).  

![Contact us form](media/contact-us-form.png "Contact us form")  

## Add a form to your portal

The Entity Form contains relationships to webpages and additional properties in order to control the initialization of the form within the portal. The relationship to Web Page allows dynamic retrieval of the form definition for a given page node within the [website](#website-1).  

To view existing Entity Forms or to create new Entity Forms navigate to **Portals &gt; Entity Forms**

When creating a new Entity Form the first step is to decide the **Entity** and **Form Name** that you will be rendering as well as the **mode: Insert, Edit, or Read Only**. The mode selected will determine if you are creating a new record from the portal, editing an existing record, or just displaying info about a record on the portal.

>[!Note]
> An **Entity Form** must be associated with a Web Page for a given [website](#website-1) for the form to be viewable within the site.

The Web Pages associated with the Entity Form can be viewed by clicking the **Web Pages** link listed in the **Related** navigation links in the leftmost menu.

When creating or editing a Web Page, an **Entity Form** can be specified in the lookup field provided on the Web Page form.

The various master pages used by the portal found in the Dynamics 365 portal installation directory contains declarations of the **EntityForm** server control. When rendering the Web Page containing either the Page (~/Pages/Page.aspx) page template or Full Page (~/Pages/FullPage.aspx) page template, the controls will determine if the Entity Form lookup contains a value then the form will be rendered.

## Secure your forms

To secure your forms, you must create entity permissions that determine access and ownership of the records in Dynamics 365 according to Web Roles. If a user lands on an Entity Form and does not have permissions, they will receive an error message. To Enable Permissions for an Entity Form. set **Enable Entity Permissions** to true. More information: [Create web roles for portals](create-web-roles.md).  

### See Also

[Configure a Dynamics 365 portal](configure-portal.md)  
[Web Form properties for portals](web-form-properties.md)  
[Web Form steps for portals](web-form-steps.md)  
[Web Forms metadata for portals](configure-web-form-metadata.md)  
[Web Form subgrid configuration for portals](configure-web-form-subgrid.md)  
[Notes configuration for Web Forms for portals](configure-notes.md)  

