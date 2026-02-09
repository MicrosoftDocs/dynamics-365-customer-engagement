---
title: Configure global settings for Case Management Agent 
description: Learn how to configure global settings for Case Management Agent in Dynamics 365 Customer Service to enable fully autonomous case resolution, follow-up, and closure capabilities.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot
ms.update-cycle: 180-days 
ms.date: 11/07/2025
ms.custom: bap-template
---

# Configure global settings for Case Management Agent 

Configure global settings for Case Management Agent in Dynamics 365 Customer Service to enable fully autonomous case resolution, follow-up, and closure capabilities.

## Prerequisites

- An Azure account that has an active subscription.
- You at least have the [Application Developer](/entra/identity/role-based-access-control/permissions-reference#application-developer) to create app registrations.
- The following connectors with the listed actions are available:
    - **Connector name**: Microsoft Dataverse
    - **List of actions**:
        - Add a new row to selected environment
        - Delete a row from selected environment
        - Get a row by ID from selected environment
        - List rows from selected environment
        - Perform a bound action in selected environment
        - Perform an unbound action in selected environment
        - Relate rows in selected environment
        - Unrelate rows in selected environment
        - Update a row in selected environment
        - Upsert a row in selected environment
    - **Connector name**: Microsoft Copilot Studio
        - **Name of the action**: ExecuteCopilotAsyncV2

The prerequisites, such as connection references or Power Automate flows, appear on the **Case Management Agent** page with the current status under the **Prerequisites** section. Use the options to quickly navigate to the settings that need to be configured for Case Management Agent.

:::image type="content" source="../media/prerequisites-settings-case-management-agent.png" alt-text="A screenshot of the prerequisites with status of each prerequisite configuration.":::

## Configure global settings

The AI agent requires a dedicated application user to send emails and resolve cases autonomously. This application user handles all email communication on behalf of your organization. Do the steps in the following sections in the order specified.

### Register an application and create a secret

1. Sign in to [Microsoft Entra admin center](https://entra.microsoft.com) and perform the steps in [register a single-tenant application registration](/entra/identity-platform/quickstart-register-app#register-an-application). After your application is registered, copy the values of **Client ID** and **Tenant ID** from the application overview page.
1. Perform the steps in [Create a client secret](/entra/identity-platform/how-to-add-credentials?tabs=client-secret#add-a-credential-to-your-application) and copy **Value** of the client secret.

### Create an application user in Power Platform admin center

The application user you create in Power Platform admin center is used to receive and send responses. Perform the following steps:

1. Sign in to [Power Platform admin center](https://admin.powerplatform.microsoft.com) and perform the steps in [Create an application user](/power-platform/admin/manage-application-users?tabs=new#create-an-application-user) to create a new application user.
1. Assign the Customer Service Representative role to the application user.

### Assign a shared mailbox to the application user

1. Go to [Microsoft 365 admin center](https://admin.cloud.microsoft/) and do the steps 1 through 4 in [Create a shared mailbox](/microsoft-365/admin/email/create-a-shared-mailbox#create-a-shared-mailbox-and-add-members). Copy the email ID of the shared mailbox.
1. In Power Platform admin center, open the application user that you created in [Create an application user](#create-an-application-user-in-power-platform-admin-center) and set the shared mailbox id to the email ID you've copied in the previous step. Learn more in [View or edit the details of an application user](/power-platform/admin/manage-application-users?tabs=new#view-or-edit-the-details-of-an-application-user).

### Assign a security group to the application user

1. Go to [Microsoft 365 admin center](https://admin.cloud.microsoft/) and do the steps 1 through 4 in [Create a security group](/microsoft-365/admin/email/create-edit-or-delete-a-security-group#add-a-security-group). Copy the group id of the security group.
1. In Power Platform admin center, open the application user that you created and update the security group id. Learn more in [View or edit the details of an application user](/power-platform/admin/manage-application-users?tabs=new#view-or-edit-the-details-of-an-application-user).

### Connect and authenticate connection references

Authenticate the following connection references using an admin account to enable Case Management Agent to access data sources. These connections are essential for the agent to perform autonomous case processing, data retrieval, and AI-powered customer interactions. 

- **Case Processing Agent CDS Connection**
- **Case Processing Agent MCS Connection**
- **Microsoft Copilot Studio for Sales**, if Dynamics 365 Sales application is configured in your environment. If you don't have Dynamics 365 Sales application, use **Microsoft Dataverse CDS Connection**.

Perform the following steps:

1. In [Power Apps](https://make.powerapps.com/) select **Solutions** and then select **Default Solution**.
1. In the **Objects** pane, search for and select **Connection References**. The list of existing connection references appears.
1. Select **Case Processing Agent CDS Connection**.
1. In the **Edit Case Processing Agent CDS Connection** pane that appears, do the following steps:
    1. Select **New connection** from the **Connection** dropdown. The **New connection** page appears in a new tab. Perform the following steps:
       1. Search and select **Dataverse**.
       1. Select OAuth as the authentication type and then select **Create**.
       1. In the pop-up, select the admin account to authenticate the connection.
       1. After the connection is created, the status of the connection reference changes to **Connected**.
1. In the **Edit Case Processing Agent CDS Connection** pane, from the **Connection** dropdown, select the admin connection that you created.

- Repeat the steps to authenticate the **Case Processing Agent MCS Connection** connection reference. Make sure to select **Microsoft Copilot Studio** instead of **Dataverse** when you're creating a new connection.
- For **Microsoft Copilot Studio for Sales** or **Microsoft Dataverse CDS Connection**, in the edit pane that appears, the admin id appears in the **Connection** dropdown. Select the admin ID. You don't have to create a new connection.

### Enable flows

In Power Automate, make sure that the **Invoke case processing agent** and **Call custom agent** flows are enabled. Learn more in [Turn on a flow](/power-automate/disable-flow#turn-on-a-flow).

### Add connection references in Copilot Studio

In Copilot Studio, perform the following steps:

 1. Select **Agents** and then select **Case Processing Agent**.
 1. In the **Case Processing Agent** page, select **Publish**.
 1. In the **Case Processing Agent** page, do the steps to [View connections on the Connection Settings page](/microsoft-copilot-studio/authoring-connections#view-connections-on-the-connection-settings-page). **Microsoft Dataverse** and **Call custom agent** appears on the **Manage connections** page.

   - For Dataverse, add a new connection reference using service principal authentication to establish the identity and authorization framework for Case Management Agent. Perform the following steps:
       1. Select **Connect** for **Microsoft Dataverse**.
       1. On the page that appears, select **...** > **Add new connection**.
       1. Select Service Principal as the authentication type.
       1. Specify the **Client ID**, **Client Secret**, and **Tenant ID** that you copied in the [Register an application and create a secret](#register-an-application-and-create-a-secret) section and then select **Create**. After the connection is created, the status of the connection reference changes to **Connected**.
   - For **Call custom agent**, you can use the Ouath authentication.
       1. Select **Connect** for **Call custom agent**.
       1. On the page that appears, select **...** and then select the admin connection.
       1. Select **Submit**. After the connection is created, the status of the connection reference changes to **Connected**.

### Next steps

[Set up Case Management Agent to create and update cases](set-up-autonomous-case-agents.md)  
[Set up Case Management Agent to resolve cases](set-up-case-resolution-agent.md)  
[Set up Case Management Agent for case follow-up and closure](set-up-case-closure.md)  