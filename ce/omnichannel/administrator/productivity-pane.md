---
title: "Productivity pane in the Omnichannel for Customer Service app | MicrosoftDocs"
description: "Learn how to enable productivity pane in in the Omnichannel for Customer Service app to display agent scripts and smart assist cards for your agents."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 01/31/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Enable productivity pane to provide guidance to agents

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

Productivity pane in Omnichannel for Customer Service app enables you to display agent scripts and smart assist cards in an unified view. First you need to configure agent scripts and smart assist cards, and then enable the productivity pane so that the agent scripts and the smart assist cards are displayed to the users who use the Omnichannel for Customer Service app.

To learn more about configuring agent scripts and smart assist cards, see [Agent scripts](agent-scripts.md) and [Smart assist](smart-assist.md).

According to the requirements, for your users, you can set the pane in two modes:

**Collapsed** mode

> [!div class='mx-imgBorder']
> ![Productivity pane](../media/productivity-pane-collapsed.PNG "Productivity pane")

**Expanded** mode

> [!div class='mx-imgBorder']
> ![Productivity pane](../media/productivity-pane-expanded.PNG "Productivity pane")

## Enable productivity pane

After you've created the agent script and/or smart assist, you need to enable the productivity pane to display the agent script and/or smart assist to the agents in the Omnichannel for Customer app.

1. Sign in to the Omnichannel Administration app.

2. Select **Productivity pane** under **Agent Experience**.

3. Set the **Productivity pane** toggle to **Enabled** to enable the productivity pane for the users in the Omnichannel for Customer app.

4. Set the **Mode** toggle as per your requirement. By default, the **Collapsed** mode is set, and you can set it to **Expanded**.

    The productivity pane will be in expanded mode for the users if you set **Expanded**.

    > [!div class=mx-imgBorder] 
    > ![Enable productivity pane](../media/productivity-pane-enable.png "Enable productivity pane")

After you've enabled the productivity pane, users can see the agent scripts and the smart assist cards on the productivity pane in the Omnichannel for Customer Service app.

> [!Note]
> - If you don't create agent script and enable the productivity pane, then users wouldn't see the pane in the Omnichannel for Customer Service app. 
>
> - It is recommended to remove the agent script control If you've customized a form to add the agent script field so agents can see it.
>
> - If you don't remove the agent script control, then agents will see the agent script control in the form and also in the productivity pane.

## See also

[Agent scripts](agent-scripts.md)

[Smart assist](smart-assist.md)