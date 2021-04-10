---
title: "Add a chat widget | MicrosoftDocs"
description: "Instructions to add a chat widget in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 04/09/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Add a chat widget

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

You can configure a live chat widget that can be displayed on your portal for customers to interact with bots and human agents.

## Configure a chat widget in Omnichannel admin center

Perform the following steps to configure chat in Omnichannel admin center:

1. In the site map of Omnichannel admin center, select **Workstreams**.
2. In the **All workstreams** view, select the workstream for which you want to configure the chat widget.
3. On the workstream page, select **Set up chat** if a chat channel hasn't been created, or select **Add chat channel** to add a chat widget.
4. On the **Channel details** page, enter a name and select a language in the **Name** and **Language** fields, respectively.
5. On the **Chat Widget** page, enter the following details:
   - **Title:** Display name for the chat widget.
   - **Subtitle:** Additional title, such as "We're online".
   - **Theme color:** Choose a color from the list.
   - **Logo URL:** Select the default value or enter the link to the logo that you want to be displayed.
   - **Agent display name:** Select a value from the list.
6. Set the toggle to yes if you want to enable the following options:
   - [Proactive chat](proactive-chat.md)
   - [Reconnect to previous chat](configure-reconnect-chat.md)
   - Only show widget during operation hours
     - **Operation hours name:** Select an operating hour setting. More information: [Configure operating hours](create-operating-hours.md).
   - **Only show widget on the provided domains:** Enter the link of the portal.
7. On the **Behaviors** page, configure the following options:
   - [Custom automated messages](configure-automated-message.md)
   - [Pre-conversation survey](configure-pre-chat-survey.md)
   - [Post-conversation survey](configure-post-conversation-survey.md)
   - [Authentication settings](create-chat-auth-settings.md)
   - Customer wait time
     - **Show position in queue:** Select if you want to show customers their position in the queue when they're waiting to interact with an agent. More information: [Show customers their queue position](show-queue.md)
     - **Show average wait time:** Select if you want to show customers average wait time in the queue when they're waiting to interact with an agent. More information: [Show customers their average wait time in a queue](average-wait-time.md)
   - Customer location detection: Select a location provider. More information: [Set up visitor location detection](geo-location-provider.md).
