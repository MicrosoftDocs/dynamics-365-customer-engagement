---
title: Use representative diagnostics as a self-help tool
description: Learn how to use the representative diagnostics in Copilot Service workspace as a self-help tool to identify and share issues with your administrator for quick resolutions.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to
ms.collection:
ms.date: 04/30/2025
ms.custom: bap-template
---

# Use representative diagnostics as a self-help tool

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

The representative diagnostics tool helps you identify and address issues in your environment. Use the tool to run a set of predefined rules from Microsoft to diagnose frequent issues. You can download a report to send to admins or support and reduce support tickets.

Out of the box, the following rules are available:

- App Profile Assignment
- Inbox
- Live Chat Communication
- Omnichannel Presence
- Omnichannel Provider URL
- Productivity Pane

One of the following rule result messages appear after you run the rules.

- **No issues found**: When the rule runs successfully.
- **Issue found**: When the rule identifies one or more issues.
- **Not reproduced**: When something unexpected occurs with the rule. You'll need to run the rule after refreshing the app. If the issue persists, contact your support team.
 
## Run diagnostics

The rules that you can run in the app are specific to your permissions.

1. Sign in to Copilot Service workspace.
1. After the presence loads, select **Ctrl**+**Shift**+**F12**. Optionally, you might need to select the **fn** key. The **Diagnostic center** page displays a list of tests.
1. Select one or more rules, and then select **Run diagnosis**. The rule results are displayed in the **Diagnostic result** column.

   :::image type="content" source="../media/screenshot-of-representative-diagnostics.png" alt-text="Screenshot of representative diagnostics rules with results." lightbox="../media/screenshot-of-representative-diagnostics.png":::

1. If you see a result as **Issue found**, select its link. The **Diagnostic Report** pane displays the issue details.
1. Select **Download Report**. The report details are available in a text file that you can share with the administrator.
1. Optionally, run the rule again after the administrator resolves the issue to make sure that no further issues are present.

### Related information

[View the communication panel for conversations](oc-conversation-control.md)  
[Get started with Copilot Service workspace](../implement/csw-overview.md)  


 

