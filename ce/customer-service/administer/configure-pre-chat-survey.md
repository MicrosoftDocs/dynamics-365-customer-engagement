---
title: Configure a pre-conversation survey
description: Configure a pre-conversation survey in Customer Service admin center to ask customers questions before they start a conversation.
author: neeranelli
ms.author: nenellim
ms.date: 02/06/2024
ms.topic: how-to
ms.collection:
ms.reviewer:
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/04/2023
---

# Configure a pre-conversation survey

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Configure a pre-conversation survey

For the chat channel, you can configure a survey that users can respond to when they access the widget to start a conversation.

1. Go to one of the apps, and perform the following steps.

   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    - In the site map, select **Workstreams** in **Customer support**.

   ### [Omnichannel admin center (deprecated)](#tab/omnichanneladmincenter)

    [!INCLUDE[oac-deprecation](../../includes/oac-deprecation.md)] 
    
     - In the site map, select **Workstreams** in **General settings**.

1. Select the workstream for the chat channel in which you want to configure the pre-conversation survey.

1. On the page that appears, select the channel instance from the dropdown list, and then select **Edit**.

1. On the **Chat channel settings** dialog, go to the **Behaviors** tab, and set the toggle for **Pre-conversation survey** to **On**.

1. In the **Survey questions** area, select **Add**, and then enter the following details on the **Survey question** page:
   - **Survey question name**: Specify a name that's used internally.
   - **Question text**: Enter the question text. The text appears as a question to the user at runtime. The length of each question must be less than or equal to 512 characters.
   - **Answer type**: Select one of the following values from the list:
        - **Single line**: The user can enter a single line of text.
        - **Multiple lines**: The user can enter multiple lines of text.
        - **Option set**: The user can select an option in a drop-down list. You must enter options separated by a semicolon.
        - **User consent**: Use this option to request user consent for the pre-chat survey. You can provide a ../link to a webpage, such as the privacy policy page. Links must be in the following format: [../link text](../link to the webpage). A checkbox appears beside the question text in the pre-conversation survey.
   - **Required**: Set the toggle to **Yes** if the response to the question needs to be mandatory. If the answer type is **User Consent**, make sure you specify **Yes**.

    > [!NOTE]
    > - Validations in pre-conversation surveys are supported for mandatory fields only.
    > - After you add the survey questions, corresponding context variables are created and displayed in the **Advanced settings** > **Context variables** section of the workstream.

1. Select **Confirm**. The survey question with its details is listed in the **Survey questions** area.

1. Repeat the steps pertaining to creating questions. You can add up to five questions only.

      :::image type="content" source="../media/ocac-pre-conversation-questions.png" alt-text="Screenshot of the pre-conversation survey questions that you can configure.":::
    

1. Optionally, you can change the order in which the questions are listed.


## Runtime view of survey questions

The following screenshot is a sample of the pre-conversation survey that will be displayed for customers.

  :::image type="content" source="../media/oc-pre-chat-survey.png" alt-text="Screenshot of the runtime view of pre-conversation survey questions.":::

More information: [Automatically identify customers using pre-chat responses](record-identification-rule.md)

### See also

[Add a chat widget](add-chat-widget.md) <br>
[Configure agent display name](agent-display-name.md)<br>
[Configure file attachment capability](configure-file-attachment.md)<br>
[Create quick replies](create-quick-replies.md) <br>
[Create and manage operating hours](create-operating-hours.md) <br>
[Create chat authentication settings](create-chat-auth-settings.md) <br>
[Embed chat widget in your website or portal](embed-chat-widget-portal.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
