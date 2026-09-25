---
title: Integrate the Sales Development agent with Dynamics 365 (preview)
description: Learn how to integrate the Sales Development agent with Dynamics 365 Sales to enhance your sales processes and improve customer engagement.
ms.date: 09/25/2026
ms.topic: overview
author: sbmjais
ms.author: shjais
ai-usage: ai-assisted
---

# Integrate the Sales Development agent with Dynamics 365 (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

The Sales Development agent can integrate with Dynamics 365 to connect with leads, log interactions, and sync engagement actions such as emails, qualification, disqualification, and ownership transfer. This integration ensures that all outreach activities are tracked and accessible to your sales team.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Step 1: Give the agent user access to Dynamics 365 Sales  

1. Like other users, the agent user needs a license to access Dynamics 365 Sales. In Microsoft 365 admin center, add the appropriate Sales license to the agent user. [Learn more about assigning licenses for users in Microsoft 365 admin center](/microsoft-365/admin/manage/assign-licenses-to-users?view=o365-worldwide&preserve-view=true).
    1. In the [Microsoft 365 admin center](https://admin.microsoft.com/), search for the agent name in the search bar at the top of the page, and select the agent user from the search results.
    1. In the right pane, select **Licenses and Apps**.
    1. Assign the appropriate Sales license to the agent user.
    1. Select **Save changes**.
1. In Power Platform admin center, add the agent user to your Dynamics 365 Sales instance and assign the appropriate role. The Sales Development Agent is configured to use the **Salesperson** role, but you can also use a custom role with permissions to access and manage leads. Learn more about [assigning a security role to a user in Power Platform admin center](/power-platform/admin/assign-security-roles).
    1. In the [Power Platform admin center](https://admin.powerplatform.microsoft.com/), select **Manage** in the left navigation pane.
    1. Select **Environments**, and then select your Dynamics 365 Sales environment.
    1. Select **Settings** > **Users + permissions** > **Agents (preview)**.
    1. Select **Add agent**.
    1. Enter the agent name in the search bar, select the agent user from the search results, and then select **Add**.
    1. Select the Salesperson role (or a custom role with appropriate permissions) for the agent user, and then select **Save**.
    1. Select **Save** to confirm the role assignment.

## Step 2: Enable the Dataverse Model Context Protocol (MCP) server

The Sales Development agent uses the Dataverse Model Context Protocol (MCP) server to connect with Dynamics 365. You only need to enable the Dataverse MCP server in your environment once. The Sales Development agent doesn't need to be designated as an explicit MCP Client to function. [Learn how to enable the Dataverse MCP server in the Power Platform admin center](/power-apps/maker/data-platform/data-platform-mcp-disable#configure-and-manage-the-dataverse-mcp-server).

## Step 3: Publish the MCP server to the CRM environment

Next, publish the Dataverse MCP server to your Dynamics 365 Sales environment either by VS Code or Agent 365 CLI tool. This step allows the Sales Development agent to communicate with Dynamics 365 Sales and perform necessary actions. Developers don't need a specific role or permission to publish MCP servers.

### Publish using VS Code

1. In VS Code, open the Command Palette (Ctrl + Shift + P), select **MCP: Add Server**, and then select **HTTP (HTTP or Server-Sent Events)**.
1. For the URL of the Dataverse MCP server, enter the following URL, replacing `{TenantId}` with your tenant ID:

    ```
    https://agent365.svc.cloud.microsoft/agents/tenants/{TenantId}/servers/MCPManagement
    ```

    Learn more about [configuring the mcp.json file in Visual Studio Code](https://code.visualstudio.com/docs/copilot/customization/mcp-servers#_configure-the-mcpjson-file).

1. For the unique name of the server, accept the default value or enter a new name. For example, `DataverseMCPServer`.
1. Select the configuration target as **Global** or **Workspace**.

    The **mcp.json** file is created in the `.vscode` folder of your workspace.

1. Open the Command Palette (Ctrl + Shift + P), select **MCP: List Servers**, select the new server, and then select **Start Server**.
1. In the confirmation dialog, select **Allow** and sign in with your credentials.
1. Use the chat agent in Visual Studio Code and interact with it in a natural language to publish the MCP server to your CRM environment.
    1. Ask the agent to list environments in the tenant.
    1. Ask the agent to publish the Dataverse MCP server to your environment. For example, you can say `Publish the dataverse mcp server to environment <environment ID>.`
    1. Ensure the publish result matches your environment ID and is successful.

If there's an error during publishing or the environment ID doesn't match, you can unpublish the MCP server and try again. To unpublish, ask the agent to unpublish the MCP server from the environment. For example, `Unpublish the dataverse mcp server from the environment <environment ID>.`

### Publish using Agent 365 CLI tool

1. Install the [Agent 365 CLI tool](/microsoft-agent-365/developer/agent-365-cli?tabs=windows).
1. Sign in with your admin tenant credentials by running the following command:

    ```az login --allow-no-subscriptions```
1. List the available environments to publish the MCP server to by running the following command and confirm your Dynamics 365 Sales environment appears in the list:

    ```a365 develop-mcp list-environments```
1. List the available MCP servers by running the following command and confirm `msdyn_DataverseMCPServer` appears in the list:

    ```a365 develop-mcp list-servers```
1. Publish the Dataverse MCP server to your target environment by running the following command:

    ```a365 develop-mcp publish --server-name msdyn_DataverseMCPServer --environment-id <environment ID> --alias new_<uniquealias> --display-name <unique display name>```

    > [!NOTE]
    > The alias and display name must be unique. If either value is already used, pick a different `new_<uniquealias>` or `display name` value and rerun the publish command.

1. Confirm the Dataverse MCP server is published successfully by running the following command and checking that the MCP server is listed:

    ```a365 develop list-available```

If you want to unpublish the MCP server and try again, run the following command:

```a365 develop-mcp unpublish --server-name new_<uniquealias> --environment-id <environment ID>```

For more information about the `develop-mcp` command reference, see [Agent 365 CLI develop-mcp command reference](/microsoft-agent-365/developer/reference/cli/develop-mcp).

## Step 4: Approve the MCP server

MCP servers are published at a tenant level and require approval from a Global Admin or AI Admin. You must approve the MCP server you published before the Sales Development agent can use it to access Dynamics 365 Sales.

[Learn more about reviewing and approving tool requests](/microsoft-365/admin/manage/manage-tools-for-agent?view=o365-worldwide#review-and-approve-tool-requests&preserve-view=true).

After approval, confirm the following:

- The MCP request is approved in Microsoft 365 admin center.
- The approved request matches the alias that you published.
- The approved request matches the display name you published.

If you requested the wrong alias or display name, or didn't complete approval, retry the publish flow and approve the correct request.

## Next steps after CRM integration

After you publish the MCP server to your environment, the Sales Development agent can interact with Dynamics 365. You can [onboard the Sales Development agent](onboard-agent.md) directly in Teams to configure its playbook, guidelines, product knowledge, and settings.

> [!NOTE]
> - Chat with the agent in Teams and tell it to onboard to the CRM. For example, you can say "Onboard to CRM." or "Connect to CRM."
> - Set the default product recommendation for the agent.