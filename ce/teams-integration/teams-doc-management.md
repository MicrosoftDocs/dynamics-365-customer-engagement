---
title: "Document management in Microsoft Teams integration| MicrosoftDocs"
ms.custom: 
description: "How file and document works with Microsoft Teams integration and SharePoint "
ms.date: 02/18/2021
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 apps
ms.assetid: 8097c9ec-023b-407d-ac0e-074b5e1964a5
caps.latest.revision: 1
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - enduser
search.app: 
  - D365CE
  - Powerplatform
---
# Document management in Microsoft Teams integration

Document management with SharePoint lets you manage common document types, such as Word, Excel, PowerPoint, and OneNote. You can also create folders to save and manage those documents in customer engagement apps (such as Dynamics 365 Sales, Dynamics 365 Customer Service, Dynamics 365 Field Service, Dynamics 365 Marketing, and Dynamics 365 Project Service Automation), that are stored in SharePoint.

With Microsoft Teams integration with customer engagements apps, you can use document management with Microsoft Teams. It allows a user to co-author documents and automatically sync documents to customer engagement apps using SharePoint.

There isn't an automatic relationship between SharePoint permissions and permissions to customer engagement apps. To access documents between Microsoft Teams and customer engagement apps, you need explicit permission to use document management for customer engagement apps and SharePoint. For information: [Permissions required for document management tasks](https://docs.microsoft.com/dynamics365/customerengagement/on-premises/admin/permissions-required-document-management-tasks)

Use the **Files** tab in Teams or the **Documents** tab in your customer engagement apps, to store and manage documents in the context of a record on a SharePoint Server. Documents are stored on a SharePoint Server that allows a user on Microsoft Teams to access the documents on the SharePoint Server as long as the user has appropriate permissions.

A user's access to files in Microsoft Teams or cusomter engagement apps depends on their access to the SharePoint site the file is stored in.

> [!NOTE]
> - A guest user in Microsoft Teams will get error message when they try to access a pinned customer engagemnt app record. 
> - A user who is part of Microsoft Teams channel or team that does have access to customer engagementapps won't have access to the record in Microsoft Teams.
 


