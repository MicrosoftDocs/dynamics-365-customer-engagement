---
title: Enable supervisor access to manage conversations | MicrosoftDocs
description: "How to enable supervisors to monitor, assign, transfer, and close conversations in the Customer Service admin center app."
ms.date: 10/03/2022
ms.topic: article
author: lalexms
ms.author: laalexan
---

# Enable supervisor access to manage conversations

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]


As an administrator, you can enable your supervisors to take specific actions on various conversations being handled by their agents in Omnichannel for Customer Service. You can grant your supervisors permissions to monitor, assign, transfer, and forcibly end conversations by enabling the respective permissions in the admin app.

## Configure supervisor settings

1. Go to one of the admin apps, and perform the following steps.
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)
   
     1. In the site map, select **Insights** in **Operations**. The **Insights** page appears.
     1. In the **Ongoing conversation insights** section, select **Manage**.

     The **Omnichannel Configuration.Supervisor Settings** page is displayed.

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)
    
     1. In the site map, select **Supervisor Settings** in **Advanced settings**. The **Supervisor settings** page appears.
     2. In the **Ongoing conversation insights** section, select **Manage**.

      The **Omnichannel Configuration.Supervisor Settings** page is displayed.

2. To enable the supervisors to perform the following actions, set the corresponding toggles to **Yes**:
    - **Supervisor Monitor**: Monitor how conversations are happening or being handled by their agents.
    - **Supervisor Assign**: Assign conversations to agents.
    - **Supervisor Transfer**: Transfer conversations from one agent to another.
    - **Force Close**: End voice calls and conversations that take place on the voice and messaging channels. More information: [Monitor, assign, transfer, and forcibly end conversations](monitor-conversations.md#end-conversations-forcibly)

3. To disable any of the settings, set the corresponding toggle to **No**.

### See also

[Monitor, assign, transfer, and close conversations](monitor-conversations.md)  
[Provide access to Ongoing Conversations dashboard](configure-ongoing-conversations-dashbaord.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
