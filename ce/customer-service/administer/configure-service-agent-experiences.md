---
title: "Configure Service Agent Experiences"
description: "Customize Service Agent experiences in Dynamics 365 Customer Service to match your support processes and business requirements. Learn how to configure layouts, forms, and tools for different teams."
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.topic: how-to
ms.date: 08/25/2026
ms.update-cycle: 180-days
ms.custom: bap-template
---

# Configure Service Agent experiences

Administrators can customize the Service Agent experience to match their organization's support processes, representative roles, and business requirements. Service Agent supports configuration at the organization, application profile, and individual user levels, so you can define a common baseline experience and then refine it for specific support teams, such as frontline and escalation teams.

You configure these experiences in maker mode, where you can tailor layouts, forms, timelines, tool availability, and default behaviors.

## Prerequisites

- You have a security role that allows Service Agent administration, such as System Administrator or System Customizer.
- Your role includes the `prvmsdyn_ServiceAgentMakerCustomize` Dataverse privilege for the `msdyn_agentmetadataoverride` elastic table. 

## Enter maker mode in Service Agent

Use maker mode to configure Service Agent. While maker mode is active, standard requests are paused.

1. Open Service Agent.
1. Ask Service Agent to enter maker mode.
1. Select the configuration scope:
   - **Organization**: Apply changes across the organization.
   - **Application profile**: Apply changes to a specific application profile.
   - **User**: Apply changes to an individual user.
1. Make the required configuration changes. To review or undo your changes, ask Service Agent to show the current configurations or reset the configuration to its default settings.
1. When you finish configuring Service Agent, ask Service Agent to exit maker mode. You can then resume standard requests.

## Configure layouts and the user interface

### Customize case grids

You can modify the list views that appear in Service Agent. You can:

- Add columns.
- Remove columns.
- Reorder columns.
- Control the default sort order.

For example, you can show the **Created On** and **Customer** columns in the case grid, hide **Origin**, and move **Priority** beside **Status**.

### Customize forms

You can adjust the forms that appear within Service Agent. You can:

- Show or hide fields.
- Reorder sections.
- Make fields required.
- Make fields read-only.

For example, you can make **Priority** required, hide internal escalation fields from frontline representatives, and move **Resolution details** above the timeline.

### Configure timelines

Define which activities appear in the timeline experience. You can:

- Show or hide activity types.
- Control the order of activities.
- Configure the display density.

For example, you can show only **Emails** and **Notes**, hide **Phone calls**, and display the newest activities first.

## Configure behavior and defaults

### Default forms

Control which form opens by default for a record type, such as a case resolution form, a frontline case form, or an escalation case form.

### Picklists

Limit which option values representatives can choose. For example, hide deprecated categories, restrict **Case Type** selections, and limit resolution codes.

### Lookups

Control which records users can search for or select. For example, restrict account and product lookups, and limit entitlement selections.

## Configure tool visibility

Service Agent includes built-in tools and customer-defined tools, such as non-Microsoft MCP tools. You can:

- Show tools.
- Hide tools.
- Configure default tool availability.
- Override tool settings by profile.

For example, you can hide advanced tools from frontline representatives, enable email drafting only for supervisors, and disable specific MCP tools.

## Configure tools by namespace

### What is a namespace
A namespace in MCP is a logical grouping that filters the tools visible to a user. For example, a namespace such as "service" can expose only service-related tools, and hide sales or field-service tools. In MCP-based systems, the namespace acts as the user’s starting tool set, helping keep users focused on their domain while still allowing administrators to selectively add tools from other namespaces when needed.

### Modify the tools available in a namespace
By default, each namespace exposes a predefined set of tools. When an administrator enters Maker mode, they can view all available tools, including tools that aren't part of the current namespace, and configure namespace-specific overrides.

To make a tool available in a different namespace:

1. Open Service Agent.
1. Ask to **enter maker mode**.
1. Select the scope that you want to configure:
   - **Organization**: Applies the changes across the organization.
   - **Application profile**: Applies the changes to a specific application profile.
   - **User**: Applies the changes for an individual user.
1. Ask Service Agent to add the desired tool to a namespace. For example:
   - "Add ServiceMcp_get_case to the Sales namespace."
   - "Add SalesMcp_leads to the Customer Support application profile."
1. Verify that the tool appears in the target namespace and is available to users within the selected scope.

## Configure profile-based experiences

You can create layered experiences for different roles. For example:

- **Organization baseline**: A standard case layout and timeline.
- **Frontline profile**: A simplified form and a limited tool set.
- **Escalation profile**: A full form and advanced diagnostics tools.
- **Supervisor profile**: Administrative and reporting tools.

## Common customizations

| Requirement | Where to configure it |
| --- | --- |
| Show **Created On** and hide **Origin** | Case grid |
| Show only **Emails** and **Notes** | Timeline |
| Make **Priority** required | Form |
| Hide advanced tools from frontline representatives | Tool visibility |
| Use different layouts for frontline and escalation teams | Profile overrides |

## Related information

- [Enable Service Agent in Microsoft 365 Copilot](configure-service-agent.md)  
- [Configure non-Microsoft MCP servers in Service Agent](configure-service-agent-mcp-servers.md)  
- [Configure Copilot Studio agents in Service Agent](configure-service-agent-copilot-studio-agents.md)
