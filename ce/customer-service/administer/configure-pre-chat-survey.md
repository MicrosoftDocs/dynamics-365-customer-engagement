---
title: Configure a preconversation survey
description: Configure a preconversation survey in Customer Service admin center to ask customers questions before they start a conversation.
author: neeranelli
ms.author: nenellim
ms.date: 06/14/2024
ms.topic: how-to
ms.collection:
ms.reviewer: nenellim
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/04/2023
---

# Configure a preconversation survey

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]


For the chat channel, you can configure a survey that users can respond to when they access the widget to start a conversation.

1. In the site map of Customer Service admin center or Contact Center admin center, select **Workstreams** in **Customer support**.

1. Select the workstream for the chat channel in which you want to configure the preconversation survey.

1. On the page that appears, select the channel instance from the dropdown list, and then select **Edit**.

1. On the **Chat channel settings** dialog, go to the **Behaviors** tab, and set the toggle for **Pre-conversation survey** to **On**.

1. In the **Survey questions** area, select **Add**, and then enter the following details on the **Survey question** page:
   - **Survey question name**: Specify a name that's used internally.
   - **Question text**: Enter the question text. The text appears as a question to the user at runtime. The length of each question must be less than or equal to 512 characters.
   - **Answer type**: Select one of the following values from the list:
        - **Single line**: The user can enter a single line of text.
        - **Multiple lines**: The user can enter multiple lines of text.
        - **Option set**: The user can select an option in a drop-down list. You must enter options separated by a semicolon.
        - **User consent**: Use this option to request user consent for the preconversation survey. You can provide a ../link to a webpage, such as the privacy policy page. Links must be in the following format: [../link text](../link to the webpage). A checkbox appears next to the question text in the preconversation survey.
   - **Required**: Set the toggle to **Yes** if the response to the question needs to be mandatory. If the answer type is **User Consent**, make sure you specify **Yes**.

    > [!NOTE]
    > - Validations in preconversation surveys are supported for mandatory fields only.
    > - After you add the survey questions, corresponding context variables are created and displayed in the **Advanced settings** > **Context variables** section of the workstream.

1. Select **Confirm**. The survey question with its details is listed in the **Survey questions** area.

1. Repeat the steps pertaining to creating questions. You can add up to 10 questions only.

      :::image type="content" source="../media/ocac-pre-conversation-questions.png" alt-text="Screenshot of the preconversation survey questions that you can configure.":::
    

1. Optionally, you can change the order in which the questions are listed.


## Runtime view of survey questions

The following screenshot is a sample of the preconversation survey that will be displayed for customers.

  :::image type="content" source="../media/oc-pre-chat-survey.png" alt-text="Screenshot of the runtime view of preconversation survey questions.":::

More information: [Automatically identify customers using preconversation responses](record-identification-rule.md)

### Related information

[Add a chat widget](add-chat-widget.md)  
[Configure agent display name](agent-display-name.md)  
[Configure file attachment capability](configure-file-attachment.md)  
[Create quick replies](create-quick-replies.md)  
[Create and manage operating hours](create-operating-hours.md)   
[Create chat authentication settings](create-chat-auth-settings.md)  
[Embed chat widget in your website or portal](embed-chat-widget-portal.md)  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
