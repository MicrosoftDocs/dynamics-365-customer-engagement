---
title:  Link timeline notes to other table records
description: learn about linking timeline notes to other table records
author: gandhamm
ms.author: mgandham
ms.reviewer: neeranelli
ms.topic: conceptual
ms.collection: 
ms.date: 06/26/2023
ms.custom: bap-template 
---

# Learn about linking timeline notes to other tables

You can use notes on the timeline to record case summary, investigations, or add images and files for reference. You can use the **Relate note to a table record** feature on the timeline, to perform the following actions, on case, account, and contact tables without having to leave the current page:
- Move a note on the timeline of an existing table record to another table record. For example, you can move a note on the timeline of a contact to an existing case. 
 > [!NOTE]
 > When the note is linked to another table record, it no longer appears on the current table's timeline, as the note gets moved from the current record to the new table record. 
- Create a new table record from the note. For example, you can create a case from an existing note on a contact's timeline.

## Move note from one table to another table

Consider the following scenario, you have taken a note on the timeline of the account Contoso Coffee during an interaction with the customer about an issue with CX300 coffee machine. After the interaction, you want to link the note to an existing case or create a new case for the same issue. To link the note on the account to an existing case, for example Issue with coffee machine, perform the following steps:
1.	On the Contoso Coffee account timeline, select the note to link.
2.	Select **Link to record** button. 
3.	On the window that appears, search for the case to move the note to. In our example, the case is Issue with coffee machine.
4.	The application displays a message to confirm if the note must be unlinked from the account table. Select **Ok**. The note won’t appear on the Contoso Coffee account timeline and is displayed on the timeline of the Issue with coffee machine case.

## Create a new table record from a note

Consider a scenario where you are talking to the customer over a voice call. The customer's account, Contoso Coffee, appears on the Customer Details section of the Active Conversation form. On the communication panel, you select the **Notes** to take notes. After you've saved the note, it is displayed on the timeline. The timeline on the Active Conversation form is either the account or the contact timeline, based on the record you select to associate your conversation with. In our example, as the  conversation is linked to the customer's account, the timeline is the Contoso Coffee account timeline. If you want to create a new case from the note, perform the following steps:
1.	Select the note that you took on the timeline for the account Contoso Coffee. 
2.	Select **Link to record** button. 
3.	On the window that appears, select **Add a new record**. Based on your administrator's configurations, you'll see **Case**, **Account**, and **Contact**. 
4. Select **Case**. The case form opens and some of the fields on the case form are populated with the content from note based on your administrator configuration.For example, if your administrator has configured to notes title to be copied as the case title and Notes description to be copied to the case description, **Case Title** and **Description** will be auto-populated from the note. 
6. Add the other fields on the case and select **Save**. The application displays a message to confirm if the note must be unlinked from the account table. Select **Ok**. The note won’t appear on the conversation timeline and is displayed on the timeline of the new case that you've created.

 :::image type="content" source="media/link-note-conversation-mini.png" alt-text="runtime experience for the " lightbox="media/link-note-conversation.png":::