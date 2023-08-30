---
title: Use agent diagnostics as self-help tool (preview)
description: Learn how to use the agent diagnostics in Customer Service workspace as a self-help tool to identify and share issues with your administrator for quick resolutions.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: how-to
ms.collection:
ms.date: 08/30/2023
ms.custom: bap-template
---

# Use agent diagnostics as self-help tool (preview)

[This article is prerelease documentation and is subject to change.]

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note.md)]

The agent diagnostics tool helps agents to self-heal their environment. Use the tool to run a set of predefined rules from Microsoft to diagnose frequent issues. Agents can download a report to send to admins or support, and eliminate the need for opening support tickets.

Out of the box, the following rules are available:

- App Profile Assignment
- Inbox
- Live Chat Communication
- Omnichannel Presence
- Omnichannel Provider URL
- Productivity Pane

One of the following rule result messages appear after you run the rules.

- **No issues found**: When rule runs successfully.
- **Issue found**: When the rule identifies one or more issues.
- **Not reproduced**: When something unexpected occurs with the rule. You'll need to run the rule after refreshing the app. If the issue persists, contact your support team.
 
## Run agent diagnostics

The rules that can be run in the agent app are specific to the agent and their permissions.

1. Sign in to Customer Service workspace.
1. After presence loads, select **Ctrl**+**Shift**+**F12**. Optionally, you might need to select the **fn** key. The **Diagnostic center (preview)** page displays a list of tests.
1. Select one or more rules, and then select **Run diagnosis**. The rule results are displayed in the **Diagnostic result** column.

   :::image type="content" source="media/screenshot-of-agent-diagnostics.png" alt-text="Screenshot of agent diagnostics rules with results.":::

1. If you see a result as **Issue found**, select its link. The **Diagnostic Report** pane displays the issue details.
1. Select **Download Report**. The report details are available in a text file that you can share with the administrator.
1. Optionally, run the rule again after the administrator resolves the issue to make sure that no further issues are present.

### See also

[view the communication panel for conversations](oc-conversation-control.md)  
[Get started with Customer Service workspace](csw-overview.md)  


 

