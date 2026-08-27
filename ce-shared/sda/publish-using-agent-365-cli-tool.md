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

