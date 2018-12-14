---
title: "Set up a chat widget"
description: "Instructions to configure a chat widget in Omni-channel Engagement Hub."
keywords: ""
author: sbmjais
ms.author: shjais
manager: shujoshi
applies_to: 
ms.date: 12/14/2018
ms.service: 
ms.topic: article
ms.assetid: 983e691f-0ee2-4e30-ba70-7e534c762611
ms.custom: 
---
# Set up a chat widget

As an administrator, you can set up and configure a chat widget for your website to engage with your customers.

## Add a chat widget

1.  Sign in to Omni-channel Engagement Hub.

2.  Go to **Administration** &gt; **Work Streams**.

3.  To create a new work stream, select **New**.

4.  Under the **Summary** tab, select **Live Chat** from the **Stream Source** drop-down list.

5.  Specify values under **Agents**, **Agent Profiles**, and **Context Variable**. More information: [Work streams](work-streams.md).  

6.  Under the **Chat settings** tab, select **Add** from **Chat engagements** section.

7.  On the **New Chat Widget** page, enter the following details:

    a. **Basic details** tab

        i.  Under the **General information** section, enter name of the chat engagement. You can optionally specify authentication settings. Save the record to enter more details. More information on setting up authentication settings: [Set up authentication settings](#set-up-authentication-settings).

        ii.  Under the **Widget location** section, select **Add** to specify the website domain where the chat widget needs to be displayed. If no domain is specified,  the chat widget is displayed in all configured domains. The domain format should not include the protocol (for example, http, https).

        iii.  Copy the value from the **Code snippet** section and embed it into the HTML source of your website.

            > [!div class=mx-imgBorder]
            > ![configure basic details of a chat widget](../media/oc-chat-widget-basic-details-tab.png "Configure basic details of a chat widget")

    b. **Design** tab: Use this tab to specify the theme color, logo, title, subtitle, position, and operating hours of chat widget. More information on setting up operating hours: [Set up operating hours](#set-up-operating-hours).

        > [!div class=mx-imgBorder]
        > ![configure design of a chat widget](../media/oc-chat-widget-design-tab.png "Configure design of a chat widget")  
    c. **Survey** tab: Use this tab to set up a pre-chat survey. This survey is displayed to a user before initiating a conversation. More information: [Set up a pre-chat survey](#set-up-a-pre-chat-survey)

        > [!div class=mx-imgBorder]
        > ![configure survey in a chat widget](../media/oc-chat-widget-survey-tab.png "Configure survey in a chat widget")  
## Set up a pre-chat survey

You can configure your chat engagement to display a survey for a user to respond before starting the conversation.

1.  Sign in to Omni-channel Engagement Hub.

2.  Go to **Administration** &gt; **Work Streams**.

3.  Select the work stream under which your widget is created.

4.  Under the **Chat settings** tab, select the chat widget name.

5.  Go to the **Survey** tab.

6.  In the **Pre-chat survey** field, select **Yes**.

7.  Select **Add question** to add questions from the question library. More information: [Set up a question library](#set-up-a-question-library)  

 **Note**: You can add only five questions to the pre-chat survey.

8.  In the **Quick Create: Survey Question Sequence** pane, select a question from the question library and specify whether it is mandatory or optional.

 **Note**: Validations in pre-chat survey are not supported in this preview.

9.  Select **Save**.

    > [!div class=mx-imgBorder]
    > ![add a question to the pre-chat survey](../media/oc-add-chat-question.png "Add a question to the pre-chat survey")  

10. The questions are added to the pre-chat survey.

    > [!div class=mx-imgBorder]
    > ![configure survey in a chat widget](../media/oc-chat-widget-survey-tab.png "Configure survey in a chat widget")  

11. To change the order of a question, select the question, and then select **Move up** or **Move down**.

    > [!div class=mx-imgBorder]
    > ![change order of a question in a pre-chat survey](../media/oc-change-question-order.png "Change order of a question in a pre-chat survey")  

## Set up a question library

You can create questions in a question library, which will be used to create pre-chat surveys for a chat widget. All chat widgets that are created within a work stream can use questions from the question library.

1.  Sign in to Omni-channel Engagement Hub.

2.  Go to **Administration** &gt; **Work Streams**.

3.  Select the work stream in which you need to create a question library.

4.  Under the **Survey questions library** tab, select **Add question**.

    > [!div class=mx-imgBorder]
    > ![add a question to the question library](../media/oc-add-question.png "Add a question to the question library")  

5.  On the **New Survey Question** page, enter the following values:

    a. **Question name**: Name of the question. The name must be unique across work stream.

    b. **Answer type**: Type of the answer required from a user. You can select either of the following:

        - **Single line**: Allows a user to enter a single line of text.

        - **Multiple lines**: Allows a user to enter multiple lines of text.

        - **Option set**: Allows a user to select an option from the drop-down list. If you select this option, you must first save the question to specify the answer options.

        > [!div class=mx-imgBorder]
        > ![question with answer type as option set](../media/oc-option-set-answer-type.png "Question with answer type as Option set")  

    c. **Question text**: Text of the question.

    d. **Help text**: Help text to be displayed to a user as a watermark.

        > [!div class=mx-imgBorder]
        > ![add help text to a question](../media/oc-question-help-text.png "Add help text to a question")  

6.  Select **Save**.

## Set up quick replies

Quick replies are the template messages that can be created for agents to quickly reply to common questions by customers. For information on agent experience of quick response, see [Send quick replies in the chat](../agent/customer360-overview-existing-challenges.md#send-quick-replies-in-the-chat).  

1.  Sign in to Omni-channel Engagement Hub.

2.  Go to **Administration** &gt; **Quick Responses**.

3.  To add a new quick reply, select **New**.

4.  To edit an existing quick reply, select the quick reply name.

5.  Enter or modify the following values:

    a. **Title**: Title of the message.

    b. **Locale**: Locale of the message.

        > [!NOTE]
        > This field is not editable in this preview.

    c. **Message**: Text of the message.

        > [!NOTE]
        > This field supports slugs, but the slug editor is not available in this preview.

    ![create a quick reply](../media/oc-create-a-quick-reply.png "Create a quick reply")

6.  Select **Save**.

## Set up operating hours

You can create operating hours to set the hours during which your organization’s customer support team is active and available to serve customers. This helps your customers and organization to work together and resolve an issue. After you create an operating hour record, you must add it in the **Design** tab of the appropriate chat widget to make it function.

> [!NOTE]
> The chat widget will be hidden during non-operating hours.


