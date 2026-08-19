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

