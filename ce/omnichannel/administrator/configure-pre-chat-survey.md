---
title: "Configure a pre-chat survey | MicrosoftDocs"
description: "Instructions to configure a pre-chat survey in Omnichannel for Customer Service."
author: sbmjais
ms.author: shjais
manager: shujoshi
ms.date: 08/29/2019
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Configure a pre-chat survey

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

You can configure your chat widget to show users a survey that they should respond to before they start the conversation.

1. Sign in to Omnichannel Administration.
2. Go to **Channels** &gt; **Chat**.
3. Open the chat widget in which you want to configure a pre-chat survey, and select **Pre-chat survey**.
4. In the **Pre-chat survey** box, select **Yes**. The options to add questions and refresh are displayed.
5. Select **Add question**.

    > [!NOTE]
    > You can add only five questions to a pre-chat survey.

6. In the **New Question** pane, provide the following information:

    - **Question name**: Enter a name for the question.
    - **Question text**: Enter the text of the question.
    - **Question type**: Select the type of answer that is required from users:

        - **Single line**: The user can enter a single line of text.
        - **Multiple lines**: The user can enter multiple lines of text.
        - **Option set**: The user can select an option in a drop-down list. You must enter options separated by a semi-colon.
        - **User Consent**: Use this option to request user consent for the pre-chat survey. A check box will appear beside the question text in the pre-chat survey.

    - **Mandatory**: Select **Yes** or **No** to indicate whether the question is mandatory. If  question type is **User Consent**, make sure you specify **Yes**.

    > [!NOTE]
    > Validations in pre-chat survey are supported only for mandatory fields.
    

    > [!div class=mx-imgBorder]
    > ![Add a question to the pre-chat survey](../media/oc-add-chat-question.png "Add a question to the pre-chat survey")

7. Select **Save and Close**.

    The questions are added to the pre-chat survey.

    > [!div class=mx-imgBorder]
    > ![Configure a pre-chat survey in a chat widget](../media/oc-chat-widget-survey-tab.png "Configure a pre-chat survey in a chat widget")

8. To change the order of a question, select it, and then select **Move up** or **Move down**.

    > [!div class=mx-imgBorder]
    > ![Change the order of a question in a pre-chat survey](../media/oc-change-question-order.png "Change the order of a question in a pre-chat survey")

More information: [Automatically identify customers using pre-chat responses](record-identification-rule.md)

### See also

[Add a chat widget](add-chat-widget.md) <br>
[Configure agent display name](agent-display-name.md)<br>
[Configure file attachment capability](configure-file-attachment.md)<br>
[Create quick replies](create-quick-replies.md) <br>
[Create and manage operating hours](create-operating-hours.md) <br>
[Create chat authentication settings](create-chat-auth-settings.md) <br>
[Embed chat widget in Dynamics 365 Portals](embed-chat-widget-portal.md)
