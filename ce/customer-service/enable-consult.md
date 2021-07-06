---
title: "Enable consult in Omnichannel for Customer Service | MicrosoftDocs"
description: "Enable consult in agent experience for agent productivity in Omnichannel for Customer Service"
ms.date: 07/15/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365CS
---

# Preview: Enable consult pane for agents

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]
[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
>
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided "as-is," "with all faults," "as available," and without warranty.
> - This preview feature does not come with technical support and Microsoft Dynamics 365 Technical Support won't be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk. All previews are subject to separate [Terms and Conditions](../legal/supp-dynamics365-preview.md).

To improve agent productivity, the consult option in the communication panel is now a separate pane. With the consult pane, the agents can conveniently consult another agent or supervisor without getting their messages mixed up with those meant for their customers. When the consult option is turned off, a separate pane will not open when agents select the consult option. Instead, the consulted messages will be flagged as internal and will appear in the communication panel.

Do the following to enable the consult pane for agents:

1. In Omnichannel admin center, under **Advanced settings**, select **Agent experience**.
2. On the **Agent experience** page, under **Agent productivity**, select the **Manage** option for **Consult (preview)**.
3. On the **Omnichannel configuration** page, on the **Consult** tab, set the toggle to **Yes** for **Enable new consult experience**.
4. Save and close the page.

When agents use the consult option during their interaction with a customer, the Consult pane will appear beside the communication panel.

### See also

[Consult with agents and supervisors](oc-conversation-control.md#consult-with-agent-or-supervisor)  
[Know the agent interface](oc-introduction-agent-interface.md)  
