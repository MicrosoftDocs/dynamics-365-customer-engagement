---
title: Enable consult and transfer settings for representatives
description: Learn how to enable consult and transfer settings so representatives can consult with a supervisor or transfer conversations in Dynamics 365 Contact Center and Customer Service.
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

## Enable consult to queue

1. Turn on the toggle for **Consult to queue**.

1. Enter countdown numbers for voice and messaging channels to specify how long the system searches for representatives to consult with.

   :::image type="content" source="../media/consult-to-queue-settings.png" alt-text="Screenshot of consult to queue setting in admin center.":::

1. Save and close.

## Enable blocking of capacity during consult

By default, representative capacity is blocked for consult to queue sessions. For direct consult sessions, you must explicitly enable capacity blocking.

- On the **Consult and transfer** page, select the checkbox to block capacity of the representatives when they engage in a consultation using the consult with representatives option on the communication panel.

## Enable direct transfer of conversations

When you enable the transfer to representative setting, representatives can select another representative directly and initiate transfer.

1. On the **Consult and transfer** page, in **Transfer settings** turn on the **transfer to representatives** toggle.
1. Select **Save**.

## Configure custom inbox view

Representatives can configure the inbox to show their consult sessions. The inbox view helps representatives rejoin the consulted sessions and leave the consultation to release their capacity.

1. Create a view by using the **Advanced** option in [Configure custom views for the inbox](configure-inbox.md#configure-custom-views-for-the-inbox).
1. To configure the view, use the conditions shown in the following screenshot.

   :::image type="content" source="../media/configure-consult-inbox-view.png" alt-text="Screenshot of the conditions builder to view consult sessions in inbox.":::

## Configure filters to display representatives selectively in consult and transfer scenarios

In the different consult and transfer scenarios that you enable for your representatives, to make sure that representatives choose the right queue or another representative within the business unit or view, define FetchXML filter rules. At runtime, a selective list of representatives or queues appear when the representative initiates a consult or transfer session. By default these settings are disabled and you need to enable them and configure.

1. In Copilot Service admin center, go to the **Channels** > **Consult and transfer** page.
1. Enable the toggle for each of the following settings:
    - **Consult to queue filtering**
    - **Transfer to queue filtering**
    - **Consult with representative filtering**
    - **Transfer to representative filtering**
1. Fill the FetchXML query in each of the settings and validate. The FetchXML can be a simple filter or a complex query that uses linked entities with a custom mapping table based on business rules.
1. Save the changes.

   :::image type="content" source="../media/consult-transfer-fetchxml.png" alt-text="A screenshot of the FetchXMLs to restrict representatives during consult and transfer scenarios.":::

### Use sample FetchXMLs to filter queues

For queues, the primary entity must be a queue.

In the sample scenario, the FetchXML uses a mapping table to filter records based on the current queue of the representative. To support runtime filtering, you must include {queue.queueid} in linked-entity conditions that rely on the current conversation’s queue.

During runtime,

1. The placeholder is replaced with the actual queue ID of the active conversation.
1. The system evaluates the query dynamically.
1. Eligible queues only appear for consult or transfer.

**Simple FetchXML for filtering queues**

```
<fetch version="1.0" output-format="xml-platform" mapping="logical" distinct="false">
	<entity name="queue">
		<attribute name="name"/>
		<attribute name="emailaddress"/>
		<attribute name="queueid"/>
		<order attribute="name" descending="false"/>
		<filter type="and">
			<condition attribute="queueid" operator="eq" uitype="queue" value="{aaaaaaaa-0000-1111-2222-bbbbbbbbbbbb}"/>
		</filter>
	</entity>
</fetch>
```

**Mapped entity filtering FetchXML for filtering queues**

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
### Use sample FetchXMLs to filter representatives

For representatives, the primary entity must be a system user.

In this example, the FetchXML retrieves supervisors who belong to the same business unit as the representative who might invoke a consult or transfer session.

At runtime,

- The query runs in the context of the signed-in representative.
- The representative’s business unit ID is used for filtering.
- Representatives who match the criteria only appear in the consult or transfer list.

Use the FetchXML for

- Role-based visibility
- Restrict consults and transfers to business units
- Filter via custom mapping tables

**Simple FetchXML for filtering representatives**

```
<fetch version="1.0" output-format="xml-platform" mapping="logical" distinct="false">
	<entity name="systemuser">
		<attribute name="fullname"/>
		<order attribute="fullname" descending="false"/>
		<filter type="and">
			<condition attribute="systemuserid" operator="eq" uitype="systemuser" value="{bbbbbbbb-1111-2222-3333-cccccccccccc}"/>
		</filter>
	</entity>
</fetch>
```

**FetchXML with multiple filters for representatives**

```
<fetch version="1.0" output-format="xml-platform" mapping="logical" distinct="true">
	<entity name="systemuser">
		<attribute name="fullname"/>
		<order attribute="fullname" descending="false"/>
		<filter type="and">
			<condition attribute="systemuserid" operator="not-null"/>
			<condition attribute="businessunitid" operator="eq-businessid"/>
		</filter>
		<link-entity name="systemuserroles" from="systemuserid" to="systemuserid" visible="false" intersect="true">
			<link-entity name="role" from="roleid" to="roleid" alias="by">
				<filter type="and">
					<condition attribute="roleid" operator="eq" uiname="Omnichannel supervisor" uitype="role" value="{cccccccc-2222-3333-4444-dddddddddddd}"/>
				</filter>
			</link-entity>
		</link-entity>
	</entity>
</fetch>
```

## Runtime experience of consult and transfer

When you enable the consult to queue setting, your service representatives can see the **Queue** tab on the communication panel.

Similarly, when you enable the direct transfer setting, the **Representatives** tab appears. The tab also appears when the representative wants to transfer conversations to another representative after engaging in a consultation with them.

The representative capacity is released in the following scenarios:

- The primary representative ends the call or conversation and closes their session.
- The primary representative ends the consult.

## Related information

[Consult with representative or supervisor](../use/oc-conversation-control.md#consult-with-representative-or-supervisor)  
[Use consult to collaborate with other representatives or supervisors](../use/voice-channel-transfer-consult.md#use-consult-to-collaborate-with-other-representatives-or-supervisors)  
[Transfer conversations to representatives](../use/oc-conversation-control.md#transfer-conversations)  
[Transfer calls to representatives](../use/voice-channel-transfer-consult.md#transfer-calls)
