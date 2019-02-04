---
title: "Associate documents with playbook activities (Dynamics 365 for Sales) | MicrosoftDocs"
description: "Associate documents in context of playbook activities to help your team with accurate and latest sales material or training content to close a deal."
keywords: ""
ms.date: 02/21/2019
ms.service:
  - "dynamics-365-sales"
ms.custom:
  - "dyn365-sales"
ms.topic: article
applies_to:
  - "Dynamics 365 for Customer Engagement"
  - "Dynamics 365 for Customer Engagement apps version 9.1"
ms.assetid: 293f83ce-5ea3-4a3a-ab8a-52cae27b7859
author: shubhadaj
ms.author: shujoshi
manager: annbe
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
topic-status: Tech Reviewing
---

## Preview: Associate documents to playbook activities

[!INCLUDE cc-beta-prerelease-disclaimer]

> [!NOTE]

> - [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)] 
> - [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)] 


To ensure the sales rep always have the accurate and latest sales material or training content to close a deal, you can associate and store documents in context of playbook activities that you add to a playbook template.
For example, you’ve created a playbook template for an event when the decision maker your sales reps are working with leaves the organization. While adding the activities to this template, you can also attach documents that will help the sales rep to bring the new decision maker up to speed. 

### Prerequisites

To be able to add documents, Document Management must be enabled for the Playbook activity entity. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Enable SharePoint document management for specific entities](../admin/enable-sharepoint-document-management-specific-entities.md), [Set up SharePoint integration](../admin/set-up-sharepoint-integration.md)

### Add documents 

1.	In the **Playbook activities** section of the playbook template, open the playbook activity to which you want to associate a document.

2.	In the activity form, select the **Related** tab, and then select **Documents**.

3.	Select **Upload** to add all the relevant documents that a sales rep may need while working on this playbook activity. The documents are stored on the configured SharePoint site. For more information about working with documents, see [Manage your SharePoint documents from Dynamics 365 for Customer Engagement apps](../basics/manage-sharepoint-documents-document-locations-in-dynamics-365-apps.md)


> [!NOTE]

> -	Based on the permissions assigned to you, you can perform all document operations such as New, Upload, check out, edit, delete and so on. 

> - If a system administrator disables document management on a playbook activity on which it was earlier enabled and documents were associated, the documents won’t be available to the associated activities when a playbook is launched for an entity such as opportunity or lead.

> - By default, the Playbook activity entity is enabled for customization because that’s a prerequisite to enable SharePoint integration. However, we don't support any customizations to this entity.

### See also
[Manage playbook templates](manage-playbook-templates.md)  
[Enforce best practices with playbooks](enforce-best-practices-playbooks.md)  