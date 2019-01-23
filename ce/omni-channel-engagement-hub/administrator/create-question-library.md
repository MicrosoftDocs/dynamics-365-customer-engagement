---
title: "Create a question library | MicrosoftDocs"
description: "Instructions to create a question library in Omni-channel Engagement Hub."
keywords: ""
author: sbmjais
ms.author: shjais
manager: shujoshi
applies_to: 
ms.date: 1/29/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 75DC82E3-BD66-4D27-89F0-3B0C6C70D95C
ms.custom: 
---

# Create a question library

[!INCLUDE[cc-applies-to-update-9-0-0](../../includes/cc_applies_to_update_9_0_0.md)]

You can add questions to the question library in a work stream. You can then use those questions to create pre-chat surveys for chat widgets that are created in that work stream.

1. Sign in to Omni-channel Engagement Hub.
2. Go to **Administration** &gt; **Work Streams**.
3. Select the work stream to create a question library in.
4. On the **Survey questions library** tab, select **Add question**.

    > [!div class=mx-imgBorder]
    > ![Add a question to the question library](../media/oc-add-question.png "Add a question to the question library")

5. On the **New Survey Question** page, provide the following information:

    - **Question name**: Enter a name for the question. The name must be unique within a work stream.
    - **Answer type**: Select the type of answer that is required from users:

        - **Single line**: The user can enter a single line of text.
        - **Multiple lines**: The user can enter multiple lines of text.
        - **Option set**: The user can select an option in a drop-down list. If you select this answer type, you must save the question before you can specify the answer options.

        > [!div class=mx-imgBorder]
        > ![Question where the answer type is Option set](../media/oc-option-set-answer-type.png "Question where the answer type is Option set")

    - **Question text**: Enter the text of the question.
    - **Help text**: Enter help text that will be shown to the user as a watermark.

    > [!div class=mx-imgBorder]
    > ![Add Help text to a question](../media/oc-question-help-text.png "Add Help text to a question")

6. Select **Save**.
