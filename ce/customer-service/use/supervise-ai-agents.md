---
title: Monitor and supervise autonomous agents
description: As supervisors, monitor AI agent activities in your Dynamics 365 Customer Service and Dynamics 365 Contact Center.
ms.date: 06/27/2026
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.collection: bap-ai-copilot
ms.update-cycle: 180-days
ms.custom: bap-template
---

# Monitor and supervise autonomous agents


As a supervisor, you can monitor autonomous agents and review their activities across cases. This process helps you track agent progress, investigate escalations, review completed actions, and identify cases that require attention. You can supervise agent activity through the **Agent feed (preview)**, which provides detailed activity and escalation information, and the **Agent Supervisor** view, which provides case-level visibility into work being handled by AI agents.


## Prerequisites

- Your administrator enables **Agent feed** (preview).
- Case Management Agent is configured.
- The supervisor must also be the flow owner to view the agent feed.

## Monitor autonomous agent activities through Agent feed

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

In Copilot Service workspace, as a supervisor, you can view the agent activities by using the agent feed.
- In the site map, select **Agent feed**. You can view all the agent activities. Perform the following actions:
  - Select **Needs attention** to view agent escalations that require service representative intervention. Select an activity to review escalation details, such as status, error information, execution mode, and related record and request IDs, to determine the appropriate next steps.
  - Select **Completed** to view tasks that agents complete successfully. Select an activity to review details about the completed action, including the source, creation time, activity the agent performed, record, and request identifiers.
  - Filter agent activities by agent or case to focus on the work that is most relevant to you.
      - **Agent filter**: View activities for all agents or select a specific agent to monitor its activity and investigate agent-specific issues.
      - **Record filter**: Select a record to view all agent activities associated with a specific case.

You can learn more about the various options in [Supervise agents in model-driven apps with agent feed](/power-apps/user/supervise-agents-with-agent-feed).

## Use the Agent supervisor view

As a supervisor, use the **Agent Supervisor** view in the Customer Service Representative dashboard to monitor cases handled by autonomous agents and review the latest agent activities for each case.

The Agent Supervisor view surfaces autonomous agent-specific fields that help supervisors monitor agent activity, execution progress, detected intents, communications, and escalations.

| Column | Description |
|----------|-------------|
| Agent Mode | Level of autonomy the agent has when handling the case. |
| Fallback Reason | Reason the agent couldn't continue autonomously and required an alternate action or escalation. |
| Agent Last Action | Level of autonomy the agent has when handling the case. |
| Status | Current status of the autonomous agent. |
| Processing Status | Current processing state of the agent's work on the case. |
| Created By | User who created the case record. |
| Created By (Delegate) | Delegate who created the case record on behalf of another user. |
| Modified By | User who last modified the case record. |
| Modified By (Delegate) | Delegate who last modified the AI case record on behalf of another user. |
| Last Email | Most recent email associated with the agent's activity. |
| Last Intent | Most recent customer intent identified by the agent. |
| Last Intent Group | Category associated with the most recent customer intent. |
| Created On | Date and time the case record was created. |
| Modified On | Date and time the case record was last modified. |
| Current AI Status | Current operational state of the autonomous agent. |
| Emails Sent by Agent | Number of emails sent by the agent for the case. |
| Escalated On | Date and time the case was escalated for human review or intervention. |
| Record Created On | Date and time the related record was created. |

Add the autonomous agent-specific fields to other case views to monitor agent execution, communications, and escalations across your case management experience.

### Related information

[Set up Case Management Agent to create and update cases](../administer/set-up-autonomous-case-agents.md)  
[Configure autonomous agent monitoring](../administer/configure-agent-feed.md)  