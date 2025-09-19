---
title: Configure requirements for Sales Qualification Agent
description: Learn how to configure the requirements for the Research-only and Research and engage modes of the Sales Qualification Agent in Dynamics 365 Sales.
ms.topic: how-to
ms.date: 07/31/2025
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
ms.custom: bap-template
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Configure requirements for Sales Qualification Agent

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

Before you configure the agents, ensure that prerequisites are configured in your Dynamics 365 Sales environment. Depending on the type of automation, you must configure the requirements as follows:

| Prerequisite | Applicable for | Description |
|--------------|------------|-------------|
| Create application in Azure | Research-only and Research and engage | An Azure AD application is required to securely authenticate the agent’s Dataverse Application User, enabling it to act independently via app-based access.<br>More information: [Create application in Azure](#create-application-in-azure) |
| Create an app user in Dataverse | Research-only and Research and engage | Create a Dataverse app user so the agent can act independently, like send emails, own records, and more.<br>More information: [Create an app user in Dataverse and assign AISalesPerson role](#create-an-app-user-in-dataverse-and-assign-aisalesperson-role) |
| Create a shared mailbox | Research and engage | The agent mailbox that will be used to send emails and follow-ups in compliance with your org’s policies.<br>More information: [Create a shared mailbox](#create-a-shared-mailbox) |
| Configuring server-side synchronization | Research and engage | Connect Dynamics 365 Sales and Exchange to sync emails, contacts, tasks, and calendar.<br>More information: [Configuring server-side synchronization](#configuring-server-side-synchronization) |

## Create application in Azure

1. Ensure that you have the **Application Developer** role in Microsoft Entra.
1. [Go to the agent settings page](open-sales-qualification-agent-settings.md).  
1. In the agent settings page, go to the **Prerequisites** section, and in the **Create app in Azure** section, select **Set up**.

    :::image type="content" source="media/sqa-settings-create-app-in-azure.png" alt-text="Screenshot of selecting set up in the create app in Azure section.":::

1. In the **Register an application** page, enter a name, select the account type (usually **Accounts in this organizational directory only**), and if applicable, enter a relevant redirect URI.  

    :::image type="content" source="media/sqa-settings-azure-app-registration.png" alt-text="Screenshot of the new registration page in Azure.":::

    > [!NOTE]
    > You can also create the application in the Azure portal by going to **Microsoft Entra ID** > **App registrations** and then selecting **New registration**.

1. Select **Register**.  
    Your app is created, and details are displayed. Copy the created Application (client) ID to be used while creating app user in your Dynamics 365 organization.  

1. Go back to the agent settings page and select the **Mark as done** checkbox in the **Create app in Azure** section. You must select this checkbox to proceed with the agent configuration.  

To learn more about app creation, see [Quickstart: Register an app in Microsoft Entra ID](/entra/identity-platform/quickstart-register-app?tabs=certificate%2Cexpose-a-web-api).  

## Create a shared mailbox

1. Ensure that you have one of the following roles in Microsoft Office 365 admin portal&madsh; **Office 365 Global Administrator**, **Exchange Administrator**, or **Exchange Recipient Administrator**.
1. [Go to the agent settings page](open-sales-qualification-agent-settings.md).  
1. In the agent settings page, go to the **Prerequisites** section, and in the **Create shared mailbox** section, select **Set up**.

    :::image type="content" source="media/sqa-settings-create-shared-mailbox.png" alt-text="Screenshot of selecting set up in the create shared mailbox section.":::

1. In the Exchange admin center, go to **Recipients** > **Mailboxes** and then select **Add a shared mailbox**.  
1. In the **Add a shared mailbox** pane, enter the following information:  
    - **Display name**: Enter a name for the shared mailbox.  
    - **Email address**: Enter the email address.  

    :::image type="content" source="media/sqa-settings-add-shared-mailbox.png" alt-text="Screenshot of adding a shared mailbox in the Exchange admin center.":::

1. Select **Create**.  
    A shared mailbox is created. Now, you can create and add app users to this mailbox as described in the following section.  
1. Go back to the agent settings page and select the **Mark as done** checkbox in the **Create shared mailbox** section. You must select this checkbox to proceed with the agent configuration.  

To learn more about shared mailboxes, see [Shared mailboxes in Exchange Online](/exchange/collaboration-exo/shared-mailboxes).

## Create an app user in Dataverse and assign AISalesPerson role

1. Ensure that you have the **System Administrator** role for your Dynamics 365 organization.  
1. [Go to the agent settings page](open-sales-qualification-agent-settings.md).  
1. In the agent settings page, go to the **Prerequisites** section, and in the **Create an app user in Dataverse** section, select **Set up**.  

    :::image type="content" source="media/sqa-settings-create-app-user.png" alt-text="Screenshot of selecting set up in the create an app user in Dataverse section.":::

1. In Power Platform admin center, select the environment where you want to create the app user.  
1. Go to **Settings** > **Users + permissions** > **Application users** and then select **+ New app user**.  
1. In the **Create a new app user** pane, select **+ Add an app** and then add the application (Application client ID) that is registered in Azure.  
1. Enter the business unit name, and enter the security role for the app user as **AIsalesperson**.  
1. Select **Save**.  
1. Go back to the agent settings page and select the **Mark as done** checkbox in the **Create an app user in Dataverse** section. You must select this checkbox to proceed with the agent configuration.  

To learn more about app users, see [Manage application users in the Power Platform admin center](/power-platform/admin/manage-application-users).

## Configuring server-side synchronization

1. Ensure that you have the following roles:  
    - **System Administrator** for your Dynamics 365 organization.  
    - **Office 365 Global Administrator** or **Exchange Administrator** in Microsoft Office 365 admin portal.  
1. In the agent settings page, go to the **Prerequisites** section, and in the **Configure server side sync** section, select **Set up**.  

    :::image type="content" source="media/sqa-settings-configure-server-side-sync.png" alt-text="Screenshot of selecting set up in the configure server side sync section.":::

    > [!NOTE]
    > You can also configure server-side synchronization in your Dynamics 365 organization by going to **Advanced Settings** > **System** > **Email Configuration** > **Mailboxes**.
1. Change the view to **All Mailboxes** and select the mailbox associated with the created application user.  
1. Replace the email address with that of the shared mailbox and then select **Approve Email**.  
1. Select **Test & Enable Mailbox** to verify that the server-side sync is established successfully for the email. When successful, the incoming and outgoing email status display Success under the Configuration Status section.  
1. Go back to the agent settings page and select the **Mark as done** checkbox in the **Configure server side sync** section. You must select this checkbox to proceed with the agent configuration.  

## Next step

[Configure general settings for the Sales Qualification Agent](sales-qualification-agent-general-settings.md)

## Related information

[Configure the Sales Qualification Agent](configure-sales-qualification-agent.md)
