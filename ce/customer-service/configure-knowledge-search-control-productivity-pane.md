---
title: Configure knowledge search control to app side pane (Dynamics 365 Customer Service) | MicrosoftDocs
description: See how to configure the settings for knowledge search control in Dynamics 365 Customer Service
ms.date: 01/20/2021
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
ms.custom: 
  - dyn365-customerservice
searchScope: 
 - D365-App-customerservicehub 
 - D365-Entity-knowledgearticle
 - D365-UI-form
 - Dynamics 365 
 - Customer Service 
 - Customer Engagement 
---

# Configure knowledge search control on the app side pane

## Introduction

You can configure how you want the knowledge search control to appear on the app side pane for a multisession. You can set what your agents will experience while they interact with customers during a multisession for an entity making it easy for agents to quickly search and use an article related to an entity.

## Enable record types for which you want to turn on knowledge management
You can enable record types from the Customer Service admin center (preview) app.

> [!IMPORTANT]
> The Customer Service admin center app is in preview. [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]


To add an entity record:

1. On the Customer Service admin center (preview) app, select **Knowledge** in **Agent Experience**.
1. On the **Knowledge** page, in **Record Types**, select **Manage**.
1. On the **Record Types** page, select **Add**. The **Add record type** dialog appears.
1. On the **Add record type** dialog, from the **Select record type** dropdown, select the record type.
1. In **Automatic search**, set the **Turn on automatic search** toggle to yes, if you want automatic search to be enabled for your entity record.
1. In **Actions**, set the toggle as per your requirements for the following:
    * **Link/unlink article**
    * **Copy URL**
    * **Link article and email URL**
    * **Link article and send article content**
7.	In **Email recipient**, from the **Select default email recipient** dropdown, select the email recipient.
8.	Click **Save and Close**.

    :::image type="content" source="media/add-ent-record.png" alt-text="Add an entity record for which you want to turn on knowledge management":::

To edit an entity record:

1. On the Customer Service admin center (preview) app, select **Knowledge** in **Agent Experience**.
1. On the **Knowledge** page, in Record Types, select **Manage**.
1. On the **Record Types** page, select the entity which you want to edit.
1. Click **Edit**. The **Set up Knowledge settings on the app side pane** dialog appears.
1. In **Automatic search**, set the **Turn on automatic search** toggle to yes, if you want automatic search to be enabled for your entity record.
1. From the **Provide search results using** dropdown, select the fields by which search results will be provided for the entity.
1. In **Actions**, set the toggle as per your requirements for the following:
    * **Link/unlink article**
    * **Copy URL**
    * **Link article and email URL**
    * **Link article and send article content**
7.	In **Email recipient**, from the **Select default email recipient** dropdown, select the email recipient.
8.	Click **Save and Close**.
  
    :::image type="content" source="media/edit-ent-record.png" alt-text="edit an existing entity record":::

You can also add a knowledge base search control to Dynamics 365 for Customer Engagement forms to make it easy for users in your organization to find knowledge articles so they can answer common customer questions and resolve their issues right from the records, without having to switch to a different application. More information, see [Add the Knowledge Base Search control to forms](add-knowledge-base-search-control-forms.md#add-the-knowledge-base-search-control-to-forms).

### See also  

 [Add the Knowledge Base Search control to a form](../customer-service/add-knowledge-base-search-control-forms.md)   


[!INCLUDE[footer-include](../includes/footer-banner.md)]
