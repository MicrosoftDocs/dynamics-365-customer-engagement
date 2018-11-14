---
title: "Set up a chat widget"
description: "Instructions to configure a chat widget in Omni-channel Engagement Hub."
keywords: ""
author: sbmjais
ms.author: shjais
manager: shujoshi
applies_to: 
ms.date: 11/13/2018
ms.service: 
ms.topic: article
ms.assetid: 983e691f-0ee2-4e30-ba70-7e534c762611
ms.custom: 
---
# Set up a chat widget

As an administrator, you can set up and configure a chat widget for your website to engage with your customers.

## Add a chat engagement

1.  Sign in to Omni-channel Engagement Hub.

2.  Go to **Administration** &gt; **Work Streams**.

3.  To create a new work stream, select **New**.

4.  Under the **Summary** tab, select **Live Chat** from the **Stream Source** drop-down list.

5.  Specify values under **Agents**, **Agent Profiles**, and **Context Variable**. More information: [Work streams](work-streams.md).  

6.  Under the **Chat settings** tab, select **Add** from **Chat engagements** section.

7.  On the **New Chat Engagement** page, enter the following details:

    1. **Basic details** tab

        1.  Under the **General information** section, enter name of the chat engagement. Save the record to enter more details.

        2.  Under the **Location information** section, select **Add** to specify the website domain where the chat widget needs to be displayed.

        3.  Copy the value from the **Code snippet** section and embed it into the HTML source of your website.

![configure basic details of a chat widget](media/oc-chat-widget-basic-details-tab.png "Configure basic details of a chat widget")

1. **Design** tab: Use this tab to specify the theme color, logo, title, subtitle, and position of chat widget.

 ![configure design of a chat widget](media/oc-chat-widget-design-tab.png "Configure design of a chat widget")  

2. **Survey** tab: Use this tab to set up a pre-chat survey. This survey is displayed to a user before initiating a conversation. More information: [Set up a pre-chat survey](#set-up-a-pre-chat-survey)  

 ![configure survey in a chat widget](media/oc-chat-widget-survey-tab.png "Configure survey in a chat widget")  

## Set up a pre-chat survey

You can configure your chat engagement to display a survey for a user to respond before starting the conversation.

1.  Sign in to Omni-channel Engagement Hub.

2.  Go to **Administration** &gt; **Work Streams**.

3.  Select the work stream under which your widget is created.

4.  Under the **Chat settings** tab, select the chat engagement name.

5.  Go to the **Survey** tab.

6.  In the **Pre-chat survey** field, select **Yes**.

7.  Select **Add question** to add questions from the question library. More information: [Set up a question library](#set-up-a-question-library)  

 **Note**: You can add only five questions to the pre-chat survey.

8.  In the **Quick Create: Chat Question Sequence** pane, select a question from the question library and specify whether it is mandatory or optional.

 **Note**: Validations in pre-chat survey are not supported in this preview.

9.  Select **Save**.

 ![add a question to the pre-chat survey](media/oc-add-chat-question.png "Add a question to the pre-chat survey")  

10. The questions are added to the pre-chat survey.

 ![configure survey in a chat widget](media/oc-chat-widget-survey-tab.png "Configure survey in a chat widget")  

11. To change the order of a question, select the question, and then select **Move up** or **Move down**.

 ![change order of a question in a pre-chat survey](media/oc-change-question-order.png "Change order of a question in a pre-chat survey")  

## Set up a question library

You can create questions in a question library, which will be used to create pre-chat surveys for a chat engagement. All chat engagements that are created within a work stream can use questions from the question library.

1.  Sign in to Omni-channel Engagement Hub.

2.  Go to **Administration** &gt; **Work Streams**.

3.  Select the work stream in which you need to create a question library.

4.  Under the **Chat questions library** tab, select **Add question**.

 ![add a question to the question library](media/oc-add-question.png "Add a question to the question library")  

5.  On the **New Chat Question** page, enter the following values:

    1. **Question name**: Name of the question. The name must be unique across work stream.

    2. **Answer type**: Type of the answer required from a user. You can select either of the following:

        - **Single line**: Allows a user to enter a single line of text.

        - **Multiple lines**: Allows a user to enter multiple lines of text.

        - **Option set**: Allows a user to select an option from the drop-down list. If you select this option, you must first save the question to specify the answer options.

 ![question with answer type as option set](media/oc-option-set-answer-type.png "Question with answer type as Option set")  

    3. **Question text**: Text of the question.

    4. **Help text**: Help text to be displayed to a user as a watermark.

 ![add help text to a question](media/oc-question-help-text.png "Add help text to a question")  

6.  Select **Save**.

## Set up quick responses

Quick responses are the template messages that can be created for agents to quickly reply to common questions by customers. For information on agent experience of quick response, see [Send Quick responses in the chat](#send-quick-responses-in-the-chat).  

1.  Sign in to Omni-channel Engagement Hub.

2.  Go to **Administration** &gt; **Quick Responses**.

3.  To add a new quick response, select **New**.

4.  To edit an existing quick response, select the quick response name.

5.  Enter or modify the following values:

    1. **Title**: Title of the message.

    2. **Locale**: Locale of the message.

**Note**: This field is not editable in this preview.

1. **Message**: Text of the message.

 **Note**: This field supports slugs, but the slug editor is not available in this preview.

 ![create a quick reply](media/oc-create-a-quick-reply.png "Create a quick reply")  

<!-- -->

1.  Select **Save**.

