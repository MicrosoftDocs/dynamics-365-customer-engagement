---
title: "Manage SharePoint documents on a portal in Dynamics 365 | MicrosoftDocs"
description: "Instructions to manage SharePoint document in a portal."
ms.custom: 
  - dyn365-portal
ms.date: 10/01/2018
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 5AF82567-EF2A-47FE-917E-4877B0FA6DBD
ms.reviewer: ""
author: sbmjais
ms.author: shjais
manager: shubhadaj
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Portals
---

# Manage SharePoint documents

Dynamics 365 supports integration with SharePoint Online that enables you to use the document management capabilities of SharePoint from within Dynamic 365. Dynamics 365 Portal now supports uploading and displaying documents to and from SharePoint directly on an entity form or web form in a portal. This allows portal users to view, download, add, and delete documents from a portal. Portal users can also create sub-folders to organize their documents.

> [!NOTE]
> Document management works only with SharePoint Online.
> Document management is supported with server-based integration.

To work with document management capabilities of SharePoint from within Dynamic 365, you must:
1.	Set up SharePoint integration from Portal Admin Center
2.	Enable document management functionality in Dynamics 365
3.	Enable document management for entities
4.	Edit the appropriate form in Dynamics 365 to display documents
5.	Create appropriate entity permission and assign it to the appropriate web role

## Step 1: Set up SharePoint integration from Portal Admin Center

To use the document management capabilities of SharePoint from within Dynamic 365, you must enable SharePoint integration from Portal Admin Center.

> [!NOTE]
> You must be a global administrator to perform this action.

1.	Go to the Dynamics 365 Administration Center page and select the **Applications** tab.
2.	Select the name of the portal for which you want enable SharePoint integration, and then select **Manage**.
3.	Go to Set up SharePoint integration > Enable SharePoint integration.
4.	Select **Enable** in the confirmation window. This will enable the portal to communicate with SharePoint. While the SharePoint integration is being enabled, the portal restarts and will be unavailable for a few minutes. A message appears when SharePoint integration is enabled.

When SharePoint integration is enabled, the following action becomes available:

- **Disable SharePoint integration**: Allows you to disable the SharePoint integration with your portal. While the SharePoint integration is being disabled, the portal restarts and will be unavailable for a few minutes. A message appears when SharePoint integration is disabled.

> [!NOTE]
> Enabling or disabling the SharePoint integration will update the Azure Active Directory application for the portal and add or remove the required SharePoint permissions, respectively. You will also be redirected to provide your consent for the changes to be made in Azure Active Directory application. 

If you do not provide your consent:

- Enabling or disabling the SharePoint integration will not be complete and an error message is displayed.

- Your Azure AD login on the portal will not work. 

## Step 2: Enable document management functionality in Dynamics 365

You must enable document management functionality in Dynamics 365 by using server-based SharePoint integration. Server-based SharePoint integration allows Dynamics 365 (online) and SharePoint Online to perform a server-to-server connection. The default SharePoint site record is used by portal. For information on how to enable document management functionality in Dynamics 365, see [Configure server-based authentication with Dynamics 365 (online) and SharePoint Online](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/admin/configure-server-based-authentication-sharepoint-online).

## Step 3: Enable document management for entities
You must enable document management for entities to store documents related to Dynamics 365 entity records in SharePoint. For information on how to enable document management for entities, see [Enable SharePoint document management for specific entities](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/admin/enable-sharepoint-document-management-specific-entities).

## Step 4: Configure the appropriate form to display documents

### Dynamics 365 customization

Identify the form where you want to use document management capabilities. You must edit the form by using Dynamics 365 form editor and add a sub-grid to it. The sub-grid adds a section to the form, which allows you to work with documents from within a portal. You must set the following properties in the sub-grid for this feature to work:

- Under **Data Source**, select **Document Locations** from the **Entity** list.

- Under **Data Source**, select **Active Document Locations** from the **Default View** list.

You can specify name and label as per your requirement. Save and publish the form once the sub-grid is added and configured.

> [!NOTE]
> Document management must be enabled for the entity for which you edit the form. More information: [Enable document management for entities](#enable-document-management-for-entities)

### Dynamics 365 Portal configuration

If you do not already have an entity or web form configured, then configure one. For more information on configuring entity forms, see Add a form to your portal. If you are configuring this on a web form, see Define web form properties for portals and Define web form steps for portals.

Apart from the standard configuration required for entity form or web form, you must set the following properties to enable document management:

- **Entity Name** and **Form Name**: Enter the Dynamics 365 entity and form names customized in the previous step, respectively.

- Select the **Enable Entity Permission** check box on the form to allow a user to read the documents.

- Set the **Mode** to **Edit** to allow document uploads.

## Step 5: Create appropriate entity permission and assign it to the appropriate web role

Two entity permission records are required to establish the necessary access to view and upload documents.

- Permissions on the entity of the Entity or Web Form: 
    - Create an Entity Permission record specifying the Entity Name as the entity of the Entity Form or Web Form configured previously. 
    - Select a Scope and scope relationship that is appropriate to the desired behavior of the form. 
    - Enable Read and Append To privileges to allow read access to documents and optionally enable Write privilege to allow document uploads. Ignore the Child Entity Permissions section for now since it will be populated by the next step.
- Permissions on the Document Location with Parent scope referring to the previous permission record: 
    - Create an Entity Permission record specifying the Entity Name as Document Location entity with Scope set to Parent. 
    - Select the Parent Entity Permission to the entity permission record created in previous step. 
    - Privileges 
        - The minimum privileges to allow read access to documents are Read, Create, and Append. 
        - Include Write privileges for document upload access. 
        - Include Delete to allow deletion of a document.
