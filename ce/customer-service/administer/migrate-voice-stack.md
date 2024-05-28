---
title: Migrate to enhanced voice stack
description: Learn how to migrate to the enhanced voice stack
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to .
ms.collection: 
ms.date: 05/23/2024
ms.custom: bap-template
---


# Migrate to enhanced voice stack

In Dynamics 365 Customer Service, you can upgrade your existing voice stack to the enhanced voice stack with minimal disruptions to your contact center operations. You can also connect the enhanced Copilot Studio bot to the voice channel that supports interactive voice response capabilities, including speech and Dual-Tone Multi-Frequency (DTMF) input, context variables, call transfer, speech and DTMF customization.

## Prerequisites

- You must have an Azure Communication Services resource connected to your Dynamics 365 Customer Service instance.
- The Event Grid subscription for incoming calls must be set up. Else, you will see an error message.
- Update event grid for the recording webhook.
- Classic bots aren’t compatible with the updated voice stack. You must create a new voice copilot that’s a copy of your classic bot before you run the update. Perform the steps in Build voice copilot from a template section to create a new bot.

### Update event grid for recording webhook

If you are migrating to the enhanced voice stack, you must update the event grid for the recording webhook. Perform the following steps:
.
1. Copy the **Endpoint** value from the **Recording Web Hook Endpoint** field in the Customer Service admin center> Phone Numbers > Advanced > Manage Azure Communication Services (Preview).
1. 
 Go to your resource from the Azure portal. 
1. Select **Events** and then search for and select your existing record event subscription.
1. Paste the value you've copied from Customer Service admin center into the **Endpoint** field and select Save.

## Run the voice update
To update to the new voice experience, perform the following steps:

1. Go to Customer Service admin center and select **Channels** in **Customer support**.
1. Select **Manage** for **Voice update**. In the Voice update page, all the **Workstreams** and the associated phone numbers, inbound and outbound profiles, and the corresponding update and test status are displayed.
1. Select the required workstream and then select **Run update**.

    > [!NOTE]
    > We recommend that you migrate all the workstreams with a common queue containing a Copilot Classic bot at the same time.
1. On the **Replace or remove bots** page, you can see the Copilot Studio classic bots connected to channels either as the post call survey bot, workstream as the deflection bot, or queues as a bot agent.
1. Select the new Copilot Studio bot you’ve created in **Set up a new voice IVR bot** section to replace the Copilot Classic bot wherever it is connected
1. Select **Run** update. The application takes at least 15 minutes to sync the changes.
1. On the **Results** page, the application displays the update status and if the update has succeeded or failed. If the update status is **Failed**, you can retry the update or the application automatically rolls back to original state and displays an error message. If roll back fails, a critical error message appears.

> [!NOTE]
> - Azure direct offer numbers sync faster than direct routing numbers.
> -  Calls should work for Azure direct offer numbers within 15 minutes.
> - Calls to direct routing numbers can fail for up to 30 minutes after the first test call made after the update.
> - The test status field can be used to keep track of testing.  If any call to any phone number attached to a profile/workstream fails after 30 minutes, the test status should be set to “Test failed” to allow “Revert” option


## Next steps

<!--Remove all the comments in this template before you sign-off or merge to the main branch.-->
