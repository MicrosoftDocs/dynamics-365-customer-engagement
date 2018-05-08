---
title: "Define entity forms and custom logic within a portal in Dynamics 365 | MicrosoftDocs"
description: "Instructions to create entity forms in a portal."
ms.custom:
  - dyn365-portal
ms.date: 12/05/2017
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 4da44fa7-ace1-4c7c-a989-867d7b91cff0
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Define entity forms and custom logic within the [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] portal

A data-driven configuration to allow end users to add a form to collect data in the portal without the need for a developer to surface the form in the portal, entity forms are created in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] and then placed into webpages in the portal or used in conjunction with subgrids and entity lists to build out complete web applications. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Add a webpage to render a list of records](add-webpage-render-list-records.md) 

![Contact us form](media/contact-us-form.png "Contact us form")  

## Add a form to your portal

The entity form contains relationships to webpages and additional properties to control the initialization of the form within the portal. The relationship to webpages allows dynamic retrieval of the form definition for a given page node within the [website](#website-1).  

To view existing entity forms or to create new entity forms, go to **Portals** &gt; **Entity Forms**.

When creating a new entity form, the first step is to decide the **Entity** and **Form Name** that you will be rendering, in addition to the **mode: Insert, Edit, or Read Only**. The mode selected will determine if you are creating a new record from the portal, editing an existing record, or just displaying information about a record on the portal.

> [!Note]
> - An **Entity Form** must be associated with a webpage for a given [website](#website-1) for the form to be viewable within the site.
> - The Connection entity subgrids are not supported in entity forms. If you add a Connection entity subgrid to the form using Form designer, error messages are displayed when you render the form on the portal and use the Connection entity.

The webpages associated with the entity form can be viewed by selecting the **Web Pages** link listed in the **Related** navigation links in the leftmost menu.

When creating or editing a webpage, an **Entity Form** can be specified in the lookup field provided on the Web Page form.

The various master pages used by the portal found in the [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] portal installation directory contain declarations of the **EntityForm** server control. When rendering the webpage containing either the Page (~/Pages/Page.aspx) page template or Full Page (~/Pages/FullPage.aspx) page template, the controls will determine whether the entity form lookup contains a value, in which case the form will be rendered.

## Secure your forms

To secure your forms, you must create entity permissions that determine access and ownership of the records in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] according to web roles. If a user lands on an entity form and does not have permissions, they will receive an error message. To enable permissions for an entity form, set **Enable Entity Permissions** to true. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Create web roles for portals](create-web-roles.md).  

## Geolocation configuration for entity forms

A managed form can be configured to display a map control to either display an existing location as a pin on a map or to provide the ability for the user to specify a location. See [Add Geolocation](add-geolocation.md).

The form's map control requires additional configuration to tell it what the IDs of the various location fields are, to assign values to them or retrive values from them. The Entity Form record in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] has a configuration section that defines these field mappings that you must specify. The field names will vary depending on the schema you have created.

![Geolocation data in entity form](media/geolocation-managed-form.png "Geolocation data in entity form") 

> [!Note]
> - The address field in a read-only entity form is replaced with the map when geolocation is enabled.
> - The Geolocation section is not visible in the German Sovereign Cloud environment. If a user has enabled geolocation by using a different form, it will not be displayed during rendering on portal.

### See also

[Configure a Dynamics 365 portal](configure-portal.md)  
[Web Form properties for portals](web-form-properties.md)  
[Web Form steps for portals](web-form-steps.md)  
[Web Forms metadata for portals](configure-web-form-metadata.md)  
[Web Form subgrid configuration for portals](configure-web-form-subgrid.md)  
[Notes configuration for Entity Forms and Web Forms for portals](configure-notes.md)