8. On the **User features** page, configure the following options:
   - [File attachments](enable-file-attachments.md)
   - [Customer notifications](#configure-customer-notifications)
   - [Conversation transcripts](download-email-chat-transcripts.md)
   - **Voice and video calls:** Set the toggle to **On** and select the calling option.
   - **Screen sharing:** Set the toggle to **On** and select a provider.
   - **Co-browse:** Set the toggle to **On** and select a provider if you want the agents to see and interact with a customer's web browse.
9. Select **Save and close**.

## Configure a chat widget in Omnichannel Administration

1. Sign in to Dynamics 365, and select Omnichannel Administration.

2. Go to **Channels** > **Chat**.

3. Select **New**. The **New Chat Widget** page is displayed.

4. On the **General settings** tab, specify the information for the following fields. The **Customer waiting** and **Chat Reconnect** options are available only for Live chat. Enter the settings in the fields depending on the type of chat you want to configure.

    | Section | Field | Description | Example value |
    |---------------|------------------------|-----------------------------------|---------------------|
    | **General information** | **Name** | Specify the name of the widget. | Contoso chat |
    |  | **Language**| Select the language of the chat widget from the list. | English - United States |
    |  | **Agent display name** | Select an agent display name type from the list: **Full name**, **First name**, **Last name**, and **Nick name**. <br> More information: [Configure agent display name](agent-display-name.md) | Full name |
    |  | **Authentication settings** |Select an authentication setting from the list. This is an optional field. More information: [Create chat authentication settings](create-chat-auth-settings.md) | Chat authentication |
    |||
    

    |Section | Field | Description | Example value |
    |--------|-------|-------------|-------------------------------|
    |**Conversation Mode** | **Select mode** | Select the conversation mode from the list. For more information, see: [Persistent chat](persistent-chat.md) | Persistent chat or Live Chat|
    ||||

    | Section | Field | Description | Example value |
    |---------------|------------------------|-----------------------------------|---------------------|
    | **Work distribution** | **Work stream** | Select a work stream from the list. Initially, a default a work stream is selected. <br>More information: [Understand and create work streams](create-workstreams.md) <br> **Note:** <br> If you save the chat widget, you can't edit the **Work stream** field. If you want to edit the field, you must delete the chat widget and create a new one. | Live work stream |
    
    | Section | Field | Description | Example value |
    |---------------|------------------------|-----------------------------------|---------------------|    
    | **Proactive chat** | **Enable Proactive Chat** | Select whether to enable proactive chat. <br>More information: [Configure proactive chat](proactive-chat.md) | Yes |
    |||

    | Section | Field | Description | Example value |
    |---------------|------------------------|-----------------------------------|---------------------|    
    |**File attachments** | **Enable file attachments for customers** |Select whether to allow customers to attach and send files as attachments. <br> More information: [Configure file attachment capability](configure-file-attachment.md) | Yes |
    | | **Enable file attachments for agents** | Select whether to allow agents to attach and send files as attachments. <br> More information: [Configure file attachment capability](configure-file-attachment.md) | Yes |
    |||

    | Section | Field | Description | Example value |
    |---------------|------------------------|-----------------------------------|---------------------|
    | **Chat Transcripts** | **Allow download of transcript** | Select whether to allow chat transcripts to be downloaded. <br> More information: [Configure download and email of chat transcripts](download-email-chat-transcripts.md) | Yes |
    | | **Allow email of transcript** |Select whether to allow chat transcripts to be emailed. <br> More information: [Configure download and email of chat transcripts](download-email-chat-transcripts.md) | Yes |
    | | **Email Template** |If you selected **Yes** for the **Allow email of transcript** field, the **Email Template** field is displayed. Select the email template you want to use to send the chat transcript as an email to the customer. | Conversation transcript email template |
    | | **From mailbox** | If you selected **Yes** for the **Allow email of transcript** field, the **"From" mailbox** field is displayed. Select the mailbox from which you want to send the chat transcript email to the customer. | Contoso |
    |||


    | Section | Field | Description | Example value |
    |---------------|------------------------|-----------------------------------|---------------------|            
    |**Customer waiting** | **Show position in queue** | Select whether to show customers their position in the queue when they're waiting to interact with an agent. <br> More information: [Show customers their position in a queue](show-queue.md) | Yes |
    | | **Show average wait time**| Select whether to show customers average wait time in the queue when they're waiting to interact with an agent. <br> More information: [Show customers their average wait time in a queue](average-wait-time.md) | Yes |
    |||

5. Select **Save**. The following sections are displayed:
    - **Code snippet:** The code snippet that you need to embed in the HTML source of your website to display the chat widget is displayed in the **Widget snippet** box.
    - **Chat Reconnect:** The toggle to configure options for providing a reconnect link to the chat user is displayed. More information: [Configure reconnection to a previous chat session](configure-reconnect-chat.md)


    > [!div class=mx-imgBorder]
    > ![Configure the basic details of a chat widget](media/chat-widget.png "Configure the basic details of a chat widget")

6. On the **Automated messages** tab, set up automated messages for your chat widget. More information: [Configure automated messages](configure-automated-message.md)

7. On the **Surveys** tab, specify the information for the following fields.

    | Section | Field | Description | Example value |
    |---------------|------------------------|-----------------------------------|---------------------|
    | Pre-conversation survey | Pre-conversation survey | Select whether to set up a pre-chat survey in the chat widget. The survey will be shown to users before a conversation is initiated. | Yes |
    | Pre-chat unauthenticated questions | Pre-chat unauthenticated questions | If you set **Yes** for the **Pre-conversation survey** field, the **Pre-chat unauthenticated questions** section is displayed. <br> Add the pre-chat questionnaires <br> More information: [Configure a pre-conversation survey][(configure-pre-chat-survey.md)] | Product |
    |Post-conversation survey| Turn on | If you set to **Yes**, you can configure a post-conversation survey to be presented to customers. More information: [Configure a post-conversation survey](configure-post-conversation-survey.md) |

    > [!div class=mx-imgBorder]
    > ![Configure a pre-conversation survey in a chat widget](media/oc-chat-widget-survey-tab.png "Configure a pre-conversation survey in a chat widget")

8. On the **Conversation options** tab, specify the information for the following fields.

    | Section | Field | Description | Example value |
    |---------------|------------------------|-----------------------------------|---------------------|
    |Voice and video calls | Call options | Select a call option from the list: <ul>**No calling**: <br>Agents can't make voice or video calls. </ul><br> <ul>**Video and voice calling**:<br> Agents can make both voice and video calls. **Note:** Video calling is not available in Unified Service Desk. </ul><br><ul>**Voice only**:<br> Agents can make only voice calls.  </ul>| Video and voice calling |
    | Visual engagement | Screen sharing | Select whether to enable third-party screen sharing. You must install a third-party provider from AppSource to use the feature. | Enabled |
    | Visual engagement | Screen sharing provider | Select the provider from the list.| *Screen sharing provider* |
    | Visual engagement | Co-browse | Select whether to enable third-party co-browse. You must install a third-party provider from AppSource to use the feature. | Enabled |
    | Visual engagement | Co-browse provider | Select the provider from the list. | *Co-browse provider* |
       
   > [!NOTE]
   > You can select one co-browse provider and/or one screen sharing provider for each chat widget. Only co-browse and screen sharing providers that have published a solution on AppSource will appear in the lists.
   
9. On the **Design** tab, specify the information for the following fields. The offline settings are available only when the operating hours are set.

    | Section | Field | Description | Example value |
    |---------------|------------------------|-----------------------------------|---------------------|
    | Online | Theme color | Select a color from the list for the chat widget. | Blue |
    | Online | Logo | Enter a link for the image that's hosted on a publicly available site. | https://oc-cdn-ocprod.azureedge.net/livechatwidget/images/chat.svg |
    | Online | Title | Specify the name for the widget that's displayed for customers in the chat widget. | Let's Chat! |        
    | Online | Subtitle | Specify the name for the widget that's displayed for customers in the chat widget. | We're Online |
    | Online | Position | Specify the position of the widget. | Bottom right |
    | Online | Operating hours | Select an operating hour window for the chat widget from the list. <br> More information: [Create and manage operating hours](create-operating-hours.md) | Regular shift |
    |Online|Turn on sound notifications|Set to **Yes** if you want your customers to receive a sound notification when the chat widget is minimized or not active||
    |Online|Turn on unread message indicator|Set to **Yes** if you want to display the count of unread messages when the chat widget is minimized or not active for the customer.||
    | Offline | Show widget during offline hours | Set to **Yes** to display the chat widget during the offline hours.| Yes. The default is No; the chat widget will be hidden .|
    | Offline | Theme color | Select a color from the list. | Grey |
    |Offline | Title | Specify a title to be displayed. | We're offline. |
    | Offline | Subtitle | Optionally, specify a subtitle. | No agents are available. |
    |||||
    
10. On the **Location** tab, do the following:

    1. In the **Widget location** section, select **Add** to specify the website domain where the chat widget must be shown. The domain format should not include the protocol (for example, **http** or **https**).
    2. In the **Visitor location** section, specify whether you need to detect the visitor's location, and then select a **Geo Location Provider**. More information: [Set up location detection](geo-location-provider.md)

    > [!NOTE]
    > If no domains are specified, the chat widget can be embedded on any website without restrictions. If you specify a domain, the chat widget can be hosted only on the specified domain.

11. On the **Related** tab, view activity associated with your chat widget, such as survey responses, chat widget locations, and system messages. 

12. Select **Save** to save the configurations.

After you configure, agents can get the capabilities while they are in a conversation. To learn more, see [Call options and visual engagement in live chat](call-options-visual-engagement.md).

### Configure customer notifications

You can configure visual and sound notifications to be sent to customers when they're interacting with agents through the chat widget on your organization portal. If the chat window is minimized or isn't active, a sound notification is played when a message arrives and a count of the unread messages is displayed.

Perform the following steps to enable the customer notifications:

1. In Omnichannel admin center, edit a chat widget, and on the **Chat channel settings** page, select the **User features** tab.
2. For **Customer notifications**, set the toggle to **On**. The following check boxes are displayed as selected:
   - **Show number of new messages**
   - **Play sound notifications for new messages**

You can also configure the customer notifications when you're configuring the chat channel.


### Troubleshooting

[Errors in creating a chat widget](troubleshoot-omnichannel-customer-service.md#chat-widget)

### See also

[Configure a pre-conversation survey](configure-pre-chat-survey.md)  
[Configure agent display name](agent-display-name.md)  
[Configure proactive chat](proactive-chat.md)  
[Configure file attachment capability](configure-file-attachment.md)  
[Create quick replies](create-quick-replies.md)  
[Create and manage operating hours](create-operating-hours.md)  
[Create chat authentication settings](create-chat-auth-settings.md)  
[Embed chat widget in your website or portal](embed-chat-widget-portal.md)  
[Embed chat widget in mobile experiences](render-live-chat-widget-mobile.md)  
[Supported browsers for live chat widget](system-requirements-omnichannel.md#browsers-for-chat)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
