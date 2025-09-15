---
title: Configure global settings for case Management Agent (preview)
description: Learn how to configure Case Management Agent in Dynamics 365 Customer Service to help customer support teams efficiently resolve cases.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.collection: bap-ai-copilot 
ms.date: 08/08/2025
ms.custom: bap-template
---

# Configure global settings for Case Management Agent (preview)

You must configure global settings for the Case Management Agent in Dynamics 365 Customer Service to enable fully autonomous case resolution, follow-up, and closure capabilities.

- For the AI agent to send emails and resolve cases autonomously, you must set up a dedicated application user to send and receive emails on behalf of your organization. Perform the following steps:
   1. [Create](/entra/identity-platform/quickstart-create-new-tenant#create-a-new-microsoft-entra-tenant) and [register a single-tenant application registration](/entra/identity-platform/quickstart-register-app#register-an-application) in the Azure portal. Copy the values of **Client ID**, **Client Secret**, and **Tenant**.
   2. [Create an application user](/power-platform/admin/manage-application-users?tabs=new#create-an-application-user) with Customer Service Representative role in Power Platform admin center.
   3. Create a shared mailbox in Exchange Online. Learn more in [Shared mailboxes in Exchange Online](/exchange/collaboration-exo/shared-mailboxes).
   4. Assign the shared mailbox email id to the application user in Power Platform admin center. Learn more in [Manage email settings](/power-platform/admin/settings-email). This application user is used in Copilot Service admin center to receive and send responses.
   5. In Copilot Studio, select Case Processing Agent in **Agents** and create a connection reference with the following data. Learn more in [Configure and manage connections](/microsoft-copilot-studio/authoring-connections).
       - **Authentication Type**: Service Principal
       - Specify the **Client ID**, **Client Secret**, and **Tenant** that you've copied in the earlier step.
       - Publish the agent. 

## Prerequisites

- An Azure account that has an active subscription.
- You must have atleast the [Application Developer](/entra/identity/role-based-access-control/permissions-reference#application-developer) to create app registrations.

## Configure global settings

For the AI agent to send emails and resolve cases autonomously, you must set up a dedicated application user to send and receive emails on behalf of your organization. Perform the steps in the following sections in the order specified.

### Register an application and create a secret 

1. Sign in to [Microsoft Entra admin center](https://entra.microsoft.com) and perform the steps in [register a single-tenant application registration](/entra/identity-platform/quickstart-register-app#register-an-application). After your application is registered, copy the values of **Client ID** and **Tenant ID** from the application overview page.
1. Perform the steps in [Create a client secret](/entra/identity-platform/how-to-add-credentials?tabs=client-secret#add-a-credential-to-your-application) and copy the value of the client secret.

### Create an application user in Power Platform admin center

This application user is used in Copilot Service admin center to receive and send responses.

1. Sign in to [Power Platform admin center](https://admin.powerplatform.microsoft.com) and perform the steps in [Create an application user](/power-platform/admin/manage-application-users?tabs=new#create-an-application-user) to create a new application user. 
1. Assign the Customer Service Representative role to the application user.

### Assign a shared mailbox to the application user

1. Go to [Microsoft 365 admin center](https://admin.cloud.microsoft/) and do the steps 1 to 4 in [Create a shared mailbox](/microsoft-365/admin/email/create-a-shared-mailbox#create-a-shared-mailbox-and-add-members) to create a shared mailbox. Copy the email id of the shared mailbox.
1. In Power Platform admin center, open the application user that you created in the previous step and update the shared mailbox email id. Learn more in [View or edit the details of an application user](/power-platform/admin/manage-application-users?tabs=new#view-or-edit-the-details-of-an-application-user).

### Assign a security group to the application user

1. Go to [Microsoft 365 admin center](https://admin.cloud.microsoft/) and do the steps 1 to 4 in [Create a security group](/microsoft-365/admin/create-groups/create-a-security-group) to create a security group. Copy the group id of the security group.
1. In Power Platform admin center, open the application user that you created in the previous step and update the security group id. Learn more in [View or edit the details of an application user](/power-platform/admin/manage-application-users?tabs=new#view-or-edit-the-details-of-an-application-user).

### Connect and authenticate connection references

You must authenticate the following connection references using an admin account to enable the Case Management Agent's access to data sources:
- Case Processing Agent CDS Connection
- Case Processing Agent MCS Connection
- Microsoft Copilot Studio for Sales

These connections are essential for the agent to perform autonomous case processing, data retrieval, and AI-powered customer interactions. 

Perform the following steps:

1. In [Power Apps](https://make.powerapps.com/) select **Solutions**.
1. In the page that appears, select **Default Solution**.
1. In the **Objects** pane, search for and select **Connection References**. The list of existing connection references appears.
1. Select **Case Processing Agent CDS Connection**.
1. In the **Edit Case Processing Agent CDS Connection** pane that appears, do the following steps:
    1. Select **New connection** from the **Connection** dropdown. The **New connection** page appears in a new tab. Perform the following steps:
      1. Search and select for Dataverse.
      1. Select OAuth as the authentication type and then select **Create**.
      1. In the pop-up, select the admin account to authenticate the connection.
      1. After the connection is created, the status of the connection reference changes to **Connected**.
1. In the **Edit Case Processing Agent CDS Connection** pane, from the **Connection** dropdown, select the admin connection that you just created.

Repeat the steps to authenticate the **Case Processing Agent MCS Connection** connection reference. Make sure to select Microsoft Copilot Studio when you're creating a new connection.

### Enable flows

In Power Automate, make sure that the **Invoke case processing agent** and **Call custom agent** flows are enabled. Learn more in [Turn on a flow](/power-automate/disable-flow#turn-on-a-flow).


### Publish Case Management Agent

- In copilot studio, select **Agents** and then select **Case Processing Agent**.
- In the **Case Processing Agent** page, select **Publish** to publish the agent.
