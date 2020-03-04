---
title: "Add a chat widget | MicrosoftDocs"
description: "Instructions to add a chat widget in Omnichannel for Customer Service."
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 04/01/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Add a chat widget

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

1. Sign in to Omnichannel Administration.

2. Go to **Channels** > **Chat**.

3. Select **New**. The **New Chat Widget**<!--note from editor: Edit assumes this is the name of the page. If it's simply a new Chat Widget page, it should be "A new **Chat Widget** page is displayed."--> page is displayed.

4. On the <!--note from editor: Via Style Guide, you can say "Go to the ___ tab" or "On the ____ tab" if the instruction is brief. But you don't select a tab.-->**Basic details** tab, specify the information for the following fields.

    | Section | Field | Description | Example value |
    |---------------|------------------------|-----------------------------------|---------------------|
    | General information | Name | Specify the name of the widget. | Contoso chat |
    | General information | Language | Select the language of the chat widget from the list. | English - United States |
    | General information | Agent display name | Select an agent display name type from the list: **Full name**, **First name**, **Last name**, and **Nick name**<!--note from editor: Are you sure this isn't "Nickname"? It's actually one word.-->. <br> More information: [Configure agent display name](agent-display-name.md) | Full name |
    | General information | Authentication settings |Select an authentication setting from the list. This is an optional field. More information: [Create chat authentication settings](create-chat-auth-settings.md) | Chat authentication |
    | Work distribution | Work stream | Select a work stream from the list. Initially, a default a work stream is selected. <br>More information: [Understand and create work streams](work-streams-introduction.md) <br> **Note:** <br> If you save the chat widget, you can't edit the **Work stream** field. If you want to edit the field, you must delete the chat widget and create a new one. | Live work stream |
    | Proactive chat | Enable Proactive Chat | Select whether<!--note from editor: Suggested.--> to enable proactive chat. <br>More information: [Configure proactive chat](proactive-chat.md) | Yes |
    | File attachments | Enable file attachments for customers |Select whether to allow customers <!--note from editor: Suggested. Adding the phrase "or deny" means you have to change the sentence so you're not saying "select whether... to deny customers to attach and send files as attachments" --> to attach and send files as attachments. <br> More information: [Configure file attachment capability](configure-file-attachment.md) | Yes |
    | File attachments | Enable file attachments for agents | Select whether to allow agents to attach and send files as attachments. <br> More information: [Configure file attachment capability](configure-file-attachment.md) | Yes |
    | Chat Transcripts | Allow download of transcript |  Select whether to allow chat transcripts to be downloaded. <br> More information: [Configure download and email of chat transcripts](download-email-chat-transcripts.md) | Yes |
    | Chat Transcripts | Allow email of transcript |Select whether to allow chat transcripts to be emailed. <br> More information: [Configure download and email of chat transcripts](download-email-chat-transcripts.md) | Yes |
    | Chat Transcripts | Email Template |If you selected **Yes** for the **Allow email of transcript** field, the **Email Template**<!--edit okay?--> field is displayed. Select the email template you want to use to send the chat transcript as an email to the customer. | Conversation transcript email template |
    | Chat Transcripts | From mailbox | If you selected **Yes** for the **Allow email of transcript** field, the **"From" mailbox** <!--edit okay?-->field is displayed. Select the mailbox from which you want to send the chat transcript email to the customer. | William Contoso<!--note from editor: This is not an approved name, sorry to say. You'd think it would be okay, but we haven't cleared it as a person's name, we've only cleared "Contoso" as a fictitious company.--> |
    | Queue position | Show position in queue | Select whether to show customers their position in the queue when they're waiting to interact with an agent. <br> More information: [Show customers their position in a queue](show-queue.md) | Yes |
    | Code snippet | Widget snippet | Copy the snippet and embed it in the HTML source of your website where you need to display the chat widget. | ?<!--note from editor: What goes in this cell?--> |

    > [!div class=mx-imgBorder]
    > ![Configure the basic details of a chat widget](../media/oc-chat-widget-basic-details-tab.png "Configure the basic details of a chat widget")<!--note from editor: Please change the fictitious name to match the one you decide on in line 38 of the table. Also, unless you're sure that the code in the "Widget snippet" section has been sanitized and approved for publication, can you please smear out the URLs? I'm a bit nervous about sharing them.-->

