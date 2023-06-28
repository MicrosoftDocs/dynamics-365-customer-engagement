---
title: Configure knowledge search control on app side pane for an entity record | Microsoft Docs
description: See how to configure the settings for knowledge search control in Dynamics 365 Customer Service
ms.date: 06/09/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
search.audienceType: 
  - admin
  - customizer
  - enduser
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

# Configure knowledge search control on app side pane for an entity record

## Introduction

You can configure how you want the knowledge base search control to appear for your entities on the app side pane of Customer Service workspace and Omnichannel for Customer Service. To do so, you'll need to first add the record types for which you want to turn on knowledge management and then configure the record type settings.

Configuring a record type will specify the information that your agents will see while they interact with customers. **Case** and **Conversation** record types are enabled by default. The **Conversation** record type will be available by default if you have purchased add-on SKUs, such as Chat, Digital messaging, or Voice. If you're an existing user, you'll also see all the entities previously enabled by you.

## Add record types for which you want to turn on knowledge management

Go to the Customer Service admin center or Customer Service Hub app, and perform the following steps:

### [Customer Service admin center](#tab/customerserviceadmincenter)

1. In the site map, select **Knowledge** in **Agent Experience**.
1. On the **Knowledge** page, in the **Record Types** section, select **Manage**.
1. On the **Record Types** page, select **Add**. The **Add record type** dialog appears.
1. On the **Add record type** dialog, from the **Select record type** dropdown list, select the record type.
1.	Select **Save and Close**.

### [Customer Service Hub](#tab/customerservicehub)

1. Go to **Service Management** and select **Settings** in **Knowledge Base Management**. The **Settings** page appears.

2. On the **Settings** page, in **Record Types**, select the record types you want to turn on knowledge management for. The list will include all available entities for an N:N relationship. Knowledge management is enabled for the **Case** entity by default.

---

After you've enabled a record type, to set up knowledge base search control on a standard or custom form, see [Add the Knowledge Base Search control to forms](add-knowledge-base-search-control-forms.md#add-the-knowledge-base-search-control-to-forms). Setting up knowledge base search control on a standard or custom form makes it easy for agents in your organization to find knowledge articles, so they can answer common customer questions and resolve their issues right from the records, without having to switch to a different application.

To set up knowledge search control on the app side pane, see [Configure knowledge search control on the app side pane](#configure-knowledge-search-control-on-app-side-pane).


## Configure knowledge search control on the app side pane<a name="configure-knowledge-search-control-on-app-side-pane"></a>

After you've added the record types for which you want to turn on knowledge management, you can configure the knowledge search control on the app side pane by editing the record type. The app side pane is available only in Customer Service workspace and Omnichannel for Customer Service. For more information on how to set up an app side pane, go to [Configure productivity pane](../app-profile-manager/create-agent-experience-profile.md#assign-users-templates-configure-productivity-pane-channels).

> [!NOTE]
> You can configure the knowledge settings for record types from the Customer Service admin center app only. You'll also be able to view and edit the record types that you've previously enabled in Customer Service Hub.

To edit an entity record:

1. In the Customer Service admin center, on the **Record Types** page, select the entity you want to edit.
1. Select **Edit**. The **Knowledge settings** dialog appears.
1. In **Automatic search**:
    - Set the **Turn on automatic search** toggle to **Yes**, if you want automatic search to be enabled for your entity record.
    - From the **Provide search results using** dropdown list, select the field by which the search results will be provided for the entity.
1. In **Actions**, select the checkboxes as required for the following:
    * **Link / unlink article**
    * **Copy URL**
    * **Link article and email URL**
    * **Link article and send article content**
7.	In **Email recipient**, from the **Select default email recipient** dropdown list, select the email recipient.
    The **Email recipient** option is available only to the Customer or Lookup attribute type, and to the Account or Contact lookup entity.
8.	Select **Save and Close**.
  
    :::image type="content" source="media/edit-ent-record.png" alt-text="edit an existing entity record":::


### See also  

 [Add the Knowledge Base Search control to a form](../customer-service/add-knowledge-base-search-control-forms.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
