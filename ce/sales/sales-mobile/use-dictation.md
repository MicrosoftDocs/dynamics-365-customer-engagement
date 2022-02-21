---
title: Dictate text in the Dynamics 365 Sales mobile app
description: Learn how to use dictation to enter content in a note or a description in a record in the Dynamics 365 Sales mobile app.
ms.date: 02/14/2022
ms.topic: article
ms.service: dynamics-365-sales
author: sbmjais
ms.author: shjais
manager: shujoshi
---
<!--note from editor: The edits to the description are suggested.-->
# Use dictation in the mobile app

You can use the Dynamics 365 Sales mobile app to dictate text in a [compliant and secure way](/legal/cognitive-services/speech-service/speech-to-text/data-privacy-security) by using the microphone icon in the app. You can use dictation for the following:

- Taking notes
- Entering details in a field that supports multiple lines of text, for example **Description**

> [!IMPORTANT]
> - The dictation capability in the mobile app uses the Microsoft Speech service. More information: [Speech service](/azure/cognitive-services/speech-service/)<!--note from editor: Should "Microsoft Speech" really be the branding for this service? It looks like it's part of Azure Cognitive Services, but it seems to be called simply "the Speech service" in the SDK docs and on GitHub, although the usage isn't consistent. I'd be curious to see any guidance you might have gotten from a PM so I can share it with the editing team.-->
> - If you use the microphone icon on your phone's keyboard for dictation, it uses the built-in dictation capabilities of the phone's operating system.

## Use dictation to take notes

1. In the **Note** form, tap ![Microphone icon to add a note.](media/mic-icon-note.png "Microphone icon to add a note") on the bottom command bar.

    ![Tap the microphone button on the Notes form.](media/note-mic.png "Tap the microphone button on the Notes form")

    > [!NOTE]
    > If you're using the dictation capability for the first time in the Dynamics 365 Sales<!--note from editor: Edit okay?--> mobile app, you're prompted to allow the app to access your phone's microphone. Go to **Settings**, and give the app the access to your phone's microphone.

2. Tap the microphone button to start listening.

    ![Tap the microphone button to start listening.](media/mic-to-listen.png "Tap the microphone button to start listening")

3. When the microphone button turns blue and the **Listening...** caption appears, start speaking.

    ![Tap the microphone button to start speaking.](media/mic-to-speak.png "Tap the microphone button to start speaking")

4. After you finish speaking and the text is written on the screen, tap the microphone button to stop listening. 

    ![Note text is written.](media/note-text-speech.png "Note text is written")

## Use dictation in a field supporting multiple lines of text

1. Open a record that includes a field that supports multiple lines of text. For example, opportunity has a **Description** field in which you can enter multiple lines of text.<!--note from editor: Suggested.-->

2. Edit the record and tap the field that supports multiple lines of text.

3. Tap ![Microphone icon to add text.](media/mic-icon-note.png "Microphone icon to add text") at the bottom of the form.

    ![Tap the microphone button on the record form.](media/record-form-mic.png "Tap the microphone button on the record form")

    > [!NOTE]
    > If you're using the dictation capability for the first time in the Dynamics 365 Sales mobile app, you're prompted to allow the app to access your phone's microphone. Go to **Settings**, and give the app the access to your phone's microphone.

4. Tap the microphone button to start listening.

    ![Tap the microphone button to start listening in a record.](media/mic-to-listen-record.png "Tap the microphone button to start listening in a record")

5. When the microphone button turns blue and the **Listening...** caption appear, start speaking.

6. After you finish speaking and the text is written on the screen, tap the microphone button to stop listening. 

## Supported languages 

The following languages are supported by the dictation capability in the mobile app.

