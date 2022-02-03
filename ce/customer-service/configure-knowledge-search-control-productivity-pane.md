---
title: Configure knowledge search control on app side pane for an entity record | Microsoft Docs
description: See how to configure the settings for knowledge search control in Dynamics 365 Customer Service
ms.date: 02/01/2021
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

# Configure knowledge search control on the app side pane for an entity record (preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>

## Introduction

You can configure how you want the knowledge base search control to appear for your entities on the app side pane for a multisession. To do so, you will need to first add the record types for which you want to turn on knowledge management and then configure the various settings.

Configuring a record type will specify the information that your agents will see while they interact with customers during a multisession. **Case** and **Conversation** record types are enabled by default. The **Conversation** record type will be available by default if you have purchased add-on SKUs, such as Chat, Digital messaging, or Voice. If you are an existing user, you will also see all the entities previously enabled by you.

You can also add a knowledge base search control to standard or custom forms to make it easy for users in your organization to find knowledge articles, so they can answer common customer questions and resolve their issues right from the records, without having to switch to a different application. More information, see [Add the Knowledge Base Search control to forms](add-knowledge-base-search-control-forms.md#add-the-knowledge-base-search-control-to-forms).

## Add record types for which you want to turn on knowledge management

You can add record types from the Customer Service Hub or the Customer Service admin center (preview) app. Depending on your app, perform the following steps:

### [Customer Service Hub](#tab/customerservicehub)

1. Go to **Service Management** and select **Settings** in **Knowledge Base Management**. The **Settings** page appears.

2. On the **Settings** page, in **Record Types**, select the record types you want to turn on knowledge management for. The list will include all available entities for an N:N relationship. Knowledge management is enabled for the **Case** entity by default.

### [Customer Service admin center (preview)](#tab/customerserviceadmincenter)

> [!IMPORTANT]
> The Customer Service admin center app is in preview. [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]

1. Select **Knowledge** in **Agent Experience**.
1. On the **Knowledge** page, in **Record Types**, select **Manage**.
1. On the **Record Types** page, select **Add**. The **Add record type** dialog appears.
1. On the **Add record type** dialog, from the **Select record type** dropdown, select the record type.
1. In **Automatic search**, set the **Turn on automatic search** toggle to yes, if you want automatic search to be enabled for your entity record.
1. From the **Provide search results using** dropdown list, select the field by which search results will be provided for the entity.
1. In **Actions**, set the toggle as per your requirements for the following:
    * **Link/unlink article**
    * **Copy URL**
    * **Link article and email URL**
    * **Link article and send article content**
1.	In **Email recipient**, from the **Select default email recipient** dropdown, select the email recipient.
1.	Click **Save and Close**.

    :::image type="content" source="media/add-ent-record.png" alt-text="Add an entity record for which you want to turn on knowledge management":::

---

## Configure knowledge search control on the app side pane

After you have added the record types for which you want to turn on knowledge management, you can configure the knowledge search control on the app side pane by editing the record type.

> [!NOTE]
> You can configure the knowledge settings for record types only from the Customer Service admin center (preview) app. Record types for which you have turned on knowledge management from the Customer Service Hub app will also be available to you for configuration from the Customer Service admin center (preview) app.

To edit an entity record:

1. On the Customer Service admin center (preview) app, select **Knowledge** in **Agent Experience**.
1. On the **Knowledge** page, in Record Types, select **Manage**.
1. On the **Record Types** page, select the entity you want to edit.
1. Click **Edit**. The **Set up Knowledge settings on the app side pane** dialog appears.
1. In **Automatic search**, set the **Turn on automatic search** toggle to yes, if you want automatic search to be enabled for your entity record.
1. From the **Provide search results using** dropdown list, select the fields by which search results will be provided for the entity.
1. In **Actions**, set the toggle as per your requirements for the following:
    * **Link/unlink article**
    * **Copy URL**
    * **Link article and email URL**
    * **Link article and send article content**
7.	In **Email recipient**, from the **Select default email recipient** dropdown, select the email recipient.
8.	Click **Save and Close**.
  
    :::image type="content" source="media/edit-ent-record.png" alt-text="edit an existing entity record":::

### See also  

 [Add the Knowledge Base Search control to a form](../customer-service/add-knowledge-base-search-control-forms.md)   


[!INCLUDE[footer-include](../includes/footer-banner.md)]
