---
title: "Configure a pre-conversation survey | MicrosoftDocs"
description: "Perform the following steps to configure a pre-conversation survey in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
ms.date: 04/04/2022
ms.topic: article
---

# Configure a pre-conversation survey

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Configure a pre-conversation survey in Omnichannel admin center

For the chat channel, you can configure a survey that users can respond to when they access the widget to start a conversation.

1. Go to one of the apps, and perform the following steps.

   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    - In the site map, select **Workstreams** in **Customer support**.

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)
    
     - In the site map, select **Workstreams** in **General settings**.

1. Select the workstream for the chat channel in which you want to configure the pre-conversation survey.

1. On the page that appears, select the channel instance from the dropdown list, and then select **Edit**.

1. On the **Chat channel settings** dialog, go to the **Behaviors** tab, and set the toggle for **Pre-conversation survey** to **On**.

1. In the **Survey questions** area, select **Add**, and then enter the following details on the **Survey question** page:
   - **Survey question name**: Specify a name that will be used internally.
   - **Question text**: Enter the question text. This will be displayed as a question to the user at runtime. The length of each question should be less than or equal to 512 characters.
   - **Answer type**: Select one of the following values from the list:
        - **Single line**: The user can enter a single line of text.
        - **Multiple lines**: The user can enter multiple lines of text.
        - **Option set**: The user can select an option in a drop-down list. You must enter options separated by a semicolon.
        - **User consent**: Use this option to request user consent for the pre-chat survey. You can provide a link to a webpage, such as the privacy policy page. Links must be in the following format: [link text](link to the webpage). A check box will appear beside the question text in the pre-chat survey.
   - **Required**: Set the toggle to **Yes** if the response to the question needs to be mandatory. If the answer type is **User Consent**, make sure you specify **Yes**.

    > [!NOTE]
    > - Validations in pre-conversation surveys are supported for mandatory fields only.
    > - After you add the survey questions, corresponding context variables are created and displayed in the **Advanced settings** > **Context variables** section of the workstream.

1. Select **Confirm**. The survey question with its details is listed in the **Survey questions** area.

1. Repeat the steps pertaining to creating questions. You can add up to five questions only.

    > [!div class=mx-imgBorder]
    > ![Pre-conversation survey questions.](media/ocac-pre-conversation-questions.png "Pre-conversation survey questions")

1. Optionally, you can change the order in which the questions are listed.


#### Configure a pre-conversation survey in Omnichannel Administration

[!INCLUDE[cc-omnichannel-administration-deprecation-note.md](../includes/cc-omnichannel-administration-deprecation-note.md)]

You can configure your chat widget to show users a survey that they must respond to before they start the conversation.

1. Sign in to Omnichannel Administration.
2. Go to **Channels** &gt; **Chat**.
3. Open the chat widget in which you want to configure a pre-chat survey, and select **Surveys**.
4. In the **Pre-conversation survey** area, set the **Turn on** toggle to **Yes**. The options to add questions and refresh the page are displayed.
5. Select **Add question**.

    > [!NOTE]
    > - You can add only five questions to a pre-conversation survey. The length of each question should be less than or equal to 512 characters.
    > - When you add a question to the pre-conversation survey, a corresponding context variable is created and is displayed in the  **Advanced settings** > **Context variables** section.

6. In the **New Question** pane, provide the following information:

    - **Question name**: Enter a name for the question.
    - **Question text**: Enter the text of the question.
    - **Question type**: Select one of the following options to indicate how user response needs to be provided:

        - **Single line**: The user can enter a single line of text.
        - **Multiple lines**: The user can enter multiple lines of text.
        - **Option set**: The user can select an option in a drop-down list. You must enter options separated by a semicolon.
        - **User consent**: Use this option to request user consent for the pre-chat survey. You can provide a link to a webpage, such as the privacy policy page. Links must be in the following format: [link text](link to the webpage). A checkbox will appear beside the question text in the pre-chat survey.

    - **Mandatory**: Select **Yes** or **No** to indicate whether the question is mandatory. If question type is **User Consent**, make sure you specify **Yes**.

    > [!NOTE]
    > Validations in pre-chat surveys are supported only for mandatory fields.
    

    > [!div class=mx-imgBorder]
    > ![Add a question to the pre-chat survey.](media/oc-add-chat-question.png "Add a question to the pre-chat survey")

7. Select **Save and Close**. The questions are added in the **Pre-chat unauthenticated questions** area.
  
8. Optionally, select a question and select **Move up** or **Move down** in the right corner to change its order.

## Runtime view of survey questions

The following screenshot is a sample of the pre-conversation survey that will be displayed for customers.

> [!div class=mx-imgBorder]
> ![Sample pre-chat survey.](media/oc-pre-chat-survey.png "Sample pre-chat survey")

More information: [Automatically identify customers using pre-chat responses](record-identification-rule.md)

### See also

[Add a chat widget](add-chat-widget.md) <br>
[Configure agent display name](agent-display-name.md)<br>
[Configure file attachment capability](configure-file-attachment.md)<br>
[Create quick replies](create-quick-replies.md) <br>
[Create and manage operating hours](create-operating-hours.md) <br>
[Create chat authentication settings](create-chat-auth-settings.md) <br>
[Embed chat widget in your website or portal](embed-chat-widget-portal.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