5. On the **Design** tab, specify the information for the following fields.

    | Section | Field | Description | Example value |
    |---------------|------------------------|-----------------------------------|---------------------|
    | Online | Theme color | Select a color from the list for the chat widget. | Blue |
    | Online | Logo | Logo for the chat widget. | <!--note from editor: Is this site really where you want to send readers? If not, can you use contoso.com as the domain?-->https://oc-cdn-ocprod.azureedge.net/livechatwidget/images/chat.svg |
    | Online | Title | Specify the name for the widget <!--note from editor: Where is the title displayed, as opposed to the subtitle?-->that's displayed for customers. | Let's Chat! |        
    | Online | Subtitle | Specify the name for the widget<!--note from editor: Same question as previous row. Where is this displayed, and how is it different from the Title?--> that's displayed for customers. | We're Online |
    | Online | Position | Specify the position of the widget. | Bottom right |
    | Online | Operating hours | Select an operating hour window for the chat widget from the list. <br> More information: [Create and manage operating hours](create-operating-hours.md) | Regular shift<!--note from editor: The graphic (or the UI) can't be correct; the hours should be "Regular shift (0800 to 1700)". --> |

    > [!div class=mx-imgBorder]
    > ![Configure the design of a chat widget](../media/oc-chat-widget-design-tab.png "Configure the design of a chat widget")

6. On the **Pre-chat survey** tab, specify the information for the following fields.

    | Section | Field | Description | Example value |
    |---------------|------------------------|-----------------------------------|---------------------|
    | Pre-chat survey | Pre-chat survey | Select whether to set up a pre-chat survey in the chat widget. The survey will be shown to users before a conversation is initiated. | Yes |
    | Pre-chat unauthenticated questions | Pre-chat unauthenticated questions | If you selected **Yes** for the **Pre-chat survey** field, the **Pre-chat unauthenticated questions** section is displayed. <br> Add the pre-chat questionnaires <br> More information: [Configure a pre-chat survey](configure-pre-chat-survey.md) | Product |

    > [!div class=mx-imgBorder]
    > ![Configure a pre-chat survey in a chat widget](../media/oc-chat-widget-survey-tab.png "Configure a pre-chat survey in a chat widget")

7. On the **Location** tab, in the **Widget location** section, select **Add** to specify the website domain where the chat widget must be shown. The domain format should not include the protocol (for example, **http** or **https**).

8. In the **Visitor location** section, specify whether you need to detect the visitor's location, and then select a **Geo Location Provider**. More information: [Set up location detection](geo-location-provider.md)

    > [!NOTE]
    > If no domains are specified, the chat widget can be embedded on any website without restrictions. If you specify a domain, the chat widget can be hosted only on the specified domain.

    > [!div class=mx-imgBorder]
    > ![Configure widget and visitor location in a chat widget](../media/chat-widget-location-tab.png "Configure widget and visitor location in a chat widget")

9. On the **Conversation options** tab, specify the information for the following fields. 

    | Section | Field | Description | Example value |
    |---------------|------------------------|-----------------------------------|---------------------|
    | Remote assistance | Co-browse | Select whether to enable third-party co-browse. You must install a third-party provider from AppSource to use the feature. | Enabled |
    | Remote assistance | Co-browse provider | Select the provider from the list. | Co-browse_provider |
    | Remote assistance | Screen sharing | Select whether to enable third-party screen sharing. You must install a third-party provider from AppSource to use the feature. | Enabled |
    | Remote assistance | Screen sharing provider | Select the provider from the list.| Screen_sharing_provider|
    |Calling | Calling options | Select a calling option from the list: <ul>**No calling**: <br>Agents can't make voice or video calls. </ul><br> <ul>**Video and voice calling**:<br> Agents can make both voice and video calls. </ul><br><ul>**Voice only**:<br> Agents can make only voice calls.  </ul>| Video and voice calling |

   > [!div class=mx-imgBorder]
   > ![Enable third-party co-browse and screen sharing through conversation options in a chat widget](../media/chat-widget-conversation-options.png "Enable third-party co-browse and screen sharing through conversation options in a chat widget")
        
   > [!NOTE]
   > You can select one co-browse provider and/or one screen-sharing provider for each chat widget. 

10. Select **Save** to save the configurations.   

### See also

[Configure a pre-chat survey](configure-pre-chat-survey.md) <br>
[Configure agent display name](agent-display-name.md)<br>
[Configure proactive chat](proactive-chat.md)<br>
[Configure file attachment capability](configure-file-attachment.md)<br>
[Create quick replies](create-quick-replies.md) <br>
[Create and manage operating hours](create-operating-hours.md) <br>
[Create chat authentication settings](create-chat-auth-settings.md) <br> 
[Embed chat widget in Power Apps portals](embed-chat-widget-portal.md)
