---
title: Integrate the Sales Development agent with Salesforce (preview)
description: Learn how to integrate the Sales Development agent with Salesforce to enhance your sales processes and improve customer engagement.
ms.date: 10/20/2026
ms.topic: how-to
author: sbmjais
ms.author: shjais
ai-usage: ai-assisted
---

# Integrate the Sales Development agent with Salesforce (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

The Sales Development agent can integrate with Salesforce to connect with leads, log interactions, and sync engagement actions such as emails, qualification, disqualification, and ownership transfer. This integration ensures that your sales team can track and access all outreach activities.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

Before you begin, ensure you have:

- A Salesforce organization with API access enabled. API access is typically available with Enterprise and Unlimited editions, or with Professional edition and the API add-on.
- Salesforce credentials for a user who can authorize the connection.
- A fully provisioned Sales Development agent instance that you can interact with in a Microsoft Teams chat.

## Step 1: Give the agent user access to Salesforce

Like other users, the agent user needs a license to access Salesforce. Both the user who authorizes the connection and the agent user need the following Salesforce permissions:

- **Lead** object: Read, Create, and Edit.
- **Task** object: Create, for logging email activities.
- **User** object: Read, for onboarding and owner assignment.
- API access enabled on the user's profile.

## Step 2: Create the Salesforce connection

The Sales Development agent uses the Salesforce Model Context Protocol (MCP) server to connect to Salesforce. You only need to enable the Salesforce MCP server for an agent once. Any Salesforce user can authorize the connection if they have the required permissions.

1. In Microsoft Teams, open the chat with the agent.
1. Ask the agent to connect to Salesforce. For example, enter "Connect to my Salesforce CRM".

    If you make a generic request such as "Connect to CRM", the agent asks you to select a CRM. Select Salesforce.

1. Open the connection link that the agent provides. The link takes you to a simplified Power Platform maker portal.
1. Find the Salesforce MCP server, and then select **Connect**.
1. Sign in with your Salesforce credentials.
1. Grant the requested permissions to create the connection.
1. Wait for confirmation that the Salesforce connection is established.

If connection verification fails, check the following settings:

- Confirm that API access is enabled for your Salesforce organization. For more information, see [API access control overview](https://help.salesforce.com/s/articleView?id=xcloud.security_api_access_control_about.htm&type=5).
- Confirm that the user who authorized the connection has sufficient permissions. Use a System Administrator profile or a custom profile with API access and the object permissions listed in [Step 1](#step-1-give-the-agent-user-access-to-salesforce).
- Confirm that your organization's firewall and IP restrictions allow the connection.

## Step 3: Share the Salesforce connection

After you create the connection in the simplified Power Platform maker portal, share it with your Sales Development agent instance.

1. Find the Salesforce MCP server, and then select **Share**.
1. Confirm that your name appears with the **Owner** role.
1. In the search box, enter your agent's name.
1. Select the agent when it appears in the search results.
1. Confirm that the **Can use** role is assigned.
1. Select **Share**.
1. Select **Share** again to confirm that you want to share the connection with the agent user.
1. Wait for confirmation that the connection was shared successfully.

> [!NOTE]
> An agent can receive a shared connection only from its agent manager.

## Step 4: Confirm the connection

Return to the Teams chat and tell the agent that you shared a Salesforce connection with it. For example, enter "I set up the Salesforce connection and shared it with you".

## Step 5: Configure the agent

If you didn't complete the initial configuration, the agent guides you through it and asks for Salesforce-specific details. You can change these settings later by asking the agent in Teams.

- **Playbook**: Confirm how the agent responds to actions at each stage.
- **Lead handling**: Define how the agent qualifies, disqualifies, and routes leads.
- **Email activity logging**: Allow the agent to log email interactions as activities on the corresponding Salesforce Lead record.
- **Owner assignment**: Choose the Salesforce users who receive qualified leads. The agent first searches Salesforce for the hiring manager's email address. If it doesn't find a match, it asks for the assigned seller's email address and searches Salesforce again before assigning the lead.

For more information about configuring the agent, see [Onboard the Sales Development agent](onboard-agent.md).

## Step 6: Work with Salesforce leads

After you connect and configure the agent, it can perform the following actions in Salesforce:

| Capability | What the agent does in Salesforce |
|---|---|
| Lead retrieval | Reads records from the Lead object. |
| Lead qualification | Updates `Lead.Status` to mark leads as qualified. |
| Lead disqualification | Updates `Lead.Status` to mark leads as not qualified. |
| Owner assignment | Updates `Lead.OwnerId` to transfer leads to the appropriate seller. |
| Email activity logging | Creates Task records related to leads to track email interactions. |
| Onboarding information | Reads organization metadata and user information during initial setup. |

## Troubleshoot the Salesforce integration

### CRM connection not found

The Salesforce connection might not have been created successfully. Restart the connection flow by asking the agent, "Connect to my Salesforce CRM".

### Unable to access Salesforce

- Confirm that the Salesforce user who authorized the connection has an active account and still has API access.
- Check whether your Salesforce organization exceeded its API request limits.

### Lead status values don't match the Salesforce organization

The agent uses the default Salesforce `Lead.Status` values, **Closed - Converted** and **Closed - Not Converted**. If your organization uses custom status values, contact your Salesforce administrator. Custom picklist mapping isn't currently supported.

### Agent still uses Dynamics 365 Sales

An agent instance can connect to only one CRM at a time. Confirm that the agent's CRM connection is configured for Salesforce. If the agent was originally configured for Dynamics 365 Sales, disconnect it from Dynamics 365 Sales or create another agent instance for Salesforce.

## Frequently asked questions

### Can I use Dynamics 365 Sales and Salesforce with the same agent?

No. Each Sales Development agent instance connects to one CRM at a time. Create separate agent instances to use both CRM systems.

### How are my Salesforce credentials secured?

Your credentials are used to authorize the connection. The connection is stored as a secure connection record in your Microsoft Compliant Container (MCC) organization. The agent communicates with Salesforce through a managed server that handles authentication on its behalf.

### Can I disconnect Salesforce later?

Yes. Ask the agent to disconnect from Salesforce.

### Does the agent honor email consent for Salesforce leads?

The **Email Opt Out** field on Salesforce Lead and Contact records indicates whether a prospect doesn't want to receive email communications. The Sales Development agent attempts to read and honor this field.

> [!IMPORTANT]
> If the agent can't access the **Email Opt Out** field, it might contact the lead during outreach. Ensure the agent has access to the field before you begin outreach. For more information, see [Set field permissions in permission sets and profiles](https://help.salesforce.com/s/articleView?id=platform.users_profiles_field_perms.htm&type=5).