|     Language              |     Country/Region                  |
|---------------------------|-------------------------------------|
|     Arabic                |     Algeria                         |
|     Arabic                |     Bahrain                         |
|     Arabic                |     Egypt                           |
|     Arabic                |     Iraq                            |
|     Arabic                |     Israel                          |
|     Arabic                |     Jordan                          |
|     Arabic                |     Kuwait                          |
|     Arabic                |     Lebanon                         |
|     Arabic                |     Libya                           |
|     Arabic                |     Morocco                         |
|     Arabic                |     Oman                            |
|     Arabic                |     Qatar                           |
|     Arabic                |     Saudi Arabia                    |
|     Arabic                |     Palestinian   Authority         |
|     Arabic                |     Syria                           |
|     Arabic                |     Tunisia                         |
|     Arabic                |     United Arab   Emirates          |
|     Arabic                |     Yemen                           |
|     Bulgarian             |     Bulgaria                        |
|     Catalan               |     Catalan                         |
|     Chinese               |     Traditional,   Hong Kong SAR    |
|     Chinese               |     Simplified,   China             |
|     Chinese               |     Traditional,   Taiwan           |
|     Croatian              |     Croatia                         |
|     Czech                 |     Czechia                         |
|     Danish                |     Denmark                         |
|     Dutch                 |     Netherlands                     |
|     English               |     Australia                       |
|     English               |     Canada                          |
|     English               |     Ghana                           |
|     English               |     Hong Kong SAR                   |
|     English               |     India                           |
|     English               |     Ireland                         |
|     English               |     Kenya                           |
|     English               |     New Zealand                     |
|     English               |     Nigeria                         |
|     English               |     Philippines                     |
|     English               |     Singapore                       |
|     English               |     South Africa                    |
|     English               |     Tanzania                        |
|     English               |     United   Kingdom                |
|     English               |     United States                   |
|     Estonian              |     Estonia                         |
|     Filipino              |     Philippines                     |
|     Finnish               |     Finland                         |
|     French                |     Canada                          |
|     French                |     France                          |
|     French                |     Switzerland                     |
|     German                |     Austria                         |
|     German                |     Switzerland                     |
|     German                |     Germany                         |
|     Greek                 |     Greece                          |
|     Gujarati              |     India                           |
|     Hebrew                |     Israel                          |
|     Hindi                 |     India                           |
|     Hungarian             |     Hungary                         |
|     Indonesian            |     Indonesia                       |
|     Irish                 |     Ireland                         |
|     Italian               |     Italy                           |
|     Japanese              |     Japan                           |
|     Korean                |     Korea                           |
|     Latvian               |     Latvia                          |
|     Lithuanian            |     Lithuania                       |
|     Malay                 |     Malaysia                        |
|     Maltese               |     Malta                           |
|     Marathi               |     India                           |
|     Norwegian   Bokmål    |     Norway                          |
|     Persian               |     Iran                            |
|     Polish                |     Poland                          |
|     Portuguese            |     Brazil                          |
|     Portuguese            |     Portugal                        |
|     Romanian              |     Romania                         |
|     Russian               |     Russia                          |
|     Slovak                |     Slovakia                        |
|     Slovenian             |     Slovenia                        |
|     Spanish               |     Argentina                       |
|     Spanish               |     Bolivia                         |
|     Spanish               |     Chile                           |
|     Spanish               |     Colombia                        |
|     Spanish               |     Costa Rica                      |
|     Spanish               |     Cuba                            |
|     Spanish               |     Dominican   Republic            |
|     Spanish               |     Ecuador                         |
|     Spanish               |     El Salvador                     |
|     Spanish               |     Equatorial   Guinea             |
|     Spanish               |     Guatemala                       |
|     Spanish               |     Honduras                        |
|     Spanish               |     Mexico                          |
|     Spanish               |     Nicaragua                       |
|     Spanish               |     Panama                          |
|     Spanish               |     Paraguay                        |
|     Spanish               |     Peru                            |
|     Spanish               |     Puerto Rico                     |
|     Spanish               |     Spain,   International Sort     |
|     Spanish               |     Uruguay                         |
|     Spanish               |     United States                   |
|     Spanish               |     Venezuela                       |
|     Kiswahili             |     Kenya                           |
|     Swedish               |     Sweden                          |
|     Tamil                 |     India                           |
|     Telugu                |     India                           |
|     Thai                  |     Thailand                        |
|     Turkish               |     Turkey                          |
|     Vietnamese            |     Vietnam                         |
|||

### See also

[Manage notes](view-edit-add-note.md)  
[Manage records](open-record.md)

