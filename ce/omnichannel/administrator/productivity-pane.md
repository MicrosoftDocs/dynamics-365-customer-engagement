---
title: "Productivity pane in the Omnichannel for Customer Service app | MicrosoftDocs"
description: "Learn how to enable the productivity pane in Omnichannel for Customer Service to display agent scripts and smart-assist cards for your agents."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 01/31/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Enable the productivity pane to provide guidance to agents

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

The productivity pane in Omnichannel for Customer Service enables you to display the **Agent Guidance** control (agent scripts and smart-assist cards) in a unified view. First you need to configure agent scripts and smart-assist cards, and then you enable the productivity pane so that the **Agent Guidance** control displays agent scripts and smart-assist cards to users in Omnichannel for Customer Service.

To learn more about configuring agent scripts and smart-assist cards, see [Agent scripts](agent-scripts.md) and [Smart assist](smart-assist.md).

You can set the productivity pane in collapsed mode or expanded mode, as shown in the following illustrations.

**Collapsed mode**

> [!div class='mx-imgBorder']
> ![Productivity pane](../media/productivity-pane-collapsed.PNG "Productivity pane in collapsed mode")

**Expanded mode**

> [!div class='mx-imgBorder']
> ![Productivity pane](../media/productivity-pane-expanded.PNG "Productivity pane in expanded mode")

## Enable the productivity pane

After you've created the agent script or smart-assist card, you need to enable the productivity pane to display them to agents in Omnichannel for Customer Service.

1. Sign in to the Omnichannel Administration app.

2. Under **Agent Experience**, select **Productivity pane**.

3. Set the **Productivity pane** toggle to **Enabled**.

4. Set the **Mode** toggle based on your requirements. By default, the **Collapsed** mode is set; you can change this to **Expanded**.

    > [!div class=mx-imgBorder] 
    > ![Enable the productivity pane](../media/productivity-pane-enable.png "Enable the productivity pane")

After you've enabled the productivity pane, users can see the agent scripts and smart-assist cards on the productivity pane in Omnichannel for Customer Service.

> [!Note]
> - If you don't create agent scripts or smart-assist cards and you enable the productivity pane, users won't see the pane in Omnichannel for Customer Service. 
>
> - We recommend that you remove the agent script control or smart-assist control if you've customized a form to add agent script or smart-assist. If you don't remove the agent script control or smart-assist control, agents will see the agent script control or smart-assist control in the form, and also in the productivity pane.

### See also

[Agent scripts](agent-scripts.md)<br>
[Smart assist](smart-assist.md)