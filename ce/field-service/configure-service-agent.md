---
title: Configure Service Agent for Field Service (preview)
description: Configure supported layouts, tool visibility, and extensions for Field Service capabilities in Service Agent.
ms.date: 11/23/2026
ms.topic: how-to
ms.service: dynamics-365-field-service
author: jasonccohen
ms.author: jacoh
ms.reviewer: puneetsingh
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Configure Service Agent for Field Service (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

Administrators and makers can configure Service Agent for Field Service by changing supported layouts, choosing which tools users see, and connecting approved services or agents.

These settings apply to Service Agent. They don't change the Field Service application, schedule board, or mobile application.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Prerequisites

Ask your environment administrator to confirm the following:

- Field Service capabilities are enabled in the target environment. See [Request public preview access](service-agent-preview.md).
- Maker configuration is available in Service Agent for that environment.
- Your security roles include the **Service Agent Maker Customize** privilege (`prvmsdyn_ServiceAgentMakerCustomize`). A Field Service or Environment Maker role alone doesn't establish this access.
- You have permission to read the business records you want to preview. Maker access doesn't grant access to work orders or bookings.

If the maker privilege isn't available, confirm feature availability before changing roles. Learn more about [Dataverse security roles and privileges](/power-platform/admin/security-roles-privileges).

## Choose the configuration scope

Use **organization-wide** configuration for a Field Service-only context. Customer Service Application Profiles aren't a way to target technician or dispatcher teams in that context.

Layout and tool-visibility settings apply to the selected agent context in the selected environment. Settings saved in a Customer Service context don't necessarily apply in a Field Service context.

Organization-owned MCP and Copilot Studio registrations have a broader scope: they can be available in other eligible Service Agent contexts in the environment. Review that scope before adding an extension.

## Enter configuration mode

1. Open Service Agent and confirm the Field Service context and connected environment.
2. Ask: Enter configuration mode and show what I can configure.
3. When prompted for scope, choose organization-wide configuration.
4. Choose a category, or search for a setting such as grid, form, tool visibility, or external tools.

The [configuration guide](../developer/reference/mcp-tools/browse_agent_config_options.md) shows the available options after checking your access. Browsing options doesn't save changes.

Configuration mode has a limited preview toolset. Check operational tools after you exit configuration mode.

Available options depend on the environment and selected context. Customer Service vocabulary and question-answering settings require their own setup and aren't standard Field Service configuration options.

## Configure a supported Field Service layout

Start with a small change, such as adding columns to a supported Work Order grid.

1. Ask: Show the existing organization-wide grid configuration for Work Order.
2. Ask to see the available views and columns for Work Order.
3. Choose the view and columns from the returned options.
4. Request the change and scope. For example: Add the work order number and system status columns to this Work Order grid, organization-wide.
5. Review the save result, including the table, view, scope, and time for the change to take effect.
6. Exit configuration mode and open the affected grid to check the result.

Select a specific view or form when the change should apply only there. A table-wide setting has a broader effect. See [Configure agent layout](../developer/reference/mcp-tools/save_agent_config.md) for supported settings and technical details.

Where supported, you can also configure form fields and sections, default view or form selection, timeline defaults, lookup behavior, and visible choice values.

Settings apply only to components that support shared layout configuration. Check the actual card, planner, or form that users open.

Layout settings don't update business records or change security and validation rules. Personal preferences can override organization defaults on supported components.

## Control tool visibility

1. Ask: Show all available tools and their organization-wide visibility settings.
2. Select a tool from the returned list and ask to hide or show it organization-wide.
3. Review the saved settings.
4. Exit configuration mode and check the tools available to an intended user.

Learn more in [Set tool visibility](../developer/reference/mcp-tools/save_tool_selection.md).

Tool visibility doesn't replace Dataverse permissions. Showing a tool doesn't grant access to records, enable an unavailable feature, or add another product's tools. You can't hide maker configuration tools through these settings.

## Connect additional capabilities

Optionally, connect an approved MCP server or Copilot Studio agent. You don't need extensions for built-in layout and visibility settings.

### Confirm extension eligibility and scope

Before adding either type of extension, review access and scope:

- **User access:** Intended users need **Read** access to the **Case** table (`prvReadIncident`) for either type of extension. Field Service access and the maker privilege don't include this access automatically.
- **Scope:** Organization-owned registrations are shared across eligible Service Agent contexts in the environment. Selecting Field Service when you save doesn't limit a registration to Field Service users.

> [!IMPORTANT]
> Have an administrator review the data access before granting Case Read. Also confirm destination permissions, consent, and data-handling requirements for every intended audience. Registered services can receive user-provided or Dynamics 365 data. If the required access isn't appropriate, use the built-in capabilities instead.

A successful maker connection test doesn't confirm access for other users. Test the extension as an intended technician or dispatcher after leaving configuration mode.

### Register an external MCP tool server

1. Prepare an approved HTTPS endpoint, supported Microsoft Entra authentication scope, display name, and unique tool prefix.
2. Ask: Manage my external MCP tool servers.
3. Enter the details, select **Test Connection**, review the returned tools, and save the registration.

The tested tool list determines which tools are registered. Coordinate consent with your identity administrator, and keep passwords, keys, and tokens out of chat and registration descriptions.

Learn more in [Manage external MCP tool servers](../developer/reference/mcp-tools/manage_mcp_registration.md).

### Register a Copilot Studio agent

1. Publish and activate the Copilot Studio agent in the target environment, and complete its extensibility setup.
2. Ask: Manage my Copilot Studio agent registrations.
3. Select the agent, describe when to use it, test the connection, and save the registration.

Publishing a Copilot Studio agent and registering it with Service Agent are separate steps.

Learn more in [Manage Copilot Studio agents](../developer/reference/mcp-tools/manage_copilot_studio_registration.md).

For either extension, check its availability in other eligible Service Agent contexts in the environment.

### Add another product's tools

Ask which product toolsets and individual tools are available, then grant only the tools needed for your scenario. Use organization-level grants for a Field Service-only context; profile-level grants require the Customer Service application context.

Grants affect visibility, not the user's underlying permissions or feature availability.

Learn more in [Grant foreign namespace](../developer/reference/mcp-tools/save_cross_namespace_grant.md) and [Grant individual foreign tools](../developer/reference/mcp-tools/save_cross_namespace_tools.md).

If an extension overlaps with a built-in tool, a [tool description override](../developer/reference/mcp-tools/save_tool_description.md) can help Service Agent choose between them. It doesn't guarantee which tool is selected.

## Test your changes and finish

1. Review the saved configuration, scope, and target. Wait for the time shown for the change to take effect.
2. Enter: I'm done configuring. This command exits configuration mode and restores operational tools.
3. Test the result as an intended user and confirm that users with restricted access remain restricted.

If configuration tools still appear, send another message to refresh the tool list.

Exiting configuration mode doesn't undo saved changes. To roll back, remove the specific setting or registration. Review the scope before confirming a reset; some resets remove all settings of that kind at the selected scope.

## Troubleshoot maker setup

| Symptom | What to check |
|---|---|
| Only environment-selection tools appear. | Connect to the intended Dynamics 365 environment first. |
| Configuration mode isn't available. | Check feature availability, the maker privilege, and the user's roles in that environment. |
| A profile setting doesn't affect Field Service users. | Use organization scope in a Field Service-only context. |
| A saved layout doesn't appear. | Check component support, the target table and view, the time for the change to take effect, and personal preferences. |
| A tool is missing. | Exit configuration mode, then check feature availability, permissions, visibility settings, and any cross-product grant. |
| An extension works only for the maker. | Check the intended user's Case Read access, destination access, and consent. Test outside configuration mode. |
| An extension appears in another context. | Review its environment-wide scope and intended audience before keeping it enabled. |

## Related information

- [Field Service capabilities in Service Agent](service-agent-overview.md).
- [How MCP tools support Field Service scenarios](service-agent-mcp-tools-overview.md).

[!INCLUDE[footer-include](../includes/footer-banner.md)]
