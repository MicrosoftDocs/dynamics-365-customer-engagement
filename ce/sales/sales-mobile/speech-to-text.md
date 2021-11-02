---
title: Use the speech-to-text capability in the Dynamics 365 Sales mobile app
description: Learn how to use the speech-to-text capability for entering note's content and record's description in the Dynamics 365 Sales mobile app.
ms.date: 12/01/2021
ms.topic: article
ms.service: dynamics-365-sales
author: sbmjais
ms.author: shjais
manager: shujoshi
---

# Use speech-to-text in the mobile app

Speech-to-text, also known as speech recognition, enables real-time transcription of audio streams into text. The Dynamics 365 Sales mobile app allows you to use the speech-to-text capability to enter the following information in a compliant and secure way.

- Text content of a note
- Details in a field of type **Multiple Lines of Text**. For information about the field data types, see [Types of fields and field data](/dynamics365/customerengagement/on-premises/customize/types-of-fields?view=op-9-1)

> [!NOTE]
> This feature leverages the Microsoft Speech service. More information: [Speech service](/azure/cognitive-services/speech-service/)

## Use speech-to-text to add text content to a note

1. In the **Note** form, tap ![Microphone icon to add a note.](media/mic-icon-note.png "Microphone icon to add a note") at the bottom command bar.

    ![Tap the microphone button on the Notes form.](media/note-mic.png "Tap the microphone button on the Notes form")

    > [!NOTE]
    > If you are using the speech-to-text capability for the first time in Dynamics 365 mobile app, you are prompted to allow the app to access your phone's microphone. Go to **Settings**, and give the app the access to your phone's microphone.

2. Tap the microphone button to start listening.

    ![Tap the microphone button to start listening.](media/mic-to-listen.png "Tap the microphone button to start listening")

3. When the microphone button turns blue and the **Listening...** caption appear, start speaking.

    ![Tap the microphone button to start speaking.](media/mic-to-speak.png "Tap the microphone button to start speaking")

4. Once you finish speaking and the text is written on the screen, tap the microphone button to stop listening. 

    ![Note text is written.](media/note-text-speech.png "Note text is written")

## Use speech-to-text in a Multiple Lines of Text field

1. Open the quick view form of a record that has a Multiple Lines of Text field. For example, opportunity has a **Description** field.

2. Edit the record and tap the field of type Multiple Lines of Text. For example, **Description**.

3. Tap ![Microphone icon to add text.](media/mic-icon-note.png "Microphone icon to add text") at the bottom of the form.

    ![Tap the microphone button on the record form.](media/record-form-mic.png "Tap the microphone button on the record form")

4. Tap the microphone button to start listening.

5. When the microphone button turns blue and the **Listening...** caption appear, start speaking.

6. Once you finish speaking and the text is written on the screen, tap the microphone button to stop listening. 

### See also

[Manage notes](view-edit-add-note.md)
[Manage records](open-record.md)

