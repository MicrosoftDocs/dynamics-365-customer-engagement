---
title: Enable consult and transfer settings for representatives
description: Learn how to enable consult and transfer settings so that representatives can select a supervisor or another representative to consult with or transfer conversations in Dynamics 365 Contact Center and Customer Service.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to 
ms.collection:
ms.date: 01/23/2026
ms.custom: bap-template
---

# Enable consult with representatives and transfer of conversations

By default, customer service representatives (service representatives or representatives) can consult with other representatives and transfer conversations to queues to resolve customer issues efficiently.

For advanced consult and transfer scenarios, you can enable the following settings:

- **Consult to queue**: Helps the system to intelligently select the most eligible representative to consult with.
- **Direct transfer**: Lets representatives select another representative directly without initiating a consult.

## Prerequisite

System administrator or Omnichannel administrator role.

## Enable consult and transfer settings

You can enable the settings in Copilot Service admin center under **Channels** > **Consult and transfer**.

### Enable consult to queue

1. Turn on the toggle for **Consult to queue**.

1. Enter countdown numbers for voice and messaging channels to specify how long the system searches for representatives to consult with.

   :::image type="content" source="../media/consult-to-queue-settings.png" alt-text="Screenshot of consult to queue setting in admin center.":::

1. Save and close.

### Enable blocking of capacity during consult

By default, representative capacity is blocked for consult to queue sessions. For direct consult sessions, you must explicitly enable capacity blocking..

- On the **Consult and transfer** page, select the checkbox to block capacity of the representatives when they engage in a consultation using the consult with representatives option on the communication panel.

### Enable direct transfer of conversations

When you enable the transfer to representative setting, representatives can select another representative directly and initiate transfer.

1. On the **Consult and transfer** page, in **Transfer settings** turn on the **transfer to representatives** toggle.
1. Select **Save**.

### Configure filters to display selective representatives in consult and transfer scenarios

In the different consult and transfer scenarios that you enable for your representatives, to make sure that representatives choose the right queue or another representative within the business unit or view, define a FetchXML query. At runtime, a selective list of representatives or queues appear when the representative initiates a consult or transfer session. By default these settings are disabled and you need to enable them and configure.

A sample FetchXML is as follows.

```
<fetch version="1.0" output-format="xml-platform" mapping="logical" distinct="true">
	<entity name="queue">
		<attribute name="queueid" />
		<attribute name="name" />
		<link-entity name="msdyn_consultqueuemapping" from="msdyn_consult_allowed_queue" to="queueid" link-type="inner">
			<filter type="and">
				<condition attribute="msdyn_currentqueue" operator="eq" value="{queue.queueid}" />
			</filter>
		</link-entity>
	</entity>
</fetch>
```

1. In Copilot Service admin center, go to the **Channels** > **Consult and transfer** page.
1. Enable the toggle for each of the following settings:
    - **Consult to queue filtering**
    - **Transfer to queue filtering**
    - **Consult with representative filtering**
    - **Transfer to representative filtering**
1. Fill the FetchXML query in each of the settings and validate.
1. Save the changes.

   :::image type="content" source="../media/consult-transfer-fetchXML.png" alt-text="A screenshot of the FetchXMLs to restrict representatives during consult and transfer scenarios.":::

### Configure custom inbox view

Representatives can configure the inbox to show their consult sessions. The inbox view helps representatives rejoin the consulted sessions and leave the consultation to release their capacity.

1. Create a view by using the **Advanced** option in [Configure custom views for the inbox](configure-inbox.md#configure-custom-views-for-the-inbox).
1. Use the conditions shown in the following screenshot to configure the view.

   :::image type="content" source="../media/configure-consult-inbox-view.png" alt-text="Screenshot of the conditions builder to view consult sessions in inbox.":::

## Runtime experience

When you enable the consult to queue setting, your service representatives can see the **Queue** tab on the communication panel.

Similarly, when you enable the direct transfer setting, the **Representatives** tab appears. The tab also appears when the representative wants to transfer conversations to another representative after engaging in a consultation with them.

The representative capacity is released in the following scenarios:

- If the primary representative ends the call or conversation and closes their session.
- If the primary representative ends the consult.

## Related information

[Consult with representative or supervisor](../use/oc-conversation-control.md#consult-with-representative-or-supervisor)  
[Use consult to collaborate with other representatives or supervisors](../use/voice-channel-transfer-consult.md#use-consult-to-collaborate-with-other-representatives-or-supervisors)  
[Transfer conversations to representatives](../use/oc-conversation-control.md#transfer-conversations)  
[Transfer calls to representatives](../use/voice-channel-transfer-consult.md#transfer-calls)
